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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal int playCount = 0;
        internal bool resetGame = false;
        


        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            SetButtonContent(button);
            CheckScore(button);


        }




        private void SetButtonContent(Button targetButton)
        {
            if(targetButton.Content != null)
            {
                return;                                        
            }
            if (playCount % 2 == 0)
            {
                targetButton.Content = "X";
                uxTurn.Text = "O's turn";
                playCount++;
                }
            else if (playCount % 2 != 0)
            {
                targetButton.Content = "O";
                uxTurn.Text = "X's turn";
                playCount++;
                    
            }
            
        }



        internal void CheckScore(Button button)
        {
            
            var rowQuery = from b in allPlayedButtons                                                         //for each played button in the grid
                           where b.Content.ToString() == button.Content.ToString() &&                         //and it's the same player
                           b.Tag.ToString().Split(",")[0] == button.Tag.ToString().Split(",")[0]              //where the row is the same
                           select b;                                         

            bool rowWinner = rowQuery.Count() == 3;


            var colQuery = from b in allPlayedButtons
                           where b.Content.ToString() == button.Content.ToString() &&
                           b.Tag.ToString().Split(",")[1] == button.Tag.ToString().Split(",")[1]
                           select b;
                            
            
            bool colWinner = colQuery.Count() == 3;


            if (rowWinner || colWinner)
            {
                MessageBox.Show($"Winner is {button.Content}!");
                EnableOrDisableAllButtons(false);
            }                                 

        }


        private void EnableOrDisableAllButtons(bool enableOrDisable)
        {
            foreach (var b in allButtons)
            {
                b.IsEnabled = enableOrDisable;
            }
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        internal void NewGame()
        {
            EnableOrDisableAllButtons(true);
            foreach (var b in allButtons)
            {
                b.Content = null;
            }
            uxTurn.Text = "X's takes the first turn";
        }





        internal IEnumerable<Button> allButtons
        {
            get
            {
                return uxGrid.Children.OfType<Button>();
            }
        }

        internal IEnumerable<Button> allPlayedButtons
        {
            get
            {
                return allButtons.Where(b => b.Content != null);
            }
        }






    }
}
