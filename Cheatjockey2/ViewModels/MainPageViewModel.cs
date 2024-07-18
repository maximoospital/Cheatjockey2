using System.Collections.ObjectModel;
namespace Cheatjockey2;

public class MainPageViewModel
{
    public ObservableCollection<CardItem> DownloadLinks { get; set; }

    public MainPageViewModel()
    {
        DownloadLinks = new ObservableCollection<CardItem>
        {
            new CardItem { URL = "https://www.youtube.com/watch?v=UWJN2ku_Mkk", Name = "Item 1", Format = "MP3", Duration = "05:20", Tracks = "1 Track" },
            new CardItem { URL = "https://www.youtube.com/watch?v=UWJN2ku_Mkk", Name = "Item 2", Format = "FLAC", Duration = "15:20", Tracks = "2 Tracks" },
            // Add more items as needed
        };
    }
}