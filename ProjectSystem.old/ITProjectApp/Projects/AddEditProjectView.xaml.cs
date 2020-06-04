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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITPM.App.Projects
{
    /// <summary>
    /// Interaction logic for AddEditProject.xaml
    /// </summary>
    public partial class AddEditProjectView : UserControl
    {
        public AddEditProjectView()
        {
            InitializeComponent();
        }



        private void uxRefreshStatus_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = this.DataContext as AddEditProjectViewModel;

            uxProjectStatusComboBox.SelectedItem = viewModel.ProjectStatus;
        }
    }
}
