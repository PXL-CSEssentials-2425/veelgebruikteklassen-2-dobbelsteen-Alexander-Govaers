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

namespace labo_veelgebruikteklassen2_dobbelsteen
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





        private void startButton_Click(object sender, RoutedEventArgs e)
        {
         

            int winnendeGetal = 6;
            Random rnd = new Random();
            int dobbelSteenGetal = 0;

            int pogingen = 0; 

            do 
             {
                dobbelSteenGetal = rnd.Next(1, 7);
                pogingen++;
                resultTextbox.Text += ($"Worp {pogingen} geeft een {dobbelSteenGetal} \r\n");
             }
                 while (dobbelSteenGetal != 6);
          
        }

        private void retryButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            resultTextbox.Clear();
            startButton.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

