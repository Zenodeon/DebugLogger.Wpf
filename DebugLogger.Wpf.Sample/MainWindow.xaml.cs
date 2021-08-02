﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DebugLogger.Wpf.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DLog.Instantiate();

            InitializeComponent();

            DLog.Log("Sample Project Running : Type 1");
            DLog.Log("Sample Project Running : Type 1");
            DLog.Log("Sample Project Running : Type 2");
            DLog.Log("Sample Project Running : Type 2");
            DLog.Log("Sample Project Running : Type 1");

            TestFunction();
        }

        private void TestFunction()
        {
            DLog.Log("Sample Project Running : Type 1");
            DLog.Log("Sample Project Running : Type 2");
            DLog.Log("Sample Project Running : Type 3");
            DLog.Log("Sample Project Running : Type 4");
            DLog.Log("Sample Project Running : Type 5");
            DLog.Log("Sample Project Running : Type 6");
            DLog.Log("Sample Project Running : Type 7");
            DLog.Log("Sample Project Running : Type 8");
        }

        private void OnClosingWindow(object sender, CancelEventArgs e)
        {
            DLog.Close();
        }
    }
}
