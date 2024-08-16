using Microsoft.AspNetCore.Mvc;

namespace Cors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //public class ValuesController : ControllerBase
    public class ValuesController : Controller
    {
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITrancientService _trancient;

        public ValuesController(ISingletonService singleton, IScopedService scoped, ITrancientService trancient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _trancient = trancient;
        }

        //GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _singleton.GetGuid();
        }

        public IActionResult Index()
        {
            return View("Index", _singleton.GetGuid());
        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.GetGuid());
        }

        public IActionResult Tranciend()
        {
            return View("Trancient", _trancient.GetGuid());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<int> Get(int id)
        {
            return id;
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] SimpleClass value)
        {
            value.Response = value.Request;
            value.Request = "";
            return new OkObjectResult(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
