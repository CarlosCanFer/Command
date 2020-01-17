using EjemploComand.Interfaces;
using System;

namespace EjemploComand.Comandos
{
    public class Correr : IComandos
    {
        private string _jugar = string.Empty;

        public Correr(string jugar)
        {
            this._jugar = jugar;
        }

        public string comando => throw new NotImplementedException();

        public void Ejecutar()
        {
            Console.WriteLine("Corriendo...");
        }
    }
}
