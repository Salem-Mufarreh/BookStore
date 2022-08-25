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
    public partial class Cart : System.Web.UI.Page
    {
        protected  ApplicationDBContext db = new ApplicationDBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
    }
}