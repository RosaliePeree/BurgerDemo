using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerDemo.Model.ApiModel
{
    public class Restaurant
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Menu Menu { get; set; }
        public DateTime OpeningTime { get; set; } // Should be filtered by day of the week too, but omitted for this example
        public DateTime ClosingTime { get; set; } // Idem
        public Score Rating { get; set; }
        public List<Picture> Pictures { get; set; }
    }
}
