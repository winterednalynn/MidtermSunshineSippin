using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MIDTERM2023SIPPINAPP
{
    /// <summary>
    /// Interaction logic for OnlineScreen.xaml
    /// </summary>
    public partial class OnlineScreen : Window //WINDOW 2 - ORDERING SCREEN - CODING SECTION. 
    {
        
        public OnlineScreen()
        {
            InitializeComponent();

            //RUN DISPLAY
            FlowDocument flowDocument = new FlowDocument();
            rtbHPDisplay.Document = flowDocument;
            Paragraph paragraph = new Paragraph();
            Run run = new Run("☼Connect your membership to add or use points!\r\n " +
                " -------------------------\r\n Not A Member? \r\n " +
                "Sign up with us today! \r\n --------------------\r\n" + "Sip, Relax, and Love Today ♥");
            paragraph.Inlines.Add(run);
            flowDocument.Blocks.Add(paragraph);
            rtbHPDisplay.FontSize = 14;
            rtbHPDisplay.FontWeight = FontWeights.Bold;
            rtbHPDisplay.Background = new SolidColorBrush(Colors.Beige);
            rtbHPDisplay.Foreground = new SolidColorBrush(Colors.DeepPink);

            //--------------------------------DIVIDE---------------------------------------------//

            //SCREENS 
 
            //FOR BASKET LIST: 
            lbBasket.ItemsSource = Data.Products;
            
            

            //COMBO BOX MEMBERSHIP 
            cbMembers.ItemsSource = Data.Members;



        }
    

        private void Button_Click(object sender, RoutedEventArgs e) //ADD MEMBER EVENT 
        {
            new AddMembers().Show(); // AddMember Window will pop up 
        }

        private void btnBasket_Click(object sender, RoutedEventArgs e) //ADD BASKET EVENT
        {
            new AddProduct().Show(); // AddProduct Window will pop up 
        }

        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e) // COMBO BOX EVENT ; TO PROMPT: DOUBLE CLICK ON COMBO BOX 
        {
            Member selectedMember = (Member) cbMembers.SelectedItem;  // This is the format used to identify which details are being selected in the combo box. In the combo box, our member information is queued once member inputs their information into the member screen. 
            Data.UpdateCurrentMember(selectedMember);  // Using our Data Class & accessing our UpdateCurrentMember method, the selected member in the combo box is then placed in the method parameter. In the data class this method is structured like this UPDATECURRENTMEMBER(Member member) , our selected member presents the required parameter of "member".       
                                                    
            Data.Members[0].AddProduct(Data.Products[0]); //Matching list placement from  Member & Product collection - Index 0 in Member selected will prompt information matching Index 0 in Product collection 
                                                           
            Data.Members[1].AddProduct(Data.Products[1]); //Matching list placement from  Member & Product collection

            lbPreviousTransaction.ItemsSource = Data.CurrentMember.PreviousTransations; // Displaying Product script onto Previous Transaction list box. 
            
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e) //BUY EVENT - Gain Points 
        {
            if (Data.CurrentProduct != null & Data.CurrentMember != null)
            {
                Data.CurrentMember.AddProduct(Data.CurrentProduct); //Adding Product into Current Product 
                Data.CurrentMember.AddPoints(Data.CurrentProduct); // Adding Points per product 
                cbMembers.Items.Refresh(); // This will update the point section in the member script 
            }
        }

        private void lbBasket_SelectionChanged(object sender, SelectionChangedEventArgs e) //BASKET LISTBOX , When index is selected 
        {
            //TWO FORMATS SAME JOB  
            Product currentlySelected = (Product)lbBasket.SelectedItem; // The pretty way . 
            /*Product currentlySelected = (Product)Data.Products[lbBasket.SelectedIndex];*/ // The long way. 
            Data.UpdateCurrentProduct(currentlySelected); 
        }

        private void btnUsePoint_Click(object sender, RoutedEventArgs e) //USE POINT - MINUS POINTS 
        {
            if (Data.CurrentProduct != null & Data.CurrentMember != null)
            {
                Data.CurrentMember.AddProduct(Data.CurrentProduct); //Adding Product into Current Product 
                Data.CurrentMember.DeductPoints(Data.CurrentProduct); // Minusing Points per product established points 
                cbMembers.Items.Refresh(); // This will update the point section in the member script 

            }

        }
    }
}
