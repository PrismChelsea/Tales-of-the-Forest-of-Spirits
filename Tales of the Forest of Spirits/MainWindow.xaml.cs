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

namespace Tales_of_the_Forest_of_Spirits
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int hp = 0;
        public bool strenght = false;
        public bool magic = false;
        public bool fear = false;
        public string creature;

        public MainWindow()
        {
            InitializeComponent();
            startsbutton.Visibility = Visibility.Visible;
            welcomelabel.Visibility = Visibility.Visible;
            chooselabel.Visibility = Visibility.Collapsed;
            pixiebutton.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Collapsed;
            hplabel.Visibility = Visibility.Collapsed;


        }

        public void startsbutton_Click(object sender, RoutedEventArgs e)
        {
            startsbutton.Visibility = Visibility.Collapsed;
            welcomelabel.Visibility = Visibility.Collapsed;
            chooselabel.Visibility = Visibility.Visible;
            pixiebutton.Visibility = Visibility.Visible;
            elfbutton.Visibility = Visibility.Visible;
            bansheebutton.Visibility = Visibility.Visible;

        }

        private void pixiebutton_Click(object sender, RoutedEventArgs e)
        {
            hp = 180;
            strenght = false;
            magic = true;
            fear = false;
            creature = "p";
            chooselabel.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Visible;
            hplabel.Visibility = Visibility.Visible;
        }

        private void elfbutton_Click(object sender, RoutedEventArgs e)
        {
            hp = 230;
            strenght = true;
            magic = false;
            fear = false;
            creature = "e";
            chooselabel.Visibility = Visibility.Collapsed;
            pixiebutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Visible;
            hplabel.Visibility = Visibility.Visible;
        }

        private void bansheebutton_Click(object sender, RoutedEventArgs e)
        {
            hp = 300;
            strenght = false;
            magic = false;
            fear = true;
            creature = "b";
            chooselabel.Visibility = Visibility.Collapsed;
            pixiebutton.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Visible;
            hplabel.Visibility = Visibility.Visible;
        }


        private void hplabel_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            hplabel.Content = "HP: " + hp;
            
        }

        private void creaturelabel_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (creature == "p")
            {
                creaturelabel.Content = "Your powers are: tricking; flying and vanishing";
            }
            else if (creature == "e")
            {
                creaturelabel.Content = "Your powers are: bribing, turning into an objetóct and retreating";
            }
            else if (creature == "b")
            {
                creaturelabel.Content = "Your powers are: screaming, teleportation and staring menacingly";
            }
        }
    }
}
