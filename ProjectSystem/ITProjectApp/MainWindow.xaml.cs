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

/*
using ITPM.ViewModels;
using ITPM.ViewModels.Projects;
*/


namespace ITPM.App
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
        internal static ProjectsViewModel viewModel = null;

        internal static ProjectWindow projectWindow = null;

        internal Project selectedProject = null;


        public MainWindow()
        {
            InitializeComponent();

            SetDataSource();
        }

        internal void SetDataSource()
        {
            viewModel = new ProjectsViewModel();

            uxProjectList.ItemsSource = viewModel.Projects;
        }



        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            projectWindow = new ProjectWindow();

            if (projectWindow.ShowDialog() == true)
            {
                AddNewProject(projectWindow.Project);
            }
        }


        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
            projectWindow = new ProjectWindow();
            projectWindow.Project = selectedProject;

            if (projectWindow.ShowDialog() == true)
            {

                bool updated = viewModel.ProjectRepository.Update(projectWindow.Project.ToRepositoryModel());

                if (updated)
                    LoadProjects();
                else
                    MessageBox.Show("Update was unsuccessful");

            }

        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {

        }



        private void uxProjectList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var selected = ((ListView)e.Source).SelectedItem as ProjectModel;

            selectedProject = selected;

        }

        private void uxProjectList_Click(object sender, RoutedEventArgs e)
        {

        }


        /// <summary>
        /// If a project is selected, enable the "Change" option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileChange.IsEnabled = (selectedProject != null);
            uxContextFileChange.IsEnabled = uxFileChange.IsEnabled;
        }


        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private void AddNewProject(ProjectModel uiProjectModel)
        {
            uiProjectModel = projectWindow.Project;
            viewModel.ProjectRepository.Add(uiProjectModel.ToRepositoryModel());

            LoadProjects();
        }



        private void LoadProjects()
        {
            viewModel.LoadProjects();
        }
        */
    }
}



/*

       internal static ProjectsViewModel viewModel = null;

       internal static ProjectWindow projectWindow = null;

       internal Project selectedProject = null;


       public MainWindow()
       {
           InitializeComponent();            

           SetDataSource();            
       }

       internal void SetDataSource()
       {
           viewModel = new ProjectsViewModel();

           uxProjectList.ItemsSource = viewModel.Projects;
       }



       private void uxFileNew_Click(object sender, RoutedEventArgs e)
       {
           projectWindow = new ProjectWindow();            

           if (projectWindow.ShowDialog() == true)
           {
               AddNewProject(projectWindow.Project);
           }
       }


       private void uxFileChange_Click(object sender, RoutedEventArgs e)
       {
           projectWindow = new ProjectWindow();
           projectWindow.Project = selectedProject;      

           if (projectWindow.ShowDialog() == true)
           {

               bool updated = viewModel.ProjectRepository.Update(projectWindow.Project.ToRepositoryModel());

               if (updated)
                   LoadProjects();
               else
                   MessageBox.Show("Update was unsuccessful");              

           }

       }

       private void uxFileDelete_Click(object sender, RoutedEventArgs e)
       {

       }



       private void uxProjectList_SelectionChanged(object sender, SelectionChangedEventArgs e)
       {

           var selected = ((ListView)e.Source).SelectedItem as ProjectModel;

           selectedProject = selected;

       }

       private void uxProjectList_Click(object sender, RoutedEventArgs e)
       {

       }


       /// <summary>
       /// If a project is selected, enable the "Change" option
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
       {
           uxFileChange.IsEnabled = (selectedProject != null);
           uxContextFileChange.IsEnabled = uxFileChange.IsEnabled;
       }


       private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
       {

       }


       private void AddNewProject(ProjectModel uiProjectModel)
       {
           uiProjectModel = projectWindow.Project;
           viewModel.ProjectRepository.Add(uiProjectModel.ToRepositoryModel());

           LoadProjects();
       }



       private void LoadProjects() {
           viewModel.LoadProjects();
       } 

       */
