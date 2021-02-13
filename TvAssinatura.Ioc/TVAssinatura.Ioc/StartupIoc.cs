using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TVAssinatura.Aplicacao.Clientes;
using TVAssinatura.Dados.Contextos;
using TVAssinatura.Dados.Repositorios;
using TVAssinatura.Dominio._Base;
using TVAssinatura.Dominio.Clientes;
using TVAssinatura.Dominio.Contratos;
using TVAssinatura.Dominio.Planos;
using TVAssinatura.Dominio.Planos.Canais;

namespace TVAssinatura.Ioc
{
    public static class StartupIoc
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration["ConnectionString"]));

            services.AddScoped(typeof(IRepositorio<>), typeof(RepositorioBase<>));
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<ICanalRepositorio, CanalRepositorio>();
            services.AddScoped<IPlanoRepositorio, PlanoRepositorio>();
            services.AddScoped<IContratoRepositorio, ContratoRepositorio>();

            services.AddScoped<ConsultaCliente>();

            ////Estudar ciclo de vida dos objetos
            //Scoped
            //Singleton
            //Transient
        }
    }
}
