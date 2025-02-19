using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class Teller:BaseUser
    {
        public string Cv_Url { get; set; }
  
        public int SubscribeCount { get; set; }

        public ICollection<Record> records { get; set; } = new HashSet<Record>();
    }
}
