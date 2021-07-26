using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ComaxTask.Forms
{
    public partial class ProductsListForm : Form
    {
        DataTable main_dt = new DataTable();
        bool IsEditMode = false;
        string lastOrder;
        DataTable dt; 

        public ProductsListForm()
        {
            InitializeComponent();
            lastOrder = GetLastOrder_byUser(LoginForm.connectedUser.Trim());
            dt = GetLastProductList(Convert.ToInt32(lastOrder));
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {

            if (radioBtnName.Checked == true)
            {
                AutoComplete_byName();
            }
            else if(radioBtnBarcode.Checked==true)
            {
                AutoComplete_byBarcode();
            }

            
           
            main_dt.Columns.Add("Product Name");
            main_dt.Columns.Add("Barcode");
            main_dt.Columns.Add("Quantity");

            dgvOrderedProducts.DataSource = main_dt;
            dgvOrderedProducts.Font = new Font("Arial", 12, FontStyle.Regular);
            Styles.DataGridView_Style.SetDGVAutosize(dgvOrderedProducts);
            dgvOrderedProducts.Sort(dgvOrderedProducts.Columns["Product Name"], ListSortDirection.Descending);
            dgvOrderedProducts.Sort(dgvOrderedProducts.Columns["Barcode"], ListSortDirection.Descending);
            dgvOrderedProducts.Sort(dgvOrderedProducts.Columns["Quantity"], ListSortDirection.Descending);

            string lastOrder = GetLastOrder_byUser(LoginForm.connectedUser.Trim());
            if (lastOrder != null)
            {
                
                dgvOrderedProducts.DataSource= GetLastProductList(Convert.ToInt32(lastOrder));
                IsEditMode = true;
            }
        }

        private DataTable GetLastProductList(int order_num)
        {
            string q = @"Select Product_Name,Barcode,Qty
                         from Orders
                         inner join Order_Details on Orders.Order_ID = Order_Details.Order_ID
                         where Orders.Order_ID =" + order_num;
            DataTable dt = DAL.Database.GetDataset(q).Tables[0];

            //if (dt != null || dt.Rows.Count >= 0)
                return dt;
        }



        #region AutoComplete Methods

        private void AutoComplete_byBarcode()
        {
            this.txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string[] arr = GetBarcode();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(arr);
            this.txtSearch.AutoCompleteCustomSource = collection;
        }

     
        private void AutoComplete_byName()
        {
            this.txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            string[] arr = GetProduct();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(arr);
            this.txtSearch.AutoCompleteCustomSource = collection;
        }

        #endregion

        /// <summary>
        /// Get Product name from XML for product searching
        /// </summary>
        /// <returns></returns>
        private string[] GetProduct()
        {
            XElement xelement = XElement.Load(Path.Combine(Environment.CurrentDirectory, "Products/products.xml"));
            IEnumerable<XElement> rows = xelement.Elements();
            List<string> Nm = new List<string>();
            foreach (var row in rows)
            {

                Nm.Add(row.Attribute("Nm").Value);

            }

            return Nm.ToArray();


        }

        /// <summary>
        /// Get Barcode number from XML for product searching
        /// </summary>
        /// <returns></returns>
        private string[] GetBarcode()
        {
            XElement xelement = XElement.Load(Path.Combine(Environment.CurrentDirectory, "Products/products.xml"));
            IEnumerable<XElement> rows = xelement.Elements();
            List<string> bc = new List<string>();
            foreach (var row in rows)
            {

                bc.Add(row.Attribute("BarKod").Value);

            }

            return bc.ToArray();
        }

        private static DataSet XmltoDataset()
        {
            DataSet ds = new DataSet();
            using (XmlReader reader = XmlReader.Create(new StreamReader(Path.Combine(Environment.CurrentDirectory, "Products/products.xml"))))
            {
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                ds.ReadXml(reader);
            }
            return ds;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {          
            DataTable product_table = XmltoDataset().Tables[0];
            if (txtSearch.Text != string.Empty)
            {
                if(radioBtnName.Checked==true)
                {
                    var prodname = product_table.AsEnumerable().Where(x => x.Field<string>("Nm") == txtSearch.Text).Select(g => g.Field<string>("Nm")).FirstOrDefault();
                    txtProductName.Text = prodname.ToString();
                    var barcode = product_table.AsEnumerable().Where(x => x.Field<string>("Nm") == txtSearch.Text).Select(g => g.Field<string>("BarKod")).FirstOrDefault();
                    txtBarCode.Text = barcode.ToString();
                    var cmt = product_table.AsEnumerable().Where(x => x.Field<string>("Nm") == txtSearch.Text).Select(g => g.Field<string>("Cmt")).FirstOrDefault();
                    txtQty.Text = cmt.ToString();
                }
                else if(radioBtnBarcode.Checked==true)
                {
                    var prodname = product_table.AsEnumerable().Where(x => x.Field<string>("BarKod") == txtSearch.Text).Select(g => g.Field<string>("Nm")).FirstOrDefault();
                    txtProductName.Text = prodname.ToString();
                    var barcode = product_table.AsEnumerable().Where(x => x.Field<string>("BarKod") == txtSearch.Text).Select(g => g.Field<string>("BarKod")).FirstOrDefault();
                    txtBarCode.Text = barcode.ToString();
                    var cmt = product_table.AsEnumerable().Where(x => x.Field<string>("BarKod") == txtSearch.Text).Select(g => g.Field<string>("Cmt")).FirstOrDefault();
                    txtQty.Text = cmt.ToString();
                }
                
            }
            
        }

        private void radioBtnBarcode_CheckedChanged(object sender, EventArgs e)
        {
            AutoComplete_byBarcode();
        }

        private void radioBtnName_CheckedChanged(object sender, EventArgs e)
        {
            AutoComplete_byName();
        }

        private void btnAddtoOrder_Click(object sender, EventArgs e)
        {
            if(IsEditMode==false)
            {
                if (String.IsNullOrWhiteSpace(txtQty.Text))
                {
                    MessageBox.Show("Please enter quantity of products");
                }
                else
                {
                    DataRow dr = main_dt.NewRow();
                    dr["Product Name"] = txtProductName.Text;
                    dr["Barcode"] = txtBarCode.Text;
                    dr["Quantity"] = txtQty.Text;
                    main_dt.Rows.Add(dr);

                    dgvOrderedProducts.DataSource = main_dt;
                }

            }
            else
            {
                
               
                      DataRow dr = dt.NewRow();
                dr["Product_Name"] = txtProductName.Text;
                dr["Barcode"] = txtBarCode.Text;
                dr["Qty"] = txtQty.Text;
                dt.Rows.Add(dr);
                dgvOrderedProducts.DataSource =dt;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            var created_by = LoginForm.connectedUser.Trim();

            //MessageBox.Show(created_by.ToString());

            string order_query = "Insert into Orders (Order_Date,Created_by) Values(@Order_Date,@Created_by)";
            List<SqlParameter> l = new List<SqlParameter>();
            l.Add(new SqlParameter("@Order_Date", DateTime.Now));
            l.Add(new SqlParameter("@Created_by", created_by));

            DAL.Database.ParametersCommand(order_query, l);

            string last_order = GetLastOrder_byUser(created_by);
            string order_detail = "Insert into Order_Details(Order_ID,Product_Name, Barcode,Qty,Order_Date,Created_by) Values(@Order_ID,@Product_Name, @Barcode,@Qty,@Order_Date,@Created_by)";

            if ( dgvOrderedProducts.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dgvOrderedProducts.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        List<SqlParameter> k = new List<SqlParameter>();
                        k.Add(new SqlParameter("@Order_ID", last_order));
                        k.Add(new SqlParameter("@Product_Name", row.Cells[0].Value));
                        k.Add(new SqlParameter("@Barcode", row.Cells[1].Value));
                        k.Add(new SqlParameter("@Qty", row.Cells[2].Value));
                        k.Add(new SqlParameter("@Order_Date", DateTime.Now));
                        k.Add(new SqlParameter("@Created_by", created_by));
                        DAL.Database.ParametersCommand(order_detail, k);
                    }
                }
                MessageBox.Show("Your order saved successfully");
               this.dgvOrderedProducts.DataSource = null;
               this.dgvOrderedProducts.Rows.Clear();
                this.dgvOrderedProducts.DataSource = main_dt;
                txtSearch.Clear();
                txtProductName.Clear();
                txtBarCode.Clear();
                txtQty.Clear();

               // dgvOrderedProducts.Refresh();
            }
            else
            {
                MessageBox.Show("Please add products to your orders");
            }

        }


        private string GetLastOrder_byUser(string username)
        {
            string q = @"select Top 1 Order_ID
                                     from Orders
                                     where Created_by='" + username+ "'order by Order_Date DESC";

            var last_order = DAL.Database.ExecuteScalarWithAnonymousType(q);
            if(last_order!=null)
            {
                return last_order.ToString();
            }
           else
            {
                MessageBox.Show("You have no orders yet");
                return null;
            }
              
           
            
        }

        private void dgvOrderedProducts_Sorted(object sender, EventArgs e)
        {
           
        }
    }

}
