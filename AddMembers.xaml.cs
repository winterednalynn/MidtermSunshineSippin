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

namespace MIDTERM2023SIPPINAPP
{
    /// <summary>
    /// Interaction logic for AddMembers.xaml
    /// </summary>
    public partial class AddMembers : Window // WINDOW 4 - ADD MEMBERS - CODING SECTION 
    {
        public AddMembers()
        {
            InitializeComponent();
        }

        private void btnAddMembers_Click(object sender, RoutedEventArgs e)
        {
            bool selectedStandard = RBStandardMember.IsChecked.Value;
            bool selectedGold = RBGoldMember.IsChecked.Value;

            if (selectedStandard)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                StandardMember standardMember = new StandardMember(firstName, lastName);
                lbMembership.Items.Add(standardMember);
                Data.AddMemberToCollection(standardMember); 


            }
            if (selectedGold)
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                GoldMember goldMember = new GoldMember(firstName, lastName);
                lbMembership.Items.Add(goldMember);
                Data.AddMemberToCollection(goldMember);

            }
        }

        private void lbMembership_SelectionChanged(object sender, SelectionChangedEventArgs e) //LIST BOX MEMBER , WHEN SELECTED. 
        {
            

            Member selectedMember = (Member)lbMembership.SelectedItem;  // This is the format used to identify which details are being selected in the combo box. In the combo box, our member information is queued once member inputs their information into the member screen. 
            Data.UpdateCurrentMember(selectedMember);  // Using our Data Class & accessing our UpdateCurrentMember method, the selected member in the combo box is then placed in the method parameter. In the data class this method is structured like this UPDATECURRENTMEMBER(Member member) , our selected member presents the required parameter of "member".       

            Data.Members[0].AddProduct(Data.Products[0]);
            Data.Members[1].AddProduct(Data.Products[1]);
            


            lbTransactionHistory.ItemsSource = Data.CurrentMember.PreviousTransations; // Displaying Product script onto  Transaction list box. 
           

        }
    }
}
