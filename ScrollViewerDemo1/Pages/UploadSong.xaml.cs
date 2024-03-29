﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ScrollViewerDemo1.Entity;
using ScrollViewerDemo1.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ScrollViewerDemo1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UploadSong : Page
    {
        private ISongService songService;
        public UploadSong()
        {
            this.InitializeComponent();
            //currentSong = new Song();
            songService = new SongService();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Song song = new Song()
            {
                name = txtName.Text,
                description = Description.Text,
                singer = Singer.Text,
                author = Author.Text,
                thumbnail = Thumbnail.Text,
                link = Link.Text
            };
            Dictionary<String, String> errors = song.Validate();
            if (errors.Count == 0)
            {
                songService.PostSong(song);

            }
            else
            {
                if (errors.ContainsKey("name"))
                {
                    NameMessage.Text = errors["name"];
                    NameMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    NameMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("description"))
                {
                    DescriptionMessage.Text = errors["description"];
                    DescriptionMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    DescriptionMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("singer"))
                {
                    SingerMessage.Text = errors["singer"];
                    SingerMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    SingerMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("author"))
                {
                    AuthorMessage.Text = errors["author"];
                    AuthorMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    AuthorMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("thumbnail"))
                {
                    ThumbnailMessage.Text = errors["thumbnail"];
                    ThumbnailMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    ThumbnailMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("link"))
                {
                    LinkMessage.Text = errors["link"];
                    LinkMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    LinkMessage.Visibility = Visibility.Collapsed;
                }
            }
            //var song = new Song();
        }
    }
}
