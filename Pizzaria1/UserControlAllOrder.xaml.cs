﻿using PizzeriaDomen.EntityFramework;
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
    /// Interaction logic for UserControlAllOrder.xaml
    /// </summary>
    public partial class UserControlAllOrder : UserControl
    {
        public UserControlAllOrder()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var kk = db.Clients.ToList();
            //var dd = db.Phones.ToList();
            //personGrid.ItemsSource = kk;
            //personGrid.ItemsSource = dd;
        }
    }
}
