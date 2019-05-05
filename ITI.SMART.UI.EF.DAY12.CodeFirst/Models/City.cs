using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]

        public string name { get; set; }
        [ForeignKey("country")]
        public int FK_CountryId { get; set; }
        //[ForeignKey("FK_CountryId")]
        public Country country { get; set; }
        public List<UserVisits> userVisits { get; set; }
        public Book Book { get; set; }

    }
}
