using core.Models;
using core.Spacification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repsotiry.spacification
{
    public class bookspacefcation:BaseSpacfication<Book>
    {
        public bookspacefcation() {
            includes.Add(b => b.Author);
            includes.Add(b => b.reviews);
            includes.Add(b => b.catygories);
        }
        public bookspacefcation(int id):base(b=>b.Id==id)
        {
            includes.Add(b => b.Author);
            includes.Add(b=>b.reviews);
            includes.Add(b=>b.catygories);


        }
    }
}
