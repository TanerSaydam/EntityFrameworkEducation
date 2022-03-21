using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEducation.Models
{
    public class BookManager : IBookService
    {
        public List<Book> GetBooks()
        {
            using (var context = new ContextDb())
            {
                return context.Books.ToList();
            }
        }
    }
}
