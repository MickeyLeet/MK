using Pizzaria1.Classes;
using PizzeriaDomen.Entities;
using PizzeriaDomen.EntityFramework;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        EFContext context = new EFContext();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Register_Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            UserServiceRef.UserServiceClient client = new UserServiceRef.UserServiceClient();
            try
            {
                bool isAdmin = client.Login(tb_Login.Text, tb_Password.Text);

                AdminWindow mainWindow = new AdminWindow();
                this.Close();
                mainWindow.Show();
                //MainWindow mainWindow = new MainWindow();
                //this.Close();
                //mainWindow.Show();


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //User user = cUser.(tb_Email.Text , tb_Password.Text);
            //if(user!=null)
            //{
            //    this.Hide();
            //    MainWindow mainWindow = new MainWindow();
            //    this.Close();

            //}

            //cUser.Login(tb_Email.Text, tb_Password.Text);

        }
    }
}
