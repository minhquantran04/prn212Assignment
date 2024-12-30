using CE181985_Tran_Minh_Quan_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CE181985_Tran_Minh_Quan_Assignment_2.ViewModels
{
    public class DetailVM : BaseVM
    {
       public ObservableCollection<BookingDetail> Details {  get; set; }
        public BookingReservation Bookings {  get; set; }
        public DetailVM()
        {
            Details = new ObservableCollection<BookingDetail>();
            Bookings = new();
        }
    }
}
