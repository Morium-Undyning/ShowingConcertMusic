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

namespace ShowingConcertMusic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ISaveList<List<CMusicShow>> _serialzer = new JsonMusicSaver();

        List<CMusicShow> showList = new List<CMusicShow>();
        int selectedIndex;
        public MainWindow()
        {
            InitializeComponent();
            ShowList.ItemsSource = GetListOfMusicShowNames(showList);

        }

        public List <string> GetListOfMusicShowNames(List<CMusicShow> showList)
        {
            return showList.ConvertAll(music => music.misucShowName);
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
                LoadFromJson(filePath);
            }
            ShowList.Items.Refresh();
            ShowList.ItemsSource = GetListOfMusicShowNames(showList);
        }

        public void LoadFromJson( string path)
        {
            showList = _serialzer.Load(path);
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
                NameCity.Content = (GetMusicShowByName(showList, selectedItem.ToString())).cityName;
                MusicShowName.Content = (GetMusicShowByName(showList, selectedItem.ToString())).misucShowName;
                NameMusicPlace.Content = (GetMusicShowByName(showList, selectedItem.ToString())).nameMisucPlace;
                MusicGroup.Content = (GetMusicShowByName(showList, selectedItem.ToString())).misucGroup;
                DateMusicShow.Content = (GetMusicShowByName(showList, selectedItem.ToString())).dateMisucPlace;
            }
        }
    }
}
