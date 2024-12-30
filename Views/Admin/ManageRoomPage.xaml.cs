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

namespace CE181985_Tran_Minh_Quan_Assignment_2.Views.Admin
{
    /// <summary>
    /// Interaction logic for ManageRoomPage.xaml
    /// </summary>
    public partial class ManageRoomPage : Page
    {
        RoomVM room;
        public ManageRoomPage()
        {
            InitializeComponent();
            room = new RoomVM();
            DataContext = room;
        }
    }
}
