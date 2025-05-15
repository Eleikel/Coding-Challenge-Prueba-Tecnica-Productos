using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Core.Application.Interfaces.Services
{
    public interface IGenericService<Dto> where Dto: class
    {
        Task Add(Dto dto);
        Task Update(Dto dto);
        Task Delete(int id);
        Task<List<Dto>> GetAll();
        Task<Dto> GetById(int id);

    }
}
