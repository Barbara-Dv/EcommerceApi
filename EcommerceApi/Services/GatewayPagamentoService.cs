using EcommerceApi.Models;

namespace EcommerceApi.Services;

public class GatewayPagamentoService
{
    public PagamentoResponse ProcessarPagamento(PagamentoRequest pagamento)
    {
        if (string.IsNullOrEmpty(pagamento.Valor))
        {
            return new PagamentoResponse
            {
                Aprovado = false,
                Mensagem = "Valor não informado."
            };
        }

        if (!pagamento.Valor.All(char.IsDigit))
        {
            return new PagamentoResponse
            {
                Aprovado = false,
                Mensagem = "Formato de valor inválido."
            };
        }

        if (string.IsNullOrEmpty(pagamento.Moeda))
        {
            return new PagamentoResponse
            {
                Aprovado = false,
                Mensagem = "Moeda não informada."
            };
        }

        if (string.IsNullOrEmpty(pagamento.MetodoPagamento))
        {
            return new PagamentoResponse
            {
                Aprovado = false,
                Mensagem = "Método de pagamento não informado."
            };
        }

        return new PagamentoResponse
        {
            Aprovado = true,
            Mensagem = "Pagamento aprovado."
        };
    }
}