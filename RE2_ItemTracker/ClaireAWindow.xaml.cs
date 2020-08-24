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

namespace RE2_ItemTracker
{
    /// <summary>
    /// Interaction logic for ClaireAWindow.xaml
    /// </summary>
    public partial class ClaireAWindow : Window
    {
        ButtonTracker BtnTrk = new ButtonTracker();
        public Button[,] BtnArray = new Button[6, 7];
        Image[,] ImgArray = new Image[6, 7];

        public ClaireAWindow()
        {
            InitializeComponent();
            clairea_mi.IsChecked = true;
            BtnTrk.SetColumnRowCount(main_gr);

            for (int i = 0; i < BtnTrk.RowCount; i++)
            {
                for (int j = 0; j < BtnTrk.ColumnCount; j++)
                {
                    BtnArray[i, j] = new Button();
                    ImgArray[i, j] = new Image();
                    BtnArray[i, j].Content = ImgArray[i, j];
                    BtnArray[i, j].SetValue(Grid.RowProperty, i);
                    BtnArray[i, j].SetValue(Grid.ColumnProperty, j);
                    BtnArray[i, j].BorderBrush = Brushes.Transparent;
                    BtnArray[i, j].Background = Brushes.Transparent;
                    BtnArray[i, j].PreviewMouseLeftButtonDown += Button_Click;
                    BtnArray[i, j].MouseDoubleClick += Drag;
                    main_gr.Children.Add(BtnArray[i, j]);
                }
            }

            ImgArray[0, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/maiden-medallion.png"));
            ImgArray[0, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/unicorn-medallion.png"));
            ImgArray[0, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/lion-medallion.png"));
            ImgArray[0, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/king-plug.png"));
            ImgArray[0, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/queen-plug.png"));
            ImgArray[0, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/rook-plug.png"));
            ImgArray[0, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/knight-plug.png"));

            ImgArray[1, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/bishop-plug.png"));
            ImgArray[1, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/pawn-plug.png"));
            ImgArray[1, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/diamond-key.png"));
            ImgArray[1, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/spade-key.png"));
            ImgArray[1, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/lovers-relief.png"));
            ImgArray[1, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/orphanage-key.png"));
            ImgArray[1, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/fuse-break-room-hallway.png"));

            ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png"));
            ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png"));
            ImgArray[2, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/spare-key.png"));
            ImgArray[2, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/spare-key.png"));
            ImgArray[2, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/id-wristband-general-staff.png"));
            ImgArray[2, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/id-wristband-senior-staff.png"));
            ImgArray[2, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/id-wristband-admin.png"));

            ImgArray[3, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/scissors.png"));
            ImgArray[3, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/stuffed-doll.png"));
            ImgArray[3, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/bolt-cutter.png"));
            ImgArray[3, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/valve-handle.png"));
            ImgArray[3, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/t-bar-valve-handle.png"));
            ImgArray[3, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/mechanic-jack-handle.png"));
            ImgArray[3, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/large-gear.png"));

            ImgArray[4, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/small-gear.png"));
            ImgArray[4, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/parking-garage-key-card.png"));
            ImgArray[4, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/weapons-locker-key-card.png"));
            ImgArray[4, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/tin-storage-box.png"));
            ImgArray[4, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/sewers-key.png"));
            ImgArray[4, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/stars-badge.png"));
            ImgArray[4, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/scepter.png"));

            ImgArray[5, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/bejeweled-box.png"));
            ImgArray[5, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/electronic-gadget.png"));
            ImgArray[5, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/battery.png"));
            ImgArray[5, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/red-book-art-object.png"));
            ImgArray[5, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/statues-left-arm.png"));
            ImgArray[5, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/signal-modulator.png"));
            ImgArray[5, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/dispersal-cartridge-empty.png"));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            var bc = new BrushConverter();
            int l_row, l_column;

            l_column = Convert.ToInt32(btn.GetValue(Grid.ColumnProperty));
            l_row = Convert.ToInt32(btn.GetValue(Grid.RowProperty));

            if (btn.Background == Brushes.Transparent)
            {
                btn.Background = (Brush)bc.ConvertFrom("#65006400");
                BtnTrk.SetChecked(l_row, l_column);

                if (sender == BtnArray[4, 6])
                    ImgArray[4, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/red-jewel.png"));
                else if (sender == BtnArray[4, 3])
                    ImgArray[4, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/car-key.png"));
                else if (sender == BtnArray[2, 0])
                    ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
                else if (sender == BtnArray[2, 1])
                    ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
                else if (sender == BtnArray[1, 4])
                    ImgArray[1, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/heart-key.png"));
                else if (sender == BtnArray[3, 1])
                    ImgArray[3, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/picture-block.png"));
            }
            else
            {
                btn.Background = Brushes.Transparent;
                BtnTrk.SetUnchecked(l_row, l_column);

                if (sender == BtnArray[4, 6])
                    ImgArray[4, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/scepter.png"));
                else if (sender == BtnArray[4, 3])
                    ImgArray[4, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/tin-storage-box.png"));
                else if (sender == BtnArray[2, 0])
                    ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png"));
                else if (sender == BtnArray[2, 1])
                    ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png"));
                else if (sender == BtnArray[1, 4])
                    ImgArray[1, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/lovers-relief.png"));
                else if (sender == BtnArray[3, 1])
                    ImgArray[3, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/stuffed-doll.png"));
            }
        }

        private void Drag(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender == leona_mi)
            {
                MainWindow la_win = new MainWindow();
                Loader.LoadNewWindow(clairea_win, la_win, HeightProperty, WidthProperty);
            }

            else if (sender == leonb_mi)
            {
                LeonBWindow lb_win = new LeonBWindow();
                Loader.LoadNewWindow(clairea_win, lb_win, HeightProperty, WidthProperty);
            }

            else if (sender == claireb_mi)
            {
                ClaireBWindow cb_win = new ClaireBWindow();
                Loader.LoadNewWindow(clairea_win, cb_win, HeightProperty, WidthProperty);
            }

            else if (sender == exit_mi)
            {
                App.Current.Shutdown();
            }

            else if (sender == load_mi)
            {
                var CheckBtn = BtnTrk.LoadState();
                var bc = new BrushConverter();

                for (int i = 0; i < BtnTrk.RowCount; i++)
                {
                    for (int j = 0; j < BtnTrk.ColumnCount; j++)
                    {

                        if (CheckBtn[i, j] == true)
                        {
                            BtnArray[i, j].Background = (Brush)bc.ConvertFrom("#65006400");
                            if (i == 4 && j == 6)
                                ImgArray[4, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/red-jewel.png"));
                            else if (i == 4 && j == 3)
                                ImgArray[4, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/car-key.png"));
                            else if (i == 2 && j == 0)
                                ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
                            else if (i == 2 && j == 1)
                                ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
                            else if (i == 1 && j == 4)
                                ImgArray[1, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/heart-key.png"));
                            else if (i == 3 && j == 1)
                                ImgArray[3, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/picture-block.png"));
                        }
                        else
                            BtnArray[i, j].Background = Brushes.Transparent;
                    }
                }

            }

            else if (sender == save_mi)
            {
                BtnTrk.SaveState(BtnTrk.CheckBtn);
            }
        }
    }
}
