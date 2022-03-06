using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext context) : base(context)
        {
        }

        public IList<Produto> GetProdutos()
        {
            return dbset.ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {


            foreach (var livro in livros)
            {
                                

                if (!dbset.Where(l => l.Codigo == livro.Codigo).Any())
                {
                    dbset.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }

            }
            contexto.SaveChanges();

            
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}