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
            First_Textblock.Margin = new Thickness(92, 96, 618, 440.8);
            Second_Textblock.Text = "Dolche";
            Second_Textblock.Margin = new Thickness(274, 96, 436, 440);
            Third_Textblock.Text = "Emilia";
            Third_Textblock.Margin = new Thickness(459, 96, 251, 440.8);
            fourty_Textblock.Text = "Hawai";
            fourty_Textblock.Margin = new Thickness(646, 96, 64, 440.8);
            fifth_Textblock.Text = "Julien";
            fifth_Textblock.Margin = new Thickness(99, 289, 616, 247.8);
            sixth_Textblock.Text = "Margarita";
            sixth_Textblock.Margin = new Thickness(266, 289, 434, 247.8);
            seventh_Textblock.Text = "Manhattan";
            seventh_Textblock.Margin = new Thickness(450, 289, 249, 247.8);
            eighth_Textblock.Text = "Peperoni";
            eighth_Textblock.Margin = new Thickness(636, 289, 64, 247.8);





            FirstImage.Source = new BitmapImage(new Uri("Images/chipolo.jpg", UriKind.Relative));
            SecondImage.Source = new BitmapImage(new Uri("Images/dolche.jpg", UriKind.Relative));
            ThirdImage.Source = new BitmapImage(new Uri("Images/emilia.jpg", UriKind.Relative));
            fourthImage.Source = new BitmapImage(new Uri("Images/hawai.jpg", UriKind.Relative));
            fifthImage.Source = new BitmapImage(new Uri("Images/julien.jpg", UriKind.Relative));
            sixthImage.Source = new BitmapImage(new Uri("Images/Margarita.jpg", UriKind.Relative));
            seventhImage.Source = new BitmapImage(new Uri("Images/munhaten.jpg", UriKind.Relative));
            eighthImage.Source = new BitmapImage(new Uri("Images/peperoni.jpg", UriKind.Relative));

        }

        private void Burger_Btn_Click(object sender, RoutedEventArgs e)
        {
            page = 2;
            First_Textblock.Text = "BigKing";
            First_Textblock.Margin = new Thickness(92, 96, 618, 440.8);
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



            FirstImage.Source = new BitmapImage(new Uri("burgers/big king.png", UriKind.Relative));
            SecondImage.Source = new BitmapImage(new Uri("burgers/cheaseburger def.png", UriKind.Relative));
            ThirdImage.Source = new BitmapImage(new Uri("burgers/double cheaseburger.png", UriKind.Relative));
            fourthImage.Source = new BitmapImage(new Uri("burgers/double vopper.png", UriKind.Relative));
            fifthImage.Source = new BitmapImage(new Uri("burgers/gamburger.png", UriKind.Relative));
            sixthImage.Source = new BitmapImage(new Uri("burgers/vopper + chease.png", UriKind.Relative));
            seventhImage.Source = new BitmapImage(new Uri("burgers/vopper junior.png", UriKind.Relative));
            eighthImage.Source = new BitmapImage(new Uri("burgers/vopper.png", UriKind.Relative));




        }

        private void Drinks_Btn_Click(object sender, RoutedEventArgs e)
        {
            page = 3;
            First_Textblock.Text = "7up";
            First_Textblock.Margin = new Thickness(97, 96, 618, 440.8);
            Second_Textblock.Text = "Americano";
            Second_Textblock.Margin = new Thickness(257, 96, 436, 440);
            Third_Textblock.Text = " Black tea";
            Third_Textblock.Margin = new Thickness(447, 96, 251, 440.8);
            fourty_Textblock.Text = "Green tea";
            fourty_Textblock.Margin = new Thickness(635, 96, 64, 440.8);
            fifth_Textblock.Text = "Cappuccino";
            fifth_Textblock.Margin = new Thickness(82, 289, 616, 247.8);
            sixth_Textblock.Text = "Latte";
            sixth_Textblock.Margin = new Thickness(280, 289, 434, 247.8);
            seventh_Textblock.Text = "Mirinda";
            seventh_Textblock.Margin = new Thickness(460, 289, 249, 247.8);
            eighth_Textblock.Text = "Pepsi";
            eighth_Textblock.Margin = new Thickness(648, 289, 64, 247.8);




            FirstImage.Source = new BitmapImage(new Uri("drinks/7up.png", UriKind.Relative));
            SecondImage.Source = new BitmapImage(new Uri("drinks/americano.png", UriKind.Relative));
            ThirdImage.Source = new BitmapImage(new Uri("drinks/black tea.png", UriKind.Relative));
            fourthImage.Source = new BitmapImage(new Uri("drinks/green tea.png", UriKind.Relative));
            fifthImage.Source = new BitmapImage(new Uri("drinks/kapuchino.png", UriKind.Relative));
            sixthImage.Source = new BitmapImage(new Uri("drinks/latte.png", UriKind.Relative));
            seventhImage.Source = new BitmapImage(new Uri("drinks/mirinda.png", UriKind.Relative));
            eighthImage.Source = new BitmapImage(new Uri("drinks/pepsi.png", UriKind.Relative));

        }

        private void Other_Btn_Click(object sender, RoutedEventArgs e)
        {
            page = 4;
            First_Textblock.Text = "Chery Pie";
            First_Textblock.Margin = new Thickness(83, 96, 624, 440.8);
            Second_Textblock.Text = "Chocolate donut";
            Second_Textblock.Margin = new Thickness(248, 96, 436, 440);
            Third_Textblock.Text = "Chocolate shake";
            Third_Textblock.Margin = new Thickness(432, 96, 251, 440.8);
            fourty_Textblock.Text = "KitKia icecream";
            fourty_Textblock.Margin = new Thickness(625, 96, 64, 440.8);
            fifth_Textblock.Text = "Twix icecream";
            fifth_Textblock.Margin = new Thickness(77, 289, 616, 247.8);
            sixth_Textblock.Text = "icecream";
            sixth_Textblock.Margin = new Thickness(267, 289, 434, 247.8);
            seventh_Textblock.Text = "strawberry donut";
            seventh_Textblock.Margin = new Thickness(434, 289, 249, 247.8);
            eighth_Textblock.Text = "strawberry shake";
            eighth_Textblock.Margin = new Thickness(619, 289, 64, 247.8);



            FirstImage.Source = new BitmapImage(new Uri("other/chery pie.png", UriKind.Relative));
            SecondImage.Source = new BitmapImage(new Uri("other/chocolate donut.png", UriKind.Relative));
            ThirdImage.Source = new BitmapImage(new Uri("other/chocolate shake.png", UriKind.Relative));
            fourthImage.Source = new BitmapImage(new Uri("other/icecream kitkat.png", UriKind.Relative));
            fifthImage.Source = new BitmapImage(new Uri("other/icecream twix.png", UriKind.Relative));
            sixthImage.Source = new BitmapImage(new Uri("other/icecream.png", UriKind.Relative));
            seventhImage.Source = new BitmapImage(new Uri("other/strawberry donut.png", UriKind.Relative));
            eighthImage.Source = new BitmapImage(new Uri("other/strawberry shake.png", UriKind.Relative));



        }

    }
}
