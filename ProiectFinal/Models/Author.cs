using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage = "Poza este obligatorie")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Nume")]
        [Required(ErrorMessage = "Numele este obligatoriu")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Numele trebuie sa aiba intre 3 si 50 de caractere")]
        public string FullName { get; set; }

        [Display(Name = "Biografie")]
        [Required(ErrorMessage = "Biografia este obligatorie")]
        public string Bio { get; set; }

        //relationships
        public List<Author_Book> Author_Books { get; set; }

    }
}
