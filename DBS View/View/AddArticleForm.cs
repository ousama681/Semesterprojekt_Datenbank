using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;

namespace DBS_View.View
{
    public partial class AddArticleForm : Form
    {
        private ArticleVm articleVm;
        private ArticleForm articleForm;
        private bool isArticleUpdated;
        public AddArticleForm()
        {
            InitializeComponent();
            articleVm = new ArticleVm();
        }
        public AddArticleForm(ArticleVm articleVm)
        {
            InitializeComponent();
            articleForm = new ArticleForm();
            this.articleVm = new ArticleVm();
            isArticleUpdated = true;

            TxtArticleGroup.Text = "";
            TxtArticleName.Text = articleVm.Name;
            TxtArticleNr.Text = articleVm.Nr.ToString();
            TxtPrice.Text = articleVm.Price.ToString();
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            articleVm.Name = TxtArticleName.Text;
            if (TxtArticleNr.TextLength > 0 && TxtArticleNr.Text.All(char.IsDigit))
                articleVm.Nr = Convert.ToInt32(TxtArticleNr.Text);
            if (TxtArticleNr.TextLength > 0 && !TxtPrice.Text.Any(char.IsLetter))
                articleVm.Price = Convert.ToDecimal(TxtPrice.Text);

            if (isArticleUpdated != true)
            {
                articleVm.CreateArticle(articleVm);
            }
            else
            {
                articleVm.UpdateArticle(articleVm);
            }
            this.Close();
        }
    }
}
