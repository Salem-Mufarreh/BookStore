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
        
        protected void Button1_Click(object sender, EventArgs e)
        {       
            if (IsvalidUser(TextBox1.Text, TextBox2.Text))
            {
                Response.Write("<script>alert('Data has bee updated')</script>");
            }
        }

        private bool IsvalidUser(string userName, string password)

        {
            ApplicationDBContext dBContext = new ApplicationDBContext();
            var q = from p in dBContext.Users
                    where p.Email == TextBox1.Text
                    && p.password == TextBox2.Text
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

    }


}