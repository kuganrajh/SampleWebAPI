using Sample.App.BLL.Interface;
using Sample.App.BLL.Service;
using Sample.App.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sample.App.WebApi.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IService<Student> _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        // GET: api/Students
        public HttpResponseMessage GetStudents()
        {
            List<Student> data = _studentService.Get();
            if (data == null)
            {
                string message = string.Format("No Students found");
                return Request.CreateResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                return Request.CreateResponse<List<Student>>(HttpStatusCode.OK, data);
            }
        }

        // GET: api/Student/5
        public async Task<HttpResponseMessage> GetStudent(int id)
        {
            Student data = await _studentService.GetAsync(id);
            if (data == null)
            {
                string message = string.Format("Student with id = {0} not found", id);
                return Request.CreateResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                return Request.CreateResponse<Student>(HttpStatusCode.OK, data);
            }
        }

        // POST: api/Student
        public async Task<HttpResponseMessage> PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            student.DOB = DateTime.Now;
           var data = await _studentService.CreateAsync(student);
            return Request.CreateResponse<Student>(HttpStatusCode.OK, data);
        }

        // PUT: api/BSRRate/5
        public async Task<HttpResponseMessage> PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid || id != student.Id)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
          
            var data = await _studentService.UpdateAsync(student);
            return Request.CreateResponse<Student>(HttpStatusCode.OK, data);
        }

        // DELETE: api/Student/5
        public async Task<HttpResponseMessage> DeleteStudent(int id)
        {
            Student data = await _studentService.GetAsync(id);
            if (data == null)
            {
                string message = string.Format("Student with id = {0} not found", id);
                return Request.CreateResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                var obj = _studentService.DeleteAsync(id);
                return Request.CreateResponse(HttpStatusCode.OK, obj);
            }
        }
    }
}
