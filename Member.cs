using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    public abstract class Member //ABSTRACT CLASS : MEMBER 
    {
        //FIELDS 

        string _firstName; 
        string _lastName;
        string _memberNumber;
        int _points;
        DateTime _memberSince; 
        ObservableCollection<Product> _previousTransations;


       public Member(string firstName, string lastName) //MEMBER CONSTRUCTOR 
        {
            Random random = new Random(); 
            _firstName = firstName;
            _lastName = lastName;
            _memberNumber = random.Next(1000000, 10000000).ToString();
            _memberSince = DateTime.Now; //Initializing DateTime.Now for _memberSince
            _points = 0;
            _previousTransations= new ObservableCollection<Product>(); 
        }

        //PROPERTIES 
   
       protected int Points { get => _points; set => _points = value; } //Protected Access Modifier ; Technically private unless it is inherited in a class 
       public ObservableCollection<Product> PreviousTransations { get => _previousTransations; }

        //METHODS 

        public abstract void DeductPoints(Product product); //Minus Points ; Abstract Method  - The format for abstract method is : public abstract void MethodBehavior(parameters); <- This method must be held in a abstract class to hold it's value as abstract method. 

        public abstract void AddPoints(Product product); // Adding Points ; Abstract Method  -  - The format for abstract method is : public abstract void MethodBehavior(parameters); <- This method must be held in a abstract class to hold it's value as abstract method.

        public void AddProduct(Product product)
        {
            _previousTransations.Add(product); //<--Syntax to add product onto collection ;  //Adding _previoustransation information into class of product to save onto collection data. 
        }

        public override string ToString()
        {
            return $"🌟{GetType().Name} - NAME: {_firstName} {_lastName}- POINTS: {_points} -  MEMBER ID:{_memberNumber} - MEMBER SINCE {_memberSince}";
        }
    }
    //class
}
//namespace