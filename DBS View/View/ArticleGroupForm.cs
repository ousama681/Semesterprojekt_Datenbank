using Semesterprojekt_Datenbank.Viewmodel;
using System.Xml.Linq;
using Syncfusion.Windows.Forms.Tools;


namespace DBS_View.View
{
    public partial class ArticleGroupForm : Form
    {
        ArticleGroupVm articleGroupVm;
        bool isAnyCheckboxSelected = false;
       

        public ArticleGroupForm()
        {
            InitializeComponent();
            articleGroupVm = new ArticleGroupVm();
        }

        private void CmdAddArticleGroup_Click(object sender, EventArgs e)
        {
            isAnyCheckboxSelected = false;
            foreach (TreeNodeAdv node in TrVArticleGroup.Nodes)
            {
                if (node.Checked == true)
                {
                    TreeNodeAdv newNode = new TreeNodeAdv(TxtAddArticleGroup.Text);
                    newNode.Tag = node.Text;
                    node.Nodes.Add(newNode);
                    isAnyCheckboxSelected = true;
                    articleGroupVm.CreateArticleGroup(new ArticleGroupVm(newNode.Text, newNode.Tag.ToString()));
                    node.Checked = false;
                }
                RekursiveCheckSelectedTreeNodes(node.Nodes);
            }

            if (isAnyCheckboxSelected == false)
            {
                TreeNodeAdv rootNode = new TreeNodeAdv(TxtAddArticleGroup.Text);
                rootNode.Tag = "none";
                TrVArticleGroup.Nodes.Add(rootNode);
                articleGroupVm.CreateArticleGroup(new ArticleGroupVm(rootNode.Text, rootNode.Tag.ToString()));
            }
            TrVArticleGroup.LabelEdit = false;
            TrVArticleGroup.ShowCheckBoxes = false;
        }

        private void RekursiveCheckSelectedTreeNodes(TreeNodeAdvCollection childNodeCollections)
        {
            foreach (TreeNodeAdv node in childNodeCollections)
            {
                if (node.Checked == true)
                {
                    TreeNodeAdv newNode = new TreeNodeAdv(TxtAddArticleGroup.Text);
                    newNode.Tag = node.Text;
                    node.Nodes.Add(newNode);
                    isAnyCheckboxSelected = true;
                    articleGroupVm.CreateArticleGroup(new ArticleGroupVm(newNode.Text, newNode.Tag.ToString()));
                    node.Checked = false;
                }
                if(node.Nodes.Count > 0)
                RekursiveCheckSelectedTreeNodes(node.Nodes);
            }
            
        }
        private void CmdDeleteArticleGroup_Click(object sender, EventArgs e)
        {
            isAnyCheckboxSelected = false;
            foreach (TreeNodeAdv node in TrVArticleGroup.Nodes)
            {
                if (node.Checked == true)
                {
                    ArticleGroupVm vm = new ArticleGroupVm(node.Text, node.Tag.ToString());
                    articleGroupVm.DeleteArticleGroup(vm);
                }
                RekursiveCheckSelectedTreeNodesForDeleting(node.Nodes);
            }
            TrVArticleGroup.LabelEdit = false;
            TrVArticleGroup.ShowCheckBoxes = false;
            LoadTreeView();
        }

        private void RekursiveCheckSelectedTreeNodesForDeleting(TreeNodeAdvCollection childNodeCollections)
        {
            foreach (TreeNodeAdv node in childNodeCollections)
            {
                if (node.Checked == true)
                {
                    ArticleGroupVm vm = new ArticleGroupVm(node.Text, node.Tag.ToString());
                    articleGroupVm.DeleteArticleGroup(vm);
                }

                if (node.Nodes.Count > 0)
                    RekursiveCheckSelectedTreeNodesForDeleting(node.Nodes);
            }
        }

        private void CmdSearchArticleGroup_Click(object sender, EventArgs e)
        {

        }

        private void ArticleGroupForm_Load(object sender, EventArgs e)
        {
            LoadTreeView();
        }


        private void LoadTreeView()
        {
            TrVArticleGroup.Nodes.Clear();

            var ArticleGroupList = articleGroupVm.GetArticleGroup();

            TreeNodeAdv node;
            List<TreeNodeAdv> nodes = new List<TreeNodeAdv>();
            if(ArticleGroupList != null)
            foreach (var articleGroupVm in ArticleGroupList)
            {
                node = new TreeNodeAdv(articleGroupVm.Name);
                node.Tag = articleGroupVm.ParentName;
                nodes.Add(node);
            }

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (nodes[i].Text == nodes[j].Tag.ToString())
                        nodes[i].Nodes.Add(nodes[j]);
                }
                if (nodes[i].Tag.ToString() == "none")
                    TrVArticleGroup.Nodes.Add(nodes[i]);
            }
        }

        private void CmdAdjustArticleGroups_Click(object sender, EventArgs e)
        {

            TrVArticleGroup.ShowCheckBoxes ^= true;
            TrVArticleGroup.LabelEdit ^= true;
        }

        
        private void TrVArticleGroup_AfterCheck(object sender, TreeNodeAdvEventArgs e)
        {
            if (isAnyCheckboxSelected) return;
            if (e.Node.Checked)
            {
                if (TrVArticleGroup.Nodes.Count > 0) UncheckAll(TrVArticleGroup.Nodes[0]);
                isAnyCheckboxSelected = true;
                e.Node.Checked = true;
                isAnyCheckboxSelected = false;
            }
        }
        void UncheckAll(TreeNodeAdv node)
        {
            if (node != null)
            {
                node.Checked = false;
                foreach (TreeNodeAdv item in node.Nodes)
                {
                    isAnyCheckboxSelected = true;
                    item.Checked = false;
                    if (item.Nodes.Count > 0) UncheckAll(item.Nodes[0]);
                }

                if (node.NextNode != null)
                    UncheckAll(node.NextNode);

            }
            isAnyCheckboxSelected = false;
        }
    }
}
