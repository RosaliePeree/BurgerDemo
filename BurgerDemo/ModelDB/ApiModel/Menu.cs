using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerDemo.Model.ApiModel
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public List<MenuItem> MenuItem { get; set; }

        public Menu()
        {
            MenuItem = new List<MenuItem>();
        }
    }
    public class MenuItem
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
