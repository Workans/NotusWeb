using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusWeb.data.Context
{
    public class LanguageCode
    {
        public int LanguageCodeId { get; set; }
        public string LanguageCodeName { get; set; }
        public IEnumerable<Note> Notes { get; set; }
    }
}
