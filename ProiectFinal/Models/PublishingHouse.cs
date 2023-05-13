using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Models
{
    public class PublishingHouse
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Logo")] 
        public string Logo { get; set; }
       
        [Display(Name = "Nume")]
        public string Name { get; set; }
        
        [Display(Name = "Descriere")]
        public string Description { get; set; }

        //relationships
        public List<Book> Books { get; set; }
    }
}
