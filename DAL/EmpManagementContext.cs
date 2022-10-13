using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpManagementContext : DbContext
    {
        public EmpManagementContext() : base("EmpManagement")
        {
            Database.SetInitializer(new EmpMangementInitalizer());
        }
        public virtual DbSet<EmpProfile> EmpProfiles { get; set; }
        public virtual DbSet<DeptMaster> DeptMasters { get; set; }

    }
}
