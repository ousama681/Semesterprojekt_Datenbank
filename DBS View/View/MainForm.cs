using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_View.View
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        private Button currentButton;
        //private string currentUser = Login.CurrentUser;

        public MainForm()
        {
            InitializeComponent();
            //LblCurrentUser.Text = Convert.ToString(currentUser);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //OpenChildForm(new DashboardForm());
            //ActiveButton(CmdDashboard);
            OpenChildForm(new CustomerForm());
            ActiveButton(CmdCustomer);
        }

        //private void CmdDashboard_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new DashboardForm());
        //    ActiveButton((Button)sender);
        //}

        private void CmdCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm());
            ActiveButton((Button)sender);
        }

        private void CmdArticle_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArticleForm());
            ActiveButton((Button)sender);
        }

        private void CmdArticleGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArticleGroupForm());
            ActiveButton((Button)sender);
        }

        private void CmdOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OrdersForm());
            ActiveButton((Button)sender);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.PnlMainPanel.Controls.Add(childForm);
            this.PnlMainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LblTitle.Text = childForm.Text;
        }

        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                if ((Button)sender != currentButton)
                {
                    DisableButton();
                    currentButton = (Button)sender;
                    currentButton.BackColor = Color.FromArgb(128, 128, 255);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in PnlSidebar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.Gray;
                    previousBtn.ForeColor = Color.FromArgb(224, 224, 224);
                    previousBtn.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InvoiceForm());
            ActiveButton((Button)sender);
        }

        private void CmdJahresvergleich_Click(object sender, EventArgs e)
        {
            OpenChildForm(new YearComparisonForm());
            ActiveButton((Button)sender);
        }
    }
}
