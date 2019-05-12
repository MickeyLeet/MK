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
    public partial class UserControlCart : UserControl
    {
        public UserControlCart()
        {
            InitializeComponent();
            //userControlDelivery = new UserControlDelivery();
            //MessageBox.Show(userControlDelivery.fifth_Textblock.Text);
            //ListViewCart.Items.Add(userControlDelivery.mycart);
        }


        private void Upd_Click(object sender, RoutedEventArgs e)
        {
            //ListViewCart.Items.Add(userControlDelivery.mycart);
        }
    }
}
