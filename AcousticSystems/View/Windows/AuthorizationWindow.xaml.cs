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

namespace AcousticSystems.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTxb.Text) && string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else if (string.IsNullOrEmpty(LoginTxb.Text))
            {
                MessageBox.Show("Введите логин");
            }
            else if (string.IsNullOrEmpty(PasswordPb.Password))
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                App.currentClient = App.context.Clients.FirstOrDefault(user => user.Login == LoginTxb.Text && user.Password == PasswordPb.Password);

                if (App.currentClient != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
    }
}
