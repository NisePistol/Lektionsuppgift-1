using System.IO.Compression;
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

namespace Lektionsuppgift_1
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

        private void KalkyleraArea(object sender, RoutedEventArgs e)
        {      
            //Kollar om bredd är en int
            if(int.TryParse(bredd.Text, out int intbredd))
            {   
                //Kollar om höjd är en int
                if(int.TryParse(höjd.Text, out int inthöjd))
                {   
                    //Skriver ut arean
                    area.Text = (int.Parse(bredd.Text) * int.Parse(höjd.Text)).ToString();
                }
                else
                {
                    MessageBox.Show("Du måste skriva en siffra!");
                }
            }
            else
            {
                MessageBox.Show("Du måste skriva en siffra!");
            }
        }
    }
}
