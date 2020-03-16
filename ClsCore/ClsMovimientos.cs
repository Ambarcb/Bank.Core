using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCore
{
    public class ClsMovimientos
    {
        public int ID { get; set; }
        public int IDCuenta { get; set; }
        public int IDTransaccion { get; set; }
        public float MontoTransaction { get; set; }
        public string InformacionTransaccion { get; set; }
    }
}
