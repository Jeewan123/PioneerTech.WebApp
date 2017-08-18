using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PioneerConsultancy.DAL;
using Pioneer.Tech.modelss;

namespace PioneerTech.WebApp.UI
{
    public partial class TechnicalDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode=UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TechnicalModel myTechnical = new TechnicalModel
            {
                UI = TextBox1.Text,
                ProgrammingLanguage = TextBox2.Text,
                Database = TextBox3.Text,
                employeeId = Convert.ToInt32(TextBox4.Text)

            };

            
            EmployeeDataAccessLayer mytechnical = new EmployeeDataAccessLayer();
            int result = mytechnical.TakeTechnicalDetail(myTechnical);



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
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}