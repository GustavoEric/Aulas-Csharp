using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoCRUD.DAL;
using projetoCRUD.Models;

namespace projetoCRUD.BLL
{
    internal class FilmeService
    {
        private readonly FilmeDAL _filmeDAL = new FilmeDAL();

        public Filme AdicionarFilme(Filme filme)
        {
            if (string.IsNullOrEmpty(filme.nomeFilme) || string.IsNullOrEmpty(filme.dataAssistido))
            {
                throw new ArgumentException("Nome do filme e data assistido não podem ser vazios.");
            }
            var filmeAdicionado = _filmeDAL.AdicionarFilme(filme);
            if (filmeAdicionado == null)
            {
                throw new Exception("Erro ao adicionar o filme.");
            }
            return filmeAdicionado;
        }

        public List<Filme> MostrarFilmes()
        {
            return _filmeDAL.MostrarFilmes();
        }

        public Filme EditarFilme(Filme filme)
        {
            if (string.IsNullOrEmpty(filme.nomeFilme) || string.IsNullOrEmpty(filme.dataAssistido))
            {
                throw new ArgumentException("Nome do filme e data assistido não podem ser vazios.");
            }
            _filmeDAL.EditarFilme(filme);
            return filme;
        }
        public void ExcluirFilme(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("ID do filme deve ser maior que zero.");
            }
            _filmeDAL.ExcluirFilme(id);
        }
    }
}
