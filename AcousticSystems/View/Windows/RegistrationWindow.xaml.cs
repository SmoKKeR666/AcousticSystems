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
using AcousticSystems.Model;

namespace AcousticSystems.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FullNameTxb.Text))
            {
                MessageBox.Show("Введите ФИО");
            }
            if (string.IsNullOrWhiteSpace(LoginTxb.Text))
            {
                MessageBox.Show("Введите логин");
            }
            if (string.IsNullOrWhiteSpace(PasswordPb.Password))
            {
                MessageBox.Show("Введите пароль");
            }
            Clients clients = new Clients()
            {
                FullName = FullNameTxb.Text,
                Login = LoginTxb.Text,
                Password = PasswordPb.Password
            };

            App.context.Clients.Add(clients);
            App.context.SaveChanges();
            MessageBox.Show("Поздравляем с регистрацией,\n теперь Вы можете войти!");

            FullNameTxb.Text = "";
            LoginTxb.Text = "";
            PasswordPb.Password = "";

            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
            this.Close();
        }
    }
}
