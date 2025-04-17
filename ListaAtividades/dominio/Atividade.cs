using ListaAtividades.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.dominio
{
    internal class Atividade
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public Situacao Situacao { get; set; }

        private readonly AtividadeRepositorio repositorio = new();

        public bool Criar()
        {
            //ValidarTitulo();
            if (!ValidarTitulo())
            {
                return false;
            }

            repositorio.Criar(Titulo);

            return true;
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId())
            {
                return false;
            }

            if (!ValidarSituacao())
            {
                return false;
            }

            Atividade atividadeEmAndamento = BuscarAtividadeEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.Id > 0 && atividadeEmAndamento.Situacao == novaSituacao)
            {
                return false;
            }
         
            repositorio.AtulizarSituacao(Id, (int) novaSituacao);

            return true;
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            return repositorio.BuscarAtividadeEmAndamento();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return repositorio.ListarAtividadesPendentes();
        }

        private bool ValidarId()
        {
            return Id > 0;
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(Titulo);
        }

        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluido;
        }

        private Situacao BuscarProximaSituacao()
        {
            return Situacao == Situacao.Pendente ? Situacao.Realizando : Situacao.Concluido;
        }
    }
}
