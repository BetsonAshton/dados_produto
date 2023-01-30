using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados01.Entities
{
    public class Produto
    {
        private Guid _id;
        private string _nome;
        private decimal _preco;
        private int _quantidade;
        private DateTime _dataDeValidade;

        public Guid Id
        {
            set
            {
                if(value ==Guid.Empty)
                    throw new ArgumentNullException("O id do produto é obrigatorio");
                _id = value;
            }
            get=> _id;
        }

        public string Nome
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("O nome do produto é obrigatorio");
                _nome = value;
            }
            get => _nome;
        }
        public decimal Preco
        {
            set
            {
                if(value <= 0) 
                    throw new ArgumentException("O preço tem que ser maior que zero.");
                _preco = value;
            }
            get => _preco;
        }

        public int Quantidade
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("A quantidade do produto deve ser maior do que zero.");
                _quantidade = value;
            }
            get => _quantidade;
        }

        public DateTime DataDeValidade
        {
            set
            {
                if (value == DateTime.MinValue) throw new ArgumentException("Infome a validade do produto.");
                _dataDeValidade = value;
            }
            get => _dataDeValidade;
        }
    }
}
