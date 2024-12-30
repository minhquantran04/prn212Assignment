using CE181985_Tran_Minh_Quan_Assignment_2.ViewModels;
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

namespace CE181985_Tran_Minh_Quan_Assignment_2.Views.Customer
{
    /// <summary>
    /// Interaction logic for ManageProfilePage.xaml
    /// </summary>
    public partial class ManageProfilePage : Page
    {
        

        public ManageProfilePage(string email)
        {
            ProfileVM vm = new ProfileVM(email);
            InitializeComponent();
            DataContext = vm;
        }
    }
}
