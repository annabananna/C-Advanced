﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Extensions_HW1
{
    public class Shape
    {
        public int Id { get; set; }
        public virtual double GetArea()
        {
            return 0;
        }
        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}
