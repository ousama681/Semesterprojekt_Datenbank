using Semesterprojekt_Datenbank.Viewmodel;


namespace DBS_View.View
{
    public partial class ArticleGroupForm : Form
    {
        ArticleGroupVm articleGroupVm;

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

            TreeNode node;
            List<TreeNode> nodes = new List<TreeNode>();

            foreach (var articleGroupVm in myArticleGroupList)
            {
                node = new TreeNode(articleGroupVm.Name);
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
    }
}
