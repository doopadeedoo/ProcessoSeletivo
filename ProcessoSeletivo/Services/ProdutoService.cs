using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProcessoSeletivo.Models;

namespace ProcessoSeletivo.Services
{
    public class ProdutoService
    {
        private readonly ProcessoSeletivoContext _context;

        public ProdutoService (ProcessoSeletivoContext context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.ToList();
        }

        public void Insert(Produto obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
