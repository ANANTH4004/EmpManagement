using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpOperations
    {
        EmpManagementContext context = null;

        public EmpOperations()
        {
            context = new EmpManagementContext();
        }
        public List<EmpProfile> GetAllEmp()
        {
            var ans = context.EmpProfiles.ToList();
            return ans;
        }
        public void AddEmp(EmpProfile emp)
        {
            context.EmpProfiles.Add(emp);
            context.SaveChanges();
        }
        public void EditEmp(int id, EmpProfile emp)
        {
            var ans = context.EmpProfiles.ToList().Find(temp => temp.EmpCode == id);
            context.EmpProfiles.Remove(ans);
            context.EmpProfiles.Add(emp);
            context.SaveChanges();
        }
        public void RemoveEmp(int id)
        {
            var ans = context.EmpProfiles.ToList().Find(temp => temp.EmpCode == id);
            context.EmpProfiles.Remove(ans);
            context.SaveChanges();
        }
        public List<DeptMaster> GetAllDept()
        {
            return context.DeptMasters.ToList();
        }
        public void AddDept(DeptMaster m)
        {
            context.DeptMasters.Add(m);
            context.SaveChanges();
        }
        public void EditDept(int id , DeptMaster dept)
        {
            var ans = context.DeptMasters.ToList().Find(temp=>temp.DeptCode == id);
            context.DeptMasters.Remove(ans);
            context.DeptMasters.Add(dept);
            context.SaveChanges();
        }
        public void RemoveDept(int id)
        {
            var ans = context.DeptMasters.ToList().Find(temp => temp.DeptCode == id);
            context.DeptMasters.Remove(ans);
            context.SaveChanges();
        }
    }
}
