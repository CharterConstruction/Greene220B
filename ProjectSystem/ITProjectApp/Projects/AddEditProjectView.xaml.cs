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

        private void ComboBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var test = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddEditProjectViewModel viewModel = this.DataContext as AddEditProjectViewModel;

            MessageBox.Show(viewModel.SelectedProjectStatus.StatusName);



        }
    }
}
