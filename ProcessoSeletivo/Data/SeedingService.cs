using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProcessoSeletivo.Models;

namespace ProcessoSeletivo.Data
{
    public class SeedingService
    {
        private ProcessoSeletivoContext _context;

        public SeedingService(ProcessoSeletivoContext context)
        {
            _context = context;
        }

       
        public void Seed()
        {
            if (_context.Categoria.Any() ||
                _context.Produto.Any())
            {
                return;
            }

            Categoria c1 = new Categoria(new int(), "Alimentos");
            Categoria c2 = new Categoria(new int(), "Tecnologia");
            Categoria c3 = new Categoria(new int(), "Moda");
            Categoria c4 = new Categoria(new int(), "Turismo");


            Produto p1 = new Produto(new int(), "Camiseta Polo", 35.00, 50, c3);
            Produto p2 = new Produto(new int(), "Celular", 2455.00, 100, c2);
            Produto p3 = new Produto(new int(), "Sanduíche", 24.50, 10, c1);
            Produto p4 = new Produto(new int(), "Pacote de Viagens: Nordeste", 8650.00, 2, c4);

            _context.Categoria.AddRange(c1,c2,c3,c4);
            _context.Produto.AddRange(p1, p2, p3, p4);

            _context.SaveChanges();
        }
       
    }
}
