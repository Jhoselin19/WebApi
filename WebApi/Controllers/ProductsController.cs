using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //con el action, la ruta identificara los otros endpoints
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //funcion -> endpoint
        //este es un endpoint
        [HttpGet(Name = "Get")]
        public List<string> Get()
        {
            List<string> strings = new List<string>();
            strings.Add("Manzana");
            return strings;
        }
    }
}

//carpeta models
//agregar modelo de person
//agregar controlador tipo People
//endpoint de tipo listar para traer 100 personas
//forech