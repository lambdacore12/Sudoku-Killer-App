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
using ClassesLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace Sudoku_Killer_Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Topmost = true;
        }

        private void Target_Number_Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Target_Number_Input.Text == null || Target_Number_Input.Text == string.Empty || Target_Number_Input.Text == "" )
            {

            }
            else
            {
                if (Cells_Input.Text == "2")
                {
                    //get target number from user
                    int targetNumber = int.Parse(Target_Number_Input.Text);

                    //calculate combinations
                    List<Combination> mainList = MainLogic.CalculateTwo(targetNumber);

                    //update combinations in UI
                    Combinations_Number.Text = "(" + MainLogic.TotalCombinations.ToString() + ")";

                    //create readable list of combinations
                    var read = ReadableCombination.MakeReadable(mainList);

                    Combinations_List.ItemsSource = read;
                }
                else if(Cells_Input.Text == "3")
                {
                    //get target number from user
                    int targetNumber = int.Parse(Target_Number_Input.Text);

                    //calculate combinations
                    List<Combination> mainList = MainLogic.CalculateThree(targetNumber);

                    //update combinations in UI
                    Combinations_Number.Text = "(" + MainLogic.TotalCombinations.ToString() + ")";

                    //create readable list of combinations
                    var read = ReadableCombination.MakeReadable(mainList);

                    Combinations_List.ItemsSource = read;
                }
                
            }
            
            
        }

        private void ExitApp_BTN_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
