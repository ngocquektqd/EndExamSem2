﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndExam
{
    class Book : Product
    {
        public Book(int productID, string name, double price, string producer) : base(productID, name, price, producer)
        {
        }
        public override double computeTax()
        {
            return this.price*8/100;
        }
        
    }
}
