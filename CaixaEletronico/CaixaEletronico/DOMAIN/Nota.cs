using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    class Nota
    {
        public int Tipo { get; private set; }
        public int Quantidade { get; private set; }

        public Nota (int tipo, int quantidade)
        {
            VarificaNota(quantidade, tipo);

            Tipo = tipo;
            Quantidade = quantidade;
        }

        public void VarificaNota(int quantidade, int tipo)
        {
            DomainException.When(quantidade % 10 != 0,"Quantidade incorreta !!");
            DomainException.When(quantidade <= 0, "Quatidade nao pode ser 0 ou menor que Zero !!");
            DomainException.When(tipo <= 0, "Tipo de Nota não pode ser Zero ou menor que Zero !!");
        }
    }
}
