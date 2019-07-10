using Sample.App.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.DAL.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Get();
        Task<T> GetAsync(int id);
        Task<T> CreateAsync(T model);
        Task<T> UpdateAsync(T model);
        int DeleteAsync(int id);
    }
}
