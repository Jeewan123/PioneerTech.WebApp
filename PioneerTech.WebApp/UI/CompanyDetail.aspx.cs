using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerConsultancy.DAL;
using PioneerTech.Models;

namespace PioneerTech.WebApp.UI
{
    public partial class CompanyDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            CompanyModel myCompany = new CompanyModel
            {
                employerName = TextBox1.Text,
                contactNumber = Convert.ToInt32(TextBox2.Text),
                location = TextBox3.Text,
                website = TextBox4.Text,
                employeeId = Convert.ToInt32(TextBox5.Text)
            };

            EmployeeDataAccessLayer mycompany = new EmployeeDataAccessLayer();
            int result = mycompany.TakeCompanyDetail(myCompany);



            if (result > 0)
            {
                string display = "Successful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');", true);
            }
            else
            {
                string display = "UnSuccessful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');", true);
            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyModel myCompany = new CompanyModel
            {
                employerName = TextBox1.Text,
                contactNumber = Convert.ToInt32(TextBox2.Text),
                location = TextBox3.Text,
                website = TextBox4.Text,
                employeeId = Convert.ToInt32(TextBox5.Text)
            };

            EmployeeDataAccessLayer mycompany = new EmployeeDataAccessLayer();
            int result = mycompany.EditCompanyDetail(myCompany);


            if (result > 0)
            {
                string display = "Successful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');", true);
            }
            else
            {
                string display = "UnSuccessful!";
                ClientScript.RegisterStartupScript(this.GetType(), "Operation was", "alert('" + display + "');", true);
            }




        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";

        }
    }
}