using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCore
{
    public class ClsCuenta
    {
        private int numeroCuenta;

        public int NumeroCuenta
        {
            get { return this.numeroCuenta; }
            set { this.numeroCuenta = value; }
        }

        private decimal balance;

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        private ClsCliente cliente;

        public ClsCliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }

        private DateTime fechaCreacion;

        public DateTime FechaCreacion
        {
            get { return this.fechaCreacion; }
            set { this.fechaCreacion = value; }
        }

        private ETipoCuenta tipoCuenta;

        public ETipoCuenta TipoCuenta
        {
            get { return this.tipoCuenta; }
            set { this.tipoCuenta = value; }
        }

        private DateTime fechaActualizacion;

        public DateTime FechaActualizacion
        {
            get { return this.fechaActualizacion; }
            set { this.fechaActualizacion = value; }
        }
    }
}
