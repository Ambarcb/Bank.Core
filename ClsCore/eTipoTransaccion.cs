using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsCore
{
    public enum ETipoTransaccion
    {
        Deposito,
        Retiro,
        DepositoFueraLinea,
        RetiroFueraLinea,
        EBanking_Interna,
        EBanking_Externa
    }
}
