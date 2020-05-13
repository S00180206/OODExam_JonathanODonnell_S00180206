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

namespace OODExam_JonathanODonnell_S00180206
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //phones
        Phone db = new Phone();
        public MainWindow()
        {
            InitializeComponent();
        }

        //cant remember how to get the myPhoneData
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Phones
                        select p;
            lbxPhones.ItemsSource = query.ToList();
        }

        private void lbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone selectedPhone = lbxPhones.SelectedItem as Phone;
            if(selectedPhone!=null)
            {
                //displayPrice
                string phonePrice = $"Price>>: {selectedPhone.Price:C}";
                tbPrice.Text = phonePrice;
                //displayImage
                imgPhone.Source = new BitmapImage(new Uri($"/Image/{selectedPhone.Phone_Image}", UriKind.Relative));

            }
        }
    }
}
