using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollViewerDemo1.Entity
{
    class Member
    {
        public string id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string avatar { get; set; }

        public string phone { get; set; }

        public string address { get; set; }

        public string introduction { get; set; }

        public int gender { get; set; }

        public string birthday { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string token { get; set; }

        public Dictionary<string, string> Validate()
        {
            var errors = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(firstName))
            {
                errors.Add("firstName", "firstName is required!");
            }
            if (string.IsNullOrEmpty(lastName))
            {
                errors.Add("lastName", "lastName is required!");
            }
            if (string.IsNullOrEmpty(avatar))
            {
                errors.Add("avatar", "avatar is required!");
            }
            if (string.IsNullOrEmpty(phone))
            {
                errors.Add("phone", "phone is required!");
            }
            else if (phone.Length < 10 || phone.Length > 12)
            {
                errors.Add("phone", "phone must be 10 to 11 characters!");
            }
            if (string.IsNullOrEmpty(address))
            {
                errors.Add("address", "address is required!");
            }
            if (string.IsNullOrEmpty(introduction))
            {
                errors.Add("introduction", "introduction is required!");
            }
            if (gender < 1 || gender > 2)
            {
                errors.Add("gender", "Male: 1 OR Female: 2!");
            }
            if (string.IsNullOrEmpty(birthday))
            {
                errors.Add("birthday", "birthday is required!");
            }
            if (string.IsNullOrEmpty(email))
            {
                errors.Add("email", "email is required!");
            }
            if (string.IsNullOrEmpty(password))
            {
                errors.Add("password", "password is required!");
            }
            return errors;
        }

    }
}
