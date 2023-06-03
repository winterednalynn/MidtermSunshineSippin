using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public class Coffee : Drink //INHERITING FROM DRINK 
    {
        //FIELDS 
        string _typeOfRoast; 

        //ADDED TYPE OF ROAST 
        public Coffee(string name, double price, int points, DrinkSize size, string typeOfRoast) : base(name, price, points, size)
        {
            _typeOfRoast = typeOfRoast;
        }

        //APPEND TYPE OF ROAST TO BASE STRING 
        public override string ToString()
        {
            return base.ToString() + $" Type of Roast: {_typeOfRoast}"; 
        }
    }
    //class
}
//ns
