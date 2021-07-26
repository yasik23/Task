using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComaxTask.Forms
{
    public partial class MyOrdersForm : Form
    {
        string created_by = LoginForm.connectedUser.Trim();
        public MyOrdersForm()
        {
            InitializeComponent();
        }

        private void MyOrdersForm_Load(object sender, EventArgs e)
        {
            LoadDGV();


           
        }

        public void LoadDGV()
        {
            DataTable dt = DAL.Database.GetDataset(@"Select Order_ID as[Order Number],Order_Date as [Order Date]  From Orders Where Created_by='" + created_by + "' Order by Order_Date").Tables[0];
            dgvOrderes.DataSource = dt;
        }

        private void dgvOrderes_DoubleClick(object sender, EventArgs e)
        {
            int currentrow = dgvOrderes.CurrentRow.Index;
            int ordernumber =(int) dgvOrderes.Rows[currentrow].Cells["Order Number"].Value;
            string q = @"Select Product_Name,Barcode,Qty
                         from Orders
                         inner join Order_Details on Orders.Order_ID = Order_Details.Order_ID
                         where Orders.Order_ID =" + ordernumber;
            DataTable dt = DAL.Database.GetDataset(q).Tables[0];

            if (dt == null || dt.Rows.Count <= 0)
                return;

         
        }
    }
}
