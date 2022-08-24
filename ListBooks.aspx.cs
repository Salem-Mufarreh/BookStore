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
            SqlDataSource1.DeleteCommand = "DELETE from Books where Id=@Id";
            SqlDataSource1.UpdateCommand = "UPDATE Books SET Title=@Title,Author = @Author,Description= @Description,Quantity = @Quantity,Status = @Status, Price = @Price where Id = @Id";
            
        }

        
    }
}