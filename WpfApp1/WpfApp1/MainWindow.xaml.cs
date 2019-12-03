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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student newStudent = new Student();

            newStudent.FirstName = TXTFirstName.Text;
            newStudent.LastName = TXTLastName.Text;
            newStudent.StudentID = Convert.ToInt32(TXTStudentID.Text);
            newStudent.FavoriteColor = TXTFavoriteColor.Text;

            LBListBox.Items.Add(newStudent);

            TXTFirstName.Text = string.Empty;
            TXTLastName.Text = string.Empty;
            TXTStudentID.Text = string.Empty;
            TXTFavoriteColor.Text = string.Empty;

            //do the file part
            string text = System.IO.File.ReadAllText(@"C:\Users\clint\Downloads\studentdataRandom100Rows");
            foreach (var name in text)
            {

            }
            file.ReadAllLines(studentdataRandom100Rows);

            




        }
    }
}
