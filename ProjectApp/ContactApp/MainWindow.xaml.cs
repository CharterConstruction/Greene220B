using TimecardApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ContactApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadJobs();
        }

        private void LoadJobs()
        {
            var contacts = App.JobRepository.GetAll(); 
        }

        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            var column = (sender as GridViewColumnHeader);

            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                uxContactList.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
            {
                newDir = ListSortDirection.Descending;
            }

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            uxContactList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }


        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
        }

        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
        }

        private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileChange.IsEnabled = false; //(selectedContact != null);
            uxContextFileChange.IsEnabled = uxFileChange.IsEnabled;
        }

        private TimecardApp.Models.Job selectedJob;

        private void uxContactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedJob = (TimecardApp.Models.Job)uxContactList.SelectedValue;
        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            //App.JobRepository.Remove(selectedContact.Id);
            //selectedContact = null;
            LoadJobs();
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = false; //(selectedContact != null);
            uxContextFileDelete.IsEnabled = uxFileDelete.IsEnabled;
        }
    }
}
