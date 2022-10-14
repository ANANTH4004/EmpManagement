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
        public void UpdateEmp(int id,EmpProfile emp1)
        {
            emp.EditEmp(id, emp1);
        }
        public void DeleteEmp(int id)
        {
            emp.RemoveEmp(id);
        }
        public List<DeptMaster> ShowAllDept()
        {
            return emp.GetAllDept();
        }
        public void InserDept(DeptMaster dept)
        {
            emp.AddDept(dept);
        }
        public void UpdateDept(int id , DeptMaster dept)
        {
            emp.EditDept(id, dept);
        }
        public void DeleteDept(int id)
        {
            emp.RemoveDept(id);
        }
    }
}
