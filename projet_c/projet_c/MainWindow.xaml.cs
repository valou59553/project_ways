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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonValidationSurname_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player();
            List<Player> listPlayer = new List<Player>();

            /*player.Login = textSurname.Text;
            listPlayer.Add(player);*/
            PageChooseGame testpage = new PageChooseGame();
            this.Content = testpage;

        }

        private void buttonAdmin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textbox_surname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
