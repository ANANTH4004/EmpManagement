using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Threading.Tasks;

namespace BLL
{
    public class logic
    {
        EmpOperations emp;
        public logic()
        {
            emp = new EmpOperations();
        }
        public List<EmpProfile> ShowAllEmp()
        {
            return emp.GetAllEmp();
        }
        public void InsertEmp(EmpProfile emp1)
        {
            emp.AddEmp(emp1);
        }
    }
}
