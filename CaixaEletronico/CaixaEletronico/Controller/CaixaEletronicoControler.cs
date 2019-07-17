using CaixaEletronico.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaixaEletronico.Controller
{
    class CaixaEletronicoControler
    {
        public IRepository<Nota> _notarepository;
        public NotaStore _notastore;

        public CaixaEletronicoControler(IRepository<Nota> notarepository, NotaStore notastore)
        {
            _notarepository = notarepository;
            _notastore = notastore;
        }

        public void Operacao(int nota, int tipo, int op)
        {
            var saldo = _notarepository.GetByQuantTipo(tipo);

            NotaDto dto = new NotaDto();

            //Verifica se é deposito ou saque
            if (op == 3)
                dto.Quantidade = saldo.Quantidade + nota;
            else
            {
                // Precisa fazer uma Validação de Saque antes
                dto.Quantidade = saldo.Quantidade - nota;
            }

            //Carrega o tipo de nota na DTO
            dto.Tipo = tipo;                      

            _notastore.Store(dto, op);
        }

        public IEnumerable<NotaDto> Saldo()
        {
            var saldo = _notarepository.GetAll();

            var viewmodel = saldo.Select(c => new NotaViewModel
            {
                Tipo = c.Tipo,
                Quantidade = c.Quantidade
            });

            return viewmodel;
        }


    }
}
