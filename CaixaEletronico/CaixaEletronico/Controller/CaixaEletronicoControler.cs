using CaixaEletronico.DOMAIN;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.Controller
{
    class CaixaEletronicoControler
    {
        public IRepository<Nota10> _nota10repository;
        public Nota10Store _nota10store;

        public CaixaEletronicoControler(IRepository<Nota10> nota10repository, Nota10Store nota10store)
        {
            _nota10repository = nota10repository;
            _nota10store = nota10store;
        }

        public void DepositoNota10(int nota10)
        {
            var saldo = _nota10repository.Getall();

            Nota10Dto dto = new Nota10Dto();

            dto.Valor = saldo.Valor + nota10;

            _nota10store.Deposito(dto);
        }


    }
}
