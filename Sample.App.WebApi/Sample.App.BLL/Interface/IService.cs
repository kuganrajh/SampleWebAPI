using Sample.App.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.App.BLL.Interface
{
    public interface IService<T>
    {
        List<T> Get();
        Task<T> GetAsync(int id);
        Task<T> CreateAsync(T student);
        Task<T> UpdateAsync(T student);
        int DeleteAsync(int id);
    }
}
