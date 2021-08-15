using System;

namespace ByteBank.Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            TryCaths();
            
           
        }
        public static void TryCaths()
        {
            //experimentar
            try
            {
                ContaCorrente conta1 = new ContaCorrente("PAULO HENRIQUE SILVA DOS SANTOS", 1160397, 1234);
                conta1.Depositar(0);
            }
            //os caths mais específicos devem vir primeiro
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException ");
                Console.WriteLine(ex.Message);


            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ocorreu uma exceção do tipo SaldoInsuficienteException ");
            }
            catch (ValorDepositoInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ocorreu uma exceção do tipo ValorDepositoInvalidoException ");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
