using System;

namespace ExercíciosCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada: Escreva um numero");
            int numero = int.Parse(Console.ReadLine());
            int um = (numero * 1);
            int dois = (numero * 2);
            int tres = (numero * 3);
            int quatro = (numero * 4);            
            int cinco = (numero * 5);
            int seis = (numero * 6);
            int sete = (numero * 7);
            int oito = (numero * 8);
            int nove = (numero * 9);
            int dez = (numero * 10);

            System.Console.WriteLine("numero vezes um: "+ um);
            System.Console.WriteLine("numero vezes dois: "+ dois);
            System.Console.WriteLine("numero vezes tres: "+ tres);
            System.Console.WriteLine("numero vezes quatro: "+ quatro);
            System.Console.WriteLine("numero vezes cinco: "+ cinco);
            System.Console.WriteLine("numero vezes seis: "+ seis);
            System.Console.WriteLine("numero vezes sete: "+ sete);
            System.Console.WriteLine("numero vezes oito: "+ oito);
            System.Console.WriteLine("numero vezes nove: "+ nove);
            System.Console.WriteLine("numero vezes dez: "+ dez);
        }
    }
}
