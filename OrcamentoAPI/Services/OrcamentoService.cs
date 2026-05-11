using OrcamentoAPI.Dtos;
using OrcamentoAPI.Models;

namespace OrcamentoAPI.Services
{
    public class OrcamentoService : IOrcamentoService
    {
        private static int _idOrcamento = 1;
        private static int _idItem = 1;

        public OrcamentoDto CriarOrcamento(CriarOrcamento request)
        {
            var itens = request.Itens.Select(i => new OrcamentoItemDto
            {
                Id = _idItem++,
                Descricao = i.Descricao,
                Quantidade = i.Quantidade,
                ValorUnitario = i.ValorUnitario,
                ValorTotal = i.Quantidade * i.ValorUnitario
            }).ToList();

            return new OrcamentoDto
            {
                Id = _idOrcamento++,
                ClienteId = request.ClienteId,
                VeiculoId = request.VeiculoId,
                Status = "Aberto",
                ValorTotal = itens.Sum(i => i.ValorTotal),
                DataCriacao = DateTime.Now,
                Itens = itens
            };
        }
    }
}
