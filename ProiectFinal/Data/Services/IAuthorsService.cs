using ProiectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Data.Services
{
    public interface IAuthorsService
    {
        IEnumerable<Author> GetAllAsync();
        Task<Author> GetByIdAsync(int id);
        Task AddAsync(Author author);
        Task<Author> UpdateAsync(int Id, Author newAuthor);

        Task DeleteAsync(int id);
    }
}
