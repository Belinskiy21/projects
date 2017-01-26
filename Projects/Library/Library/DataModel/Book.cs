using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel
{
    public class Book
    {
        public int BookID { get; set; }

        [MaxLength(1000)]
        [Required]
        public string Title { get; set; }
        [MaxLength(256)]
        public string Author { get; set; }
        [MaxLength(50)]
        public string ISBN { get; set; }
    }
}
