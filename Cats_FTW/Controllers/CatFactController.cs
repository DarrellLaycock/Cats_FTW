using Cats_FTW.Classes;
using Cats_FTW.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace Cats_FTW.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]//https://www.4sharing.ca,http://localhost:4200,http://localhost:3000/
    public class CatFactController : BaseController
    {
        // GET: api/CatFact
        /// <summary>
        /// Get a random Cat Image  and fact 
        /// </summary>
        /// <remarks>
        /// image is in base64 binary format
        /// </remarks>
        /// <returns></returns>
        [AllowAnonymous]
        [ResponseType(typeof(CatImageWithFact))]
        public async Task<IHttpActionResult> Get()
        {           
            CatFactGenerator catFactGenerator = new CatFactGenerator();           
            return Ok(catFactGenerator.GetRandomImageAndFact());
        }

        /*
        // GET: api/CatFact/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CatFact
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CatFact/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CatFact/5
        public void Delete(int id)
        {
        }
        */
    }
}
