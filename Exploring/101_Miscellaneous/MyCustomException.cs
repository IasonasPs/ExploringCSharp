namespace Exploring._101_Miscellaneous
{
    internal class MyCustomException : Exception
    {
        public MyCustomException() : base("I am an exception without argument")
        {
            
        }

        public MyCustomException(string message) : base("I am an exception")
        {
        }
        public MyCustomException(string message,Exception inner) : base(message, inner) 
        {
            
        }





    }

    internal class MyBetterCustomexception : Exception
    {
        public MyBetterCustomexception() : base("I am a better exception (with no argument) compared to MyCustomException")
        {
        }

        public MyBetterCustomexception(string message) : base("I am a better exception compared to MyCustomException")
        {
            
        }


    }
}
