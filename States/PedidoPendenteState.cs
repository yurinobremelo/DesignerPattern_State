using DesignerPattern_State.Context;
using DesignerPattern_State.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern_State.States
{
    public class PedidoPendenteState: IPedidoState
    {
        public void AdicionarItem(PedidoState pedido, string item)
        {
            pedido.Itens.Add(item);
            Console.WriteLine($"Item '{item}' adicionado ao pedido.");
        }

        public void RemoverItem(PedidoState pedido, string item)
        {
            if (pedido.Itens.Contains(item))
            {
                pedido.Itens.Remove(item);
                Console.WriteLine($"Item '{item}' removido do pedido.");
            }
            else
            {
                Console.WriteLine($"Item '{item}' não encontrado no pedido.");
            }
        }

        public void ProcessarPedido(PedidoState pedido)
        {
            if (pedido.Itens.Count == 0)
            {
                Console.WriteLine("Não é possível processar o pedido vazio.");
                return;
            }

            Console.WriteLine("Pedido saindo de pendente e indo para processamento !");
            pedido.State = new PedidoEmProcessamentoState(); // Transição para o estado de processamento
          
        }
    }
}
