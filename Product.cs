using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public abstract class Product
    {
        Random random = new Random();
        string _name;
        int _sku;
        double _price;
        int _points;
        static int _numberOfProduct;

        public int Points { get => _points; set => _points = value; }

        public Product(string name, double price, int points) //CONSTRUCTOR with name , price and points in parameters 
        {
             
            _name = name;
            _price = price;
            _points = points;
            _sku = random.Next(1000000, 10000000);
        }

        public override string ToString()
        {
            //THE GETTYPE().NAME calls for the name of the class. 
            //I identify the _sku as the order number 
            //The price section , there's a "c"  - that's calls for currency format. A "$" sign with prompt when script is called. 
            return $"{GetType().Name} - Order Number:{_sku} - Name: {_name} - Price: {_price.ToString("c")} - Points: {_points}";
        }
    }
}
