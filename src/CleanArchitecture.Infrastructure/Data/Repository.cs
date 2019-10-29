using CleanArchitecture.Core.Interfaces;
using System.Linq;

namespace CleanArchitecture.Infrastructure.Data
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public int TodoItemsTotal()
        {
            return _context.ToDoItems.Count();
        }
    }
}
