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

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for UserControlDelivery.xaml
    /// </summary>
    public partial class UserControlDelivery : UserControl
    {
        int page = 0;
        public UserControlDelivery()
        {
            InitializeComponent();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Pizza_Btn_Click(object sender, RoutedEventArgs e)
        {
            page = 1;
            First_Textblock.Text = "Chipolo";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            Second_Textblock.Text = "Dolche";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            Third_Textblock.Text = "Emilia";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            fourty_Textblock.Text = "Hawai";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            fifth_Textblock.Text = "Julien";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            sixth_Textblock.Text = "Margarita";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            seventh_Textblock.Text = "Manhattan";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            eighth_Textblock.Text = "Peperoni";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);

        }

        private void Burger_Btn_Click(object sender, RoutedEventArgs e)
        {
            page = 2;
            First_Textblock.Text = "BigKing";
            Second_Textblock.Margin = new Thickness(92, 96, 618, 440.8);
            Second_Textblock.Text = "Cheaseburger";
            Second_Textblock.Margin = new Thickness(254, 96, 436, 440);
            Third_Textblock.Text = " X Cheaseburger";
            Third_Textblock.Margin = new Thickness(432, 96, 251, 440.8);
            fourty_Textblock.Text = "X Vopper";
            fourty_Textblock.Margin = new Thickness(641, 96, 64, 440.8);
            fifth_Textblock.Text = "Gamburger";
            fifth_Textblock.Margin = new Thickness(84, 289, 616, 247.8);
            sixth_Textblock.Text = "Chease Vopper";
            sixth_Textblock.Margin = new Thickness(255, 289, 434, 247.8);
            seventh_Textblock.Text = "Junior Vopper";
            seventh_Textblock.Margin = new Thickness(442, 289, 249, 247.8);
            eighth_Textblock.Text = "Vopper";
            eighth_Textblock.Margin = new Thickness(646, 289, 64, 247.8);

        }

        private void Drinks_Btn_Click(object sender, RoutedEventArgs e)
        {
            page = 3;
            First_Textblock.Text = "7up";
            Second_Textblock.Margin = new Thickness(92, 96, 618, 440.8);
            Second_Textblock.Text = "Americano";
            Second_Textblock.Margin = new Thickness(254, 96, 436, 440);
            Third_Textblock.Text = " Black tea";
            Third_Textblock.Margin = new Thickness(432, 96, 251, 440.8);
            fourty_Textblock.Text = "Green tea";
            fourty_Textblock.Margin = new Thickness(641, 96, 64, 440.8);
            fifth_Textblock.Text = "Cappuccino";
            fifth_Textblock.Margin = new Thickness(84, 289, 616, 247.8);
            sixth_Textblock.Text = "Latte";
            sixth_Textblock.Margin = new Thickness(255, 289, 434, 247.8);
            seventh_Textblock.Text = "Mirinda";
            seventh_Textblock.Margin = new Thickness(442, 289, 249, 247.8);
            eighth_Textblock.Text = "Pepsi";
            eighth_Textblock.Margin = new Thickness(646, 289, 64, 247.8);
        }

        private void Other_Btn_Click(object sender, RoutedEventArgs e)
        {
            page = 4;
            First_Textblock.Text = "BigKing";
            Second_Textblock.Margin = new Thickness(92, 96, 618, 440.8);
            Second_Textblock.Text = "Cheaseburger";
            Second_Textblock.Margin = new Thickness(254, 96, 436, 440);
            Third_Textblock.Text = " X Cheaseburger";
            Third_Textblock.Margin = new Thickness(432, 96, 251, 440.8);
            fourty_Textblock.Text = "X Vopper";
            fourty_Textblock.Margin = new Thickness(641, 96, 64, 440.8);
            fifth_Textblock.Text = "Gamburger";
            fifth_Textblock.Margin = new Thickness(84, 289, 616, 247.8);
            sixth_Textblock.Text = "Chease Vopper";
            sixth_Textblock.Margin = new Thickness(255, 289, 434, 247.8);
            seventh_Textblock.Text = "Junior Vopper";
            seventh_Textblock.Margin = new Thickness(442, 289, 249, 247.8);
            eighth_Textblock.Text = "Vopper";
            eighth_Textblock.Margin = new Thickness(646, 289, 64, 247.8);
        }

    }
}
