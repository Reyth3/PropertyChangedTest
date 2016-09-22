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

namespace Attributes
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
        Hero hero;
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            hero = new Hero();
            DataContext = hero;
        }

        private void StrD(object sender, RoutedEventArgs e)
        {
            hero.Strength--;
        }

        private void StrI(object sender, RoutedEventArgs e)
        {
            hero.Strength++;
        }

        private void AgiD(object sender, RoutedEventArgs e)
        {
            hero.Agility--;
        }

        private void AgiI(object sender, RoutedEventArgs e)
        {
            hero.Agility++;
        }

        private void VitD(object sender, RoutedEventArgs e)
        {
            hero.Vitality--;
        }

        private void VitI(object sender, RoutedEventArgs e)
        {
            hero.Vitality++;
        }
    }
}
