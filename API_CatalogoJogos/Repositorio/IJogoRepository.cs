using API_CatalogoJogos.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CatalogoJogos.Repositorio
{
    public interface IJogoRepository : IDisposable
    {
        Task<List<Jogo>> obter(int pagina, int quantidade);

        Task<Jogo> obter(Guid id);

        Task<List<Jogo>> obter(string nome, string produtora);

        Task Inserir(Jogo jogo);

        Task Atualizar(Jogo jogo);

        Task Remover(Guid id);



    }
}
