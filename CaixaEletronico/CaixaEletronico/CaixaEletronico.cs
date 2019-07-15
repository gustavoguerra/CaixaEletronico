using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico
{
    public abstract class CaixaEletronico : IMovimentacao
    {
        public int Valor { get; set; }

        public void Deposito(int deposito)
        {
            deposito += Valor;
        }

        public int Saldo()
        {
            return 0;
        }

        public void Saque(int saque)
        {
            saque -= Valor;
        }


    }
}
