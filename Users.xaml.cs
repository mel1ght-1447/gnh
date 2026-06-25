using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Window
    {
        public Users()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void cbUsersEdit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void btnCreateUser_Click(object sender, RoutedEventArgs e)
        {
            string lastname = tbLastname.Text.Trim();
            string firstname = tbFirstname.Text.Trim();
            string middlename = tbMiddlename.Text.Trim();
            string login = tbLogin.Text.Trim();
            string password = tbPassword.Text.Trim();
            string phoneNumber = tbPhoneNumber.Text.Trim();
            string email = tbEmail.Text.Trim();
            string role = (cbRole.SelectedItem as ComboBoxItem)?.Content?.ToString();
            if (string.IsNullOrEmpty(middlename))
            {
                middlename = null;
            }

            if (lastname.Length < 5 || lastname.Length > 20 || firstname.Length < 5 || firstname.Length > 20 || middlename.Length < 5 || middlename.Length > 20)
            {
                MessageBox.Show("Длина полей ФИО от 5 до 20!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (login.Length < 5)
            {
                MessageBox.Show("Длина логина должна быть больше 5 символов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (password.Length < 5)
            {
                MessageBox.Show("Длина пароля должна быть больше 5 символов!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            using (isp241bykovmsContext context = new isp241bykovmsContext())
            {
                if (context.User.Any(u => u.Login == login))
                {
                    MessageBox.Show("Учетная запись с таким логином уже существует!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                string hashedPassword = HashPassword(password);
                User newUser = new User
                {
                    Lastname = lastname,
                    Firstname = firstname,
                    Midllename = middlename,
                    Login = login,
                    Password = hashedPassword,
                    PhoneNumber = phoneNumber,
                    Email = email,
                    Role = role
                };
                context.User.Add(newUser);
                try
                {
                    context.SaveChanges();
                    MessageBox.Show("Учетная запись создана!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении: {ex.InnerException?.Message ?? ex.Message}");
                }
            }
        }
        public static string HashPassword(string password)
        {
            if (password != null)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    return Convert.ToBase64String(bytes);
                }
            }
            return null;
        }
        private void btnUpdateUser_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
