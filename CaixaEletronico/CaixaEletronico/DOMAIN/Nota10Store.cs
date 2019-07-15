using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    class Nota10Store
    {
        private readonly IRepository<Nota10> _nota10repository;

        public Nota10Store (IRepository<Nota10> nota10repository)
        {
            _nota10repository = nota10repository;
        }

        public void Deposito (Nota10Dto dto)
        {
            var nota10 = new Nota10(dto.Valor);

            _nota10repository.Deposito(nota10);
        }

        public void Saque (Nota10Dto dto)
        {
             var nota10 = new Nota10(dto.Valor);

            _nota10repository.Saque(nota10);
        }
    }
}
