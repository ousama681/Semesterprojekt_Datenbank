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
    public class DBUtilityArticleGroup : IDBUtility<ArticleGroupVm>
    {
        ModelBuilder modelBuilder = new ModelBuilder();


        public void Create(ArticleGroupVm articleGroupVm)
        {
            try
            {
                using (var context = new DataContext())
                {
                    ArticleGroup articleGroup = new ArticleGroup(articleGroupVm.Name, articleGroupVm.ParentName);
                    context.Add(articleGroup);

                    modelBuilder.Entity<ArticleGroup>().HasData(new ArticleGroup()
                    {
                        Name = articleGroup.Name,
                        ParentName = articleGroup.ParentName
                    });
                    context.SaveChanges();
                    ArticleGroupVm.articleGroupList.Add(articleGroupVm);

                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Artikelgruppe konnte nicht gespeichert werden. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show("Artikelgruppe konnte nicht gespeichert werden. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return;
            }
        }

        public bool Delete(ArticleGroupVm articleGroupVm)
        {
            using (var context = new DataContext())
            {
                var articleGroupDeleteQuery = (from articlegroup in context.ArticleGroup
                                              where articlegroup.Name == articleGroupVm.Name
                                                  select articlegroup).SingleOrDefault();
                context.Remove(articleGroupDeleteQuery);
                context.SaveChanges();
                return true;
            }
        }

        public List<ArticleGroupVm> Read()
        {
            try
            {
                using (var context = new DataContext())
                {
                    List<ArticleGroupVm> articleGroupVmList = new List<ArticleGroupVm>();
                    var queryArticleGroup = (from articleGroup in context.ArticleGroup
                                             select articleGroup).ToList();

                    foreach (var singleArticleGroup in queryArticleGroup)
                    {
                        ArticleGroupVm articleGroupVm1 = new ArticleGroupVm(singleArticleGroup.Name, singleArticleGroup.ParentName);
                        articleGroupVmList.Add(articleGroupVm1);
                    }
                    context.SaveChanges();
                    return articleGroupVmList;
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
        public ArticleGroupVm ReadSingle(ArticleGroupVm customerVm)
        {
            throw new NotImplementedException();
        }

        public void Update(ArticleGroupVm item)
        {
            throw new NotImplementedException();
        }

    }
}

