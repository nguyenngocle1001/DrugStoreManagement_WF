using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Employee
    {
        DAL_Employee dalEmployee = new DAL_Employee();
        public void InsertEmployee(DTO_Employee employee){
            dalEmployee.InsertEmployee(employee);
        }

        public void UpdateEmployee(DTO_Employee employee)
        {
            dalEmployee.UpdateEmployee(employee);
        }

        public void DeleteEmployee(DTO_Employee employee)
        {
            dalEmployee.DeleteEmployee(employee);
        }
    }
}
