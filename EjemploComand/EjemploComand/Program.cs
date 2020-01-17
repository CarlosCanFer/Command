using EjemploComand.Comandos;
using System;

namespace EjemploComand
{
    class Program
    {
        static void Main(string[] args)
        {
            Invocador objinvocador = new Invocador();
            Receiver receiver = new Receiver();

            Console.WriteLine("Comandos principales");
            Console.WriteLine("      Caminar W");
            Console.WriteLine("      Correr Z");
            Console.WriteLine("      Disparar X");
            Console.WriteLine("      Golpear S");
            Console.WriteLine("      Saltar A\n");
            Console.WriteLine("      Salir Enter\n");

            Console.WriteLine("Iniciemos\n");
            var key = Console.ReadKey();
            while (Console.ReadKey(true).Key != ConsoleKey.Enter
                ) {
                while (Console.ReadKey(true).Key == ConsoleKey.A)
                {
                    objinvocador.SetEnInicio(new Saltar("Salta"));
                    objinvocador.HacerAlgoImportante();
                }
                while (Console.ReadKey(true).Key == ConsoleKey.W)
                {
                    objinvocador.SetEnInicio(new Caminar("Caminar"));
                    objinvocador.HacerAlgoImportante();
                }
                while (Console.ReadKey(true).Key == ConsoleKey.Z)
                {
                    objinvocador.SetEnInicio(new Correr("Correr"));
                    objinvocador.HacerAlgoImportante();
                }
                while (Console.ReadKey(true).Key == ConsoleKey.X)
                {
                    objinvocador.SetEnInicio(new Disparar("Disparar"));
                    objinvocador.HacerAlgoImportante();
                }
                while (Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    objinvocador.SetEnInicio(new Golpear("Golpear"));
                    objinvocador.HacerAlgoImportante();
                }
            }
            


            Console.ReadLine();
        }
    }
}
