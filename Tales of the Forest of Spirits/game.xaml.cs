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
        string movementChecker = "";
        Rect playerHitBox;
        Rect upHitBox;
        Rect downHitBox;
        Rect leftHitBox;
        Rect rightHitBox;
        

        public game()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(40);
            timer.Tick += timer_Tick;



            
        }
        void timer_Tick(object sender, EventArgs e)
        {
            if (movementChecker == "up")
            {
                Thickness t = player.Margin;
                if (alternate == false)
                    t.Top -= 10;
                else
                    t.Top += 10;
                player.Margin = t;
                if (k > 10)
                {
                    alternate = !alternate;
                    timer.Start();
                    k = 0;
                    timer.Stop();
                }
                timer.Stop();
            }

            else if (movementChecker  == "down")
            {
                Thickness t = player.Margin;
                if (alternate == false)
                    t.Top += 10;
                else
                    t.Top -= 10;
                player.Margin = t;
                if (k > 10)
                {
                    alternate = !alternate;
                    timer.Start();
                    k = 0;
                    timer.Stop();
                }
                timer.Stop();
            }

            else if (movementChecker == "left")
            {
                Thickness t = player.Margin;
                if (alternate == false)
                    t.Left -= 10;
                else
                    t.Left += 10;
                player.Margin = t;
                if (k > 10)
                {
                    alternate = !alternate;
                    timer.Start();
                    k = 0;
                    timer.Stop();
                }
                timer.Stop();
            }

            else if (movementChecker == "right")
            {
                Thickness t = player.Margin;
                if (alternate == false)
                    t.Left += 10;
                else
                    t.Left -= 10;
                player .Margin = t;
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
              if (e.Key == Key.Up)
            {
                timer.Start();
                movementChecker = "up";
            }
            else if (e.Key == Key.Down)
            {
                timer.Start();
                movementChecker = "down";
            }

            else if (e.Key == Key.Left)
            {
                timer.Start();
                movementChecker = "left";
            }

            else if (e.Key == Key.Right)
            {
                timer.Start();
                movementChecker = "right";
            }
           
            
        }

        public void Interception(object sender, EventArgs e)
        {
            if (playerHitBox.IntersectsWith(upHitBox))
            {
                playerHitBox.Location = downHitBox.Location;  
            }


        }

        public void MovementControl(object sender, EventArgs e)
        {
            if (movementChecker=="left")
            {
                Canvas.GetLeft(player);

            }
        }
    }
}
