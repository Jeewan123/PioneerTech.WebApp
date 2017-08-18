﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTech.Models
{
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
