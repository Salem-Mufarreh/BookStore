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
    public partial class Home : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext _db;
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationDBContext db = new ApplicationDBContext();
            List<Book> books=  db.Books.ToList();
           

            repeater1.DataSource = books.Take(10);
            repeater1.DataBind();
            
            
        }
    }
}