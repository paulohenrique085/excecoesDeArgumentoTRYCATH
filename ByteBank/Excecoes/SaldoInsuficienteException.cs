using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Excecoes
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string message) : base(message)
        {
        }
    }
}
