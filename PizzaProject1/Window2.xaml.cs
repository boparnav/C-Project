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

namespace PizzaProject1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        public Window2()
        {
            double TotalCharges = 0;
            InitializeComponent();
            Lblch2.Content =   Window1.total;

            double tax = 0;

            tax = (Window1.total * 13) / 100;

            LblTax2.Content = tax;



            TotalCharges = Window1.total + tax;

            LblTch2.Content =  TotalCharges;

        }
    }
}
