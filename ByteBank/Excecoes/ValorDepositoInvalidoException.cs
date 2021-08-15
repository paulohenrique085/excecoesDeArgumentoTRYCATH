using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Excecoes
{
    public class ValorDepositoInvalidoException : Exception
    {
        public ValorDepositoInvalidoException()
        {

        }

        public ValorDepositoInvalidoException(string message) : base(message)
        {
        }
    }
}
