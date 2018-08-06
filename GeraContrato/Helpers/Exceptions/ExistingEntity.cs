using System;

namespace GeraContrato.Helpers.Exceptions
{
    public class ExistingEntityException : Exception
    {
        public ExistingEntityException() 
            : base()
        {

        }

        public ExistingEntityException(String message) 
            : base(message)
        {

        }
    }
}
