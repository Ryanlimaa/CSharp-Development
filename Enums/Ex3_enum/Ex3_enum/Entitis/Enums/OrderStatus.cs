using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_enum.Entitis.Enums
{
    internal enum OrderStatus : int
    {
        PendingPayment = 0, //Pagamento pendente
        Processing = 1, //Processando
        Shipped = 2, //Enviado
        Delivered = 3 //Entregue
    }
}
