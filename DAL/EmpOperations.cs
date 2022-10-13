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
    }
}
