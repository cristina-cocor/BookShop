using Microsoft.EntityFrameworkCore;
using ProiectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Data.Services
{
    public class BooksService
    {
        private readonly AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var movieDetails = await _context.Books
                .Include(p => p.PublishingHouse)
                .Include(am => am.Author_Books).ThenInclude(a => a.Author)
                .FirstOrDefaultAsync(n => n.Id == id);

            return movieDetails;
        }


    }
}
