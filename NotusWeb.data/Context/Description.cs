using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusWeb.data.Context
{
    public class Description
    {
        public int DescriptionId { get; set; }
        public string TextDescription { get; set; }
        public DateTime CreateDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Note> Notes { get; set; }
    }
}
