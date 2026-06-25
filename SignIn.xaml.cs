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

namespace pr8
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Password;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("ошибка");
                return;
            }
            using (isp241bykovmsContext context = new isp241bykovmsContext())
            {
                User user = context.User.FirstOrDefault(u => u.Login == login && u.Password == password);
                if (user == null)
                {
                    MessageBox.Show("ошибка логина или пароля");
                    return;
                }
                OpenWindowByRole(user.Role);
            }
        }
        private void OpenWindowByRole(string role)
        {
            switch (role)
            {
                case "Administrator":
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                    break;
                case "Programmer":
                    Programmer programmer = new Programmer();
                    programmer.Show();
                    break;
                case "Manager":
                    Manager manager = new Manager();
                    manager.Show();
                    break;
                case "Accountant":
                    Accountant accountant = new Accountant();
                    accountant.Show();
                    break;
            }
        }
    }
}
