using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Kontrolnaaya2Valiev.Model;

namespace Kontrolnaaya2Valiev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static KR2_ValievEntities DB = new KR2_ValievEntities();
        public static Employees LoggedEmployee;
    }
}
