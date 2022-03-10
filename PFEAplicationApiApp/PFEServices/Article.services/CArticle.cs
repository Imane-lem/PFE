using PFEDal.Modeles;
using PFEServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFEServices.Article.services
{
    public class CArticle : IArticle
    {

        private readonly PfeDbContext _pfeContext;
        public CArticle(PfeDbContext pfeDbContext)
        {
            _pfeContext = pfeDbContext;
        }

        public async Task<ArticleDto> AddArticle(ArticleDto articleDto)
        {
            var article=new PFEDal.Modeles.Article()
            {
                ArticleId=articleDto.ArticleId,
                Designation=articleDto.Designation,
                Famille=articleDto.Famille,
                Prix=articleDto.Prix,
                QET_Min=articleDto.QET_Min,
                QTE_Stock=articleDto.QTE_Stock,
            };
            _pfeContext.Articles.Add(article);
            _pfeContext.SaveChanges();
            return articleDto;
            
        }

        public Task<List<ArticleDto>> DeleteArticle(int id)
        {
            var article = _pfeContext.Articles.FirstOrDefault(x => x.ArticleId == id);
            if (article == null)
                return null;
            _pfeContext.Articles.Remove(article);
            _pfeContext.SaveChanges();
            return null;

        }

        public List<ArticleDto> GetArticle()
        {
            var article = _pfeContext.Articles.ToList();
            var result = article.Select(x => new ArticleDto()
            {
                ArticleId=x.ArticleId,
                Designation=x.Designation,
                Prix=x.Prix,
                Famille=x.Famille,
                QET_Min=x.QET_Min,
                QTE_Stock=x.QTE_Stock,

            });
            return result.ToList();
          
        }

        public async Task<ArticleDto> GetArticleById(int id)
        {
            var article = _pfeContext.Articles.FirstOrDefault(x => x.ArticleId == id);
            if (article == null)
                return null;
            var result = new ArticleDto()
            {
                ArticleId = article.ArticleId,
                Designation=article.Designation,
                Famille=article.Famille,
                Prix=article.Prix,
                QET_Min=article.QET_Min,
                QTE_Stock=article.QTE_Stock,

                

            };
            return result; 
        }

        public async Task<ArticleDto> UpdateArticle(int id, ArticleDto articleDto)
        {
            var article = _pfeContext.Articles.FirstOrDefault(x => x.ArticleId == id);
            if (article == null)
                return null;
            article.ArticleId = articleDto.ArticleId;
            article.Designation = articleDto.Designation;
            article.Prix= articleDto.Prix;
            article.QTE_Stock = articleDto.QTE_Stock;
            article.QET_Min= articleDto.QET_Min;
            article.Famille= articleDto.Famille;
            _pfeContext.Articles.Add(article);
            _pfeContext.SaveChanges();
            return articleDto;
            
           
        }
    }
}
