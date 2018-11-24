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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public int sizePrice = 0;

        public int addon = 0;
        public int adddrink = 0;
        public int counter = 0;
        public int counter1 = 0;

        public int CrustPrice = 0;

        public static int total = 0;



        public Window1()
        {
            InitializeComponent();
            WelcomLbl.Content = "Welcome to Popular pizza " + MainWindow.name;
        }
        public void addAddon()
        {

            Console.WriteLine("checked");

            counter++;

        if (counter > 3)
        {
            int extras = counter - 3;
             addon = extras * 1;
        }

        else
        {
            addon = 0;
         }
            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }



        public void removeAddon()
        {
         Console.WriteLine("unchecked");
         Console.WriteLine("before removing " + counter);
                counter--;
        Console.WriteLine("after removing " + counter);

        if (counter > 3)

         {
             int extras = counter - 3;
             addon = extras * 1;
         }
        else
        {
            addon = 0;
        }
            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }

        public void addDrinkaddon()
        {

            Console.WriteLine("checked");

            counter1++;

            if (counter1 > 1)
            {
                int extras1 = counter1 - 1;
                adddrink= extras1 * 1;
            }

            else
            {
                adddrink = 0;
            }

            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }

        public void removeDrinkAddon()
        {
            Console.WriteLine("unchecked");
            Console.WriteLine("before removing " + counter1);
            counter1--;
            Console.WriteLine("after removing " + counter1);

            if (counter1 > 1)

            {
                int extras1 = counter1 - 1;
                adddrink = extras1 * 1;
            }
            else
            {
                adddrink = 0;
            }
            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }

        private void RdbSmall_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 10;
            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }

        private void RdbMedium_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 12;
            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }

        private void RdbLarge_Checked(object sender, RoutedEventArgs e)
        {
            sizePrice = 14;

            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }

        private void RdbWhole_Checked(object sender, RoutedEventArgs e)
        {
            CrustPrice = 2;
            total = (sizePrice + addon + CrustPrice + adddrink);
            LblTCharges_.Content = (total).ToString();
        }

        private void Chk1_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk1_top.IsChecked == true)
            {
             addAddon();
            }

            else

            {
              removeAddon();

            }


        }

        private void Chk2_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk2_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk3_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk3_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk4_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk4_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk5_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk5_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk6_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk6_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk7_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk7_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk8_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk8_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk9_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk9_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk10_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk10_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk11_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk11_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

        private void Chk12_top_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk12_top.IsChecked == true)
            {
                addAddon();
            }

            else

            {
                removeAddon();

            }

        }

       

        private void Chk1_Dr_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk1_Dr.IsChecked == true)
            {
                addDrinkaddon();
            }

            else

            {
                removeDrinkAddon();

            }
        }

        private void Chk2_Dr_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk2_Dr.IsChecked == true)
            {
                addDrinkaddon();
            }

            else

            {
                removeDrinkAddon();

            }
        }

        private void Chk3_Dr_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk3_Dr.IsChecked == true)
            {
                addDrinkaddon();
            }

            else

            {
                removeDrinkAddon();

            }
        }

        private void Chk4_Dr_Checked(object sender, RoutedEventArgs e)
        {
            if (Chk4_Dr.IsChecked == true)
            {
                addDrinkaddon();
            }

            else

            {
                removeDrinkAddon();

            }
        }

        private void btnTotal_Click(object sender, RoutedEventArgs e)
        {
            Window2 Total = new Window2();
            Total.Show();
            this.Hide();
        }
    }


    }
