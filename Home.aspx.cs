using BookStore.App_Start;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.SessionState;


namespace BookStore
{
    public partial class Home : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext _db;
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationDBContext db = new ApplicationDBContext();
            List<Book> books=  db.Books.ToList();
           

            repeater1.DataSource = books.Take(30);
            repeater1.DataBind();
            
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            LoggedInUser loggedInUser = new LoggedInUser();
            loggedInUser.UserName = "Salem";
            loggedInUser.Email = "admin@gmail.com";
            loggedInUser.Id = 0;
            loggedInUser.CartId = "0";
            loggedInUser.Role = SD.Admin;
            Session.Add("LoggedInUser", loggedInUser) ;
            ToastrNotifications notifications = new ToastrNotifications ();
            notifications.Message = "Logged in Successfull";
            notifications.Type = "success";
            Session.Add("Message", notifications);

        }
    }
}