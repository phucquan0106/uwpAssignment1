using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Newtonsoft.Json;
using ScrollViewerDemo1.Constant;
using ScrollViewerDemo1.Entity;

namespace ScrollViewerDemo1.Services
{
    class SongService:ISongService
    {
        public void PostSong(Song song)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic "+ReadFromTXTFile());
            HttpContent content = new StringContent(JsonConvert.SerializeObject(song), Encoding.UTF8, "application/json");
            Task<HttpResponseMessage> httpRequestMessageToCreateNewSong = httpClient.PostAsync(ApiUrl.URL_POST_SONG, content);
            var jsonResultToCreateNewSong = httpRequestMessageToCreateNewSong.Result.Content.ReadAsStringAsync().Result;
        }

       
        public ObservableCollection<Song> GetFreeSongs(string token)
        {
            ObservableCollection<Song> songs = new ObservableCollection<Song>();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Basic "+token);
            var responseContent = client.GetAsync(ApiUrl.URL_GET_NEW_SONG).Result.Content.ReadAsStringAsync().Result;
            songs = JsonConvert.DeserializeObject<ObservableCollection<Song>>(responseContent);
            return songs;
        }

        public ObservableCollection<Song> GetMySongs(string token)
        {
            ObservableCollection<Song> songs = new ObservableCollection<Song>();
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + token);
            var responseContent = client.GetAsync(ApiUrl.URL_GET_MY_SONG).Result.Content.ReadAsStringAsync().Result;
            songs = JsonConvert.DeserializeObject<ObservableCollection<Song>>(responseContent);
            return songs;
        }

        public string ReadFromTXTFile()
        {
            Windows.Storage.StorageFolder storageFolder =
                Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                storageFolder.GetFileAsync("sample.txt").GetAwaiter().GetResult();

            string text = Windows.Storage.FileIO.ReadTextAsync(sampleFile).GetAwaiter().GetResult();
            Debug.WriteLine("All song " + sampleFile.Path);
            return text;
        }
    }
}
