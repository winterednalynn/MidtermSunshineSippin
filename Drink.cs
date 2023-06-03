using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public abstract class Drink : Product //INHERTING FROM PRODUCT(SUPERCLASS) 
    {
        public enum DrinkSize {Short, Tall, Grande, Venti, Trenta } //Enum is short for "enumerations", which means "specifically listed" , Used ENUM for DrinkSize. 
        DrinkSize _size; //Add parameters to constructor 
        protected Drink(string name, double price, int points, DrinkSize size) : base(name, price, points)
        {
            _size = size;
        }

        public override string ToString()
        {
            return base.ToString() + $"-Drink Size {_size}"; 
        }
    }
}
