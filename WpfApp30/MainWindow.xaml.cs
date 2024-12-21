﻿using System;
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

namespace WpfApp30
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int gep = new Random().Next(1, 11);
        public MainWindow()
        {
            InitializeComponent();
            csuszka.ValueChanged += Csuszka_ValueChanged;
            gomb.Click += Gomb_Click;
        }

        private void Gomb_Click(object sender, RoutedEventArgs e)
        {
            int enTippem = (int)csuszka.Value;
            if (gep==enTippem)
            {
                MessageBox.Show("Eltaláltad");
            }
            else if (gep>enTippem)
            {
                MessageBox.Show("Nagyobbra gondoltam");
            }
            else
            {
                MessageBox.Show("Kisebbre gondoltam");
            }
        }

        private void Csuszka_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            szam.Text = csuszka.Value.ToString();
        }
    }
}
