﻿using Semesterprojekt_Datenbank;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using Semesterprojekt_Datenbank.Viewmodel;
using System.Data;
using System.Windows.Controls;
using System.Windows.Navigation;

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
            Position pos;
            int quantity = Convert.ToInt32(NumQuantity.Value);
            int articleId;
            var SelectedOrderCells = DgVOrders.SelectedCells;
            int orderId = (int)SelectedOrderCells[0].Value;
            if (CmbArticle.Text.Length > 0)
            {
                using (var context = new DataContext())
                {
                    articleId = (from a in context.Article
                        where a.Name == CmbArticle.Text
                        select a.Id).SingleOrDefault();

                    pos = new Position(quantity, 0, 0, articleId, orderId);

                    orderVM.positionList = (from p in context.Position
                        where p.OrderId == orderId
                        select p).ToList();

                    // Wenn Artikel bereits existiert dann Menge zur Position hinzufügen
                    if (orderVM.positionList.Contains(pos))
                    {
                        DBUtilityOrder.SaveExistingPosition(pos);

                        // Update UI
                        DgVOrders_RowEnter(null, null);
                    }
                    else
                    {
                        {
                            OrderVM orderVM = new OrderVM();
                            orderVM.customerName = CmbCustomer.Text;
                            orderVM.positionList.Add(pos);

                            foreach (Position position in orderVM.positionList)
                            {
                                Article article = (from a in context.Article
                                    where a.Id == position.ArticleId
                                    select a).SingleOrDefault();

                                pos.PriceNetto = (article.Price * pos.Quantity);

                                // wir haben das speichern mal hier runter genommen, da wir noch den Preis setzen müssen.
                                // Position über DB speichern
                                // ansonsten Neue Position erstellen
                                if (DBUtilityOrder.SaveNewPosition(pos))

                                    DgVPositions.Rows.Add(new object[]
                                        { positionnr++, article.Name, quantity, (quantity * article.Price) });
                            }
                        }
                    }
                }
            }

        }

        private void CmdDeletePosition_Click(object sender, EventArgs e)
        {
            if (DgVPositions.SelectedRows.Count != 0)
            {
                Position pos;
                var selectedPosCells = DgVPositions.SelectedCells;
                var selectedOrderCells = DgVOrders.SelectedCells;
                int positionNr =(int) selectedPosCells[0].Value;
                int quantity = (int)selectedPosCells[2].Value;
                Article article;
                int orderId = (int)selectedOrderCells[0].Value;

                using (var context = new DataContext())
                {
                    article = (from a in context.Article
                                where a.Name == selectedPosCells[1].Value.ToString()
                                select a).SingleOrDefault();

                    pos = (from p  in context.Position
                           where p.Article.Name == article.Name
                           select p).SingleOrDefault();

                    if (context.Position.Remove(pos) != null)
                    {
                        context.SaveChanges();
                        // Update UI
                        DgVOrders_RowEnter(null, null);
                    } else
                  {
                        // Fehlermeldung ausgeben
                    }
                }
            }
            // lösche position aus Context und Speichere
        }

        private void CmdAddOrder_Click(object sender, EventArgs e)
        {
            Order savedOrder = null;
            string customerName = CmbCustomer.Text;
            if (customerName.Length != 0)
            {
                orderVM.customerName = customerName;
                orderVM.orderDate = DateTime.Now;
                if (orderVM.CreateOrder(orderVM)) {
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

                    // DatagridView Clearen
                    // OrderVM zurücksetzen?
                    //LbPositionen.Items.Clear();
                    //orderVM.PositionList.Clear();
                    positionnr = 1;
                    // UI-Update
                    OrdersForm_Load(null, null);

                    // DVGridView auf neue Order setzen.
                    int lastOrderIndex = DgVOrders.RowCount - 1;
                    DgVOrders.Rows[lastOrderIndex].Selected = true;
                }
                else
                {
                    // Display Error that Adding Order failed
                }
            }
        }

        private void CmdDeleteOrder_Click(object sender, EventArgs e)
        {
            var selectedOrderCells = DgVOrders.SelectedCells;
            int orderId = (int)selectedOrderCells[0].Value;
            using (var context = new DataContext())
            {

                Order order = (from o in context.Order
                               where o.Id == orderId
                                   select o).SingleOrDefault();

                context.Order.Remove(order);
                context.SaveChanges();

                // UI-Update
                OrdersForm_Load(null, null);
                // Positionen Updaten
            }
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

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            DgVOrders.Rows.Clear();
            List<Order> orders;
            using (var context = new DataContext())
            {
                orders = (from o in context.Order
                    select o).ToList();
                string customerName;
                foreach (Order order in orders)
                {
                    customerName = (from c in context.Customer
                        where c.Id == order.CustomerId
                        select c.Name).FirstOrDefault();

                    DgVOrders.ClearSelection();

                    DgVOrders.Rows.Add(order.Id, customerName);
                }
                DgVOrders.FirstDisplayedCell.Selected = true;
            }
        }

        private void DgVOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // DgView Positions Clearen
            // OrderVm Positionen Clearen

            //LbPositionen.Items.Clear();
            //orderVM.PositionList.Clear();
            positionnr = 1;
            DgVPositions.Rows.Clear();

            if (DgVOrders.SelectedRows.Count != 0)
            {

                var cells = DgVOrders.SelectedCells;
                string customerName = cells[1].Value.ToString();
                List<OrderVM> orderVms = new List<OrderVM>();

                using (var context = new DataContext())
                {
                    int customerId = (from c in context.Customer
                                      where c.Name == customerName
                                      select c.Id).FirstOrDefault();

                    var clickedOrder = (from o in context.Order
                                        where o.Customer.Name == customerName && o.Id == (int)cells[0].Value
                                        select o).FirstOrDefault();

                    clickedOrder.Customer = (from c in context.Customer
                                             where c.Id == clickedOrder.CustomerId
                                             select c).SingleOrDefault();

                    clickedOrder.Positions = (from p in context.Position
                                              where p.OrderId == clickedOrder.Id
                                              select p).ToList();

                    //var positions = (from pos in context.Position
                    //                where clickedOrder.Id == pos.OrderId
                    //                    select pos).ToList();

                    int posNr = 1;

                    foreach (var position in clickedOrder.Positions)
                    {
                        Article article = (from a in context.Article
                                           where a.Id == position.ArticleId
                                           select a).SingleOrDefault();

                        DgVPositions.Rows.Add(new object[] { positionnr++, article.Name, position.Quantity, (position.Quantity * article.Price) });

                        //OrderVM vm = new OrderVM(clickedOrder.Positions, customerName, clickedOrder.Id, clickedOrder.Date);

                        // Position der DatagridView hinzufuegen
                        //LbPositionen.Items.Add(vm.GetPosition());
                        //LbPositionen.Items.Add("");
                    }
                }

            }



        }

        private void CmdGenerateInvoice_Click(object sender, EventArgs e)
        {
            // code um die Rechnung zu erstellen.
            // hier noch richtige Order selecten

            var cells = DgVOrders.SelectedCells;
            int orderIdToSelect = Convert.ToInt32(cells[0].Value);

            using (var context = new DataContext())
            {
                Order order = (from o in context.Order
                    where o.Id == orderIdToSelect
                    select o).FirstOrDefault();

                List<Position> positions = (from o in context.Order
                                            where o.Id == order.Id
                                            join p in context.Position
                                                on o.Id equals p.OrderId
                                            select p).ToList();



                decimal netPrice = 0;

                foreach (var postion in positions)
                {
                    netPrice += postion.PriceNetto;
                }


                int customerId = order.CustomerId;
                int orderId = order.Id;
                DateTime date = DateTime.Now;


                Invoice invoice = new Invoice();

                invoice.OrderId = orderId;
                invoice.Date = date;
                invoice.NetPrice = netPrice;
                invoice.CustomerId = customerId;

                context.Invoice.Add(invoice);
                context.SaveChanges();
            }
        }
    }
}
