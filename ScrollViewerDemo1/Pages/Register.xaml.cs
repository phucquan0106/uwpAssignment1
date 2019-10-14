using Newtonsoft.Json;
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

        private MemberServiceImp memberServiceImp;
        public Register()
        {
            this.InitializeComponent();
            memberServiceImp = new MemberServiceImp();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var member = new Member
            {
                firstName = txtFirstName.Text,
                lastName = txtLastName.Text,
                password = txtPassword.Password,
                address = txtAddress.Text,
                avatar = txtAvatar.Text,
                birthday = txtBirthday.Text,
                email = txtEmail.Text,
                gender = Int32.Parse(txtGender.Text),
                introduction = txtIntroduction.Text,
                phone = txtPhone.Text

            };

            Dictionary<String, String> errors = member.Validate();
            if (errors.Count == 0)
            {
                memberServiceImp.FormRegister(member, ApiUrl.URL_REGISTER);
            }
            else
            {
                if (errors.ContainsKey("firstName"))
                {
                    FirstNameMessage.Text = errors["firstName"];
                    FirstNameMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    FirstNameMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("lastName"))
                {
                    LastNameMessage.Text = errors["lastName"];
                    LastNameMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    LastNameMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("avatar"))
                {
                    AvatarMessage.Text = errors["avatar"];
                    AvatarMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    AvatarMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("phone"))
                {
                    PhoneMessage.Text = errors["phone"];
                    PhoneMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    PhoneMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("address"))
                {
                    AddressMessage.Text = errors["address"];
                    AddressMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    AddressMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("introduction"))
                {
                    IntroductionMessage.Text = errors["introduction"];
                    IntroductionMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    IntroductionMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("gender"))
                {
                    GenderMessage.Text = errors["gender"];
                    GenderMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    GenderMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("birthday"))
                {
                    BirthdayMessage.Text = errors["birthday"];
                    BirthdayMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    BirthdayMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("email"))
                {
                    EmailMessage.Text = errors["email"];
                    EmailMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    EmailMessage.Visibility = Visibility.Collapsed;
                }
                if (errors.ContainsKey("password"))
                {
                    PasswordMessage.Text = errors["password"];
                    PasswordMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    PasswordMessage.Visibility = Visibility.Collapsed;
                }
                if (txtPassword.Password != txtConfirmPassword.Password)
                {
                    ConfirmPasswordMessage.Text = "Not match!";
                    ConfirmPasswordMessage.Visibility = Visibility.Visible;
                }
                else
                {
                    ConfirmPasswordMessage.Visibility = Visibility.Collapsed;
                }
            }

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
