using AulaUdemy.Model;
using System.Collections.Generic;

namespace AulaUdemy.Services
{
    public interface IBookService
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
