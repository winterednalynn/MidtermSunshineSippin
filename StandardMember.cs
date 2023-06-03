using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public class StandardMember : Member
    {
        public StandardMember(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void AddPoints(Product product)
        {
            Points += product.Points; 
            //How I access Points = Make points in Member & Product a property to access the points. The format that is used to add points is Points += product.Points , used += to continue adding. 
            //The syntax to add points in another class is to call this method and place the product into parameters. Example: standardMember.AddPoints(Tea) , this will target the point into the Tea class and add to the Member point which is initialized as 0. Therefore, whatever points i placed into the tea class will be added to the point in member which starts w/ 0. Cause x amount points in tea + 0 will = xamount tea points. 
        }

        public override void DeductPoints(Product product)
        {
            Points -= product.Points; //Same approach as above, instead of adding we are taking away points from the member. The syntax to operate this method in another class is as followed; Example: standardMember.DeductPoints(Tea) 
        }

        
    }
    //class
}
//ns
