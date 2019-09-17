using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        public IEnumerable<string> ReturnQuote => throw new NotImplementedException();

    }
}
