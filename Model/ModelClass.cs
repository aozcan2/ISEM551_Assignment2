using System.ComponentModel;

namespace Model
{
    public class ModelClass {

        [DisplayName("book_id")]
        public string book_id {get; set;}

        [DisplayName("Name of the Book")]
        public string book_name { get; set;}

        [DisplayName("Author of the Book")]
        public string author { get; set; }

        [DisplayName("Type of the Book")]
        public string type { get; set; }

        [DisplayName("Download Link")]
        public string link { get; set; }

        [DisplayName("added_by_id")]
        public string added_by_id { get; set; }

        [DisplayName("date")]
        public string date { get; set; }
    }
}
