using BurgerDemo.Model.Identity.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerDemo.Model.ApiModel
{
    public class Score
    {
        [Key]
        public int ID { get; set; }
        public double Taste { get; set; }
        public double Texture { get; set; }
        public double VisualPresentation { get; set; }
        public ApplicationUser SubmittedBy { get; set; }
    }
}
