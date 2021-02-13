using System.Threading.Tasks;

namespace TVAssinatura.Dominio._Base
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
