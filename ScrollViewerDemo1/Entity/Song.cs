using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrollViewerDemo1.Entity
{
    class Song
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public string singer { get; set; }

        public string author { get; set; }

        public string thumbnail { get; set; }

        public string link { get; set; }

        public Dictionary<string, string> Validate()
        {
            var errors = new Dictionary<string, string>();
            if (string.IsNullOrEmpty(name))
            {
                errors.Add("name", "Name is required!");
            }
            if (string.IsNullOrEmpty(description))
            {
                errors.Add("description", "description is required!");
            }
            if (string.IsNullOrEmpty(singer))
            {
                errors.Add("single", "Single is required!");
            }
            if (string.IsNullOrEmpty(author))
            {
                errors.Add("author", "author is required!");
            }
            if (string.IsNullOrEmpty(link))
            {
                errors.Add("link", "link is required!");
            }
            if (string.IsNullOrEmpty(thumbnail))
            {
                errors.Add("thumbnail", "thumbnail is required!");
            }
            return errors;
        }
    }
}
