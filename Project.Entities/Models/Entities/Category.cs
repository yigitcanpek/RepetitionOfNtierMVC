﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Models.Entities
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Product> Products { get; set; }

    }
}
