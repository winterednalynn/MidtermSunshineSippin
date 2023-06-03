using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
   public class Tumblers:Merchandise //inherited from Merchandise 
    {
        string _color;

        public Tumblers(string name, double price, int points, string color) : base(name, price, points)
        {
            _color = color; 
        }

        //APPEND COLOR TO BASE STRING
        public override string ToString()
        {
            return base.ToString() + $" Tumbler Color: {_color} "; 
        }

    }
    //class
}
//ns
