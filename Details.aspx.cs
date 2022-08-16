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
    public partial class Details : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext _dbContext = new ApplicationDBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["LoggedInUser"] == null)
            {
                Response.Redirect(nameof(Home));
            }
            
            int value = int.Parse( Request.Params["id"]);
            List<Book> book =_dbContext.Books.Where(x => x.Id == value).ToList();
            txtAuthor.Text = book[0].Author;
            txtDescription.Text = book[0].Description;
            txtISBN.Text = book[0].Id.ToString();
            txtName.Text = book[0].Title;
            txtPrice.Text = book[0].Price.ToString()+"$";
            if (book[0].Status.Equals(SD.notAvailable))
            {
                btnCart.Visible= false;
            }


        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect(nameof(Home));
        }
    }
}