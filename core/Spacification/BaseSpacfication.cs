using core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace core.Spacification
{
    public class BaseSpacfication<T> : Ispacfiaction<T> where T : BaseClass
    {
        public Expression<Func<T, bool>> cretaria{ get ; set; }
        public List<Expression<Func<T, object>>> includes { get; set; } = new List<Expression<Func<T, object>>>();
        public BaseSpacfication()
        {
            
        }
        public BaseSpacfication(Expression<Func<T, bool>> cretaria)
        {
            
              this.cretaria = cretaria;
        }
    }
}
