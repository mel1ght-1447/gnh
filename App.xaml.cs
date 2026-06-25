using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace pr8
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string ConnectionString = "Host=pgadmin.lab;Port=5432;Database=isp-24-1-bykov-ms;Username=isp-24-bykov-ms;Password=Password=58227";
    }
}
