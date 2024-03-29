﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }

        public int? CategoryID { get; set; }
        //Relational Properties 
        public virtual Category Category { get; set; }

    }
}
