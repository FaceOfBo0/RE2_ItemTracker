using Microsoft.Win32;
using System;
using System.IO;
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
using System.Runtime.CompilerServices;
using System.ComponentModel.Design;

namespace RE2_ItemTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        ButtonTracker BtnTrk = new ButtonTracker();
        Button[,] BtnArray = new Button[6, 7];
        Image[,] ImgArray = new Image[6, 7];

        public MainWindow()
        {
            InitializeComponent();
            leona_mi.IsChecked = true;
            BtnTrk.SetColumnRowCount(main_gr);

            for (int i = 0; i < BtnTrk.RowCount; i++)
            {
                for (int j = 0; j < BtnTrk.ColumnCount; j++)
                {
                    if (i != 5 || j != 6) 
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
                    else { }
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
            ImgArray[1, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/club-key.png"));
            ImgArray[1, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/fuse-main-hall.png"));
            ImgArray[1, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/fuse-break-room-hallway.png"));

            ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png"));
            ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png"));
            ImgArray[2, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/spare-key.png"));
            ImgArray[2, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/spare-key.png"));
            ImgArray[2, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/id-wristband-visitor.png"));
            ImgArray[2, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/id-wristband-general-staff.png"));
            ImgArray[2, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/id-wristband-senior-staff.png"));

            ImgArray[3, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/square-crank.png"));
            ImgArray[3, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/bolt-cutter.png"));
            ImgArray[3, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/valve-handle.png"));
            ImgArray[3, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/t-bar-valve-handle.png"));
            ImgArray[3, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/mechanic-jack-handle.png"));
            ImgArray[3, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/large-gear.png"));
            ImgArray[3, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/small-gear.png"));

            ImgArray[4, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/parking-garage-key-card.png"));
            ImgArray[4, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/weapons-locker-key-card.png"));
            ImgArray[4, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/tin-storage-box.png"));
            ImgArray[4, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/sewers-key.png"));
            ImgArray[4, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/stars-badge.png"));
            ImgArray[4, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/scepter.png"));
            ImgArray[4, 6].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/bejeweled-box.png"));

            ImgArray[5, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/electronic-gadget.png"));
            ImgArray[5, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/battery.png"));
            ImgArray[5, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/red-book-art-object.png"));
            ImgArray[5, 3].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/statues-left-arm.png"));
            ImgArray[5, 4].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/signal-modulator.png"));
            ImgArray[5, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/dispersal-cartridge-empty.png"));
            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            var bc = new BrushConverter();
            int l_row, l_column;

            l_column = Convert.ToInt32(btn.GetValue(Grid.ColumnProperty));
            l_row = Convert.ToInt32(btn.GetValue(Grid.RowProperty));

            if (btn.Background == Brushes.Transparent)
            {
                btn.Background = (Brush)bc.ConvertFrom("#65006400");
                BtnTrk.SetChecked(l_row, l_column);

                  if (sender == BtnArray[4, 5])
                      ImgArray[4, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/red-jewel.png"));
                  else if (sender == BtnArray[4, 2])
                      ImgArray[4, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/car-key.png"));
                  else if (sender == BtnArray[2, 0])
                      ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
                  else if (sender == BtnArray[2, 1])
                      ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
            }
            else
            {
                btn.Background = Brushes.Transparent;
                BtnTrk.SetUnchecked(l_row, l_column);

                  if (sender == BtnArray[4, 5])
                      ImgArray[4, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/scepter.png"));
                  else if (sender == BtnArray[4, 2])
                      ImgArray[4, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/tin-storage-box.png"));
                  else if (sender == BtnArray[2, 0])
                      ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png"));
                  else if (sender == BtnArray[2, 1])
                      ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/boxed-electronic-part.png")); 
            }
        }

        private void Drag(object sender, MouseButtonEventArgs e)
        { 
            if (Mouse.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        public void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();

            if (sender == leonb_mi)
            {
                LeonBWindow lb_win = new LeonBWindow();
                Loader.LoadNewWindow(main_win, lb_win, HeightProperty, WidthProperty);
            }

            else if (sender == clairea_mi)
            {
                ClaireAWindow ca_win = new ClaireAWindow();
                Loader.LoadNewWindow(main_win, ca_win, HeightProperty, WidthProperty);
            }

            else if (sender == claireb_mi)
            {
                ClaireBWindow cb_win = new ClaireBWindow();
                Loader.LoadNewWindow(main_win, cb_win, HeightProperty, WidthProperty);
            }

            else if (sender == load_mi)
            {
                var CheckBtn = BtnTrk.LoadState();

                for (int i = 0; i < BtnTrk.RowCount; i++)
                {
                    for (int j = 0; j < BtnTrk.ColumnCount; j++)
                    {
                        if (i != 5 || j != 6)
                        {
                            if (CheckBtn[i, j] == true)
                            {
                                BtnArray[i, j].Background = (Brush)bc.ConvertFrom("#65006400");
                                if (i == 4 && j == 5)
                                    ImgArray[4, 5].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/red-jewel.png"));
                                else if (i == 4 && j == 2)
                                    ImgArray[4, 2].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/car-key.png"));
                                else if (i == 2 && j == 0)
                                    ImgArray[2, 0].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
                                else if (i == 2 && j == 1)
                                    ImgArray[2, 1].Source = new BitmapImage(new Uri("pack://application:,,,/Pictures/power-panel-part.png"));
                            }
                            else
                                BtnArray[i, j].Background = Brushes.Transparent;
                        }
                        else { }
                    }
                }
            }

            else if (sender == save_mi)
            {
                BtnTrk.SaveState(BtnTrk.CheckBtn);
            }

            else if (sender == exit_mi)
            {
                App.Current.Shutdown();
            }
        }
    }
}














// MessageBox.Show(BtnTrk.RowCount.ToString());
// MessageBox.Show(BtnTrk.ColumnCount.ToString());


//MessageBox.Show(l_row.ToString());
//MessageBox.Show(l_column.ToString());

/*  OpenFileDialog openProg = new OpenFileDialog();
                if (openProg.ShowDialog() == true)
                {
                    MessageBox.Show(File.ReadAllText(openProg.FileName));                   
                } */


/* SaveFileDialog saveProg = new SaveFileDialog();
                 if (saveProg.ShowDialog() == true)
                     File.WriteAllText(saveProg.FileName, "Tolle scheiße"); */


/*  private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
          {
              //Image img = sender as Image;
              StackPanel stp = sender as StackPanel;
              if (stp.Background != Brushes.DarkGreen)
              //if (img.Parent.GetValue(BackgroundProperty) == Brushes.Transparent)
              {
                  //img.Parent.SetValue(BackgroundProperty, Brushes.DarkGreen);
                  stp.Background = Brushes.DarkGreen;
              }
              else
              {
                  //img.Parent.SetValue(BackgroundProperty, Brushes.Transparent);
                  stp.Background = Brushes.Transparent;
              }
          } */
