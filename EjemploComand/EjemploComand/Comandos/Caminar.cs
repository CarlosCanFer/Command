using EjemploComand.Interfaces;
using System;

namespace EjemploComand.Comandos
{
    public class Caminar : IComandos
    {
        private string _jugar = string.Empty;

        public Caminar(string jugar)
        {
            this._jugar = jugar;
        }

        public string comando => throw new NotImplementedException();

        public void Ejecutar()
        {
            Console.WriteLine("Caminando...");
        }
    }
}
