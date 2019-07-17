using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico.DOMAIN
{
    class NotaStore
    {
        private readonly IRepository<Nota> _notarepository;

        public NotaStore(IRepository<Nota> notarepositoru)
        {
            _notarepository = notarepositoru;
        }

        public void Store(NotaDto dto, int op)
        {
            var nota = new Nota(dto.Tipo, dto.Quantidade);

            if (op == 3)
                _notarepository.Deposito(nota);
            else
                _notarepository.Saque(nota);
        }
        
    }
}
