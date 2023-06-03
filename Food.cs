using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MIDTERM2023SIPPINAPP
{
    public abstract class Food : Product //INHERTING FROM PRODUCT (SUPERCLASS) 
    {
        bool _isHeated; //YES OR NO IS HEATED 

        protected Food(string name, double price, int points, bool isHeated) : base(name, price, points)
        {
            _isHeated = isHeated;
        }

        //APPEND BOOL CONCLUSION TO BASE. 
        public override string ToString()
        {
            return base.ToString() + $" Heated: {_isHeated} "; 
        }
    }
}
