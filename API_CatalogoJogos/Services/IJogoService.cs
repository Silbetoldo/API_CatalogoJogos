using API_CatalogoJogos.InputModel;
using API_CatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_CatalogoJogos.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> obter(int pagina, int quantidade);

        Task<JogoViewModel> obter(Guid id);

        Task<JogoViewModel> Inserir(JogoInputModel Jogo);

        Task Atualizar(Guid id, JogoInputModel jogo);

        Task Atualizar(Guid id, double preco);


        Task Remover(Guid id);


    }
}
