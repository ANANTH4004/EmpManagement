using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using EmpManagement.Models;

namespace EmpManagement.Controllers
{
    public class EmpController : ApiController
    {
        logic log;
        public EmpController()
        {
            log = new logic();
        }
        // GET api/<controller>
        public List<Employee> Get()
        {
           var ans = log.ShowAllEmp();
            List<Employee> emplist = new List<Employee>();
            foreach (var item in ans)
            {
                emplist.Add(new Employee() { EmpName = item.EmpName, DeptCode = item.DeptCode, DateOfBirth = item.DateOfBirth, Email = item.Email, EmpCode = item.EmpCode });
            }
            return emplist;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] Employee value)
        {
            EmpProfile emp = new EmpProfile();
            emp.EmpCode = value.EmpCode;
            emp.DateOfBirth = value.DateOfBirth;
            emp.EmpName = value.EmpName; 
            emp.DeptCode = value.DeptCode;
            emp.EmpName=value.EmpName;
            emp.Email = value.Email;
           
            log.InsertEmp(emp);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}