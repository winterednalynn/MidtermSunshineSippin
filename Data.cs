using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDTERM2023SIPPINAPP
{
    internal static class Data // DATA CLASS , THE GLOBAL SCRIPTURE. 
    {
        //FIELDS 
        static ObservableCollection<Member> _members; //static access ObservableCollection for Member class valuing as _members; -- This list can be updated and store info
        static ObservableCollection<Product> _products; //static access for ObservableCollection for Product class valuing as _products; -- This list can be updated and store info
        static Product currentProduct = null; //static access for Product class = null; <-- null will represent information that it is given to for current Product 
        static Member currentMember = null; //static access for Member class = null <-- null will represent information that it is given for current Member. 

        //CONSTRUCTOR: Default w/ _members & _products initialized as ObservableCollection. 
        static Data()
        {
            _members = new ObservableCollection<Member>();
            _products = new ObservableCollection<Product>(); 
        }

        //PROPERTIES FOR OBSERVABLE COLLECTION: MEMBER & PRODUCT also current PRODUCT & MEMBERS as the GET PROPERTY: The get method returns the value of the variable name
        public static ObservableCollection<Member> Members { get => _members; }
        public static ObservableCollection<Product> Products { get => _products; }
        public static Product CurrentProduct { get => currentProduct;  }
        public static Member CurrentMember { get => currentMember; }

        //METHODS , These following methods should prompt when Data is called in another class. You must call Data then placed a period to access these methods to run it's code. 

        public static void AddProductToCollection(Product product) // TO add to the product collection 
        {
            _products.Add(product);
        }

        public static void AddMemberToCollection(Member member) // TO add to the member collection 
        {
            _members.Add(member);
        }

        public static void UpdateCurrentProduct(Product product) //TO update current product ; To access product information in another class THIS IS THE FORMAT OF THAT SYNTAX:->  Data.UpdateCurrentProduct(Data.Products[0]) <- identified index to prompt list placement , The value Products corresponds to the property established above. This returns the value of this variable 
        {
            currentProduct = product;
        }

        public static void UpdateCurrentMember(Member member) // TO update current member ; To access member information in another class THIS IS THE FORMAT OF THAT SYNTAX:-> Data.UpdateCurrentProduct(Data.Members[0]) <- identified index to prompt list placement , The value Members correlates to the property established above. This returns the value of this variable 
        {
            currentMember = member; 
        }
    }
}
