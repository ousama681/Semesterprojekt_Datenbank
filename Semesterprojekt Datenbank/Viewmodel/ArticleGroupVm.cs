using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class ArticleGroupVm
    {

        public static List<ArticleGroupVm> articleGroupList = new List<ArticleGroupVm>();

        private DBUtilityArticleGroup db = new DBUtilityArticleGroup();

        public int Id { get; set; }
        public string Name { get; set; }
        public string? ParentId { get; set; } 

        public ArticleGroupVm(int id, string name, string? parentId)
        {
            Id = id;
            Name = name;
            ParentId = parentId;
        }

        public ArticleGroupVm(string name, string? parentId)
        {
            Name = name;
            ParentId = parentId;
        }

        public ArticleGroupVm() { }

        public void CreateArticleGroup(ArticleGroupVm articleGroupVm)
        {
            db.Create(articleGroupVm);

        }
        public List<ArticleGroupVm> GetArticleGroup()
        {
            return db.CteRead();
        }

        public bool DeleteArticleGroup(ArticleGroupVm articleGroupVm)
        {
            return db.Delete(articleGroupVm);
        }

        public int GetNodeId(ArticleGroupVm articleGroupVm)
        {
            return db.GetId(articleGroupVm);
        }

    }
}
