using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HardcoverDecorator : BookDecorator
    {
        public HardcoverDecorator(IBook book) : base(book)
        {
        }

        public override string GetTitle()
        {
            return $"{book.GetTitle()}\n add hardcover;";
        }
    }
}
