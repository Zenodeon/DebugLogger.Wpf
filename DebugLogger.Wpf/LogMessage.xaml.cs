﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace DebugLogger.Wpf
{
    /// <summary>
    /// Interaction logic for LogMessage.xaml
    /// </summary>
    public partial class LogMessage : UserControl
    {
        public Frame frame { get; set; }

        private int count = 0;
        public int logCount
        {
            get
            {
                return count;
            }
            set
            {
                count = value;

                Count.Content = value;
            }
        }


        public LogMessage()
        {
            InitializeComponent();
        }

        public LogMessage(LogData logData)
        {
            InitializeComponent();

            TextRange timePeriodText = new TextRange(LogBox.Document.ContentStart, LogBox.Document.ContentEnd);
            timePeriodText.Text = logData.timePeriod + " ";
            timePeriodText.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Color.FromArgb(255, 100, 100, 100)));

            TextRange logText = new TextRange(LogBox.Document.ContentEnd, LogBox.Document.ContentEnd);
            logText.Text = logData.log;
            logText.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(Color.FromArgb(255, 255, 255, 255)));

            logCount = 1;
        }
    }
}
