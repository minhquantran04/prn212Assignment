using CE181985_Tran_Minh_Quan_Assignment_2.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CE181985_Tran_Minh_Quan_Assignment_2.Views.Admin
{
    /// <summary>
    /// Interaction logic for ManageBookingPage.xaml
    /// </summary>
    public partial class ManageBookingPage : Page
    {
        BookVM book = new BookVM();
        public ManageBookingPage()
        {
            InitializeComponent();
            DataContext = book;
        }

        private void detailBtn_Click(object sender, RoutedEventArgs e)
        {
            if (book.SelectedItem != null)
            {
                Window detail = new DetailView();
                DetailVM d = new DetailVM();
                d.Bookings = book.SelectedItem;
                using (var context = new FuminiHotelManagementContext())
                {
                    if (d.Bookings != null)
                    {
                        var items = context.BookingDetails.Include(x => x.Room).Include(x => x.BookingReservation).Where(x => x.BookingReservationId == d.Bookings.BookingReservationId).ToList();
                        if (items != null)
                        {
                            foreach (var item in items)
                            {
                                item.BookingReservation= d.Bookings;
                                d.Details.Add(item);
                            }
                        }
                    }

                }
                detail.DataContext = d;
                detail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select any item in table before do this function!", "No Data", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
