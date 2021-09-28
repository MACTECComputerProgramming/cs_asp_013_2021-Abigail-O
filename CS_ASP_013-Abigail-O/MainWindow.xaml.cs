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

namespace CS_ASP_013_Abigail_O
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Double total = 0.0; 

            String length = " ";
            Double lengthTotal = 0;
            if (sixSubButton.IsChecked == true)
            {
                length = " Six Inch, ";
                lengthTotal = 3.50;
            }
            else if (footLongButton.IsChecked == true)
            {
                length = " Foot Long, ";
                lengthTotal = 5.0;
            }

            String bread = " ";
            Double breadTotal = 0;
            if (wheatButton.IsChecked == true)
            {
               bread = "Wheat,";
               breadTotal = 0 ;
            }
            else if (italianButton.IsChecked == true)
            {
               bread = "Italian,";
               breadTotal = 0;
            }
            else if (flatButton.IsChecked == true)
            {
               bread = "Flat Bread,";
                breadTotal = 0.50;
            }

            String Meat = " ";
            Double meatTotal = 0.0;
            if (hamButton.IsChecked == true)
            {
                Meat = " Ham, ";
                meatTotal = 0;
            }
            else if (chickenButton.IsChecked == true)
            {
                Meat = " Roasted Chicken, ";
                meatTotal = 0;
            }
            else if (meatballButton.IsChecked == true)
            {
                Meat = " Meatballs, ";
                meatTotal = 1.00;
            }
            else if (steakButton.IsChecked == true)
            {
                 Meat = " Steak, ";
            }

            String cheese = " ";
            Double cheeseTotal = 0.0;
            sandwhichLabel.Content = (americanBox.IsChecked == true) ? cheese =  "American Cheese, " : "";
            totalLabel.Content = (americanBox.IsChecked == true) ? cheeseTotal = 0.25 : 0.0;

            sandwhichLabel.Content = (swissBox.IsChecked == true) ? cheese = "Swiss Cheese, " : "";
            totalLabel.Content = (swissBox.IsChecked == true) ? cheeseTotal = 0.30 : 0.0;

            sandwhichLabel.Content = (pepperBox.IsChecked == true) ? cheese = "PepperJack Cheese, " : "";
            totalLabel.Content = (pepperBox.IsChecked == true) ? cheeseTotal = 0.75 : 0.0;

            String veggies = " ";
            Double veggieTotal = 0.0;
            sandwhichLabel.Content = (cucumberBox.IsChecked == true) ? veggies = "Cucumbers" : "";

            sandwhichLabel.Content = (pepperBox.IsChecked == true) ? veggies = "Green Peppers" : "";
            sandwhichLabel.Content = (pepperBox.IsChecked == true) ? veggieTotal = 0.15 : 0.0;

            sandwhichLabel.Content = (lettuceBox.IsChecked == true) ? veggies = "Lettuce" : "";
            sandwhichLabel.Content = (lettuceBox.IsChecked == true) ? veggieTotal = 0.15 : 0.0;

            sandwhichLabel.Content = (onionBox.IsChecked == true) ? veggies = "Red Onion" : "";
            sandwhichLabel.Content = (onionBox.IsChecked == true) ? veggieTotal = 0.10 : 0.0;

            sandwhichLabel.Content = (allBox.IsChecked == true) ? veggies = "Cucumbers, Green Peppers, Lettuce, Red Onion": "";
            sandwhichLabel.Content = (allBox.IsChecked == true) ? veggieTotal = 0.25 : 0.0;

            String special = " ";
            Double specialTotal = 0.0;
            if ((footLongButton.IsChecked == true) && (wheatButton.IsChecked == true) && (meatballButton.IsChecked == true) && (americanBox.IsChecked == true));
            {
                special = "Special ($2.00 off)";
                specialTotal = -2.00;
            }

            sandwhichLabel.Content = length + bread + Meat + cheese + veggies + special;

            totalLabel.Content = lengthTotal + breadTotal + meatTotal + cheeseTotal + veggieTotal + specialTotal;
        }
    }
}
