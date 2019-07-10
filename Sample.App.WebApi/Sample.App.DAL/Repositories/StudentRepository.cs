using Sample.App.BO;
using Sample.App.DAL.Infrastructure;
using Sample.App.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.DAL.Repositories
{
    public class StudentRepository: IRepository<Student>
    {
        private readonly AppContext _context;
        public StudentRepository()
        {
            _context = new AppContext();
        }

        /// <summary>
        /// Get All Data of object .
        /// </summary>
        /// <returns></returns>
        public List<Student> Get()
        {
            var listData = _context.Students.ToList();
            return listData;
        }

        /// <summary>
        /// Get specific single Data of object by key  .
        /// </summary>
        /// <returns></returns>
        public async Task<Student> GetAsync(int id)
        {
            var data = await _context.Students.FindAsync(id);
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
            var data = _context.Students.Add(student);
            await _context.SaveChangesAsync();
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
            _context.Entry(student).State = System.Data.Entity.EntityState.Modified;
            await _context.SaveChangesAsync();
            return student;
        }

        /// <summary>
        /// Delete specific single Data of object by key
        /// </summary>
        /// 
        /// <returns></returns>
        /// 
        public int DeleteAsync(int id)
        {
            Student data = _context.Students.Find(id);
            _context.Students.Remove(data);
            _context.SaveChanges();
            return id;
        }
    }
}
