/*
    @ Author: Israel Mendes
    @ Data: 02-06-2025

 */

using Microsoft.AspNetCore.Mvc;

namespace ProdutoApp.Controllers {
    public class BaseController : Controller {
        public virtual List<string> AcoesProduto => new();
        public virtual (string NomeTela, string CodigoModulo) InformacoesProduto => ("", "");
    }
}