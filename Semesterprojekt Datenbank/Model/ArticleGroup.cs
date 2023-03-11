using System;
using System.Collections.Generic;

namespace Semesterprojekt_Datenbank.Model
{
    public class ArticleGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ParentId { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public ArticleGroup() { }

        public ArticleGroup(string name, string? parentId)
        {
            Name = name;
            ParentId = parentId;
        }
    }
}
