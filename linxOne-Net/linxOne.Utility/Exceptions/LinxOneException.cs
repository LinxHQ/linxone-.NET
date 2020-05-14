using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Utility.Exceptions
{
   public class LinxOneException :Exception
    {
        public LinxOneException()
        {

        }
        public LinxOneException(string message):base(message)
        {

        }
        public LinxOneException(string message,Exception inner):base(message,inner)
        {

        }
    }
}
