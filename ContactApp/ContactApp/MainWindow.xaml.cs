using ContactApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ContactApp
{
    public partial class MainWindow : Window
    {

        //private GridViewColumnHeader listViewSortCol

        internal List<ContactModel> allContacts = null;


        private ContactModel selectedContact;

        private void uxContactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedContact = (ContactModel)uxContactList.SelectedValue;
        }

        public MainWindow()
        {
            InitializeComponent();

            LoadContacts();
        }

        private void LoadContacts()
        {
            var contacts = App.ContactRepository.GetAll();
            allContacts = contacts.Select(t => ContactModel.ToModel(t)).ToList();

            uxContactList.ItemsSource = contacts
                .Select(t => ContactModel.ToModel(t))
                .ToList();

            // OR
            //var uiContactModelList = new List<ContactModel>();
            //foreach (var repositoryContactModel in contacts)
            //{
            //    This is the .Select(t => ... )
            //    var uiContactModel = ContactModel.ToModel(repositoryContactModel);
            //
            //    uiContactModelList.Add(uiContactModel);
            //}

            //uxContactList.ItemsSource = uiContactModelList;
        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new ContactWindow();

            if (window.ShowDialog() == true)
            {
                var uiContactModel = window.Contact;

                var repositoryContactModel = uiContactModel.ToRepositoryModel();

                App.ContactRepository.Add(repositoryContactModel);

                // OR
                //App.ContactRepository.Add(window.Contact.ToRepositoryModel());

                LoadContacts();
            }
        }





        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            App.ContactRepository.Remove(selectedContact.Id);
            selectedContact = null;
            LoadContacts();
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = (selectedContact != null);
            uxContextFileDelete.IsEnabled = uxFileDelete.IsEnabled;
        }




        private void ToggleSortByColumn(GridViewColumnHeader columnHeader)
        {
            string columnName = columnHeader.Content.ToString();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(allContacts);
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

        private void uxContactList_Click(object sender, RoutedEventArgs e)
        {
            var selectedColumn = (GridViewColumnHeader)e.OriginalSource;
            ToggleSortByColumn(selectedColumn);
        }

        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
            var window = new ContactWindow();
            window.Contact = selectedContact;

            if (window.ShowDialog() == true)
            {
                App.ContactRepository.Update(window.Contact.ToRepositoryModel());
                LoadContacts();
            }
        }

        private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileChange.IsEnabled = (selectedContact != null);
            uxContextFileChange.IsEnabled = uxFileChange.IsEnabled;
        }
    }
}