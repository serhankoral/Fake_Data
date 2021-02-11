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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uret_Click(object sender, RoutedEventArgs e)
        {
            uretmek();
        }
           
        void uretmek()
        {
            
            for (int i = 0; i < 10; i++)
            {
                string ad = FakeData.NameData.GetFirstName();
                string soyad = FakeData.NameData.GetSurname();
                string adres = FakeData.PlaceData.GetAddress();
                text.Text = text.Text+"\n "+ad + "   " + soyad + "    " + adres;
            }
        }
    }
}
