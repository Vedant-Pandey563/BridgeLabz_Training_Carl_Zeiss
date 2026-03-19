using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp
{
    public class BookAlreadyIssuedException : Exception
    {
        public BookAlreadyIssuedException(string message) : base(message)
        {
        }
    }
}

