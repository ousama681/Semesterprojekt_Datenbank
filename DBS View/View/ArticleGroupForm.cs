using Semesterprojekt_Datenbank.Viewmodel;
using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;
using System.Xml.Linq;
using Semesterprojekt_Datenbank;
using Semesterprojekt_Datenbank.Utilities;


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
            foreach (TreeNode node in TrVArticleGroup.Nodes)
            {
                if (node.Checked == true)
                {
                    isAnyCheckboxSelected = true;
                    TreeNode newNode = new TreeNode(TxtAddArticleGroup.Text);
                    newNode.Tag = node.ImageIndex; //ImageIndex == ID Node == newNode ParentID      (ノಠ益ಠ)ノ彡┻━┻    H.E.L.P
                    ArticleGroupVm vm = new ArticleGroupVm(newNode.Text, newNode.Tag?.ToString());
                    articleGroupVm.CreateArticleGroup(vm);
                    newNode.ImageIndex = articleGroupVm.GetNodeId(vm);
                    node.Nodes.Add(newNode);
                    node.Checked = false;
                }
                RekursiveCheckSelectedTreeNodes(node.Nodes);
            }
            if (isAnyCheckboxSelected == false)
            {
                TreeNode rootNode = new TreeNode(TxtAddArticleGroup.Text);
                rootNode.Tag = null;
                ArticleGroupVm vm = new ArticleGroupVm(rootNode.Text, rootNode.Tag?.ToString());
                articleGroupVm.CreateArticleGroup(vm);
                rootNode.ImageIndex = articleGroupVm.GetNodeId(vm);
                TrVArticleGroup.Nodes.Add(rootNode);
            }
            TrVArticleGroup.LabelEdit = false;
        }

        private void RekursiveCheckSelectedTreeNodes(TreeNodeCollection childNodeCollections)
        {
            foreach (TreeNode node in childNodeCollections)
            {
                if (node.Checked == true)
                {
                    isAnyCheckboxSelected = true;
                    TreeNode newNode = new TreeNode(TxtAddArticleGroup.Text);
                    newNode.Tag = node.ImageIndex;
                    ArticleGroupVm vm = new ArticleGroupVm(newNode.Text, newNode.Tag?.ToString());
                    articleGroupVm.CreateArticleGroup(vm);
                    newNode.ImageIndex = articleGroupVm.GetNodeId(vm);
                    node.Nodes.Add(newNode);
                    node.Checked = false;
                }
                if(node.Nodes.Count > 0)
                RekursiveCheckSelectedTreeNodes(node.Nodes);
            }
        }

        private void CmdDeleteArticleGroup_Click(object sender, EventArgs e)
        {
            isAnyCheckboxSelected = false;
            foreach (TreeNode node in TrVArticleGroup.Nodes)
            {
                if (node.Checked == true)
                {
                    ArticleGroupVm vm = new ArticleGroupVm(node.Text, node.Tag?.ToString());
                    articleGroupVm.DeleteArticleGroup(vm);
                }
                RekursiveCheckSelectedTreeNodesForDeleting(node.Nodes);
            }
            TrVArticleGroup.LabelEdit = false;
            TrVArticleGroup.CheckBoxes = false;
            LoadTreeView();
        }

        private void RekursiveCheckSelectedTreeNodesForDeleting(TreeNodeCollection childNodeCollections)
        {
            foreach (TreeNode node in childNodeCollections)
            {
                if (node.Checked == true)
                {
                    ArticleGroupVm vm = new ArticleGroupVm(node.Text, node.Tag?.ToString());
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
            CmdAddArticleGroup.Enabled = false;
            CmdChangeArticleGrpName.Enabled = false;
            CmdDeleteArticleGroup.Enabled = false;
            TxtAddArticleGroup.Enabled = false;
            TxtArticleGroupName.Enabled = false;
        }

        private void LoadTreeView()
        {
            TrVArticleGroup.Nodes.Clear();
            var ArticleGroupList = articleGroupVm.GetArticleGroup();
            TreeNode node;
            List<TreeNode> nodes = new List<TreeNode>();
            if (ArticleGroupList != null)
                foreach (var articleGroupVm in ArticleGroupList)
                {
                    node = new TreeNode(articleGroupVm.Name);
                    node.Tag = articleGroupVm.ParentId;
                    node.ImageIndex = articleGroupVm.Id;
                    nodes.Add(node);
                }

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (nodes[i].ImageIndex.ToString() == nodes[j].Tag.ToString())
                        nodes[i].Nodes.Add(nodes[j]);
                }
                if (nodes[i].Tag == "")
                    TrVArticleGroup.Nodes.Add(nodes[i]);
            }
        }

        private void CmdAdjustArticleGroups_Click(object sender, EventArgs e)
        {
            TrVArticleGroup.CheckBoxes ^= true;
            TrVArticleGroup.LabelEdit ^= true;
            CmdAddArticleGroup.Enabled ^= true;
            CmdChangeArticleGrpName .Enabled ^= true;
            CmdDeleteArticleGroup.Enabled ^= true;
            TxtAddArticleGroup.Enabled ^= true;
            TxtArticleGroupName.Enabled ^= true;
        }

        void UncheckAll(TreeNode node)
        {
            if (node != null)
            {
                node.Checked = false;
                foreach (TreeNode item in node.Nodes)
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

        private void TrVArticleGroup_AfterCheck(object sender, TreeViewEventArgs e)
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

        private void CmdChangeArticleGrpName_Click(object sender, EventArgs e)
        {
            if (TrVArticleGroup.SelectedNode != null)
            {
                string oldName = TrVArticleGroup.SelectedNode.Text;
                string newName = TxtArticleGroupName.Text;
                if (newName.Length != 0)
                {
                    TrVArticleGroup.SelectedNode.Text = newName;
                    DBUtilityArticleGroup.ChangeArticleGroupName(newName, oldName);
                }
            }
            TxtArticleGroupName.Clear();
        }
    }
}
