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
    public partial class MainWindow : Window
    {
        public void Default()
        {
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
            fightstartbutton.Visibility = Visibility.Collapsed;
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
        public void starttbuttonmethod()
        {
            startsbutton.Visibility = Visibility.Collapsed;
            welcomelabel.Visibility = Visibility.Collapsed;
            chooselabel.Visibility = Visibility.Visible;
            pixiebutton.Visibility = Visibility.Visible;
            elfbutton.Visibility = Visibility.Visible;
            bansheebutton.Visibility = Visibility.Visible;
        }

        public void IfBanshee()
        {
            pixiebutton.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
        }

        public void IfPixie()
        {
            elfbutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
        }

        public void IfElf()
        {
            pixiebutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
        }

        public void readybuttonmethod()
        {
            chooselabel.Visibility = Visibility.Collapsed;
            pixiebutton.Visibility = Visibility.Collapsed;
            elfbutton.Visibility = Visibility.Collapsed;
            bansheebutton.Visibility = Visibility.Collapsed;
            creaturelabel.Visibility = Visibility.Collapsed;
            hplabel.Visibility = Visibility.Visible;
            namelabel.Visibility = Visibility.Collapsed;
            readybutton.Visibility = Visibility.Collapsed;
            fightstartbutton.Visibility = Visibility.Visible;
        }
    }
}
