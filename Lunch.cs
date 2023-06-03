using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public class Lunch : Food //INHERTIED FROM FOOD 
    {
        bool _isCombo; //TRUE OR FALSE , is combo 

        public Lunch(string name, double price, int points, bool isHeated, bool isCombo) : base(name, price, points, isHeated)
        {
            _isCombo = isCombo;
           
        }

        //APPEND BOOL TO BASE 
        public override string ToString()
        {
            return base.ToString() + $" Combo: {_isCombo} "; 
        }
    }
    //class
}
//ns
