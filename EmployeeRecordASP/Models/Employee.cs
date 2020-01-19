using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRecordASP.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int salary { get; set; } 
        public string JobType { get; set; }
    }
}