using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefindedArray
{
//    Create an array of 5 products contains id,name & price & display the products
//Display all products - using for & foreach
//Display the products whose price is > 500 -foreach

    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] prod = new Product[] {
             new Product{Id=1,Name="Perfume",Price=550},
             new Product{Id=2,Name="SunGlasses" , Price=450},
             new Product{Id=3,Name="Shoe",Price=700},
             new Product{Id=5,Name="Smart-Watch",Price=1500},
             new Product{Id=5,Name="Wallet",Price=350}
            };
            Console.WriteLine("-------------Using for loop-----------------");
            for(int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine(prod[i]);
            }
            Console.WriteLine();
            Console.WriteLine("------------Using foreach loop---------------");
            foreach (Product p in prod) {
                Console.WriteLine(p);
            }

            Console.WriteLine();
            Console.WriteLine("---Display the products whose price is > 500 -foreach---");

            foreach (Product p in prod)
            {
                if (p.Price > 500)
                {
                    Console.WriteLine(p);
                }
            }
        }
    }
}
