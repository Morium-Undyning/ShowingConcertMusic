using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Policy;

namespace ShowingConcertMusic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ISaveList<List<CMusicShow>> _serialzer = new JsonMusicSaver();

        CMusicShowList showList = new CMusicShowList();
        int selectedIndex;
        public MainWindow()
        {
            InitializeComponent();
            ShowList.ItemsSource = showList.GetListOfMusicShowNames();

        }
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "shows";
            dlg.DefaultExt = ".json";
            dlg.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string filePath = dlg.FileName;
                showList.LoadFromJson(filePath);
            }
            ShowList.Items.Refresh();
            ShowList.ItemsSource = showList.GetListOfMusicShowNames();
        }

        
        public CMusicShow GetMusicShowByName(List<CMusicShow> showList, string misucShow)
        {
            return showList.Find(musics => musics.misucShowName.Equals(misucShow, StringComparison.OrdinalIgnoreCase));

        }

        private void ShowList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = ShowList.SelectedItem;
            selectedIndex = ShowList.SelectedIndex;
            if (selectedItem != null)
            {
                scene.Children.Clear();
                NameCity.Content = (showList.GetMusicShowByName(selectedItem.ToString())).cityName;
                MusicShowName.Content = (showList.GetMusicShowByName(selectedItem.ToString())).misucShowName;
                NameMusicPlace.Content = (showList.GetMusicShowByName(selectedItem.ToString())).nameMisucPlace;
                MusicGroup.Content = (showList.GetMusicShowByName(selectedItem.ToString())).misucGroup;
                DateMusicShow.Content = (showList.GetMusicShowByName(selectedItem.ToString())).dateMisucPlace;
                double x = Convert.ToDouble((showList.GetMusicShowByName(selectedItem.ToString())).posOfMapX.ToString());
                double y = Convert.ToDouble((showList.GetMusicShowByName(selectedItem.ToString())).posOfMapY.ToString());
                Parametsr.Content = (showList.GetMusicShowByName(selectedItem.ToString())).typeMusicShowOrOriginOrGenresOfMusic;


                scene.Children.Add(MapPos(x,y));
                
            }
        }

        public Ellipse MapPos(double X,double Y)
        {
            Ellipse sprite = new Ellipse();

            sprite.Fill = Brushes.BlueViolet;
            sprite.StrokeThickness = 2;
            sprite.Stroke = Brushes.Black;

            sprite.HorizontalAlignment = HorizontalAlignment.Center;
            sprite.VerticalAlignment = VerticalAlignment.Center;

            sprite.Width = 5;
            sprite.Height = 5;



            sprite.RenderTransform = new TranslateTransform(X, Y);

            return sprite;
        }

        private void scene_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pos = e.GetPosition((IInputElement)sender);
            double x = Convert.ToDouble(tb1.Text);
            ShowList.ItemsSource = null;
            ShowList.Items.Clear();
            foreach (var item in showList.GetShows())
            {
                if(Math.Pow(item.posOfMapX-pos.X,2)+ Math.Pow(item.posOfMapY-pos.Y, 2) <= Math.Pow(x, 2))
                {
                    ShowList.Items.Add(item.misucShowName);
                }
            }

        }
    }
}
