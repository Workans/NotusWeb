using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusWeb.data.Context
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<Note> Notes { get; set; }
        public IEnumerable<Description> Descriptions { get; set; }
    }
}
