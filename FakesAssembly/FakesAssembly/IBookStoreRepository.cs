using System.Collections.Generic;

namespace FakesAssembly
{
    public interface IBookStoreRepository
    {
        Author GetAuthor(int id);
        Book GetBook(int id);
        IEnumerable<Book> GetBooksOfAuthor(Author author);
    }
}
