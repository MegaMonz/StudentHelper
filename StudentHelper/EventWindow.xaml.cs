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

namespace StudentHelper {
    /// <summary>
    /// Interaction logic for EventWindow.xaml
    /// </summary>
    public partial class EventWindow : Window {
        private string weekDay;
        public EventWindow(string weekday) {
            InitializeComponent();
            weekDay = weekday;
        }

        

        

        private void Button_HWComplete_Click(object sender, RoutedEventArgs e)
        {
            DateTime staTime = Convert.ToDateTime(Date.SelectedDate);

            TimeSpan timest = new TimeSpan(Convert.ToInt32(Hours.SelectedItem.ToString()), Convert.ToInt32(Minutes.SelectedItem.ToString()), 0);

            staTime = staTime + timest;


        }

        private void Hours_DropDownOpened(object sender, EventArgs e) {

        } 
    }
}
