namespace _03.RangeExceptions
{
    using System;
    
    public class InvalidRangeException<T> : ApplicationException
    {
        public InvalidRangeException(string message)
            : base(message)
        {

        }

        public InvalidRangeException(string message, Exception ex)
            : base(message, ex)
        {

        }

        public string InvalidRangeDescription { get; set; }
    }
}
