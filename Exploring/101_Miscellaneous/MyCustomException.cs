using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exploring._101_Miscellaneous
{
    internal class MyCustomException : Exception
    {
        public MyCustomException()
        {
            
        }

        public MyCustomException(string message) : base("I am an exception")
        {
        }
        public MyCustomException(string message,Exception inner) : base(message, inner) 
        {
            
        }





    }
}
