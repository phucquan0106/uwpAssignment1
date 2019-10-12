﻿using Newtonsoft.Json;
using ScrollViewerDemo1.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json.Linq;
using ScrollViewerDemo1.Constant;
using ScrollViewerDemo1.Services;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ScrollViewerDemo1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        public Register()
        {
            this.InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var member = new Member
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                password = txtPassword.Password.ToString(),
                address = txtAddress.Text,
                avatar = txtAvatar.Text,
                birthday = txtBirthday.Text,
                email = txtEmail.Text,
                gender = Int32.Parse(txtGender.Text),
                introduction = txtIntroduction.Text,
                phone = txtPhone.Text

            };

            MemberServiceImp memberServiceImp = new MemberServiceImp();
            memberServiceImp.FormRegister(member, ApiUrl.URL_REGISTER);

            ////Debug.WriteLine(JsonConvert.SerializeObject(member));
            //Debug.WriteLine(JsonConvert.SerializeObject(member));
            //var httpClient = new HttpClient();
            ////httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + token);
            //HttpContent content = new StringContent(JsonConvert.SerializeObject(member), Encoding.UTF8,
            //    "application/json");
            //Task<HttpResponseMessage> httpRequestMessage = httpClient.PostAsync(ApiUrl, content);
            //String responseContent = httpClient.PostAsync(ApiUrl, content).Result.Content.ReadAsStringAsync().Result;
            //Debug.WriteLine("Response: " + responseContent);

            //Member resMember = JsonConvert.DeserializeObject<Member>(responseContent);
            //JObject resJObject = JObject.Parse(responseContent);
            //Debug.WriteLine(resMember.email);
            //Debug.WriteLine(resJObject["email"]);
        }

        //private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        //{
        //    CameraCaptureUI captureUI = new CameraCaptureUI();
        //    captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;
        //    captureUI.PhotoSettings.CroppedSizeInPixels = new Size(200, 200);

        //    StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

        //    if (photo == null)
        //    {
        //        // User cancelled photo capture
        //        return;
        //    }

        //    FileServiceImp fileServiceImp = new FileServiceImp();
        //    string UploadURL = fileServiceImp.GetUploadURL(apiForUploadURL);
        //    fileServiceImp.UploadFile(UploadURL, "myFile", "image/png", photo, Avatar, AvatarUrl);
        //}
    }
}
