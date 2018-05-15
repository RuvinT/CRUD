using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudTest2
{
    public partial class Crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["Fname"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tfname")).Text;
            SqlDataSource1.InsertParameters["Lname"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tlname")).Text;
            SqlDataSource1.InsertParameters["Age"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tage")).Text;
            SqlDataSource1.InsertParameters["Address"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Taddress")).Text;
            SqlDataSource1.Insert();
        }
    }
}