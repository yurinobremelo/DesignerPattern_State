using DesignerPattern_State.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern_State.Interface
{
    public interface IPedidoState
    {
        void AdicionarItem(PedidoState pedido, string item);
        void RemoverItem(PedidoState pedido, string item);
        void ProcessarPedido(PedidoState pedido);
    }
}
