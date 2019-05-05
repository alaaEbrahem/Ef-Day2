using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.SMART.UI.EF.DAY12.CodeFirst.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string name { get; set; }
        public List<Employee> employees { get; set; }
    }
}
