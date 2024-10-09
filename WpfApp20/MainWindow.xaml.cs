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

namespace WpfApp20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            csokkent.Click += Csokkent_Click;
            novel.Click += Novel_Click;
        }

        private void Novel_Click(object sender, RoutedEventArgs e)
        {
            int jelenlegi = Convert.ToInt32(szam.Text);
            int novelt = jelenlegi+1;
            szam.Text = novelt.ToString();
        }

        private void Csokkent_Click(object sender, RoutedEventArgs e)
        {
            int jelenlegi = Convert.ToInt32(szam.Text);
            int csokkentett = jelenlegi - 1;
            szam.Text = csokkentett.ToString();
        }
    }
}
