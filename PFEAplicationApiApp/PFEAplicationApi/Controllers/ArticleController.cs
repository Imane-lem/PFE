using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PFEServices.Article.services;
using PFEServices.Models;

namespace PFEAplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticle _articleService;

        public ArticleController(IArticle article)
        {
            _articleService=article;
        }
        [HttpGet]
        [Route("GetArticle")]
        public async Task<ActionResult<List<ArticleDto>>> GetArticles()
        {
            return Ok(_articleService.GetArticle());
        }
        [HttpPost]
        [Route("AddArticle")]
        public async Task<ActionResult<ArticleDto>> AddArticle([FromBody]ArticleDto articleDto)
        {
            var result =  _articleService.GetArticle();
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpPut]
        [Route("UpdateArticle")]
        public async Task<ActionResult<ArticleDto>> UpdateArticle(int id,[FromBody]ArticleDto articleDto)
        {
            var result = await _articleService.UpdateArticle(id, articleDto);
            if (result == null)
                return BadRequest(result);
            else
                return Ok(result);
        }
        [HttpDelete]
        [Route("Delet")]
        public async Task<ActionResult<ArticleDto>> DeletArticle(int id)
        {
            var result = await _articleService.DeleteArticle(id);
            if (result == null)
                return NotFound();
            else
                return Ok(result);

        }




    }
}
