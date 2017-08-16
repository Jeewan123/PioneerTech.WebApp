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
    public partial class ProjectDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ProjectModel myProject = new ProjectModel
            {
                projectName = TextBox2.Text,
                clientName = TextBox3.Text,
                location = TextBox6.Text,
                roles = TextBox4.Text,
                employeeId = Convert.ToInt32(TextBox5.Text)

            };


            EmployeeDataAccessLayer myproject = new EmployeeDataAccessLayer();
            int result = myproject.TakeProjectDetail(myProject);



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
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";


        }
    }
}