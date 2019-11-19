using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace GUI_I_think
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var connectionString = "Data Source=tcp:s13.winhost.com;Initial Catalog=DB_128040_practice;User ID=DB_128040_practice_user;Password=test123;Integrated Security=False;";
            using (var connection = new SqlConnection()) 
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    //                                  0           1       2   3       4           5
                    command.CommandText = "SELECT   Movie_Id, duration, gross, genres, movie_title, movie_imdb_link " +
                                            "FROM   Movie";
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Movie myMovie = new Movie();
                            myMovie.Id = Convert.ToInt32(reader[0]);
                            myMovie.duration = Convert.ToInt32(reader[1]);
                            myMovie.gross = Convert.ToInt32(reader[2]);
                            myMovie.genres = Convert.ToString(reader[3]);
                            myMovie.movie_title = Convert.ToString(reader[4]);
                            myMovie.movie_imbd_link = Convert.ToString(reader[5]);
                            var col1 = reader[0]; //gets first column returned
                                                  // Perform stuff for each ROW // OR INSTANCE
                            LMovies.Items.Add(myMovie);
                            web.Navigate(myMovie.movie_imbd_link);
                        }
                    }
                }
            
            }
        }

        private void LMovies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var movie = (Movie)LMovies.SelectedItem;
        }
    }
}
