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

            Position pos;
            
            int quantity = Convert.ToInt32(NumQuantity.Value);
            int articleId;

            //orderId organisieren durch dataGrid
            var SelectedOrderCells = DgVOrders.SelectedCells;
            int orderId = (int)SelectedOrderCells[0].Value;

            using (var context = new DataContext())
            {
                articleId = (from a in context.Article
                    where a.Name == CmbArticle.Text
                    select a.Id).SingleOrDefault();

                // TODO: muss noch nummer PosNr vergeben
                pos = new Position(positionnr, quantity, 0, 0, articleId, orderId);

                //orderVM.positionNr
                //    //orderVM.articleName
                //    //orderVM.quantity
                //    orderVM.customerName

                // Position in Datenbank speichern
                if (DBUtilityOrder.SavePosition(pos))
                {
                    OrderVM orderVM = new OrderVM();
                    //orderVM.articleName = CmbArticle.Text;
                    //orderVM.quantity = Convert.ToInt32(NumQuantity.Value);
                    orderVM.customerName = CmbCustomer.Text;
                    orderVM.positionList.Add(pos);



                    // Position in ´DataGridview packen

                    //pos.Quantity = orderVM.quantity;
                    //pos.Article = DBUtilityArticle.FindArticle(orderVM.articleName);


                    foreach (Position position in orderVM.positionList)
                    {
                        Article article = (from a in context.Article
                            where a.Id == position.ArticleId
                            select a).SingleOrDefault();

                        DgVPositions.Rows.Add(new object[] { positionnr++, article.Name, quantity, (quantity * article.Price) }) ;
                        //LbPositionen.Items.Add("");
                        //LbPositionen.Items.Add(position.PositionToString(orderVM.positionNr));
                    }


                }
                else
                {

                }
            }

        }

        private void CmdDeletePosition_Click(object sender, EventArgs e)
        {
            //if (LbPositionen.SelectedItem != null && LbPositionen.SelectedIndex % 2 == 0 && LbPositionen.SelectedIndex > 0)
            //{
            //    string removeableItem = LbPositionen.SelectedItem.ToString();
            //    int removeableIndex = LbPositionen.SelectedIndex;
            //    Position removePos = new Position();
            //    LbPositionen.Items.RemoveAt(removeableIndex);
            //    LbPositionen.Items.RemoveAt(removeableIndex - 1);
            //    foreach (Position position in orderVM.positionList)
            //    {
            //        if (position.PositionToString(orderVM.positionNr).Equals(removeableItem))
            //            removePos = position;
            //    }
            //    orderVM.positionList.Remove(removePos);
            //    // wieso zählen wir hier die Positionsnummer zurück?
            //    // Mal angenommen ich habe 5 Positionen und ich lösche Position 3, dann würde die Positionsnummer von 5 auf 4 zurückfallen, wenn ich jetzt
            //    // eine neue Position hinzufuege, wird diese mit PositionsNr 5 gespeichert, aber diese existiert ja schon.
            //    // ich persönlich würde einfach weiter laufen lassen, oder wir müssen alle neu durchnummerieren.
            //    // wir können das ja noch zusammen besprechen.
            //    positionnr--;
            //    LbPositionen.Items.Clear();
            //    LbPositionen.Items.Add(orderVM.customerName);
            //    int newPosNr = 1;
            //    foreach (Position pos in orderVM.positionList)
            //    {
            //        // Hier brauchen wir wieder die Positionsnummer.
            //        // Am einfachsten wäre es, der Position ein neues Feld hinzuzufuegen mit der Nr. Da dies auch OOP entspricht. 
            //        pos.positionNr = newPosNr++;
            //        LbPositionen.Items.Add("");
            //        LbPositionen.Items.Add(pos.GetPosition());
            //    }

            //}

            // prüfe ob Position angewählt

            if (DgVPositions.SelectedRows.Count != 0)
            {

                Position pos;

                var selectedPosCells = DgVPositions.SelectedCells;
                var selectedOrderCells = DgVOrders.SelectedCells;

                int positionNr =(int) selectedPosCells[0].Value;
                int quantity = (int)selectedPosCells[2].Value;
                int articleId = 0;
                int orderId = (int)selectedOrderCells[0].Value;


                using (var context = new DataContext())
                {

                    articleId = (from a in context.Article
                                where a.Name == selectedPosCells[1].Value.ToString()
                                select a.Id).SingleOrDefault();

                    pos = (from p  in context.Position
                           where p.PositionNr == positionNr && p.ArticleId == articleId
                           select p).SingleOrDefault();


                    if (context.Position.Remove(pos) != null)
                    {

                        context.SaveChanges();

                        // Update UI

                        DgVOrders_RowEnter(null, null);

                        // Wir müssen hier irgendwie die positionsnummern aktualisieren
                        // Wir können nach dem UI Updat edie PosNr des DataGridView übernehmen und dann einen Update Table Position machen auf die Order.Positions.

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
                    DgVOrders.Rows.Add(savedOrder.Id, customerName);

                    // DatagridView Clearen
                    // OrderVM zurücksetzen?
                    //LbPositionen.Items.Clear();
                    //orderVM.PositionList.Clear();
                    positionnr = 1;
                }
                else
                {
                    // Display Error that Adding Order failed
                }
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

           
            
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
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

                    DgVOrders.Rows.Add(order.Id, customerName);
                }
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
    }
}
