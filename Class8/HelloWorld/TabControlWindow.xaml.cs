using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for TabControlWindow.xaml
    /// </summary>
    public partial class TabControlWindow : Window
    {
        public TabControlWindow()
        {
            InitializeComponent();
        }



        private void uxPrevTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = uxTab.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = uxTab.Items.Count - 1;
            uxTab.SelectedIndex = newIndex;
        }

        private void uxNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = uxTab.SelectedIndex + 1;
            if (newIndex >= uxTab.Items.Count)
                newIndex = 0;
            uxTab.SelectedIndex = newIndex;
        }

        private void uxResetTab_Click(object sender, RoutedEventArgs e)
        {
            uxTab.SelectedIndex = 0;            
        }

        private void uxSelectedTab_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected tab: " + (uxTab.SelectedItem as TabItem).Header);            
        }
    }
}
