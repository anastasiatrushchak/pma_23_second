using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BookDecorator : IBook
    {
        protected IBook book;

        public BookDecorator(IBook someBook)
        {
            book = someBook;
        }

        public virtual string GetTitle()
        {
            return book.GetTitle();
        }

        public virtual string GetAuthor()
        {
            return book.GetAuthor();
        }
    }
}
