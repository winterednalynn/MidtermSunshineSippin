using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public class Tea : Drink //inherited from Drink 
    {
        string _typeOftea;
        
        public Tea(string name, double price, int points, DrinkSize size,string typeOftea) : base(name, price, points, size)
        {
            _typeOftea = typeOftea;
        }

        //Append Tea to base string 
        public override string ToString()
        {
            return base.ToString() + $"Type Of Tea: {_typeOftea}";
        }

    }
}
