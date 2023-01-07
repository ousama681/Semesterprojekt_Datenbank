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
        public string ParentName { get; set; }

        public ArticleGroupVm(string name, string parentName)
        {
            Name = name;
            ParentName = parentName;
        }

        public ArticleGroupVm() { }

        public void CreateArticleGroup(ArticleGroupVm articleGroupVm)
        {
            db.Create(articleGroupVm);
        }
        public List<ArticleGroupVm> GetArticleGroup()
        {
            return db.Read();
        }

    }
}
