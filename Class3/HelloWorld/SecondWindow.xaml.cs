using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HelloWorld.Models;

namespace HelloWorld
{

    

    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        private List<User> users = null;

        public SecondWindow()
        {
            InitializeComponent();
            InitializeUsers();
            
        }

        private void uxList_Click(object sender, RoutedEventArgs e)
        {
            var selectedColumn = (GridViewColumnHeader)e.OriginalSource;
            ToggleSortByColumn(selectedColumn);

        }


        private void InitializeUsers()
        {
            users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "DavePwd" });
            users.Add(new Models.User { Name = "Steve", Password = "StevePwd" });
            users.Add(new Models.User { Name = "Lisa", Password = "LisaPwd" });
            users.Add(new Models.User { Name = "Abe", Password = "Xerox" });
            users.Add(new Models.User { Name = "Yinzer", Password = "Jagoff" });

            uxList.ItemsSource = users;

        }



        private void ToggleSortByColumn(GridViewColumnHeader columnHeader)
        {
            string columnName = columnHeader.Content.ToString();            
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(users);         
            ListSortDirection sortDirection = ListSortDirection.Ascending;
            
            if (view.SortDescriptions.Count > 0)
            {
                string currentColumn = view.SortDescriptions[0].PropertyName.ToString();
                ListSortDirection currentSortDirection = view.SortDescriptions[0].Direction;
                
                if (currentColumn == columnName && currentSortDirection == ListSortDirection.Ascending)
                    sortDirection = ListSortDirection.Descending;
            }
                       
            //Clear and set the target column's sorting.
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new SortDescription(columnHeader.Content.ToString(), sortDirection));
        }





    }
}
