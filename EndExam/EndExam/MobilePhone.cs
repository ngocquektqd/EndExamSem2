﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndExam
{
    class MobilePhone : Product
    {
        public MobilePhone(int productID, string name, double price, string producer) : base(productID, name, price, producer) { }
        public override double computeTax()
        {
            return this.price*10/100;
        }
    }
}
