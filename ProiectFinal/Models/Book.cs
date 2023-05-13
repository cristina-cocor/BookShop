using ProiectFinal.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Models
{
    public class Book
    {
        [Key]

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public BookCategory BookCategory { get; set; }
        
        //relationships
        public List<Author_Book> Author_Books { get; set; }
        public int PublishingHouseId { get; set; }
        [ForeignKey("PublishingHouseId")]
        public PublishingHouse PublishingHouse { get; set; }


    }
}
