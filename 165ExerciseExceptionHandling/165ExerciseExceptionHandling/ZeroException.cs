using System;

namespace _165ExerciseExceptionHandling
{
    public class ZeroException : Exception
    {
        public ZeroException()
            : base() { }
        public ZeroException(string message)
            : base(message) { }
    }
}
