﻿using System.Linq;
using TVAssinatura.Dados.Contextos;
using TVAssinatura.Dominio.Clientes;

namespace TVAssinatura.Dados.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ApplicationDbContext context) : base(context)
        {
        }

        public Cliente ObterPorCpf(string cpf)
        {
            var cliente = Context.Set<Cliente>().Where(c => c.Cpf == cpf);
            return cliente.Any() ? cliente.First() : null;
        }
    }
}
