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
    public partial class AddBooks : System.Web.UI.Page
    {
        protected readonly ApplicationDBContext db = new ApplicationDBContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor2.Text = "";
            txtDescription2.Text = "";
            txtPrice2.Text = "";
            txtStock.Text = "";
            Upload.Dispose();
            ToastrNotifications notifications = new ToastrNotifications();
            notifications.Message = "Successfly cleared";
            notifications.Type = "warning";
            Session.Add("Message", notifications);
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.Author = txtAuthor2.Text;
            book.Description = txtDescription2.Text;
            book.Price = double.Parse(txtPrice2.Text);
            book.Status = SD.available;
            book.Quantity = int.Parse(txtStock.Text);
            try
            {
                db.Books.Add(book);
                db.SaveChanges();
                Session.Add("Message", new ToastrNotifications("Successfully added Book", "success"));
                Response.Redirect(nameof(Home));
            }
            catch (Exception ex)
            {
                Session.Add("Message", new ToastrNotifications("Error in adding a Book", "error"));
                Console.WriteLine(ex.Message);
            }

        }
    }
}