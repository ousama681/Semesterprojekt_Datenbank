using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.Data;
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
                    ArticleGroup articleGroup = new ArticleGroup(articleGroupVm.Name, articleGroupVm.ParentId.ToString());
                    context.Add(articleGroup);

                    modelBuilder.Entity<ArticleGroup>().HasData(new ArticleGroup()
                    {
                        Name = articleGroup.Name,
                        ParentId = articleGroup.ParentId
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
                var articleGroupDeleteQuery = (from articleGroup in context.ArticleGroup
                                               where articleGroup.Name == articleGroupVm.Name
                                               select articleGroup).SingleOrDefault();
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
                        ArticleGroupVm articleGroupVm1 = new ArticleGroupVm(singleArticleGroup.Name, singleArticleGroup?.ParentId);
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
        public List<ArticleGroupVm> CteRead()
        {
            try
            {
                using (var context = new DataContext())
                {
                    List<ArticleGroupVm> articleGroupVmList = new List<ArticleGroupVm>();
                    //            var cte = @"with cte_Articlegroup (Id, parentId, Name) as (
                    //                        Select ArticleGroup.Id, ArticleGroup.parentId, ArticleGroup.Name
                    //                        From ArticleGroup
                    //                        where parentId is null

                    //                        Union ALL

                    //                        Select ArticleGroup.Id, ArticleGroup.ParentId, ArticleGroup.Name
                    //                        From ArticleGroup
                    //                        inner join cte_Articlegroup as cte 
                    //                        on cte.Id = ArticleGroup.parentId)

                    //                        Select cte_Articlegroup.Id, cte_Articlegroup.ParentId, cte_Articlegroup.Name from cte_Articlegroup
                    //order by Id;";

                    //            List<ArticleGroup>? result = context.ArticleGroup.FromSqlRaw(cte).ToList();
                    SqlConnection conn = new SqlConnection(DataContext.OUSAMA_CONNECTION);
                    SqlCommand cmd = new SqlCommand("Select * from dbo.ArticleGroups()", conn);
                    conn.Open();
                    IDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ArticleGroupVm articleGroupVm1 = new ArticleGroupVm((int)dr["Id"], dr["Name"].ToString(), dr["ParentId"].ToString());
                        articleGroupVmList.Add(articleGroupVm1);
                    }
                    context.SaveChanges();
                    conn.Close();
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
        public ArticleGroupVm ReadSingle(ArticleGroupVm articleGroupVm)
        {
            throw new NotImplementedException();
        }

        public int GetId(ArticleGroupVm articleGroupVm)
        {
            using (var context = new DataContext())
            {
                var getIdQuery = (from articleGroup in context.ArticleGroup
                    where articleGroupVm.Name == articleGroup.Name
                    select articleGroup.Id).SingleOrDefault();
                context.SaveChanges();
                return getIdQuery;
            }
        }

        public void Update(ArticleGroupVm item)
        {
            throw new NotImplementedException();
        }

        public static void ChangeArticleGroupName(string newName, string oldName)
        {
            var context = new DataContext();

            // ArticleGruppenach nach Name suchen und mit neuem Namen ersetzen
            (from a in context.ArticleGroup
                    where a.Name == oldName 
                    select a).ToList()
                .ForEach(x => x.Name = newName);

            // Änderungen speichern
            context.SaveChanges();
        }

    }
}

