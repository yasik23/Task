
namespace ComaxTask.Forms
{
    partial class ProductsListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gradientDesctop = new ComaxTask.Styles.GradientPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxSearching = new System.Windows.Forms.GroupBox();
            this.radioBtnBarcode = new System.Windows.Forms.RadioButton();
            this.radioBtnName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvOrderedProducts = new System.Windows.Forms.DataGridView();
            this.grBoxProduct = new System.Windows.Forms.GroupBox();
            this.btnAddtoOrder = new System.Windows.Forms.Button();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.gradientDesctop.SuspendLayout();
            this.groupBoxSearching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedProducts)).BeginInit();
            this.grBoxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSearch.Location = new System.Drawing.Point(139, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(331, 26);
            this.txtSearch.TabIndex = 0;
            // 
            // gradientDesctop
            // 
            this.gradientDesctop.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(191)))), ((int)(((byte)(167)))));
            this.gradientDesctop.ColorTop = System.Drawing.Color.Empty;
            this.gradientDesctop.Controls.Add(this.btnSave);
            this.gradientDesctop.Controls.Add(this.groupBoxSearching);
            this.gradientDesctop.Controls.Add(this.dgvOrderedProducts);
            this.gradientDesctop.Controls.Add(this.grBoxProduct);
            this.gradientDesctop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientDesctop.Location = new System.Drawing.Point(0, 0);
            this.gradientDesctop.Name = "gradientDesctop";
            this.gradientDesctop.Size = new System.Drawing.Size(778, 651);
            this.gradientDesctop.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(380, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxSearching
            // 
            this.groupBoxSearching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.groupBoxSearching.Controls.Add(this.radioBtnBarcode);
            this.groupBoxSearching.Controls.Add(this.radioBtnName);
            this.groupBoxSearching.Controls.Add(this.btnSearch);
            this.groupBoxSearching.Controls.Add(this.txtSearch);
            this.groupBoxSearching.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSearching.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(17)))));
            this.groupBoxSearching.Location = new System.Drawing.Point(16, 10);
            this.groupBoxSearching.Name = "groupBoxSearching";
            this.groupBoxSearching.Size = new System.Drawing.Size(742, 96);
            this.groupBoxSearching.TabIndex = 10;
            this.groupBoxSearching.TabStop = false;
            this.groupBoxSearching.Text = "Product Searching";
            // 
            // radioBtnBarcode
            // 
            this.radioBtnBarcode.AutoSize = true;
            this.radioBtnBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnBarcode.Location = new System.Drawing.Point(233, 66);
            this.radioBtnBarcode.Name = "radioBtnBarcode";
            this.radioBtnBarcode.Size = new System.Drawing.Size(98, 21);
            this.radioBtnBarcode.TabIndex = 3;
            this.radioBtnBarcode.Text = "by Barcode";
            this.radioBtnBarcode.UseVisualStyleBackColor = true;
            this.radioBtnBarcode.CheckedChanged += new System.EventHandler(this.radioBtnBarcode_CheckedChanged);
            // 
            // radioBtnName
            // 
            this.radioBtnName.AutoSize = true;
            this.radioBtnName.Checked = true;
            this.radioBtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnName.Location = new System.Drawing.Point(351, 66);
            this.radioBtnName.Name = "radioBtnName";
            this.radioBtnName.Size = new System.Drawing.Size(82, 21);
            this.radioBtnName.TabIndex = 2;
            this.radioBtnName.TabStop = true;
            this.radioBtnName.Text = "by Name";
            this.radioBtnName.UseVisualStyleBackColor = true;
            this.radioBtnName.CheckedChanged += new System.EventHandler(this.radioBtnName_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::ComaxTask.Properties.Resources.search24;
            this.btnSearch.Location = new System.Drawing.Point(492, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 38);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvOrderedProducts
            // 
            this.dgvOrderedProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderedProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderedProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderedProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderedProducts.EnableHeadersVisualStyles = false;
            this.dgvOrderedProducts.Location = new System.Drawing.Point(16, 238);
            this.dgvOrderedProducts.Name = "dgvOrderedProducts";
            this.dgvOrderedProducts.ReadOnly = true;
            this.dgvOrderedProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOrderedProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrderedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderedProducts.Size = new System.Drawing.Size(742, 343);
            this.dgvOrderedProducts.TabIndex = 7;
            this.dgvOrderedProducts.Sorted += new System.EventHandler(this.dgvOrderedProducts_Sorted);
            // 
            // grBoxProduct
            // 
            this.grBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grBoxProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.grBoxProduct.Controls.Add(this.btnAddtoOrder);
            this.grBoxProduct.Controls.Add(this.lblQty);
            this.grBoxProduct.Controls.Add(this.lblBarcode);
            this.grBoxProduct.Controls.Add(this.lblProduct);
            this.grBoxProduct.Controls.Add(this.txtQty);
            this.grBoxProduct.Controls.Add(this.txtProductName);
            this.grBoxProduct.Controls.Add(this.txtBarCode);
            this.grBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(165)))), ((int)(((byte)(17)))));
            this.grBoxProduct.Location = new System.Drawing.Point(16, 124);
            this.grBoxProduct.Name = "grBoxProduct";
            this.grBoxProduct.Size = new System.Drawing.Size(742, 104);
            this.grBoxProduct.TabIndex = 6;
            this.grBoxProduct.TabStop = false;
            this.grBoxProduct.Text = "Product Details";
            // 
            // btnAddtoOrder
            // 
            this.btnAddtoOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddtoOrder.Location = new System.Drawing.Point(650, 37);
            this.btnAddtoOrder.Name = "btnAddtoOrder";
            this.btnAddtoOrder.Size = new System.Drawing.Size(75, 30);
            this.btnAddtoOrder.TabIndex = 9;
            this.btnAddtoOrder.Text = "Add";
            this.btnAddtoOrder.UseVisualStyleBackColor = true;
            this.btnAddtoOrder.Click += new System.EventHandler(this.btnAddtoOrder_Click);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(56, 71);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(61, 17);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Quantity";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBarcode.ForeColor = System.Drawing.Color.White;
            this.lblBarcode.Location = new System.Drawing.Point(240, 71);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(61, 17);
            this.lblBarcode.TabIndex = 7;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(462, 71);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(98, 17);
            this.lblProduct.TabIndex = 6;
            this.lblProduct.Text = "Product Name";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQty.Location = new System.Drawing.Point(18, 37);
            this.txtQty.Name = "txtQty";
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(163, 26);
            this.txtQty.TabIndex = 5;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtProductName.Location = new System.Drawing.Point(392, 37);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(243, 26);
            this.txtProductName.TabIndex = 3;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarCode.Location = new System.Drawing.Point(204, 37);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.ReadOnly = true;
            this.txtBarCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBarCode.Size = new System.Drawing.Size(163, 26);
            this.txtBarCode.TabIndex = 4;
            // 
            // ProductsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 651);
            this.Controls.Add(this.gradientDesctop);
            this.Name = "ProductsListForm";
            this.Text = "ProductsListForm";
            this.Load += new System.EventHandler(this.ProductsListForm_Load);
            this.gradientDesctop.ResumeLayout(false);
            this.groupBoxSearching.ResumeLayout(false);
            this.groupBoxSearching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderedProducts)).EndInit();
            this.grBoxProduct.ResumeLayout(false);
            this.grBoxProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private Styles.GradientPanel gradientDesctop;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.GroupBox grBoxProduct;
        private System.Windows.Forms.DataGridView dgvOrderedProducts;
        private System.Windows.Forms.Button btnAddtoOrder;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox groupBoxSearching;
        private System.Windows.Forms.RadioButton radioBtnBarcode;
        private System.Windows.Forms.RadioButton radioBtnName;
        private System.Windows.Forms.Button btnSave;
    }
}