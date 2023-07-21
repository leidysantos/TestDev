// NombresController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class NombresController : ControllerBase
{
    private readonly NombreService _nombreService;

    public NombresController(NombreService nombreService)
    {
        _nombreService = nombreService;
    }

    [HttpGet]
    public ActionResult<List<NombreModel>> GetNombres()
    {
        var nombres = _nombreService.ObtenerNombres();
        return Ok(nombres);
    }
}
