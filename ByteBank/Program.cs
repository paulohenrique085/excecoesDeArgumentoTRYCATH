﻿using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                ContaCorrente conta1 = new ContaCorrente("PAULO HENRIQUE SILVA DOS SANTOS",0,1234);
            }
            //os caths mais específicos devem vir primeiro
            catch (ArgumentException ex)
            {   
                Console.WriteLine("Argumento com problema: "+ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException ");
                Console.WriteLine(ex.Message);


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
           
        }
    }
}
