using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollViewerDemo1.Constant
{
    class ApiUrl
    {
        public const string URL_API_BASE = "https://2-dot-backup-server-003.appspot.com/_api/v2";
        public const string URL_REGISTER = URL_API_BASE + "/members";
        public const string URL_LOGIN = URL_API_BASE + "/members/authentication";
        public const string URL_MEMBER_GET_INFORMATION = URL_API_BASE + "/members";
        public const string URL_POST_SONG = URL_API_BASE + "/songs";
        public const string URL_GET_NEW_SONG = URL_API_BASE + "/songs";
        public const string URL_GET_MY_SONG = URL_API_BASE + "/songs/get-mine";
        public const string URL_GET_UPLOAD_TOKEN = "https://2-dot-backup-server-003.appspot.com/get-upload-token";
    }
}
