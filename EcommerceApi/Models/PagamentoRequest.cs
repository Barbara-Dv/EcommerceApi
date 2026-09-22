namespace EcommerceApi.Models;

public class PagamentoRequest
{
    public int PedidoId { get; set; }

    public string Valor { get; set; } = "";

    public string Moeda { get; set; } = "";

    public string MetodoPagamento { get; set; } = "";
}