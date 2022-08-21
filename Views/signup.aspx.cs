using BookStore.App_Start;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookStore.Views
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext _db = new ApplicationDBContext() ;
       

        public string username { get; set; }
        public string password { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signup_Click(object sender, EventArgs e)
        {


            if (!IsvalidUser(email_txt.Text))
            {
                User user = new User();

                user.Name = name_txt.Text;
                user.Email = email_txt.Text;
                user.Address = address_txt.Text;
                user.PhoneNumber = phoneNumber_txt.Text;
                user.password = password_txt.Text;
                user.Role = SD.Customer;
                
                try
                {
                    _db.Users.Add(user);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert(" + ex.ToString() + ")</script>");
                }
                name_txt.Text = String.Empty;
                email_txt.Text = String.Empty;
                address_txt.Text = String.Empty;
                phoneNumber_txt.Text = String.Empty;
                password_txt.Text = String.Empty;
                Response.Write("<script>alert('Signup Succesfully !')</script>");
            }

            else
            {

                Response.Write("<script>alert('Try Again')</script>");
                name_txt.Text = String.Empty;
                email_txt.Text = String.Empty;
                address_txt.Text = String.Empty;
                phoneNumber_txt.Text = String.Empty;
                password_txt.Text = String.Empty;

            }
        }

        private bool IsvalidUser(string userName)

        {
            ApplicationDBContext dBContext = new ApplicationDBContext();

            var q = from p in dBContext.Users

                    where p.Email == email_txt.Text
                    select p;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}