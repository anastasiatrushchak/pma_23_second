using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BookMarkDecorator : BookDecorator
    {
        int pageNumber;
        public BookMarkDecorator(IBook Book, int number) : base(Book)
        {
            if (number < 1 || number > 1000)
            {
                throw new ArgumentException("Page number for bookmark must be (0;1000)", nameof(pageNumber));
            }
            pageNumber = number;
        }
        public override string GetTitle()
        {
            return $"{book.GetTitle()}\n add bookmark on page {pageNumber}";
        }
    }
}
