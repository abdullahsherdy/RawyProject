using core.Models;
using core.Spacification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Repository
{
    public interface IGenaricrepostry<T> where T : BaseClass
    {
        Task<IEnumerable<T>> getallAsync();
        Task<T> getbyidasync(int id);
        Task<IEnumerable<T>> getallwithspacAsync(Ispacfiaction<T> spac);
        Task<T> getbyidwithspacAsync(Ispacfiaction<T> spac);
    }
}
