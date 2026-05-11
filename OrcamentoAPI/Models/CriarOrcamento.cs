namespace OrcamentoAPI.Models
{
    public class CriarOrcamento
    {
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public List<CriarOrcamentoItem> Itens { get; set; }
    }
}
