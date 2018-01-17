using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebServicesCidades.Models;

namespace WebServicesCidades.Controllers
{
    [Route("api/[controller]")]

    public class PrimeiraController : Controller
    {
        Cidades cidades = new Cidades();
        DAOCidades dao = new DAOCidades();

        [HttpGet]
        public IEnumerable<Cidades> Get()
        {
            return dao.Listar();
        }

        [HttpGet("{id}")]
        public Cidades Get(int id)
        {
            return dao.Listar().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}