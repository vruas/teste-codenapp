using OrcamentoAPI.Models;

namespace OrcamentoAPI
{
    public class OrcamentoValidation
    {
        public List<string> Validar(CriarOrcamento request)
        {
            var erros = new List<string>();

            if (request.ClienteId <= 0)
                erros.Add("ClienteId é obrigatório.");

            if (request.VeiculoId <= 0)
                erros.Add("VeiculoId é obrigatório.");

            if (request.Itens == null || !request.Itens.Any())
                erros.Add("O orçamento deve ter pelo menos 1 item.");
            else
            {
                for (int i = 0; i < request.Itens.Count; i++)
                {
                    var item = request.Itens[i];
                    var prefixo = $"Item {i + 1}";

                    if (string.IsNullOrWhiteSpace(item.Descricao))
                        erros.Add($"{prefixo}: descrição é obrigatória.");

                    if (item.Quantidade <= 0)
                        erros.Add($"{prefixo}: quantidade deve ser maior que zero.");

                    if (item.ValorUnitario <= 0)
                        erros.Add($"{prefixo}: valor unitário deve ser maior que zero.");
                }
            }

            return erros;
        }
    }
}
