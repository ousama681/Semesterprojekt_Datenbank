using Semesterprojekt_Datenbank.Viewmodel;
using System.Windows.Controls;
using Syncfusion.Windows.Forms.Tools;


namespace DBS_View.View
{
    public partial class ArticleGroupForm : Form
    {

        ArticleGroupVm articleGroupVm;

        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
       
        public ArticleGroupForm()
        {
            InitializeComponent();
            articleGroupVm = new ArticleGroupVm();
        }

        private void CmdAddArticleGroup_Click(object sender, EventArgs e)
        {



        }

        private void CmdDeleteArticleGroup_Click(object sender, EventArgs e)
        {

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

            var myArticleGroupList = articleGroupVm.GetArticleGroup();

            TreeNode rootNode;
            TreeNode childNode;
            List<TreeNode> rootnodes = new List<TreeNode>();
            List<TreeNode> childnodes = new List<TreeNode>();
            List<TreeNode> nodes = new List<TreeNode>();

            foreach (var eachRootNode in myArticleGroupList)
            {
                if (eachRootNode.ParentName is "none")
                {
                    rootNode = new TreeNode(eachRootNode.Name);  
                    rootNode.Tag = eachRootNode.ParentName;
                    nodes.Add(rootNode);
                }
                else
                {
                    childNode = new TreeNode(eachRootNode.Name);               
                    childNode.Tag = eachRootNode.ParentName;
                    nodes.Add(childNode);
                }
            }

            for (int i = 0; i < nodes.Count; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    if (nodes[i].Text == nodes[j].Tag.ToString())
                    {
                        nodes[i].Nodes.Add(nodes[j]);
                        
                    }
                }
                if (nodes[i].Tag.ToString() == "none")
                {
                    TrVArticleGroup.Nodes.Add(nodes[i]);
                }
                

            }
        }
    }
}
