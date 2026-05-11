namespace OrcamentoAPI.Dtos
{
    public class OrcamentoItemDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
