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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MIDTERM2023SIPPINAPP
{//EDNA LYNN LAXA 
//PROGRAMMING III : Midterm
//May 27, 2023 
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // WINDOW 1 , INTRO SCREEN , CODING SECTION. 
    {
        public MainWindow()
        {
            InitializeComponent();

           
        }

        private void btnStartOrder_Click(object sender, RoutedEventArgs e) // START ORDER BUTTON EVENT 
        {
          
            new OnlineScreen().Show(); //ORDER SCREEN / ONLINE SCREEN WILL POP UP . 

        }
    }
}
