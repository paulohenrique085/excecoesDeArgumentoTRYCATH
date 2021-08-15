using System;
using System.Collections.Generic;
using System.Text;


namespace ByteBank.Excecoes
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
        
        public ContaCorrente(string titular,int numeroDaConta,int numeroagencia)
        {
           
            if (numeroDaConta <= 0)
            {  
              //lançador
                throw new ArgumentException("O argumento numeroDaConta deve ser maior que 0", nameof(numeroDaConta));
            }
            if (numeroagencia <= 0)
            {                                                                                                               
                throw new ArgumentException("O argumento numeroagencia deve ser maior que 0", nameof(numeroagencia));
            }


            Titular = titular;
            NumeroDaConta = numeroDaConta;
            Agencia = numeroagencia;

           _qtdeDeContas++;
            TaxaOperacao = 30 / _qtdeDeContas;
        }

        public static int QuantidadeDeContas()
        {
            return _qtdeDeContas;
        }
        public void Depositar(double valorDeposito)
        {
            if (valorDeposito<=0)
            {
                throw new ValorDepositoInvalidoException("O valor a ser depositado é menor que 0");
            }
            else {
                Saldo += valorDeposito;
            }
            
        }
        public void Sacar(double valorSaque)
        {
            if (Saldo < valorSaque)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para o valor de "+valorSaque);
            }
            else
            { 
                Saldo -= valorSaque;
              
            }
             
        }
    }
   
}
