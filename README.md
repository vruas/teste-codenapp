**Questões 1 a 5 estão no bloco de notas testecodenapp.txt neste repositório em caso de problemas com envio via plataforma**

**QUESTÃO 6**

**Como testar a API pelo Swagger**

Acessa `https://localhost:7213/swagger` com o projeto rodando e siga os passos:

---

**1. Escolha o endpoint**

Clica em `POST /api/orcamentos` para expandir.

---

**2. Habilita a edição**

Clica no botão `Try it out` no canto superior direito do endpoint.

---

**3. Edita o body**

Apaga o conteúdo padrão e cola o JSON abaixo:

```json
{
  "clienteId": 10,
  "veiculoId": 25,
  "itens": [
    {
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120.00
    },
    {
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45.00
    }
  ]
}
```

---

**4. Executa**

Clica em `Execute`.

---

**5. Resultado esperado — `201 Created`**

```json
{
  "id": 1,
  "clienteId": 10,
  "veiculoId": 25,
  "status": "Aberto",
  "valorTotal": 165,
  "dataCriacao": "2026-05-11T18:01:45.817-03:00",
  "itens": [
    {
      "id": 1,
      "descricao": "Troca de óleo",
      "quantidade": 1,
      "valorUnitario": 120,
      "valorTotal": 120
    },
    {
      "id": 2,
      "descricao": "Filtro de óleo",
      "quantidade": 1,
      "valorUnitario": 45,
      "valorTotal": 45
    }
  ]
}
```

---

**6. Teste de erro — cola esse e executa novamente**

```json
{
  "clienteId": 0,
  "veiculoId": 25,
  "itens": []
}
```

Resultado esperado — `400 Bad Request`:

```json
{
  "mensagem": "Dados inválidos.",
  "erros": [
    "ClienteId é obrigatório.",
    "O orçamento deve ter pelo menos 1 item."
  ]
}
```
