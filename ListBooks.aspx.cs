using BookStore.App_Start;
using BookStore.Models;
using System;
using System.Web.UI.WebControls;

namespace BookStore
{
    public partial class ListBooks : System.Web.UI.Page
    {
        ApplicationDBContext db = new ApplicationDBContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = btn.ClientID.Split('_')[3].Substring(3);
            int Id = int.Parse( BookGrid.Rows[int.Parse(id)-2].Cells[0].Text);
            Book book = new Book();
            book = db.Books.Find(Id);
            db.Books.Remove(book);
            db.SaveChanges();
            Response.Redirect(nameof(ListBooks));
            }
    }
}