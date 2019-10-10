using BurgerDemo.Model.Identity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerDemo.Model.ApiModel
{
    public class Picture
    {
        [Key]
        public int ID { get; set; }
        public string URL { get; set; }
        public ApplicationUser SubmittedBy { get; set; }
    }
}
