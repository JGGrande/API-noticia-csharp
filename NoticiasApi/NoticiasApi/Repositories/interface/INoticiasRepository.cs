using NoticiasApi.Moddel;

namespace NoticiasApi.Repositories.interfaces;

public interface INoticiasRepository
{
    IEnumerable<Noticia> BuscarTodas();
    Noticia? BuscarPorId(int id);

    int Adicionar(Noticia noticia);
    int Alterar(Noticia noticia);
    int Excluir(int id);

}
