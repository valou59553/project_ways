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

namespace projet_c
{
    /// <summary>
    /// Logique d'interaction pour PageChooseGame.xaml
    /// </summary>
    public partial class PageChooseGame : Page
    {
        public Boolean isQuizzGame;
        public bool Navigate(object content);

        public PageChooseGame()
        {
            InitializeComponent();
        }
        private void buttonQuizzGame_Click(object sender, RoutedEventArgs e)
        {
            isQuizzGame = true;
            Console.Write("Hello World, isquizzgame vaut : " + isQuizzGame.ToString());
            PageQuestion pageQuestion = new PageQuestion();
            /*this.NavigationService.Navigate(pageQuestion);*/
            this.Navigate(new PageQuestion());
        }   

        private void buttonQuizzOrientation_Click(object sender, RoutedEventArgs e)
        {
            isQuizzGame = false;
            Console.Write("Hello World, isquizzgame vaut : " + isQuizzGame.ToString());
            PageQuestion pageQuestion = new PageQuestion();
            this.NavigationService.Navigate(pageQuestion);
        }

    }
}
