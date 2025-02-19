using core.Models;
using core.Repository;
using core.Spacification;
using Microsoft.EntityFrameworkCore;
using Repsotiry.Data;
using Repsotiry.spacification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repsotiry.GenaricReposiory
{
    public class GenaricRepostry<T> : IGenaricrepostry<T> where T : BaseClass
    {
        private readonly RawyDbcontext rawyDbcontext;

        public GenaricRepostry(RawyDbcontext rawyDbcontext )
        {
            this.rawyDbcontext = rawyDbcontext;
        }
        public async Task<IEnumerable<T>> getallAsync()
        {
          return await rawyDbcontext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> getallwithspacAsync(Ispacfiaction<T> spac)
        {
            return await Applicationsystem(spac).ToListAsync();
        }

        public async Task<T> getbyidasync(int id)
        {
            return await rawyDbcontext.Set<T>().FindAsync(id);

        }

        public async Task<T> getbyidwithspacAsync(Ispacfiaction<T> spac)
        {
            return await Applicationsystem(spac).FirstOrDefaultAsync();
        }
        private IQueryable<T> Applicationsystem(Ispacfiaction<T> spac) {
            return spacificationEvalator<T>.GetQuery(rawyDbcontext.Set<T>(), spac);
        }
    }
}
