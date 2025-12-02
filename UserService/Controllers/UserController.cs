using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : Controller
{
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        try
        {
            return Ok("teste ok");
        }
        catch (Exception ex)
        {
            //logger.LogError(ex, GetType().FullName);
            return BadRequest(new { Mensagem = "Erro ao requisitar dados" });
        }
    }
}