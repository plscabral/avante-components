using Microsoft.AspNetCore.Http;

namespace AvanteComponents.Api.Models.Financeiro
{
    public class DespesaModel
    {
    }

    public class DocumentoDespesaModel
    {
        public string IdDespesa { get; set; }
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Tamanho { get; set; }
        public string Caminho { get; set; }
        public IFormFile File { get; set; }
    }
}
