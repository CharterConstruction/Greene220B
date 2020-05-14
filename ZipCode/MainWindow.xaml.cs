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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;


namespace ZipCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string _usZipPattern = "^(\\d{5}(?:\\-\\d{4})?)$";
        private const string _canadaPostalPattern = "^([A-Za-z]\\d[A-Za-z][-]?\\d[A-Za-z]\\d)";

        	
        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled = false;
        }

        private void uxZipCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = e.Source as TextBox;
            Match matchesUSPostal = Regex.Match(textBox.Text, _usZipPattern);
            Match matchesCanadaPostal = Regex.Match(textBox.Text, _canadaPostalPattern);

            if (matchesUSPostal.Success)
            {
                uxStatusMessage.Text = "Appears to be a valid US Zip Code!";
                uxSubmit.IsEnabled = true;
            }
            else if (matchesCanadaPostal.Success)
            {
                uxStatusMessage.Text = "Appears to be a valid Canadian Postal Code!";
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxStatusMessage.Text = "Please enter a valid US Zip Code or Canadian Postal Code";
                uxSubmit.IsEnabled = false;
            }

        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
