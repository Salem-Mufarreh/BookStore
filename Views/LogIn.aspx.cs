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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext _db;

        public string username {get;set;}
        public string password {get;set;}

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    if (IsvalidUser(TextBox1.Text, TextBox2.Text))
        //    {
        //        Response.Redirect("Home");
        //    }
        //    else
        //    {
        //        ToastrNotifications notifications = new ToastrNotifications();
        //        notifications.Message = " Your Account is Currnetly Locked, Please Contact the support System for more Details ";
        //        notifications.Type = "error";
        //        Session.Add("Message", notifications);
        //    }
        //}

       protected void Button1_Click(object sender, EventArgs e)

        {

            ApplicationDBContext dBContext = new ApplicationDBContext();

            var q = from p in dBContext.Users
                    where p.Email == TextBox1.Text
                    && p.password == TextBox2.Text
                    select p;

            // IList<User> ts = q.ToList<User>();

           IList<User> ts = q.Cast<User>().ToList();
            
            //string status = (from s in dBContext.Users where s.Email == TextBox1.Text
            //             select s.Active).First().ToString();

            if (q.Any())
            {
                if(ts[0].Active == SD.UnLocked)
                {
                    LoggedInUser user = new LoggedInUser();

                    user.Id = ts[0].Id;
                    user.UserName = ts[0].Name;
                    user.CartId = ts[0].Id.ToString();
                    user.Role = ts[0].Role;
                    user.Email = ts[0].Email;
                    Session.Add("LoggedInUser", user);
                    Response.Redirect("~/Home");
                }
                else 
                {
                    ToastrNotifications notifications = new ToastrNotifications();
                    notifications.Message = " Your Account is Currnetly Locked, Please Contact the support System for more Details ";
                    notifications.Type = "error";
                    Session.Add("Message", notifications);
                   
                }
                    

            }
            else
            {
                ToastrNotifications notifications2 = new ToastrNotifications();
                notifications2.Message = " Your Email or Password is incorect " +
                                                    " Please Try again ! ";
                notifications2.Type = "error";
                Session.Add("Message", notifications2);
            }
        }

    }


}