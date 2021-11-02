using System;

namespace DataAccessLayer
{
    public class ValidatorException : Exception
    {
        public string Fält { get; }

        public ValidatorException(string fält, string message) : base(message)
        {
            Fält = fält;
        }

    }
}