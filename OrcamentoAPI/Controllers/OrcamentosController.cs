using Microsoft.AspNetCore.Mvc;
using OrcamentoAPI.Models;
using OrcamentoAPI.Services;
using System.ComponentModel.DataAnnotations;

namespace OrcamentoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrcamentosController : ControllerBase
{
    private readonly IOrcamentoService _orcamentoService;
    private readonly OrcamentoValidation _validation;

    public OrcamentosController(IOrcamentoService orcamentoService, OrcamentoValidation validation)
    {
        _orcamentoService = orcamentoService;
        _validation = validation;
    }

    [HttpPost]
    public IActionResult CriarOrcamento([FromBody] CriarOrcamento request)
    {
        var erros = _validation.Validar(request);

        if (erros.Any())
            return BadRequest(new { Mensagem = "Dados inválidos.", Erros = erros });

        var resultado = _orcamentoService.CriarOrcamento(request);

        return CreatedAtAction(nameof(CriarOrcamento), new { id = resultado.Id }, resultado);
    }
}
