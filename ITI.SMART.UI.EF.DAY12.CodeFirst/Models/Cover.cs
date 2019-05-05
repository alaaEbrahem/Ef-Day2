using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    public class Cover
    {
        public int Id { get; set; }
        public string code { get; set; }
        public Book book { get; set; }
    }
}
