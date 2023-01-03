using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Semesterprojekt_Datenbank.Interfaces;

namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityArticle : IDBUtility<ArticleVm>
    {
        ModelBuilder modelBuilder = new ModelBuilder();

        public void Create(ArticleVm articleVm)
        {
            try
            {
                using (var context = new DataContext())
                {

                    var articlerArticleGroupId = GetArticleGroupId(context, articleVm);
                    Article article = new Article(articleVm.Name, articleVm.Nr, articleVm.Price, articlerArticleGroupId, MWST.TaxValue);
                    context.Add(article);
                    modelBuilder.Entity<Article>().HasData(new Article()
                    {
                        Nr = article.Nr,
                        Name = article.Name,
                        Price = article.Price,
                        ArticleGroupId = article.ArticleGroupId,
                        Mwst = article.Mwst
                    });
                    context.SaveChanges();
                    ArticleVm.ArticleList.Add(articleVm);
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Artikel konnte nicht gespeichert werden. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show("Artikel konnte nicht gespeichert werden. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return;
            }
        }

        private int GetArticleGroupId(DataContext context, ArticleVm articleVm)
        {
            var query = from articlegroup in context.ArticleGroups
                where articlegroup.Name == articleVm.ArticleGroup
                    select articlegroup;
            return Convert.ToInt32(query);
        }

        public bool Delete(ArticleVm articleVm)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var queryArticle = (from article in context.Articles
                        where article.Nr == articleVm.Nr
                        select article).SingleOrDefault();
                    context.Remove(queryArticle);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return false;
            }
        }

        public List<ArticleVm> Read()
        {
            try
            {
                using (var context = new DataContext())
                {
                    List<ArticleVm> articleVmList = new List<ArticleVm>();
                    var queryArticleList = (from article in context.Articles
                        select article).ToList();
                    foreach (var article in queryArticleList)
                    {
                        var queryArticleGroup = (from articleGroup in context.ArticleGroups
                            where article.Id == articleGroup.Id
                            select articleGroup).FirstOrDefault();

                        ArticleVm articleVm = new ArticleVm(article.Name, article.Nr, article.Price, queryArticleGroup.Name);
                        articleVmList.Add(articleVm);
                    }
                    return articleVmList;
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
        }

        public ArticleVm ReadSingle(ArticleVm articleVm)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var queryArticle = (from article in context.Articles
                                        where articleVm.Nr == article.Nr
                                            select article).SingleOrDefault();
                    var queryArticleGroup = (from articleGroup in context.ArticleGroups
                                            where articleGroup.Id == queryArticle.Id
                                                select articleGroup).FirstOrDefault();
                    ArticleVm vm = new ArticleVm(queryArticle.Name, queryArticle.Nr, queryArticle.Price, queryArticleGroup.Name);
                    return vm;
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
        }

        public void Update(ArticleVm articleVm)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var queryForArticle = (from article in context.Articles
                        where article.Nr == articleVm.Nr
                        select article).SingleOrDefault();
                    var queryForArticleGroup = (from articleGroup in context.ArticleGroups
                                                where articleVm.ArticleGroup ==  articleGroup.Name
                                                select articleGroup).FirstOrDefault();

                    queryForArticle.Nr = articleVm.Nr;
                    queryForArticle.Name = articleVm.Name;
                    queryForArticle.Price = articleVm.Price;
                    queryForArticle.ArticleGroupId = queryForArticleGroup.Id;
                    queryForArticle.Mwst = MWST.TaxValue;

                    context.SaveChanges();
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
            }
        }
    }
}
