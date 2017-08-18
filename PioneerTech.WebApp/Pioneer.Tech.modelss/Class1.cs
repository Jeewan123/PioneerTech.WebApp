
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pioneer.Tech.modelss;

namespace Pioneer.Tech.modelss
{
    public class CompanyModel
    {
        public string employerName { get; set; }
        public long contactNumber { get; set; }
        public string location { get; set; }
        public string website { get; set; }
        public long employeeId { get; set; }
    }

    public class EmployeeModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailId { get; set; }
        public long phoneNumber { get; set; }
        public long alternatePhoneNumber { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string homeCountry { get; set; }
        public string currentCountry { get; set; }
        public int zipCode { get; set; }
        public int employeeId { get; set; }
    }

    public class ProjectModel
    {
        public string projectName { get; set; }
        public string clientName { get; set; }
        public string location { get; set; }
        public string roles { get; set; }
        public int employeeId { get; set; }

    }

    public class TechnicalModel
    {
        public string UI { get; set; }
        public string ProgrammingLanguage { get; set; }
        public string Database { get; set; }
        public int employeeId { get; set; }

    }


}
