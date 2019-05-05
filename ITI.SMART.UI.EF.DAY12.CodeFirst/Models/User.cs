using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    [Table("User")]
    public  class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string name { get; set; }
        public List<UserVisits> userVisits { get; set; }
        [InverseProperty("Author")]
        public List<Book> Authored { get; set; }
        [InverseProperty("Designer")]
        public List<Book> Designed { get; set; }

    }
}
