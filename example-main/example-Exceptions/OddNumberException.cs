using System;
namespace ExceptionsTutorial
{
    public class OddNumberException : Exception // When creating exception, MUST have 3 constructors (empty, string, string | exception)
    {
        public int OddNumber { get; set; }

        public OddNumberException(int nbr)
            :base() {
            OddNumber = nbr;
        }

        public OddNumberException()
            : base() { }

        public OddNumberException(string Message)
            : base(Message) { }

        public OddNumberException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
        
    }
}
