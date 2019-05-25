using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[6];
            product[0] = new Book(0, "A", 1000, "A1");
            product[1] = new Book(1, "B", 2000, "B2");
            product[2] = new Book(2, "C", 3000, "C3");
            product[3] = new MobilePhone(3, "D", 4000, "D4");
            product[4] = new MobilePhone(4, "E", 5000, "E5");
            product[5] = new MobilePhone(5, "F", 6000, "D4");

            double totalTax = 0;
            for(int i=0; i < product.Length; i++)
            {
                totalTax += product[i].computeTax();
            }
           
            Console.WriteLine("Total Price: " + totalTax);
            Console.ReadKey();

        }
    }
}
