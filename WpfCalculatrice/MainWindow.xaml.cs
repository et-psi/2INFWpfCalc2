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

namespace WpfCalculatrice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Addition addition;
        public MainWindow()
        {
            InitializeComponent();
            addition = new Addition(0, 0);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            addition.setVal1(22);
            addition.setVal2(33);
            lblResponse.Content = addition.Additionne();
            MessageBox.Show(addition.Affiche());
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
