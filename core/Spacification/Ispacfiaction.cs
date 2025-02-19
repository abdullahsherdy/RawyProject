using core.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace core.Spacification
{
    public interface Ispacfiaction<T> where T : BaseClass
    {


        Expression<Func<T, bool>> cretaria { get; set; }
        List<Expression<Func<T, object>>> includes { get; set; }
    }
}
