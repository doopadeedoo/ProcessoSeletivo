using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProcessoSeletivo.Models
{
    public class ProcessoSeletivoContext : DbContext
    {
        public ProcessoSeletivoContext (DbContextOptions<ProcessoSeletivoContext> options)
            : base(options)
        {
        }

        public DbSet<ProcessoSeletivo.Models.Categoria> Categoria { get; set; }
    }
}
