using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusWeb.data.Context
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Code { get; set; }
        public int LanguageCodeId { get; set; }
        public int DescriptionId { get; set; }
        public int UserId { get; set; }
        public LanguageCode LanguageCode { get; set; }
        public Description Description { get; set; }
        public User User { get; set; }
    }
}
