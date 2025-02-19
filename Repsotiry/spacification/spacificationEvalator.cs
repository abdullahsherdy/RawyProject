using core.Models;
using core.Spacification;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repsotiry.spacification
{
    public static class spacificationEvalator<T> where T : BaseClass
    {
        public static IQueryable<T> GetQuery(IQueryable<T> input, Ispacfiaction<T> spac) {
            var Query = input;

            if (spac.cretaria is not null) 
                Query = input.Where(spac.cretaria); 
            

            Query = spac.includes.Aggregate(Query, (q1, q2) => q1.Include(q2));

            return Query;
        
       
        }
    }
}
