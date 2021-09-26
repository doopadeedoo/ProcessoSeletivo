using ProcessoSeletivo.Models;
using System.Collections.Generic;
using System.Linq;


namespace ProcessoSeletivo.Services
{
    public class CategoriaService
    {
        private readonly ProcessoSeletivoContext _context;

        public CategoriaService(ProcessoSeletivoContext context)
        {
            _context = context;
        }

        public List<Categoria> FindAll()
        {
            return _context.Categoria.OrderBy(x => x.Nome).ToList();
        }
    }
}
