using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentDataAccess;

namespace StudentServices.Controllers
{
    public class StudentsController : ApiController
    {
        public IEnumerable<Student> Get()
        {
            using (StudentDetailsEntities entities = new StudentDetailsEntities())
            {
                return entities.Students.ToList();
            }
        }

        public Student Get(int id)
        {
            using (StudentDetailsEntities entities = new StudentDetailsEntities())
            {
                return entities.Students.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}
