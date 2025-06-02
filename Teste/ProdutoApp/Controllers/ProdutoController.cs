/*
    @ Author: Israel Mendes
    @ Data: 02-06-2025
    
 */

using Microsoft.AspNetCore.Mvc;
using ProdutoApp.Services;
using ProdutoApp.ViewModels;
using ProdutoApp.Utils;


namespace ProdutoApp.Controllers {
    public class ProdutoController : BaseController {
        private readonly ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Inicializar()
        {

            // Simula a inicialização de dados necessários para a tela de produto
            try
            {
                //Simula um erro propositadamente para teste
                //throw new Exception("Erro simulado para teste");

                var viewModel = new Produto();

                return Json(new
                {
                    sucesso = true,
                    permissoes = AcoesProduto,
                    usuario = UsuarioLogado.Chave
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    sucesso = false,
                    mensagem = ex.Message
                });
            }
        }

        public override List<string> AcoesProduto => new List<string> { "Pesquisar", "Salvar" };

        public override (string NomeTela, string CodigoModulo) InformacoesProduto => ("CADASTRO_PRODUTO", "PRD001");

        //Teste para retornar informações dos Produtos
        public JsonResult Informacoes()
        {
            var info = InformacoesProduto;
            return Json(new { NomeTela = info.NomeTela, CodigoModulo = info.CodigoModulo });
        }
        //Teste para retornar informações da Lista de Produtos
        public JsonResult Listar() {
            var produtos = _produtoService.ListarProdutosExemplo(1, 2); // Exemplo de IDs de grupo e subgrupo
            return Json(new { produtos });
        }

    }

}
