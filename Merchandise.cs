using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public abstract class Merchandise : Product //INHERITED FROM PRODUCT 
    {
        protected Merchandise(string name, double price, int points) : base(name, price, points)
        {
        }


        //APPEND COLOR TO BASE STRING 
        public override string ToString()
        {
            return base.ToString();

    }   } 
}
