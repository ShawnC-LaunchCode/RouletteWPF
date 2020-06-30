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
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RouletteWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
            

            //create objects-models
            Player currentPlayer = new Player("Scott");
            var mainTable = new RouletteTable();
            //


            //set initial values on view -- break out to function INIT
            text1.Text = currentPlayer.Name + " has entered the casino with $" + currentPlayer.Bank + ".";
            playerName.Text = currentPlayer.Name;
            playerBank.Text = currentPlayer.Bank.ToString();
            
            mainTable.CurrentBet = 50;
            tableBet.Text = mainTable.CurrentBet.ToString();
            //
            



        }

        private void BetClick(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Content.ToString();

            Console.WriteLine(name);
            LogToText1(name);
           

        }

        private void LogToText1(string msg)
        {
            text1.AppendText("\n" + msg);
            text1.ScrollToEnd();
        }

        //private void betLess(object sender, RoutedEventArgs e)
        //{
            
        //}
    }
}
