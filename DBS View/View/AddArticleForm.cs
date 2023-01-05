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
            CmbArticleGroup.DataSource = articleVm.GetArticleGRoupNames();
        }
        public AddArticleForm(ArticleVm articleVm)
        {
            
            InitializeComponent();
            articleForm = new ArticleForm();
            this.articleVm = new ArticleVm();
            isArticleUpdated = true;

            CmbArticleGroup.Text = articleVm.ArticleGroup;
            TxtArticleName.Text = articleVm.Name;
            TxtArticleNr.Text = articleVm.Nr.ToString();
            TxtPrice.Text = articleVm.Price.ToString();
            TxtArticleNr.Enabled = false;
            CmbArticleGroup.DataSource = articleVm.GetArticleGRoupNames();
        }
        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (!articleVm.isArticleNrUsed(Convert.ToInt32(TxtArticleNr.Text)) && TxtArticleNr.TextLength > 0 && TxtArticleNr.Text.All(char.IsDigit))
            {
                articleVm.ArticleGroup = CmbArticleGroup.Text;
                articleVm.Name = TxtArticleName.Text;
                articleVm.Nr = Convert.ToInt32(TxtArticleNr.Text);

                if (TxtPrice.TextLength > 0 && !TxtPrice.Text.Any(char.IsLetter))
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
            else
            {
                MessageBox.Show(this,"Artikelnr bereits vergeben. Bitte andere Artikelnummer auswählen.");
            }
            
        }
    }
}
