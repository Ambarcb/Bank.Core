using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCore
{
    public class ClsPerfil
    {

        private string identificador;

        public string Identificador
        {
            get { return this.identificador; }
            set { this.identificador = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private EAccesibilidad accesibilidad;

        public EAccesibilidad Accesibilidad
        {
            get { return accesibilidad; }
            set { accesibilidad = value; }
        }

    }
}
