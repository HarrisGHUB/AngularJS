using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlToJsonToAngularJS.Models
{
    public class employeeviewmodel
    {

        public int dept_id { get; set; }
        public string dept_name { get; set; }
        public int emp_id { get; set; }
        public string emp_name { get; set; }
        public decimal emp_salary { get; set; }
        public Nullable<int> emp_department { get; set; }
    }
}