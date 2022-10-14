using BLL;
using DAL;
using EmpManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpManagement.Controllers
{
    public class DeptController : ApiController
    {
        logic log;
        // GET api/<controller>
        public DeptController()
        {
            log = new logic();   
        }
        public List<Dept> Get()
        {
            var ans = log.ShowAllDept();
            List<Dept> deptlist = new List<Dept>();
            foreach (var item in ans)
            {
                deptlist.Add( new Dept() { DeptCode = item.DeptCode,DeptName=item.DeptName });
            }
            return deptlist;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] Dept value)
        {
            DeptMaster dept = new DeptMaster();
            dept.DeptCode = value.DeptCode; ;
            dept.DeptName = value.DeptName;
            log.InserDept(dept);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Dept value)
        {
            DeptMaster dept = new DeptMaster();
            dept.DeptCode = value.DeptCode; ;
            dept.DeptName = value.DeptName;
            log.UpdateDept(id, dept);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            log.DeleteDept(id);
        }
    }
}