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

    public class UsersView : ViewBase
    {
        
        

    }

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

            //ViewBase usersView = new ViewBase()

            uxName.DataContext = user;
            uxNameError.DataContext = user;
            uxPassword.DataContext = user;
            uxPasswordError.DataContext = user;

            //this.WindowState = WindowState.Maximized;


        }

        private void InitializeUsers()
        { 
            
        
        }


        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password: " + uxPassword.Text);

            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();

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
