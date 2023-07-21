using System.Collections.Generic;

public class NombreService
{
    public List<NombreModel> ObtenerNombres()
    {
        return new List<NombreModel>
        {
            new NombreModel { Id = 1, Nombre = "Juan" },
            new NombreModel { Id = 2, Nombre = "María" },
            new NombreModel { Id = 3, Nombre = "Carlos" }
        };
    }
}
