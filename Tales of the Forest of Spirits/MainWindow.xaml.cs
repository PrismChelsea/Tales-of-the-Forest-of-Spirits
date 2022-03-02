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
using Microsoft.Win32;
using System.IO;



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
        int strength = 0;
        int vitality = 0;


        public MainWindow()
        {
            InitializeComponent();
            readybutton.IsEnabled = false;
            Default();
        }

        private void Check()
        {
            string name = namebox.Text;
            try
            {
                if (name.Length >= 16 || name.Length <= 2)
                {
                    throw new Exception();
                }
                else
                {
                    readybutton.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                readybutton.IsEnabled = false;
            }
        }




        public void startsbutton_Click(object sender, RoutedEventArgs e)
        {
            starttbuttonmethod();
        }

        private void pixiebutton_Click(object sender, RoutedEventArgs e)
        {
            hp = 180;
            strenght = false;
            magic = true;
            fear = false;
            creature = "p";
            pixiebutton.Content = "";
            IfPixie();
            Vanish();

        }

        private void elfbutton_Click(object sender, RoutedEventArgs e)
        {
            hp = 230;
            strenght = true;
            magic = false;
            fear = false;
            creature = "e";
            elfbutton.Content = "";
            IfElf();
            Vanish();

        }

        private void bansheebutton_Click(object sender, RoutedEventArgs e)
        {
            hp = 300;
            strenght = false;
            magic = false;
            fear = true;
            creature = "b";
            bansheebutton.Content = "";
            IfBanshee();
            Vanish();

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
                creaturelabel.Content = "Your powers are: bribing, turning into an object and retreating";
            }
            else if (creature == "b")
            {
                creaturelabel.Content = "Your powers are: screaming, teleportation and staring menacingly";
            }
        }



        private void readybutton_Click(object sender, RoutedEventArgs e)
        {
            readybuttonmethod();
            namebox.IsEnabled = false;
            namebox.Margin = new Thickness(10, 150, 0, 0);
        }

        private void namebox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void fightstartbutton_Click(object sender, RoutedEventArgs e)
        {
            game sw = new game();
            sw.Show();
            Close();
           

        }

    }
}