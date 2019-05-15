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
    /// Interaction logic for UserControlJob.xaml
    /// </summary>
    public partial class UserControlJob : UserControl
    {
        public UserControlJob()
        {
            InitializeComponent();
        }

        private void SendRequestJob_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (txb_JobName != null && txb_JobSurName != null && txb_JobPhone != null)
            {

            }
            else
                MessageBox.Show("You must input all lines");

        }
    }
}
