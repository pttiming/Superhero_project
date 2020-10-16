using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperheroProject.Models
{
    public class Superhero
    {
        //primary key
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Alter Ego")]
        public string AlterEgo { get; set; }
        [Display(Name = "Primary Superhero Ability")]
        public string PrimaryAbility { get; set; }
        [Display(Name = "Secondary Superhero Ability")]
        public string SecondaryAbility { get; set; }
        [Display(Name = "Catchphrase")]
        public string Catchphrase { get; set; }
    }
}
