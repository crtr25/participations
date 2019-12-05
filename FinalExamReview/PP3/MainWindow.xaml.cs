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

namespace PP3
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

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            double count = 0;

            if (txt1.Text.Contains(txt2.Text))
            {
                string word = txt1.Text.ToLower();
                char let = Convert.ToChar(txt2.Text);
                for (int i = 0; i < word.Length; i++)
                {
                    if (let == word[i])
                    {
                        count++;
                    }
                }
                string letter = Convert.ToString(let);
                txt2.IsEnabled = true;
                if (count > 1 )
                {
                    string sentence = "There were " + count + " " + let.ToString().ToUpper() + "'s" + " in " + word;
                    lb1.Content = sentence;
                }
                else 
                {
                    string sentence = "There is " + count + " " + let.ToString().ToUpper() + " in " + word;
                    lb1.Content = sentence;
                }
            }
            else
            {
                MessageBox.Show("This letter is not in that word.");
            }
           

        }
    }
}

