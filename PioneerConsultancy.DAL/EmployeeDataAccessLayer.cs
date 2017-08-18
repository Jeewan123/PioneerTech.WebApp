using System.Data.SqlClient;
using Pioneer.Tech.modelss;


namespace PioneerConsultancy.DAL
{
    public class EmployeeDataAccessLayer

    {
        public int TakeEmployeeName(EmployeeModel myEmployee)
        {
            //Creating Sql Database Connection
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeDetail VALUES(" +
                                            "'" + myEmployee.firstName + "','" + myEmployee.lastName + "','" + myEmployee.emailId + "'," +
                                            myEmployee.phoneNumber + "," + myEmployee.alternatePhoneNumber + ",'" + myEmployee.address1 + "','" + myEmployee.address2 +
                                            "','" + myEmployee.homeCountry + "','" + myEmployee.currentCountry + "'," + myEmployee.zipCode + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }

        public int TakeProjectDetail(ProjectModel myProject)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectDetail VALUES(" + "'" + myProject.projectName + "','" + myProject.clientName + "','" + myProject.location + "','" + myProject.roles + "'," + myProject.employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }

        public int TakeCompanyDetail(CompanyModel myCompany)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO CompanyDetail VALUES(" + "'" + myCompany.employerName + "'," + myCompany.contactNumber + ",'" + myCompany.location + "','" + myCompany.website + "'," + myCompany.employeeId + ")", mysqlconnection);
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;
        }

      
        public int EditCompanyDetail(CompanyModel myCompany)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";

            string sql = $"UPDATE [CompanyDetail] SET[EmployerName] =  '{myCompany.employerName}',[ContactNumber] = {myCompany.contactNumber},[Location] = '{myCompany.location}',[Website] =' {myCompany.website}' WHERE EmployeeID= {myCompany.employeeId}";
            SqlCommand cmd =new SqlCommand(sql,mysqlconnection);
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;
        }

        public int EditEmployeeDetail(EmployeeModel myEmployee)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";

            string sql = $"UPDATE [EmployeeDetail] SET[FirstName] =  '{myEmployee.firstName}',[LastName] =  '{myEmployee.lastName}',[Email] =  '{myEmployee.emailId}',[PhoneNumber] = {myEmployee.phoneNumber},[AlternatePhoneNumber] = {myEmployee.alternatePhoneNumber},[Address1] = '{myEmployee.address1}',[Address2] = '{myEmployee.address2}',[HomeCountry] =' {myEmployee.homeCountry}',[CurrentCountry] =' {myEmployee.currentCountry}',[ZipCode] = {myEmployee.zipCode} WHERE EmployeeID= {myEmployee.employeeId}";
            SqlCommand cmd = new SqlCommand(sql, mysqlconnection);
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;
        }

        public int EditProjectDetail(ProjectModel myProject)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";

            string sql = $"UPDATE [ProjectDetail] SET[ProjectName] =  '{myProject.projectName}',[ClientName] =  '{myProject.clientName}',[Location] =  '{myProject.location}',[roles] = '{myProject.roles}' WHERE EmployeeID= {myProject.employeeId}";
            SqlCommand cmd = new SqlCommand(sql, mysqlconnection);
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }
        
        public int TakeTechnicalDetail(TechnicalModel myTechnical)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-1246094;" +
                                               "database = PioneerDataBase1;Integrated security = SSPI";


            SqlCommand cmd = new SqlCommand("INSERT INTO TechnicalDetail VALUES(" +
            "'" + myTechnical.UI + "','" + myTechnical.ProgrammingLanguage + "','" + myTechnical.Database + "'," + myTechnical.employeeId + ")", mysqlconnection);
           
            //Opening Sql Database Connection
            mysqlconnection.Open();
            var result = cmd.ExecuteNonQuery();
            mysqlconnection.Close();
            return result;

        }
    }
}
