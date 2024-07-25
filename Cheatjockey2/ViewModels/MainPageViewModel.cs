using System.Collections.ObjectModel;
namespace Cheatjockey2;

public class MainPageViewModel
{
    public ObservableCollection<CardItem> DownloadLinks { get; set; }

    public MainPageViewModel()
    {
        DownloadLinks = new ObservableCollection<CardItem>
        {
            new CardItem { 
                URL = "https://www.youtube.com/watch?v=UWJN2ku_Mkk", 
                Name = "Item 1", 
                Format = "MP3", 
                Duration = "05:20", 
                TrackCount = 1 },
            new CardItem { 
                URL = "https://www.youtube.com/watch?v=UWJN2ku_Mkk", 
                Name = "Item 2", 
                Format = "FLAC", 
                Duration = "15:20", 
                TrackCount = 2 },
            // Add more items as needed
        };
    }
}