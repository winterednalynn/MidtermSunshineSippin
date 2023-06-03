using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    internal class Giftcard : Product //INHERITED FROM PRODUCT (SUPERCLASS) 
    {
        //FIELDS 
        double _amount;

        //CONSTRUCTOR w/ AMOUNT added. 
        public Giftcard(string name, double price, int points, double amount) : base(name, price, points)
        {
            _amount = amount;
        }
        
        //Override to string , append GC amount 
        public override string ToString()
        {
            return base.ToString() + $" Gift Card CONFIRMED Amount: {_amount} "; 
        }
    }
    //class
}
//ns
