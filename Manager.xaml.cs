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
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnBrowseFile_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "Документы|*.docx;*.pdf;*.xlsx";
        }

        private void btnUploadDoc_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
