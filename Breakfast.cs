using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public class Breakfast : Food //INHERTING FROM FOOD 
    {
        //FIELDS : 

        bool _hasDairy;



        //CONSTRUCTOR 
        public Breakfast(string name, double price, int points, bool isHeated, bool hasDairy) : base(name, price, points, isHeated)
        {
            _hasDairy = hasDairy;
        }


        //APPEND HAS DAIRY TO BASE 
        public override string ToString()
        {
            return base.ToString() + $" Has Dairy: {_hasDairy} ";
        }
    }
    //class
}
//ns
