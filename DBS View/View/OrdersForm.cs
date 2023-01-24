using Semesterprojekt_Datenbank;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using Semesterprojekt_Datenbank.Viewmodel;
using System.Data;

namespace DBS_View.View
{
    public partial class OrdersForm : Form
    {
        OrderVM orderVM;
        private int positionnr;
        ArticleGroupVm articleGroupVm;

        public OrdersForm()
        {
            InitializeComponent();
            orderVM = new OrderVM();
            positionnr = 1;
            CmbCustomer.DataSource = orderVM.GetCustomerNames();
            //CmbArticle.DataSource = orderVM.GetArticles();
            articleGroupVm = new ArticleGroupVm();
            LoadTreeView();
        }

        private void LoadTreeView()
        {
            TrVArticleGroupOrder.Nodes.Clear();


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
                    TrVArticleGroupOrder.Nodes.Add(nodes[i]);
            }
        }

        private void CmdAddPosition_Click(object sender, EventArgs e)
        {
            OrderVM pos = new OrderVM();
            pos.positionNr = positionnr++;
            pos.articleName = CmbArticle.Text;
            pos.quantity = Convert.ToInt32(NumQuantity.Value);
            orderVM.customerName = CmbCustomer.Text;
            orderVM.PositionList.Add(pos);
            LbPositionen.Items.Clear();
            LbPositionen.Items.Add(orderVM.customerName);
            foreach (OrderVM position in orderVM.PositionList)
            {
                LbPositionen.Items.Add("");
                LbPositionen.Items.Add(position.GetPosition());
            }
        }

        private void CmdDeletePosition_Click(object sender, EventArgs e)
        {
            if (LbPositionen.SelectedItem != null && LbPositionen.SelectedIndex % 2 == 0 && LbPositionen.SelectedIndex > 0)
            {
                string removeableItem = LbPositionen.SelectedItem.ToString();
                int removeableIndex = LbPositionen.SelectedIndex;
                OrderVM removePos = new OrderVM();
                LbPositionen.Items.RemoveAt(removeableIndex);
                LbPositionen.Items.RemoveAt(removeableIndex - 1);
                foreach (OrderVM position in orderVM.PositionList)
                {
                    if (position.GetPosition().Equals(removeableItem))
                        removePos = position;
                }
                orderVM.PositionList.Remove(removePos);
                positionnr--;
                LbPositionen.Items.Clear();
                LbPositionen.Items.Add(orderVM.customerName);
                int newPosNr = 1;
                foreach (OrderVM pos in orderVM.PositionList)
                {
                    pos.positionNr = newPosNr++;
                    LbPositionen.Items.Add("");
                    LbPositionen.Items.Add(pos.GetPosition());
                }

            }
        }

        private void CmdAddOrder_Click(object sender, EventArgs e)
        {
            Order savedOrder = null;
            string customerName = CmbCustomer.Text;
            if (customerName.Length != 0)
            {
                orderVM.customerName = customerName;
                orderVM.orderDate = DateTime.Now;
                orderVM.CreateOrder(orderVM);

                // This Part is only needed to get the saved Order, so we can Display the OrderId on the UI
                // Maybe we can add a Property to the OrderVM and Order Relation (OrderNumber)
                using (var context = new DataContext())
                {
                    int customerId = (from c in context.Customer
                                      where c.Name == customerName
                                      select c.Id).FirstOrDefault();

                    savedOrder = (from o in context.Order
                                  where o.CustomerId == customerId && o.Date == orderVM.orderDate
                                  select o).FirstOrDefault();
                }
                DgVOrders.Rows.Add(savedOrder.Id, customerName);
            }
        }

        private void CmdDeleteOrder_Click(object sender, EventArgs e)
        {

        }
        private void TrVArticleGroupOrder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CmbArticle.Items.Clear();

            string articleGroupName = TrVArticleGroupOrder.SelectedNode.Text;

            int parentId = DBUtilityArticleGroup.GetParentId(articleGroupName);
            var articles = DBUtilityArticleGroup.GetArticlesWithParentId(parentId);


            foreach (var article in articles)
            {
                CmbArticle.Items.Add(article);
                CmbArticle.Text = articles[0].Name;
            }

            // Sollten wir allenfalls noch implementieren.... 

            //if (articles[0].Name != null)
            //{
            //    CmbArticle.Text = articles[0].Name;
            //}

        }

        private void DgVOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            LbPositionen.Items.Clear();

            string selectedOrder = DgVOrders.SelectedCells.ToString();





        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            List<Order> orders;
            using (var context = new DataContext())
            {
                orders = (from o in context.Order
                    select o).ToList();

                foreach (Order order in orders)
                {

                    string customerName = (from c in context.Customer
                        where c.Id == order.CustomerId
                        select c.Name).FirstOrDefault();

                    DgVOrders.Rows.Add(order.Id, customerName);
                }
            }
        }
    }
}
