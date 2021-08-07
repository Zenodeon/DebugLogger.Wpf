﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
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
            DLog.Log("Sample Project Running : Type 2");

            TestFunction();
        }

        private void TestFunction()
        {
            DLog.Log("Sample Project Running : Type 1");
            DLog.Log("Sample Project Running : Type 2");
        }

        private void OnClosingWindow(object sender, CancelEventArgs e)
        {
            DLog.Close();
        }

        private void Log(object sender, RoutedEventArgs e)
        {
            DLog.Log(logMessage.Text);
        }

        private void LogX(object sender, RoutedEventArgs e)
        {
            int num = int.Parse(mutlipler.Text.Split(' ')[0]);

            string message = logMessage.Text;

            Task.Run(() =>
            {
                for (int i = 1; i <= num; i++)
                    DLog.Log(message + " : " + i);
            });
        }

        private readonly Regex numericalRegex = new Regex("[^0-9]"); 

        private void mutlipler_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = numericalRegex.IsMatch(e.Text);
        }

        private void Lag(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(10000);
        }

        

    }
}
