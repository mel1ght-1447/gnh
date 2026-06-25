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
    /// Логика взаимодействия для AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void Projects_Click(object sender, RoutedEventArgs e)
        {
            Projects projects = new Projects();
            projects.Show();
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {    
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
