namespace FakesAssembly
{
    public class BookStoreManager
    {
        private readonly IBookStoreRepository _bookStoreRepository;

        public BookStoreManager(IBookStoreRepository bookStoreRepository)
        {
            _bookStoreRepository = bookStoreRepository;
        }

        public Book GetBook(int bookId)
        {
            return _bookStoreRepository.GetBook(bookId);
        }
    }
}
