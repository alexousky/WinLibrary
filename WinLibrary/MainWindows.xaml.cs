﻿using System;
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

namespace WinLibrary
{
    /// <summary>
    /// Interaction logic for MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void AddBook(object sender, RoutedEventArgs e)
        {
           var wnd = new BookWindows();
            //wnd.Show(); //Separate thread
            wnd.ShowDialog(); //Same thread
        }
    }
}