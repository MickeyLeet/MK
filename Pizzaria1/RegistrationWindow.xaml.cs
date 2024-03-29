﻿using Pizzaria1.Classes;
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

namespace Pizzaria1
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        UserServiceRef.UserServiceClient cUser =new UserServiceRef.UserServiceClient();
        public RegistrationWindow()
        {
           
            InitializeComponent();
        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Accept_Click(object sender, RoutedEventArgs e)
        {
            //if (TextBox_Login != null && TextBox_Name != null && TextBox_Gmail != null && PasswordBox_Main != null)
            //{
            //    //DataUser
            //    MessageBox.Show("rr");
            //}
            //else
            //    MessageBox.Show("Input All Lines");
        }

        private void Button_Next(object sender, RoutedEventArgs e)
        {
            try
            {
                //fhf
                cUser.Registrer(tb_Login.Text, tb_Email.Text, tb_Password.Text, tb_RepeatPass.Text);
                LoginWindow loginWindow = new LoginWindow();
                this.Close();
                loginWindow.Show();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}
