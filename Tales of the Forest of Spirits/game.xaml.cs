using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Tales_of_the_Forest_of_Spirits
{
    /// <summary>
    /// Interaction logic for game.xaml
    /// </summary>
    public partial class game : Window
    {
        DispatcherTimer timer;
        int k = 0;
        bool alternate = false;
        int brumm = 0;
        public game()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(40);
            timer.Tick += timer_Tick;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (brumm == 1)
            {
                Thickness t = gamepixie.Margin;
                if (alternate == false)
                    t.Top -= 10;
                else
                    t.Top += 10;
                gamepixie.Margin = t;
                if (k > 10)
                {
                    alternate = !alternate;
                    timer.Start();
                    k = 0;
                    timer.Stop();
                }
                timer.Stop();
            }

            else if (brumm == 2)
            {
                Thickness t = gamepixie.Margin;
                if (alternate == false)
                    t.Top += 10;
                else
                    t.Top -= 10;
                gamepixie.Margin = t;
                if (k > 10)
                {
                    alternate = !alternate;
                    timer.Start();
                    k = 0;
                    timer.Stop();
                }
                timer.Stop();
            }

            else if (brumm == 3)
            {
                Thickness t = gamepixie.Margin;
                if (alternate == false)
                    t.Left -= 10;
                else
                    t.Left += 10;
                gamepixie.Margin = t;
                if (k > 10)
                {
                    alternate = !alternate;
                    timer.Start();
                    k = 0;
                    timer.Stop();
                }
                timer.Stop();
            }

            else if (brumm == 4)
            {
                Thickness t = gamepixie.Margin;
                if (alternate == false)
                    t.Left += 10;
                else
                    t.Left -= 10;
                gamepixie.Margin = t;
                if (k > 10)
                {
                    alternate = !alternate;
                    timer.Start();
                    k = 0;
                    timer.Stop();
                }
                timer.Stop();

            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                timer.Start();
                brumm = 3;
            }

            else if (e.Key == Key.Right)
            {
                timer.Start();
                brumm = 4;
            }
            else if (e.Key == Key.Up)
            {
                timer.Start();
                brumm = 1;
            }
            else if (e.Key == Key.Down)
            {
                timer.Start();
                brumm = 2;
            }
        }
    }
}
