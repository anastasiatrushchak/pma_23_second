using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AdditionalDecorator : BookDecorator
    {
        private string additional;

        public AdditionalDecorator(IBook book, string additionalContent) : base(book)
        {
            additional = additionalContent;
        }

        public override string GetTitle()
        {
            return $"{book.GetTitle()}\n add {additional};";
        }
    }
}
