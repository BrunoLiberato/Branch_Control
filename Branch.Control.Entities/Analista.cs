﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.Control.Entities
{
    public class Analista
    {
        public Analista()
        {
            this.Id = Guid.NewGuid();
        }

        public string Name { get; set; }

        public Guid Id { get; set; }



    }
}
