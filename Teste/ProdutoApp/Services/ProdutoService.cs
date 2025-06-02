/*
    @ Author: Israel Mendes
    @ Data: 02-06-2025
*/

using ProdutoApp.Models; 
using System.Collections.Generic;

namespace ProdutoApp.Services{
    public class ProdutoService {
        
        // Criação de um método para listar produtos
        public List<ProdutoGrid> ListarProdutosExemplo(int grupoId, int subgrupoId)
        {
            var produtos = new List<ProdutoGrid> {
                new ProdutoGrid { CodigoProduto = "001", DescricaoProduto = "Produto 1" },
                new ProdutoGrid { CodigoProduto = "002", DescricaoProduto = "Produto 2" },
                new ProdutoGrid { CodigoProduto = "003", DescricaoProduto = "Produto 3" },
                new ProdutoGrid { CodigoProduto = "004", DescricaoProduto = "Produto 4" },
                new ProdutoGrid { CodigoProduto = "005", DescricaoProduto = "Produto 5" }
            };

            return produtos;
        }
    }
}
