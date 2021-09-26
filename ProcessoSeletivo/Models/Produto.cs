using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoSeletivo.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double ValorUnitario { get; set; }
        public int Estoque { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string nome, double valorUnitario, int estoque, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            ValorUnitario = valorUnitario;
            Estoque = estoque;
            Categoria = categoria;
        }
    }
      
}
