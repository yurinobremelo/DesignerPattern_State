using DesignerPattern_State.Interface;
using DesignerPattern_State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern_State.Context
{
    public class PedidoState
    {
        public List<string> Itens { get; private set; }
        public IPedidoState State { get; set; }
        public PedidoState()
        {
            Itens = new List<string>();
            State = new PedidoPendenteState(); // Estado inicial
        }
        public void AdicionarItem(string item)
        {
            State.AdicionarItem(this, item);
        }
        public void RemoverItem(string item)
        {
            State.RemoverItem(this, item);
        }
        public void ProcessarPedido()
        {
            State.ProcessarPedido(this);
        }
    }
}
