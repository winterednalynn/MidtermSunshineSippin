using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public class Mugs : Merchandise //INHERITED FROM MERCHANDISE 
    {
        //FIELDS 
        string _design;

        //CONSTRUCTOR , ADDED DESIGN 
        public Mugs(string name, double price, int points, string design) : base(name, price, points)
        {
            _design = design;
        }

        //APPEND DESIGN TO BASE STRING 
        public override string ToString()
        {
            return base.ToString() + $"Design: {_design}"; 
        }
    }
}
