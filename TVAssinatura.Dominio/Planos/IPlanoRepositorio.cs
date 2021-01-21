
namespace TVAssinatura.Dominio.Planos
{
    public interface IPlanoRepositorio
    {
        Plano ObterPlanoPorNome(string nome);
    }
}
