using System.Net;
using Microsoft.AspNetCore.Mvc;
using IronPdf;

namespace ironPdf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [ProducesResponseType(typeof(byte[]), (int) HttpStatusCode.OK)]
        public ActionResult Get()
        {
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            var PDF = Renderer.RenderHtmlAsPdf("<h1>Hello World</h1>");
            return File(PDF.BinaryData, "application/pdf", "download.pdf");
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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