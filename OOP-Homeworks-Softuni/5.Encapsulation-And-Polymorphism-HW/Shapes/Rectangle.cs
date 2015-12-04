﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width*this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2*(this.Height + this.Width);
        }
    }
}