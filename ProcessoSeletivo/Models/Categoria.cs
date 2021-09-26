using System.Collections.Generic;
using System.Linq;

namespace ProcessoSeletivo.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();

        public Categoria()
        {

        }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AdicionarProduto(Produto pr)
        {
            Produtos.Add(pr);
        }
        public void ARemoverProduto(Produto pr)
        {
            Produtos.Remove(pr);
        }

    }
}
