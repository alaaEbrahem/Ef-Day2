using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public int FK_DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<Book> Books { get; set; }
    }
}
