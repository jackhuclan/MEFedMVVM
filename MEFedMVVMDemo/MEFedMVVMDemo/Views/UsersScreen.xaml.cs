﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MEFedMVVMDemo.Views
{
    /// <summary>
    /// Interaction logic for UsersScreen.xaml
    /// </summary>
    public partial class UsersScreen : UserControl
    {
        public static Dictionary<string, string> Test;

        static UsersScreen()
        {
            Test = new Dictionary<string, string>()
            {
                { "Test", "Hello" }
            };
        }

        public UsersScreen()
        {
            InitializeComponent();
        }
    }
}
