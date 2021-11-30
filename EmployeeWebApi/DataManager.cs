using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeWebApi
{
    public  class DataManager
    {
        private static int months = 12;

        public static List<int> RandomEmployeeData()
        {

            List<int> employeeData = new List<int>(); 
            Random random = new Random();

            for (int i = 0; i < months; i++)
            {
                employeeData.Add(random.Next(45, 150));
            }

            return employeeData;
        }
    }
}
