using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi.Models
{
    public class EmployeeData
    {
        public List<int> employeesNum { get; set; }
        public string year { get; set; }

        public EmployeeData(List<int> _employeesNum,  int _year)
        {
            employeesNum = _employeesNum;
            year = _year.ToString();
        }
    }
}
