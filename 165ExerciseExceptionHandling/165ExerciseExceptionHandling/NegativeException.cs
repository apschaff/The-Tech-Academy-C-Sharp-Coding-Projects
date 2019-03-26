using System;

namespace _165ExerciseExceptionHandling
{
    public class NegativeException : Exception
    {
        public NegativeException()
            : base() { }
        public NegativeException(string message)
            : base(message) { }
    }
}
