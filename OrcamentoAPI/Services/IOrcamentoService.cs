using OrcamentoAPI.Dtos;
using OrcamentoAPI.Models;

namespace OrcamentoAPI.Services
{
    public interface IOrcamentoService
    {
        OrcamentoDto CriarOrcamento(CriarOrcamento request);
    }
}
