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

namespace WpfApp40
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index = 1; // globális változó
        public MainWindow()
        {
            InitializeComponent();
            vissza.Click += Vissza_Click;
            elore.Click += Elore_Click;
        }

        private void Elore_Click(object sender, RoutedEventArgs e)
        {
            if (index<5)
            {
                index++;
                kep.Source = new BitmapImage(new Uri($"0{index}.jpg", UriKind.Relative));
            }
        }

        private void Vissza_Click(object sender, RoutedEventArgs e)
        {
            if (index>1)
            {
                index--;
                kep.Source = new BitmapImage(new Uri($"0{index}.jpg", UriKind.Relative));
            }
        }
    }
}
