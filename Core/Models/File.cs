using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class File
    {
        public int Id { get; set; }
        public string Filenames { get; set; }
        public string Size { get; set; }

        public string Type { get; set; }
    }
}
