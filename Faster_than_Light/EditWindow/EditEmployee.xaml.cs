﻿using Faster_than_Light.classes;
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

namespace Faster_than_Light.EditWindow
{
    /// <summary>
    /// Логика взаимодействия для EditEmployee.xaml
    /// </summary>
    public partial class EditEmployee : Window
    {
        public EditEmployee(Employee employee)
        {

            Employee temp = new Employee();
            InitializeComponent();
            

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {


            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {


            Close();
        }
    }
}
