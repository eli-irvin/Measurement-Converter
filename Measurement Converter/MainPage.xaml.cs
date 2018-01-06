﻿using System;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Measurement_Converter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ApplicationView.PreferredLaunchViewSize = new Size(800, 480);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(200, 100));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var number = double.Parse(inchesTextBox.Text);
                number *= 2.1167;
                int millimeters = (int)number;
                millimetersTextBlock.Foreground = new SolidColorBrush(Colors.White);
                millimetersTextBlock.Text = millimeters.ToString() + "mm";
            }
            catch(Exception)
            {
                millimetersTextBlock.Foreground = new SolidColorBrush(Colors.Red);
                millimetersTextBlock.Text = "There was a problem!";
            }
        }
    }
}
