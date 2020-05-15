using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
    /// <summary>
    /// Interaction logic for NumberControl.xaml
    /// </summary>
    public partial class NumberControl : UserControl
    {
        public NumberControl()
        {
            InitializeComponent();
        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        // DISALLOW COPYING AND PASTING OF BAD INPUT
        // Use the DataObject.Pasting Handler 
        private void TextBoxPasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        //Source: https://stackoverflow.com/questions/1268552/how-do-i-get-a-textbox-to-only-accept-numeric-input-in-wpf
        private void uxNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if e.Handled = true 
            // IT WILL STOP!
            // e.Handled = true = STOP PROCESSING
            Regex regex = new Regex("[^0-9]");
            bool cancelCommand = regex.IsMatch(e.Text);

            if (cancelCommand)
            {
                uxPromptForNumberText.Text = "ENTER A NUMBER YOU DORK!";
                e.Handled = cancelCommand;
            }     
            else 
                uxPromptForNumberText.Text = "Please enter a number";

        }
    }
}
