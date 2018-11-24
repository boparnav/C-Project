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

namespace PizzaProject1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static String name = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Tb1CN_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void BtnOrder_Click(object sender, RoutedEventArgs e)
        {
            name = Tb1CN.Text;
            if (name == "")
            {
                MessageBox.Show(" Enter your name please !");
            }
            else
            {

                Window1 window = new Window1();

                window.Show();
            }
        }
    }
}
