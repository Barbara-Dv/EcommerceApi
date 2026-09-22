using EcommerceApi.Models;
using EcommerceApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PagamentosController : ControllerBase
{
    private readonly GatewayPagamentoService _gateway;

    public PagamentosController(GatewayPagamentoService gateway)
    {
        _gateway = gateway;
    }

    [HttpPost]
    public IActionResult ProcessarPagamento(
        PagamentoRequest pagamento)
    {
        var resultado = _gateway.ProcessarPagamento(pagamento);

        if (!resultado.Aprovado)
        {
            return BadRequest(resultado);
        }

        return Ok(resultado);
    }
}