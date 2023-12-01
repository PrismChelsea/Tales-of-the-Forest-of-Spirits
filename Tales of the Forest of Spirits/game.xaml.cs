using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
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
        Rect downHitBox;
        Rect leftHitBox;
        Rect rightHitBox;
        Rect topHitBox;

        

        public game()
        {
            InitializeComponent();

            MyCanvas.Focus();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(15);
            timer.Tick += timer_Tick;

            CheckIntersection();

            playerHitBox = new Rect(Canvas.GetLeft(player), Canvas.GetTop(player), player.Width, player.Height);
            topHitBox = new Rect(Canvas.GetLeft(top), Canvas.GetTop(top), top.Width, top.Height);
            downHitBox = new Rect(Canvas.GetLeft(down), Canvas.GetTop(down), down.Width, down.Height);
            leftHitBox = new Rect(Canvas.GetLeft(left), Canvas.GetTop(left), left.Width, left.Height);
            rightHitBox = new Rect(Canvas.GetLeft(right), Canvas.GetTop(right), right.Width, right.Height);

           /* Canvas.SetTop(player, Canvas.GetTop(player ));
            Canvas.SetLeft(top, Canvas.GetLeft(top));
            Canvas.SetLeft(down, Canvas.GetLeft(down) );
            Canvas.SetLeft(left, Canvas.GetLeft(left) );
            Canvas.SetLeft(right, Canvas.GetLeft(right) );*/

           /* bool intersects = playerHitBox.IntersectsWith(leftHitBox);


            if (playerHitBox.IntersectsWith(topHitBox))
            {

                labello.Content = "yoooo"; 
            }

            if (intersects==true)
            {
                labello.Content = "yipikájé";
            }
            else
            {
                labello.Content = "nemmükszik";

            }
           */
        }

        private void CheckIntersection()
        {
            Rect rect1 = new Rect(new Size(player.Width,player.Height));
            Rect rect2 = new Rect(new Size(left.Width, left.Height));
            if (rect1.IntersectsWith(rect2))
            {
                labello.Content = "leccgooooo";
                labello.Foreground = Brushes.Green;
            }
            else 
            {
                labello.Content = "hát ez nem jött be";
                labello.Foreground = Brushes.Red;
            }

        }

        //-------------------------------------------------------------------------------------------------------------------------------------
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

            else if (movementChecker == "down")
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
        //--------------------------------------------------------------------------------------------------------------------------------------


        public void Interception(object sender, EventArgs e)
        {
           /* if (playerHitBox.IntersectsWith(upHitBox))
            {
                playerHitBox.Location = downHitBox.Location;
            }*/
           /*
            if (playerHitBox.IntersectsWith(upHitBox))
            {
                playerHitBox.Location=downHitBox.Location;
            }

            else if (playerHitBox.IntersectsWith(downHitBox))
            {
                playerHitBox.Location = new Point(300, 100);
            }

            else if (playerHitBox.IntersectsWith(leftHitBox))
            {
                playerHitBox.Location = new Point(300, 100);
            }

            else if (playerHitBox.IntersectsWith(rightHitBox))
            {
                playerHitBox.Location = new Point(300, 100);
            }

            else
            {
                playerHitBox.Location = new Point(300, 100);
            }
            */





        }
        //------------------------------------------------------------------------------------------------------------------------------------------





    }
}
