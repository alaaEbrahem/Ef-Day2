using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    [Table("Country")]
    public class Country
    {
        [Key]
        
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        [Column(TypeName ="varchar")]
        public string name { get; set; }

        [InverseProperty("country")]
        public List<City> cities { get; set; }
    }
}
