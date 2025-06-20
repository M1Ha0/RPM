﻿using Lab12_13.Model;
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

namespace Lab12_13.View
{
    /// <summary>
    /// Логика взаимодействия для PensiaView.xaml
    /// </summary>
    public partial class PensiaView : Window
    {
        public ClassPensia Pensia { get; set; }
        public PensiaView(ClassPensia pensia)
        {
            InitializeComponent();
            Pensia = pensia;
            DataContext = Pensia;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
