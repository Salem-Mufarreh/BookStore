using BookStore.App_Start;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;


namespace BookStore
{
    public partial class Home : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext _db;
        protected void Page_Load(object sender, EventArgs e)
        {





        }

        //protected void Unnamed_Click(object sender, EventArgs e)
        //{
        //    LoggedInUser loggedInUser = new LoggedInUser();
        //    loggedInUser.UserName = "Salem";
        //    loggedInUser.Email = "admin@gmail.com";
        //    loggedInUser.Id = 0;
        //    loggedInUser.CartId = "0";
        //    loggedInUser.Role = SD.Admin;
        //    Session.Add("LoggedInUser", loggedInUser);
        //    ToastrNotifications notifications = new ToastrNotifications();
        //    notifications.Message = "Logged in Successfull";
        //    notifications.Type = "success";
        //    Session.Add("Message", notifications);

        //}
    }
}