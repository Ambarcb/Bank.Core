using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCore
{
    public class ClsCliente
    {
        private string nombres;

        public string Nombres
        {
            get { return this.nombres; }
            set { this.nombres = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }

        private string identificador;

        public string Identificador
        {
            get { return this.identificador; }
            set { this.identificador = value; }
        }

        private ClsCuenta cuenta;

        public ClsCuenta Cuenta
        {
            get { return this.cuenta; }
            set { this.cuenta = value; }
        }

        private string cedula;

        public string Cedula
        {
            get { return this.cedula; }
            set { this.cedula = value; }
        }

        private string correo;

        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        private string sexo;

        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        private string estadoCivil;

        public string EstadoCivil
        {
            get { return this.estadoCivil; }
            set { this.estadoCivil = value; }
        }
    }
}
