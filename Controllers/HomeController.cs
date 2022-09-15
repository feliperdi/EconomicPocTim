using EconomicPocTim.Business;
using Microsoft.AspNetCore.Mvc;

namespace EconomicPocTim.Controllers
{
    [ApiController]
    [Route("[controller]")]


    public class HomeController : Controller
    {
        public FileBusiness _fileBusiness;
        HomeController(FileBusiness fileBusiness)
        {
            _fileBusiness = fileBusiness;
        }

        [HttpPost]
        public String PostNewDocumentAsync(IFormFile file)
        {
            _fileBusiness.
            return "";
        }
    }
}
