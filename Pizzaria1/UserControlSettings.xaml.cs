﻿using System;
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
    /// Interaction logic for UserControlSettings.xaml
    /// </summary>
    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    if (NightMode_CheckBox.IsChecked == true)
                    {

                    }
                }
            });

                
        }

        private void NightMode_CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}