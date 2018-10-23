using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
using App8.Entity;
using Newtonsoft.Json;
using System.Text;
using Windows.Storage;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using App8.Service;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App8.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SongForm : Page   //Upload bai hat
    {
        
        private Song currentSong;
        public static string tokenKey = null;
        public static async Task<string> ReadToken()
        {
            if (tokenKey == null)
            {
                StorageFolder folder = ApplicationData.Current.LocalFolder;
                StorageFile file = await folder.GetFileAsync("token.txt");
                string content = await FileIO.ReadTextAsync(file);
                TokenResponse member_token = JsonConvert.DeserializeObject<TokenResponse>(content);
                Debug.WriteLine("token la: " + member_token.token);
                tokenKey = member_token.token;
            }

            return tokenKey;
        }
        public SongForm()
        {
            this.InitializeComponent();
            
        }

        // Them bai hat
        private async void BtnAddSong(object sender, RoutedEventArgs e)
        {
          HttpClient client = new HttpClient();
            this.currentSong.name = this.Name.Text;
            this.currentSong.description = this.Description.Text;
            this.currentSong.singer = this.Singer.Text;
            this.currentSong.author = this.Author.Text;
            this.currentSong.thumbnail = this.Thumbnail.Text;
            this.currentSong.link = this.Link.Text;
            var jsonSong = JsonConvert.SerializeObject(this.currentSong);
            StringContent content = new StringContent(jsonSong, Encoding.UTF8, "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + tokenKey);
            var response = client.PostAsync(ApiHandle.REGISTER_SONG, content);
            var contents = await response.Result.Content.ReadAsStringAsync();
            if (response.Result.StatusCode == HttpStatusCode.Created)
            {
                Debug.WriteLine("Success");
                MessageDialog messageDialog = new MessageDialog("Success");
                messageDialog.ShowAsync();
            }
            else
            {
                ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(contents);
                if (errorResponse.error.Count > 0)
                {
                    foreach (var key in errorResponse.error.Keys)
                    {
                        if (this.FindName(key) is TextBlock textBlock)//kiem tra xem no co phai la mot dang textBlock
                        {
                            textBlock.Text = "* " + errorResponse.error[key];
                        }
                    }
                }
            }

        }
    }
}
