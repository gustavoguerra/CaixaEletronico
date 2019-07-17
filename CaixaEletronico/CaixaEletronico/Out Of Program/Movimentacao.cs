using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public abstract class Movimentacao : IMovimentacao
    {
        public int Valor { get; set; }

        public void Deposito(int deposito)
        {
            Valor += deposito;
        }

        public void Saque(int saque)
        {
            Valor -= saque;
        }
    }
}
