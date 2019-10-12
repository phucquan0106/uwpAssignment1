using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrollViewerDemo1.Entity;

namespace ScrollViewerDemo1.Services
{
    interface ISongService
    {
        void PostSong(Song song);

        ObservableCollection<Song> GetFreeSongs(string token);

        ObservableCollection<Song> GetMySongs(string token);
    }
}
