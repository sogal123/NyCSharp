using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.ExceptionClass
{
    public class SerializerException : Exception
    {
        public string fileName { get; }

        public SerializerException(string fileName, string message) : base(message)
        {
            this.fileName = fileName;
        }
    }
}
