using Dados01.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados01.Repositories
{
    public class ProdutoRepository 
    {
        #region Atributos

        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BD07;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #endregion

        public void Inserir(Produto produto)
        {
            var query = @"
        INSERT INTO PRODUTO(ID, NOME, PRECO, QUANTIDADE, DATADEVALIDADE)
                VALUES(@Id, @Nome, @Preco, @Quantidade, @DataDeValidade)    
                ";
            
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, produto);
            }
        }

        public void Alterar(Produto produto)
        {
            var query = @"
                UPDATE PRODUTO
                SET
                NOME = @Nome,
                PRECO = @Preco,
                QUANTIDADE = @Quantidade,
                DATADEVALIDADE = @DataDeValidade
               WHERE
                ID = @Id
             ";

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, produto);
            }
        }

        public void Excluir(Produto produto)
        {
            var query = @"
                DELETE FROM PRODUTO
                WHERE ID = @Id
                ";

            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, produto);
            }
        }

        public List<Produto> Consultar()
        {
            var query = "SELECT * FROM PRODUTO";

            using(var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Produto>(query).ToList();
            }
        }
    }
}
