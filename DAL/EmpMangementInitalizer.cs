using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpMangementInitalizer : CreateDatabaseIfNotExists<EmpManagementContext>
    {
        protected override void Seed(EmpManagementContext context)
        {
            List<DeptMaster> deptMasterList = new List<DeptMaster>();   
            deptMasterList.Add(new DeptMaster() { DeptCode=10,DeptName="Production"});
            deptMasterList.Add(new DeptMaster() { DeptCode = 20, DeptName = "Marketing" });
            context.DeptMasters.AddRange(deptMasterList);
            List<EmpProfile> empProfileList = new List<EmpProfile>();
            empProfileList.Add(new EmpProfile() { DeptCode = 10, EmpName = "Anand" , DateOfBirth= new DateTime(2001,05,11),Email="anandabus11@gmail.com",EmpCode=4004 });
            empProfileList.Add(new EmpProfile() { DeptCode = 20, EmpName = "Varun" , DateOfBirth= new DateTime(2001,05,11),Email="varunkrish@gmail.com",EmpCode=4001 });
            context.EmpProfiles.AddRange(empProfileList);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
