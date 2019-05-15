using PizzeriaDomen.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for UserControlAllProduct.xaml
    /// </summary>
    public partial class UserControlAllProduct : UserControl
    {
        public UserControlAllProduct()
        {
            InitializeComponent();
            FillDataGrid();
        }


        private void FillDataGrid()
        {
            string ConString = "Data Source=den1.mssql8.gear.host;Initial Catalog=mcdonaldsdb;User ID=mcdonaldsdb;Password=123456*";
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM tbl_Products";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("tbl_Products");
                sda.Fill(dt);
                DataGrid1.ItemsSource = dt.DefaultView;
            }
        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void DataGrid1_Loaded(object sender, RoutedEventArgs e)
        {
        }
    
    }
}
