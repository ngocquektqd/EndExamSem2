using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndExam
{
    abstract class Product
    {
        public int productID;
        public string name;
        public double price;
        public string producer;

        protected Product(int productID, string name, double price, string producer)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }

        public abstract double computeTax();
    }

}
