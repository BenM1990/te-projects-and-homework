using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class CreditCardValidationException : Exception
    {
        public CreditCardValidationException(string message) : base(message) { }
    }
}
