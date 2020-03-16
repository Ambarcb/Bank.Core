using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCore
{
    public class ClsTransaccion
    {
        private int numeroTransaccion;

        public int NumeroTransaccion
        {
            get { return this.numeroTransaccion; }
            set { this.numeroTransaccion = value; }
        }


        private ETipoTransaccion tipoTransaccion;

        public ETipoTransaccion TipoTransaccion
        {
            get { return this.tipoTransaccion; }
            set { this.tipoTransaccion = value; }
        }

        private ClsCuenta cuentaOrigen;

        public ClsCuenta CuentaOrigen
        {
            get { return this.cuentaOrigen; }
            set { this.cuentaOrigen = value; }
        }

        private ClsCuenta cuentaDestino;

        public ClsCuenta CuentaDestino
        {
            get { return this.cuentaDestino; }
            set { this.cuentaDestino = value; }
        }

        private DateTime fechaRealizacion;

        public DateTime FechaRealizacion
        {
            get { return this.fechaRealizacion; }
            set { this.fechaRealizacion = value; }
        }

        private double monto;

        public double Monto
        {
            get { return this.monto; }
            set { this.monto = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        private EBanco banco;

        public EBanco Banco
        {
            get { return this.banco; }
            set { this.banco = value; }
        }

        private E_EstadoTransaccion estado;

        public E_EstadoTransaccion Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

    }
}
