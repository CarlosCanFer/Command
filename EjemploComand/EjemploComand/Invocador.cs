using EjemploComand.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploComand
{
    public class Invocador
    {
        private IComandos _enInicio;

        private IComandos _enFin;

        public void SetEnInicio(IComandos comandos)
        {
            this._enInicio = comandos;
        }
        public void SetEnFin(IComandos comandos)
        {
            this._enFin = comandos;
        }

        public void HacerAlgoImportante()
        {
            if (this._enInicio is IComandos)
            {
                this._enInicio.Ejecutar();
            }            
            if (this._enFin is IComandos)
            {
                this._enFin.Ejecutar();
            }
        }
    }
}
