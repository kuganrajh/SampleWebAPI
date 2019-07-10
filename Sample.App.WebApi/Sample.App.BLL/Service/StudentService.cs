using Sample.App.BLL.Interface;
using Sample.App.BO;
using Sample.App.DAL.Interfaces;
using Sample.App.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.BLL.Service
{
    public class StudentService :IService<Student>
    {
        private readonly IRepository<Student> _studentRepository;
        public StudentService()
        {
            // of this here we can use Dependency Injection- Ninject module
            _studentRepository = new StudentRepository();
        }

       
        /// <summary>
        /// Get All Data of object .
        /// </summary>
        /// <returns></returns>
        public List<Student> Get()
        {
            var listData = _studentRepository.Get();
            return listData;
        }

        /// <summary>
        /// Get specific single Data of object by key  .
        /// </summary>
        /// <returns></returns>
        public async Task<Student> GetAsync(int id)
        {
            var data = await _studentRepository.GetAsync(id);
            return data;
        }

        /// <summary>
        /// save specific single Data of object
        /// </summary>
        /// 
        /// <returns></returns>
        /// 
        public async Task<Student> CreateAsync(Student student)
        {
            var data = await _studentRepository.CreateAsync(student);
            return data;
        }

        /// <summary>
        /// Update specific single Data of object
        /// </summary>
        /// 
        /// <returns></returns>
        /// 
        public async Task<Student> UpdateAsync(Student student)
        {
            var data = await _studentRepository.UpdateAsync(student);
            return data;
        }

        /// <summary>
        /// Delete specific single Data of object by key
        /// </summary>
        /// 
        /// <returns></returns>
        /// 
        public int DeleteAsync(int id)
        {
            return _studentRepository.DeleteAsync(id);
        }
    }
}
