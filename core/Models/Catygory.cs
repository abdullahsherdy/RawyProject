﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class Catygory:BaseClass
    {
        [Required]
        [MaxLength(100)]
        public string Type { get; set; }


        public ICollection<Book> Books { get; set; }=new HashSet<Book>();
    }
}
