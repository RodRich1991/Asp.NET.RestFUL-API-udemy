using RestWithAsp.NET_core.UDEMY.V1.Model;
using RestWithAsp.NET_core.UDEMY.V1.Repository.Base;
using System.Collections.Generic;

namespace RestWithAsp.NET_core.UDEMY.V1.Service.Implementation
{
    public class BookServiceImpl : IBookService
    {
        private IBaseRepository<Book> _baseRepository;

        public BookServiceImpl(IBaseRepository<Book> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public Book Create(Book book)
        {
            return _baseRepository.Create(book);
        }

        public void Delete(long id)
        {
            _baseRepository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _baseRepository.FindAll();
        }

        public Book FindById(long id)
        {
            return _baseRepository.FindById(id);
        }

        public Book Update(Book book)
        {
            return _baseRepository.Update(book);
        }

    }
}
