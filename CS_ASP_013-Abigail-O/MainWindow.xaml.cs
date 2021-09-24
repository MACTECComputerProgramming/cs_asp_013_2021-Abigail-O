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
            
            
            if (wheatButton.IsChecked == true)
            {
                sandwhichLabel.Content = "Wheat,";
            }
            else if (italianButton.IsChecked == true)
            {
                sandwhichLabel.Content = "Italian,";
            }
            else if (flatButton.IsChecked == true)
            {
                sandwhichLabel.Content = "Flat Bread,";
            }
            if (hamButton.IsChecked == true)
            {
                sandwhichLabel.Content = " Ham, ";
            }
            else if (chickenButton.IsChecked == true)
            {
                sandwhichLabel.Content = " Roasted Chicken, ";
            }
            else if (meatballButton.IsChecked == true)
            {
                sandwhichLabel.Content = " Meatballs, ";
            }
            else if (steakButton.IsChecked == true)
            {
                sandwhichLabel.Content = " Steak, ";
            }


            sandwhichLabel.Content = (americanBox.IsChecked == true) ? "American Cheese" : "";

            sandwhichLabel.Content = (swissBox.IsChecked == true) ? "Swiss Cheese" : "";

            sandwhichLabel.Content = (pepperBox.IsChecked == true) ? "PepperJack Cheese" : "";

            sandwhichLabel.Content = (cucumberBox.IsChecked == true) ? "Cucumbers" : "";

            sandwhichLabel.Content = (pepperBox.IsChecked == true) ? "Green Peppers" : "";

            sandwhichLabel.Content = (lettuceBox.IsChecked == true) ? "Lettuce" : "";

            sandwhichLabel.Content = (onionBox.IsChecked == true) ? "Red Onion" : "";

            sandwhichLabel.Content = (allBox.IsChecked == true) ? "Cucumbers, Green Peppers, Lettuce, Red Onion": "";

        }
    }
}
