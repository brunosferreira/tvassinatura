﻿using System.Threading.Tasks;
using TVAssinatura.Dominio._Base;

namespace TVAssinatura.Dados.Contextos
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

    }
}
