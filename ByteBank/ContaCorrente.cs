using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class ContaCorrente
    {
        public string Titular { get; set; }
        private double _saldo = 0;
        public double Saldo
        {
            get {
                return _saldo;
            }
            private set
            {
                if (value <= 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }

        }
        public int Agencia { get; }
        public int NumeroDaConta{get;}
        public static int _qtdeDeContas { get; private set; }
        public static double TaxaOperacao { get; private set; }
        
        public ContaCorrente(string titular,int numeroDaConta,int agencia)
        {
           
            if (agencia<=0)
            {  
             //lançador
                throw new ArgumentException("O argumento agencia deve ser maior que 0");
            }
            if (numeroDaConta<=0)
            {
                throw new ArgumentException("O argumento numeroDaConta deve ser maior que 0");
            }


            Titular = titular;
            NumeroDaConta = numeroDaConta;
            Agencia = agencia;

           _qtdeDeContas++;
        }

        public static  int QuantidadeDeContas()
        {
            return _qtdeDeContas;
        }
        public bool Depositar(double valorDeposito)
        {
            if (valorDeposito<=0)
            {
                Console.WriteLine("Valor inválido");
                return false;
            }
            else { 
                 Saldo += valorDeposito;
                return true;
            }
            
        }
        public bool Sacar(double valorSaque)
        {
            if (Saldo < valorSaque)
            {
                Console.WriteLine("Saldo insuficiente para saque, seu saldo é: " + Saldo);
                return false;
            }
            else
            { 
                Saldo -= valorSaque;
                return true;
            }
             
        }
    }
   
}
