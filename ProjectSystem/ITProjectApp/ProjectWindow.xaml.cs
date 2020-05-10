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
using ITProjectsViewModel;
using ITProjectsViewModel.Models;


namespace ITProjectApp
{
    /// <summary>
    /// Interaction logic for ProjectWindow.xaml
    /// </summary>
    public partial class ProjectWindow : Window
    {
        public ProjectWindow()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        public ProjectModel Project { get; set; }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            // This is the return value of ShowDialog( ) below
            DialogResult = true;
            Close();
        }               


        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            // This is the return value of ShowDialog( ) below
            DialogResult = false;
            Close();
        }
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Project != null)
            {
                uxSubmit.Content = "Update";
            }
            else
            {
                Project = new ProjectModel();                
            }

            uxGrid.DataContext = Project;
        }

    }
}
