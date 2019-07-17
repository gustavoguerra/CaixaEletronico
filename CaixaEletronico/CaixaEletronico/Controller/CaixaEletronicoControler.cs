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

        /// <summary>
        /// Recebe as informações que vem do usuario
        /// operação "Saque ou Deposito"
        /// Tipo da nota "10 ,20, 50...."
        /// Valor "Depende do tipo de operação será $ para saque e Quant para Deposito"
        /// </summary>
        /// <param name="valor">Valor em $ ou Qnt</param>
        /// <param name="tiponota">Tipo da Nota 50 20 etc</param>
        /// <param name="op">Tipo de Operalção "Saque ou Deposito"</param>
        public void Operacao(int valor, int tiponota, int op)
        {
            NotaDto dto = new NotaDto();
         
            if (op == 3) // Si Deposito
            {
                /* Criar uma uma validação as notas antes de fazer a incluzao */
                var saldo = _notarepository.GetByQuantTipo(tiponota);
                dto.Quantidade = saldo.Quantidade + valor;
                dto.Tipo = tiponota;

                _notastore.Store(dto, op);
            }
            else // Senão Saque
            {
                /* Crair a validação das notas para o saque*/

                // A Chamada devera está dentro de um laço para atualizar o saldo de todas as notas
                _notastore.Store(dto, op);
            }            
        }

        /// <summary>
        /// Retorna Saldo para View
        /// </summary>
        /// <returns></returns>
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
