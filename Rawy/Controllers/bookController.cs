using core.Models;
using core.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repsotiry.GenaricReposiory;
using Repsotiry.spacification;

namespace Rawy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bookController : ControllerBase
    {
        private readonly IGenaricrepostry<Book> genaricrepostry;

        public bookController(IGenaricrepostry<Book> genaricrepostry)
        {
            this.genaricrepostry = genaricrepostry;
        }
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Book>>> getall()
        //{
        //    var books = await genaricrepostry.getallAsync();
        //    return Ok(books);

        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> getallwithspac()
        {
            var spac = new bookspacefcation();
            var books = await genaricrepostry.getallwithspacAsync(spac);
            return Ok(books);

        }


        //[HttpGet("{id}")]
        //public async Task<ActionResult<Book>> getbyid (int id){
        //    var book= await genaricrepostry.getbyidasync(id);
        //    return Ok(book);    
        //}

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> getbyidwithspac(int id)
        {
            var spac = new bookspacefcation(id);
            var book = await genaricrepostry.getbyidwithspacAsync(spac);
            return Ok(book);
        }

    }
}