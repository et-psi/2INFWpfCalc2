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

namespace WpfCalculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Addition addition;
        private Soustraction soustraction;
        private Multiplication mult;
        private Division division;

        public MainWindow()
        {
            InitializeComponent();
            addition = new Addition(0, 0);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    addition.setVal1(dblNumber1);
                    addition.setVal2(dblNumber2);
                    lblResponse.Content = addition.Additionne();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisis !", "Convesion",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    soustraction.setVal1(dblNumber1);
                    soustraction.setVal2(dblNumber2);
                    lblResponse.Content = soustraction.Soustraire();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisis !", "Convesion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    division.setVal1(dblNumber1);
                    division.setVal2(dblNumber2);
                    lblResponse.Content = division.Diviser();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisis !", "Convesion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            double dblNumber1;
            double dblNumber2;

            if (double.TryParse(tbxNumber1.Text, out dblNumber1))
            {
                if (double.TryParse(tbxNumber2.Text, out dblNumber2))
                {
                    mult.setVal1(dblNumber1);
                    mult.setVal2(dblNumber2);
                    lblResponse.Content = mult.multiplier();
                }
            }
            else
            {
                MessageBox.Show("Veuillez contrôler le format des nombres saisis !", "Convesion", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
