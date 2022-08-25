using BookStore.App_Start;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext _db = new ApplicationDBContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoggedInUser user = (LoggedInUser)Session["LoggedInUser"];

                if (user != null)
                {

                    name_txt.Text = user.UserName;
                    email_txt.Text = user.Email;
                    phone_txt.Text = user.phoneNumber;
                    address_txt.Text = user.Address;
                }
                else
                {
                    ToastrNotifications notifications = new ToastrNotifications();
                    notifications.Message = " Please Log In to enter your Profile ";
                    notifications.Type = "error";
                    Session.Add("Message", notifications);
                }

            }

         


        }

        protected void edit_btn_Click(object sender, EventArgs e)
        {
            name_txt.ReadOnly = false;
            email_txt.ReadOnly = false;
            phone_txt.ReadOnly = false;
            address_txt.ReadOnly = false;

        }

        protected void save_btn_Click(object sender, EventArgs e)
        {
      //      User user1 = (User)Session["user"];

            LoggedInUser user = new LoggedInUser();
            var query =  from p in _db.Users
                where p.Email == email_txt.Text
                select p;

            foreach (User p in query)
            {
                user.UserName = name_txt.Text;
                p.Name = name_txt.Text;
                user.Email = email_txt.Text;
                p.Email = email_txt.Text;
                user.phoneNumber = phone_txt.Text;
                p.PhoneNumber = phone_txt.Text;
                user.Address = address_txt.Text;
                p.Address = address_txt.Text;
            }
          


            try
            {
                _db.SaveChanges();
                Session.Add("LoggedInUser", user);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(" + ex.ToString() + ")</script>");
            }

            name_txt.ReadOnly = true;
            email_txt.ReadOnly = true;
            phone_txt.ReadOnly = true;
            address_txt.ReadOnly = true;
        }
}
}