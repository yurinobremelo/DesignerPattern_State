using DesignerPattern_State.Context;
using DesignerPattern_State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern_State.States
{
    public class PedidoEnviadoState: IPedidoState
    {
        public void AdicionarItem(PedidoState pedido, string item)
        {
            Console.WriteLine("Não é possível adicionar itens a um pedido já enviado.");
        }

        public void RemoverItem(PedidoState pedido, string item)
        {
            Console.WriteLine("Não é possível remover itens de um pedido já enviado.");
        }

        public void ProcessarPedido(PedidoState pedido)
        {
            Console.WriteLine("O pedido já foi enviado e não pode ser processado novamente.");
        }
    
    }
}
