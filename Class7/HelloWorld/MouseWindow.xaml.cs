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
    /// Interaction logic for MouseWindow.xaml
    /// </summary>
    public partial class MouseWindow : Window
    {
        public MouseWindow()
        {
            InitializeComponent();
        }

        private void uxCanvas_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            // This event (MouseMove) has been handled.
            // Stop processing this event.
            e.Handled = true;
        }

        private void uxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            UpdateStatus(e);

            if (uxCanvas.Children.Count > 0 && isMoving)
            {
                var ellipse = (Ellipse)uxCanvas.Children[0];

                Point location = e.GetPosition(null);

                // Move the ellipse to the new location
                ellipse.Margin = new Thickness(
                    
                    ellipse.Margin.Left + location.X - downPoint.X,
                    ellipse.Margin.Top + location.Y - downPoint.Y,                    
                    
                    //location.X,
                    //location.Y,
                    0, 0);

                downPoint = location;
            }
        }

        private bool isMoving;
        private Point downPoint;

        private void uxCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point location = e.GetPosition(null);
            downPoint = location;

            var selectedElement = InputHitTest(location);            

            if (selectedElement is Ellipse)
            {
                Ellipse ellipse = selectedElement as Ellipse;
                isMoving = true;
            }


            if (uxCanvas.Children.Count == 0)
            {
                var ellipse = new Ellipse();
                ellipse.Name = "uxEllipse";

                SolidColorBrush mySolidColorBrush = new SolidColorBrush();
                mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
                ellipse.Fill = mySolidColorBrush;
                ellipse.StrokeThickness = 2;
                ellipse.Stroke = Brushes.Black;

                ellipse.Height = 100;
                ellipse.Width = 100;

                ellipse.Margin = new Thickness(location.X, location.Y, 0, 0);

                uxCanvas.Children.Add(ellipse);
            }
            else 
            {
                UpdateStatus(e);
            }

            
        }

        private void uxCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isMoving = false;
            UpdateStatus(e);
        }

        private void UpdateStatus(MouseEventArgs e)
        {
            Point location = e.GetPosition(null);
            uxStatus.Text = string.Format("({0},{1}) IsMoving={2}", location.X, location.Y, isMoving);
        }
    }
}
