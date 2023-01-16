using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semesterprojekt_Datenbank.Viewmodel;

namespace DBS_View.View
{
    public partial class OrdersForm : Form
    {
        OrderVM orderVM;
        private int positionnr;
        public OrdersForm()
        {
            InitializeComponent();
            orderVM = new OrderVM();
            positionnr = 1;
            CmbCustomer.DataSource = orderVM.GetCustomerNames();
            CmbArticle.DataSource = orderVM.GetArticles();
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
                int removeableIndex= LbPositionen.SelectedIndex;
                OrderVM removePos = new OrderVM();
                LbPositionen.Items.RemoveAt(removeableIndex);
                LbPositionen.Items.RemoveAt(removeableIndex -1);
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

        }

        private void CmdDeleteOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
