using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Article.services
{
    public interface IArticle
    {
        List<ArticleDto> GetArticle();
        Task<ArticleDto> AddArticle(ArticleDto articleDto);
        Task<ArticleDto> UpdateArticle(int id, ArticleDto articleDto);
        Task<List<ArticleDto>> DeleteArticle(int id);
        Task<ArticleDto> GetArticleById(int id);
    }
}
