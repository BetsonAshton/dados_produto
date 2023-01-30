using Dados01.Entities;
using Dados01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados01.Controller
{
    public class ProdutoController
    {
        public void CadastrarProduto(){

            try
            {
                Console.WriteLine("\n*** CADASTRO DO PRODUTO **\n");

                var produto = new Produto();

                produto.Id= Guid.NewGuid();

                Console.Write("Entre com o nome do produto....: ");
                produto.Nome = Console.ReadLine();

                Console.Write("Entre com o preco do produto...: ");
                produto.Preco = decimal.Parse(Console.ReadLine());

                Console.Write("Entre com a quantidade do produto...: ");
                produto.Quantidade = int.Parse(Console.ReadLine());

                Console.Write("Entre com a data de validade...: ");
                produto.DataDeValidade = DateTime.Parse(Console.ReadLine());

                var produtoRepository = new ProdutoRepository();
                produtoRepository.Inserir(produto);

                Console.WriteLine("\nProduto cadastrado com sucesso!");

               


            }
            catch(Exception e)
            { 

                Console.WriteLine("\nFalha ao cadastrar: " + e.Message);
            
            
            }
        
        }
    }
}
