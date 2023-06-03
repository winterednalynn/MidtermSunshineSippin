using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public class GoldMember : Member //INHERITED FROM MEMBER(SUPERCLASS) 
    {
        public GoldMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void AddPoints(Product product)
        {
            //ADD THE PRODUCTS +50 POINTS 
            Points += product.Points + 50; // The format to add +50 as we continue adding product we are adding an extra 50 points. 
        }

        public override void DeductPoints(Product product)
        {
            //DEDUCT half the products points - 50 from the member 
            Points -= (product.Points/2)-50;
        }

        
    }
    //class
}
//ns