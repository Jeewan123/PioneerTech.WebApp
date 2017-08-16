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
    public partial class EmployeeDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)//save
        {
            EmployeeModel myEmployee = new EmployeeModel
            {
                firstName = TextBox1.Text,
                lastName = TextBox2.Text,
                emailId = TextBox3.Text,
                phoneNumber = Convert.ToInt64(TextBox4.Text),
                alternatePhoneNumber = Convert.ToInt64(TextBox5.Text),
                address1 = TextBox6.Text,
                address2 = TextBox7.Text,
                homeCountry = TextBox8.Text,
                currentCountry = TextBox9.Text,
                zipCode = Convert.ToInt32(TextBox10.Text)
            };
            EmployeeDataAccessLayer myempdataal = new EmployeeDataAccessLayer();
            int result = myempdataal.TakeEmployeeName(myEmployee);
            


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

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";

        }
    }
}