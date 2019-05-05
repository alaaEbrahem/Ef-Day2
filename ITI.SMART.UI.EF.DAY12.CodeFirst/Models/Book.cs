using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public User Author { get; set; }
        public User Designer { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        [ForeignKey("Designer")]
        public int DesignerId { get; set; }
        public List<Employee> employees { get; set; }
        public City City { get; set; }

    }
}
