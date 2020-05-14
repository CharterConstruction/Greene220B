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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxZipCode_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = e.Source as TextBox;
            Match matchesUSPostal = Regex.Match(textBox.Text, _usZipPattern);
            Match matchesCanadaPostal = Regex.Match(textBox.Text, _usZipPattern);

            if(matchesUSPostal.Success|| matchesCanadaPostal.Success)
            {
                uxStatusMessage.Text = "Match!";
            }
            else
            {
                uxStatusMessage.Text = "FAIL";
            }

        }
    }
}
