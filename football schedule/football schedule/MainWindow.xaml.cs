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
//using System.Windows.Shapes;

namespace football_schedule
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_128040_practiceEntities FBDB = new DB_128040_practiceEntities();
        public MainWindow()
        {
            InitializeComponent();
            cmbYear.Items.Clear();
            foreach (var game in FBDB.FootballSchedules)
            {
                if (cmbYear.Items.Contains(game.Season) == false)
                {
                    cmbYear.Items.Add(game.Season);
                }
              
            }

           

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           /*  foreach (var year in FBDB.FootballSchedules.Where(FBDB => FBDB.Season == Convert.ToInt32(cmbYear.SelectedValue)))
            {
                lsbHome.Items.Add(
            }
            */
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }

        private void CmbYear_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lsbHome.Items.Clear();
            lsbAway.Items.Clear();
            int selectSeason = (int)cmbYear.SelectedValue;
       
            foreach (var year in FBDB.FootballSchedules.Where(FBDB => FBDB.Season == selectSeason))
            {
                if (year.IsHomeGame)
                {
                    lsbHome.Items.Add(year.Opponent);
                }
                else
                {
                    lsbAway.Items.Add(year.Opponent);
                }

            }
        }
    }
}
