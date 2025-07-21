using DesignerPattern_State.Context;
using DesignerPattern_State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern_State.States
{
    public class PedidoEmProcessamentoState: IPedidoState   
    {  
        public void AdicionarItem(PedidoState pedido, string item)
        {
            Console.WriteLine("Não é possível adicionar itens enquanto o pedido está em processamento.");
        }

        public void RemoverItem(PedidoState pedido, string item)
        {
            Console.WriteLine("Não é possível remover itens enquanto o pedido está em processamento.");
        }

        public void ProcessarPedido(PedidoState pedido)
        {
            Console.WriteLine("O pedido já está em processamento.");
            pedido.State = new PedidoEnviadoState(); 
        }
        
    }
}
