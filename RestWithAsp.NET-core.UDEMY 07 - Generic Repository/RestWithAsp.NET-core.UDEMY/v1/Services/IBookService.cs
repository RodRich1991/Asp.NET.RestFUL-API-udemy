using RestWithAsp.NET_core.UDEMY.V1.Model;
using System.Collections.Generic;

namespace RestWithAsp.NET_core.UDEMY.V1.Service
{
    public interface IBookService
    {
        Book Create(Book person);

        Book FindById(long id);

        List<Book> FindAll();

        Book Update(Book person);

        void Delete(long id);
    }
}
