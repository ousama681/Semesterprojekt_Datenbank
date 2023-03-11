using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityArticle : IDBUtility<ArticleVm>
    {
        ModelBuilder modelBuilder = new ModelBuilder();
        MWST mwst = new MWST();

        public bool Create(ArticleVm orderVM)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var articleGroupId = GetArticleGroupId(context, orderVM);
                    Article article = new Article(orderVM.Name, orderVM.Nr, orderVM.Price, articleGroupId, 1, DateTime.Now);
                    context.Add(article);
                    modelBuilder.Entity<Article>().HasData(new Article()
                    {
                        Nr = article.Nr,
                        Name = article.Name,
                        Price = article.Price,
                        ArticleGroupId = article.ArticleGroupId,
                        Mwstid = article.Mwstid,
                        DateTime = article.DateTime
                    });
                    context.SaveChanges();
                    ArticleVm.ArticleList.Add(orderVM);
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Artikel konnte nicht gespeichert werden. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Artikel konnte nicht gespeichert werden. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return false;
            }

            return true;
        }

        private int GetArticleGroupId(DataContext context, ArticleVm articleVm)
        {
            var query = (from articlegroup in context.ArticleGroup
                         where articlegroup.Name == articleVm.ArticleGroup
                         select articlegroup.Id).FirstOrDefault();
            return query;
        }

        public bool Delete(ArticleVm articleVm)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var queryArticle = (from article in context.Article
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
        public List<string> ReadArticleGroup()
        {
            try
            {
                using (var context = new DataContext())
                {
                    return (from articleGroup in context.ArticleGroup 
                            select articleGroup.Name).ToList();
                    
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
        public List<ArticleVm> Read()
        {
            try
            {
                using (var context = new DataContext())
                {
                    List<ArticleVm> articleVmList = new List<ArticleVm>();
                    var queryArticleList = (from article in context.Article
                                            select article).ToList();
                    foreach (var article in queryArticleList)
                    {
                        var queryArticleGroup = (from articleGroup in context.ArticleGroup
                                                 where article.ArticleGroupId == articleGroup.Id
                                                 select articleGroup).FirstOrDefault();

                        ArticleVm articleVm = new ArticleVm(article.Name, article.Nr, article.Price, queryArticleGroup.Name, article.DateTime);
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
                    var queryArticle = (from article in context.Article
                                        where articleVm.Nr == article.Nr
                                        select article).SingleOrDefault();
                    var queryArticleGroup = (from articleGroup in context.ArticleGroup
                                             where articleGroup.Id == queryArticle.ArticleGroupId
                                             select articleGroup).FirstOrDefault();
                    ArticleVm vm = new ArticleVm(queryArticle.Name, queryArticle.Nr, queryArticle.Price, queryArticleGroup.Name, queryArticle.DateTime);
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
                    var queryForArticle = (from article in context.Article
                                           where article.Nr == articleVm.Nr
                                           select article).SingleOrDefault();
                    var queryForArticleGroup = (from articleGroup in context.ArticleGroup
                                                where articleVm.ArticleGroup == articleGroup.Name
                                                select articleGroup).FirstOrDefault();

                    queryForArticle.Nr = articleVm.Nr;
                    queryForArticle.Name = articleVm.Name;
                    queryForArticle.Price = articleVm.Price;
                    queryForArticle.ArticleGroupId = queryForArticleGroup.Id;
                    queryForArticle.Mwstid = 1;

                    context.SaveChanges();
                    ArticleVm.ArticleList = Read();
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

        public static Article FindArticle(string articleName)
        {
            using (var context = new DataContext())
            {
                return (from a in context.Article
                        where a.Name == articleName
                        select a).SingleOrDefault();
            }
        }

        public List<string> ReadFilter(List<string> item)
        {
            throw new NotImplementedException();
        }
    }
}
