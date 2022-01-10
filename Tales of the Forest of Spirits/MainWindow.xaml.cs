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
        int szetoszthato = 10;


        public MainWindow()
        {
            InitializeComponent();
            startsbutton.Visibility = Visibility.Visible;
            welcomelabel.Visibility = Visibility.Visible;
            namelabel.Visibility = Visibility.Collapsed;
            namebox.Visibility = Visibility.Collapsed;
            chooselabel.Visibility = Visibility.Collapsed;
            pixiebutton.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Collapsed;
            hplabel.Visibility = Visibility.Collapsed;
            readybutton.Visibility = Visibility.Collapsed;
            readybutton.IsEnabled = false;
            fightstartbutton.Visibility = Visibility.Collapsed;
            vitalitylabel.Visibility = Visibility.Collapsed;
            vtButton.Visibility = Visibility.Collapsed;
            vtButton2.Visibility = Visibility.Collapsed;
            vt.Visibility = Visibility.Collapsed;
            dowritebutton.Visibility = Visibility.Collapsed;
            szetoszthatoLabel.Visibility = Visibility.Collapsed;

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

        private void Vanish()
        {
            chooselabel.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Visible;
            hplabel.Visibility = Visibility.Visible;
            namelabel.Visibility = Visibility.Visible;
            namebox.Visibility = Visibility.Visible;
            readybutton.Visibility = Visibility.Visible;
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
            pixiebutton.Content = "";
            elfbutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
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
            pixiebutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
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
            pixiebutton.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
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
            
            chooselabel.Visibility = Visibility.Collapsed;
            pixiebutton.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Collapsed;
            hplabel.Visibility = Visibility.Visible;
            namelabel.Visibility = Visibility.Collapsed;
            readybutton.Visibility = Visibility.Collapsed;
            namebox.IsEnabled = false;
            namebox.Margin = new Thickness(10, 150, 0, 0);
            fightstartbutton.Visibility = Visibility.Visible;
            vitalitylabel.Visibility = Visibility.Visible;
            vtButton.Visibility = Visibility.Visible;
            vtButton2.Visibility = Visibility.Visible;
            vt.Visibility = Visibility.Visible;
            dowritebutton.Visibility = Visibility.Visible;
            szetoszthatoLabel.Visibility = Visibility.Visible;
        }

        private void namebox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check();
        }

        private void fightstartbutton_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void vtbutton2_Click(object sender, RoutedEventArgs e)
        {
            strength--;
            vt.Text = strength.ToString();
            szetoszthato++;
            szetoszthatoLabel.Content = szetoszthato;
            if (szetoszthato == 10)
            {
                vtButton2.IsEnabled = false;
            }
            vtButton.IsEnabled = true;
        }

        private void vtButton_Click(object sender, RoutedEventArgs e)
        {
            strength++;
            vt.Text = strength.ToString();
            szetoszthato--;
            szetoszthatoLabel.Content = szetoszthato;
            if (szetoszthato == 0)
            {
                vtButton.IsEnabled = false;
            }
            vtButton2.IsEnabled = true;
        }

        private void dowritebutton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog filedowrite = new OpenFileDialog();
            filedowrite.Filter = "Szöveges állományok (*.txt)|*.txt|Minden állomány (*.*)|*.*";
            if (filedowrite.ShowDialog() == true)
            {
                StreamReader sr = new StreamReader(filedowrite.FileName);
                sr.Close();
            }
        }
    }
}