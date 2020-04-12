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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.User user = new Models.User(); 
        
        public MainWindow()
        {
            InitializeComponent();

            EnableSubmitIfReadyToSubmit();
            uxName.DataContext = user;
            uxNameError.DataContext = user;
            uxPassword.DataContext = user;
            uxPasswordError.DataContext = user;

            //this.WindowState = WindowState.Maximized;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password: " + uxPassword.Text);
        }
        

        private bool IsReadyToSubmit()
        {
            if (IsTextBlockFilled(uxName) && IsTextBlockFilled(uxPassword))
                return true;
            else
                return false;
        }


        private bool IsTextBlockFilled(TextBox targetTextBox)
        {
            return !String.IsNullOrWhiteSpace(targetTextBox.Text);
        }


        private void EnableSubmitIfReadyToSubmit()
        {
            uxSubmit.IsEnabled = IsReadyToSubmit();            
        }


        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSubmitIfReadyToSubmit();
        }


        private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableSubmitIfReadyToSubmit();
        }

    }
}
