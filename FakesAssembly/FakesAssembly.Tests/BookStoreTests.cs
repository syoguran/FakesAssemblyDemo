using NUnit.Framework;
using FakesAssembly.Fakes;

namespace FakesAssembly.Tests
{
    [TestFixture]
    public class BookStoreTests
    {
        [Test]
        public void GetBookTest()
        {

            var repo = new StubIBookStoreRepository
                           {
                               GetBookInt32 = bookId => new Book
                                                            {
                                                                Id = bookId,
                                                                Title =
                                                                    string.Format("Stub Book Title With Id {0}", bookId),
                                                                Author = new Author()
                                                            }
                           };

            var manager = new BookStoreManager(repo);
            var book = manager.GetBook(5);

            Assert.AreEqual(5, book.Id);
            Assert.AreEqual("Stub Book Title With Id 5",book.Title);
        }
    }
}
