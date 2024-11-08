using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefindedArray
{
    //Create an array of 5 products contains id,name & price & display the products
    public class Product
    {
        private int id;
        private string name;
        private double price;

       public int Id
        {
            set { id=value;}
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        public override string ToString()
        {
            return $"Id={id}  Name={name}  Price={price}";
        }
    }
}
