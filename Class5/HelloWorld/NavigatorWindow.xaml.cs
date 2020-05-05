using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for NavigatorWindow.xaml
    /// </summary>
    public partial class NavigatorWindow : Window
    {
        public NavigatorWindow()
        {
            InitializeComponent();
        }







        private void uxNavigator_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // Convert the Uri into a string
            var fileName = e.Uri.AbsoluteUri;

            // Pass the fileName to the helper class
            var processStartInfo = new ProcessStartInfo(fileName)
            {
                UseShellExecute = true,
                Verb = "open",
            };

            // Start a new process
            Process.Start(processStartInfo);
        }

        private void uxUrlNavigateButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(uxUrlTextBox.Text);                
            RequestNavigateEventArgs targetUrl = new RequestNavigateEventArgs(uri, "target");                           

            uxNavigator_RequestNavigate(sender, targetUrl);
        }
    }
}
