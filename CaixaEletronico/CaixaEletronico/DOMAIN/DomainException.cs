using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    class DomainException : Exception
    {
        public DomainException(string error) : base(error)
        {

        }
        public static void When(bool hasError, string error)
        {
            if(hasError)
            {
                Console.WriteLine(error);
                throw new DomainException(error);
            }
        }



    }
}
