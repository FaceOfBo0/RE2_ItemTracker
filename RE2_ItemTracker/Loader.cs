using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace RE2_ItemTracker
{
    class Loader
    {
        public Loader() { }

        public static void LoadNewWindow (Window a_old, Window a_new, DependencyProperty Height, DependencyProperty Width)
        {
            // Get absolute location on screen of upper left corner of window
            Point locationFromScreen = a_old.PointToScreen(new Point(0, 0));

            a_new.Top = locationFromScreen.Y;
            a_new.Left = locationFromScreen.X;
            a_new.SetValue(Height, a_old.Height);
            a_new.SetValue(Width, a_old.Width);
            a_new.Show();
            a_old.Close();
        }
    }


}
