using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    [Table("UserVisit")]
    public class UserVisits
    {
        public DateTime when { get; set; }
        [Key]
        [ForeignKey("user")]
        [Column(Order = 1)]
        public int FK_UserId { get; set; }

        [Key]
        [ForeignKey("city")]
       [Column(Order = 2)]
        public int FK_CityId { get; set; }
        public User user { get; set; }
        public City city { get; set; }
    }
}
