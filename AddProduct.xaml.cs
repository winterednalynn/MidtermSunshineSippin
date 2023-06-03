using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MIDTERM2023SIPPINAPP // ADD PRODUCT WINDOW - CODING SECTION 
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window // WINDOW 3 - ADD PRODUCT WINDOW - CODING SECTION 
    {
        
        public AddProduct()
        {
            InitializeComponent();
            PopulateSizeComboBox(); //Calling Populated Sizes 
        

        }

        public void PopulateSizeComboBox() //Copied from midterm outline , this will print into our combo box our our AddProduct window 
        {

            //cbsize is the name of the combo box 
            //Items.Add is the syntax to add info into combo box 
            //Items.Add is then followed by a pair of parentheses , within the parentheses is the name of the content in between two quotation marks. 

            cbSize.Items.Add("Short");
            cbSize.Items.Add("Tall");
            cbSize.Items.Add("Grande");
            cbSize.Items.Add("Venti");
            cbSize.Items.Add("Trenta");
            cbSize.SelectedIndex = 0;

        }

        private void btnCoffee_Click(object sender, RoutedEventArgs e) //COFFEE EVENT , what happens when the coffee button is pressed. 
        {
            Coffee.DrinkSize size = (Coffee.DrinkSize)cbSize.SelectedIndex; // When user select size in combo box 
            
            string nameOfProduct = txtProduct.Text; // Giving variable to txtbox for Product Name , Why: When customer types in product this will be identified as a string. 
            string cost = txtPrice.Text; 
            double price = double.Parse(cost); // Giving variable name for price - establishing as a double type cause prices can be in a decimal format. 
            string tally = txtPoints.Text;
            int points = int.Parse(tally); // Product Points , Placed as an int type. (integer) 
            string cupSize = cbSize.SelectedValue.ToString(); //Giving variable for cupSize , when user selects in a combo box in a computer brain this is recognized as a index, when it is .ToString it will print the value of the selection. 
            string typeOfRoast = txtRoastOrTea.Text; //txtbox for Roast Or Tea - this string will print out . 
           
            //Since our focal point is in the coffee index, this will partake in our coffee class. 
            Coffee coffee = new Coffee(nameOfProduct, price, points, size,typeOfRoast);

            
            lbProductList.Items.Add(coffee); //Proper syntax to add Item to our product list in the list box. 
            Data.AddProductToCollection(coffee); //Adding Data into our data class for method AddProduct to Collection.
            Data.UpdateCurrentProduct(coffee); 

        }

        private void btnTea_Click(object sender, RoutedEventArgs e) //TEA EVENT , what happpens when we press the tea button 
        {
            Tea.DrinkSize size = (Tea.DrinkSize)cbSize.SelectedIndex;// When user select size in combo box 

            string nameOfProduct = txtProduct.Text; //Txt box for name of product this will queue in our constructor 
            string cost = txtPrice.Text;
            double price = double.Parse(cost); // Price is placed as a double type , this will queue in our constructor  
            string tally = txtPoints.Text;
            int points = int.Parse(tally); //Product Points , int type  , this will queue in our constructor  
            string cupSize = cbSize.SelectedValue.ToString(); //Giving variable for cupSize , when user selects in a combo box in a computer brain this is recognized as a index, when it is .ToString it will print the value of the selection. 
            string typeOftea = txtRoastOrTea.Text;//txtbox for Roast Or Tea - this string will print out , this will queue in our constructor  

            //Focal point is on our tea class, this is our tea class and the information above is then placed in the parameters as we structure a calling for these types. 
            Tea tea = new Tea(nameOfProduct, price, points, size, typeOftea);

            lbProductList.Items.Add(tea); //<--Syntax to add to our list box 
            Data.AddProductToCollection(tea); //<--Syntax to add our tea info into our Data class in a Method called Add Product to Collection. 
            Data.UpdateCurrentProduct(tea);

        }

        private void btnBreakfast_Click(object sender, RoutedEventArgs e) // BREAKFAST EVENT , what happens when we press the breakfast button 
        {
            string nameOfProduct = txtProduct.Text; //Txt box for name of product this will queue in our constructor 
            string cost = txtPrice.Text;
            double price = double.Parse(cost); // Price is placed as a double type , this will queue in our constructor  
            string tally = txtPoints.Text;
            int points = int.Parse(tally); //Product Points , int type  , this will queue in our constructor


            bool hasDairy = chbHasDairyorCombo.IsChecked.Value; //Using bool to identify the value of hasDairy. This varible will either return as True or False. It will then display true or false depending if the check box of it's corresponding of dairy / combo is checked or not. 
            bool isHeated = chbIsHeated.IsChecked.Value; 

            if (chbHasDairyorCombo.IsChecked.Value) // Using if statement for checkbox. If the checkbox is marked for HasDairy / Combo this will display true. 
            {
                hasDairy = true;  
            }
            if (chbIsHeated.IsChecked.Value)
            {
                isHeated = true; 
            }
            else //If it is not marked, then it will read false. 
            {
               
            }


            Breakfast breakfast = new Breakfast(nameOfProduct, price, points,isHeated, hasDairy); //In this breakfast event, we are focusing on the breakfast class & inputting it's requested constructor information. 
            lbProductList.Items.Add(breakfast); // The info above from name of product , price , points and has dairy will then be added onto our list box 
            Data.AddProductToCollection(breakfast); //This format is to add the information above into our data class in a method called AddProducttoCollection. 
            Data.UpdateCurrentProduct(breakfast);


        }

        private void btnLunch_Click(object sender, RoutedEventArgs e) //LUNCH EVENT ; what happens when we click on the lunch button 
        {
            string nameOfProduct = txtProduct.Text; //Txt box for name of product this will queue in our constructor 
            string cost = txtPrice.Text;
            double price = double.Parse(cost); // Price is placed as a double type , this will queue in our constructor  
            string tally = txtPoints.Text;
            int points = int.Parse(tally); //Product Points , int type  , this will queue in our constructor

            bool isAcombo = chbHasDairyorCombo.IsChecked.Value; //Using bool to identify the value of hasDairy. This varible will either return as True or False. It will then display true or false depending if the check box of it's corresponding of dairy / combo is checked or not. 
            bool isHeated = chbIsHeated.IsChecked.Value;

            if (chbHasDairyorCombo.IsChecked.Value) // Using if statement for checkbox. If the checkbox is marked for HasDairy / Combo this will display true. 
            {
                isAcombo = true;
            }
            if (chbIsHeated.IsChecked.Value)
            {
                isHeated=true;
            }
            else //If it is not marked, then it will read false. 
            {
                
            }
            Lunch lunch = new Lunch(nameOfProduct, price, points,isHeated, isAcombo);
            lbProductList.Items.Add(lunch); 
            Data.AddProductToCollection(lunch);
            Data.UpdateCurrentProduct(lunch);


        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e)//TUMBLER EVENT , what happens when we click on tumbler 
        {
            string nameOfProduct = txtProduct.Text; //Txt box for name of product this will queue in our constructor 
            string cost = txtPrice.Text;
            double price = double.Parse(cost); // Price is placed as a double type , this will queue in our constructor  
            string tally = txtPoints.Text;
            int points = int.Parse(tally); //Product Points , int type  , this will queue in our constructor
            string color = txtColorOrStyle.Text;

            Tumblers tumblers = new Tumblers(nameOfProduct, price, points, color);
            lbProductList.Items.Add(tumblers); //Adding constructor information onto our listbox called products 
            Data.AddProductToCollection(tumblers); //Adding information into our Data class in method AddProductstoCollection. 
            Data.UpdateCurrentProduct(tumblers);
        }

        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            string nameOfProduct = txtProduct.Text; //Txt box for name of product this will queue in our constructor 
            string cost = txtPrice.Text;
            double price = double.Parse(cost); // Price is placed as a double type , this will queue in our constructor  
            string tally = txtPoints.Text;
            int points = int.Parse(tally); //Product Points , int type  , this will queue in our constructor
            string design = txtColorOrStyle.Text;

            Mugs mugs = new Mugs(nameOfProduct, price, points, design); //Adding MUG constructor information

            lbProductList.Items.Add(mugs); //Adding info into product list to display 
            Data.AddProductToCollection(mugs); // Adding information to the data class to add to collection of products. 
            Data.UpdateCurrentProduct(mugs);

        }

        private void btnGiftCard_Click(object sender, RoutedEventArgs e) //GIFTCARD EVENT , what happens when giftcard button is pressed. 
        {

            string nameOfProduct = txtProduct.Text; //Txt box for name of product this will queue in our constructor 
            string cost = txtPrice.Text;
            double price = double.Parse(cost); // Price is placed as a double type , this will queue in our constructor  
            string tally = txtPoints.Text;
            int points = int.Parse(tally); //Product Points , int type  , this will queue in our constructor

            Giftcard giftcard = new Giftcard(nameOfProduct, price, points, price); // Adding parameters for Giftcard 

            lbProductList.Items.Add(giftcard);  
            Data.AddProductToCollection(giftcard);
            Data.UpdateCurrentProduct(giftcard);

        }
    }
    //class
}
//ns
