using ProiectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectFinal.Data.Services
{
    public interface IBooksService
    {
        IEnumerable<Book> GetAllAsync();
        Task<Book> GetByIdAsync(int id);
    }
}
