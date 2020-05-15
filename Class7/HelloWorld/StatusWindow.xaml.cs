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

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for StatusWindow.xaml
    /// </summary>
    public partial class StatusWindow : Window
    {
        public StatusWindow()
        {
            InitializeComponent();
            uxProgressBar.Value = 0;
            uxProgressPercentage.Text = "0%";

            uxProgressBar.Maximum = 100;
        }


        private void uxTextEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = uxTextEditor.GetLineIndexFromCharacterIndex(uxTextEditor.CaretIndex);
            int col = uxTextEditor.CaretIndex - uxTextEditor.GetCharacterIndexFromLineIndex(row);

            //not using String.Format - this is bad!
            uxStatus.Text = "Line " + (row + 1) + ", Char " + (col + 1);

            uxProgressBar.Value = uxTextEditor.Text.Length; // Set the progressbar
            
            
            uxTextEditor.MaxLength = 0;
            var percentage = Math.Round(uxProgressBar.Value / uxTextEditor.MaxLength * 100,2);

            uxProgressPercentage.Text = percentage.ToString() + "%";
        }
    }
}
