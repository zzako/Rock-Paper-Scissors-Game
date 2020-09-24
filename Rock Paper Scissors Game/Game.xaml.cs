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
using System.Windows.Shapes;

namespace Rock_Paper_Scissors_Game
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
        }



      

    

        private void OnImageButtonClick3(object sender, RoutedEventArgs e)
        {
            List<string> computerHand1 = new List<string>(3);
            computerHand1.Add("Rock");
            computerHand1.Add("Paper");
            computerHand1.Add("Scissors");

            Random random = new Random();
            int index = random.Next(computerHand1.Count);

            if (index == 0)
            {
                MessageBox.Show("You Drew, Computer chose Rock");
            }
            else if (index == 1)
            {
                MessageBox.Show("You Lost, Computer chose  " + index);
            }
            else if (index == 2)
            {
                MessageBox.Show("You Won, Computer chose  " + index);
            }
        }

        private void OnImageButtonClick2(object sender, RoutedEventArgs e)
        {
            List<string> computerHand1 = new List<string>(3);
            computerHand1.Add("Rock");
            computerHand1.Add("Paper");
            computerHand1.Add("Scissors");

            Random random = new Random();
            int index = random.Next(computerHand1.Count);

            if (index == 0)
            {
                MessageBox.Show("You Won, Computer chose Rock ");
            }
            else if (index == 1)
            {
                MessageBox.Show("You Drew, Computer chose Paper ");
            }
            else if (index == 2)
            {
                MessageBox.Show("You Lost, Computer chose Scissors");
            }
        }

        private void OnImageButtonClick1(object sender, RoutedEventArgs e)
        {
            List<string> computerHand1 = new List<string>(3);
            computerHand1.Add("Rock");
            computerHand1.Add("Paper");
            computerHand1.Add("Scissors");

            Random random = new Random();
            int index = random.Next(computerHand1.Count);

            if (index == 0)
            {
                MessageBox.Show("You Drew, Computer chose Rock ");
            }
            else if (index == 1)
            {
                MessageBox.Show("You Lost, Computer chose Paper ");
            }
            else if (index == 2)
            {
                MessageBox.Show("You Won, Computer chose Scissors ");
            }
        }
    }
}
