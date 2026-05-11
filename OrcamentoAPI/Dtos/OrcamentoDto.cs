namespace OrcamentoAPI.Dtos
{
    public class OrcamentoDto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public string Status { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<OrcamentoItemDto> Itens { get; set; }
    }
}
