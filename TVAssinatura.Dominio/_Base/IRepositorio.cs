using System.Collections.Generic;

namespace TVAssinatura.Dominio._Base
{
    public interface IRepositorio<TEntidade>
    {
        TEntidade ObterPorId(int id);
        List<TEntidade> ObterTodos();
        void Adicionar(TEntidade entity);
    }
}