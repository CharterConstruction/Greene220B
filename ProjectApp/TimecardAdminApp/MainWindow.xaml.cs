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


//using TimecardAdminApp.Employees;
//using TimecardAdminApp.Jobs;



namespace TimecardAdminApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private AdminViewModel viewModel = null;
        //private Job selectedJob = null;
        
        public MainWindow()
        {
            InitializeComponent();
            InitialLoad();
        }

        public void InitialLoad()
        {

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
                //uxJobList.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
            {
                newDir = ListSortDirection.Descending;
            }

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            //uxJobList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }
                

        private void uxJobList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //selectedJob = (TimecardAdminApp.Models.Job)uxJobList.SelectedValue;
        }

        private void uxReloadButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
