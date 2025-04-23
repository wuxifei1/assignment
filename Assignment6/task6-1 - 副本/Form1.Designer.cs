namespace task6_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            txtSearchCustomer = new TextBox();
            btnSearch = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            splitContainer1 = new SplitContainer();
            dgvOrders = new DataGridView();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            dgvDetails = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailsBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).BeginInit();
            SuspendLayout();

            // panel1
            panel1.Controls.Add(txtSearchCustomer);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 83);
            panel1.TabIndex = 0;

            // txtSearchCustomer
            txtSearchCustomer.Location = new Point(40, 26);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.PlaceholderText = "输入客户名称或订单ID";
            txtSearchCustomer.Size = new Size(478, 30);
            txtSearchCustomer.TabIndex = 1;

            // btnSearch
            btnSearch.Location = new Point(615, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "搜索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            // flowLayoutPanel1
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Controls.Add(btnEdit);
            flowLayoutPanel1.Controls.Add(btnDelete);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 457);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1042, 150);
            flowLayoutPanel1.TabIndex = 1;

            // btnAdd
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "添加订单";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            // btnEdit
            btnEdit.Location = new Point(121, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "编辑订单";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;

            // btnDelete
            btnDelete.Location = new Point(239, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "删除订单";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            // splitContainer1
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 83);
            splitContainer1.Name = "splitContainer1";

            // splitContainer1.Panel1
            splitContainer1.Panel1.Controls.Add(dgvOrders);

            // splitContainer1.Panel2
            splitContainer1.Panel2.Controls.Add(dgvDetails);
            splitContainer1.Size = new Size(1042, 374);
            splitContainer1.SplitterDistance = 514;
            splitContainer1.TabIndex = 2;

            // dgvOrders
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] {
                orderIdDataGridViewTextBoxColumn,
                customerDataGridViewTextBoxColumn,
                totalAmountDataGridViewTextBoxColumn});
            dgvOrders.DataSource = orderBindingSource;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.RowTemplate.Height = 32;
            dgvOrders.Size = new Size(514, 374);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;

            // orderIdDataGridViewTextBoxColumn
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "orderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "订单ID";
            orderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.Width = 150;

            // customerDataGridViewTextBoxColumn
            customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            customerDataGridViewTextBoxColumn.HeaderText = "客户名称";
            customerDataGridViewTextBoxColumn.MinimumWidth = 8;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.Width = 200;

            // totalAmountDataGridViewTextBoxColumn
            totalAmountDataGridViewTextBoxColumn.DataPropertyName = "totalAmount";
            totalAmountDataGridViewTextBoxColumn.HeaderText = "总金额";
            totalAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            totalAmountDataGridViewTextBoxColumn.Width = 150;

            // orderBindingSource
            orderBindingSource.DataSource = typeof(Order_Management.Order);

            // dgvDetails
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetails.Columns.AddRange(new DataGridViewColumn[] {
                productNameDataGridViewTextBoxColumn,
                priceDataGridViewTextBoxColumn,
                quantityDataGridViewTextBoxColumn});
            dgvDetails.DataMember = "details";
            dgvDetails.DataSource = orderBindingSource;
            dgvDetails.Dock = DockStyle.Fill;
            dgvDetails.Location = new Point(0, 0);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.RowHeadersWidth = 62;
            dgvDetails.RowTemplate.Height = 32;
            dgvDetails.Size = new Size(524, 374);
            dgvDetails.TabIndex = 0;

            // productNameDataGridViewTextBoxColumn
            productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            productNameDataGridViewTextBoxColumn.HeaderText = "产品名称";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.Width = 200;

            // priceDataGridViewTextBoxColumn
            priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            priceDataGridViewTextBoxColumn.HeaderText = "单价";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 150;

            // quantityDataGridViewTextBoxColumn
            quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 100;

            // orderDetailsBindingSource
            orderDetailsBindingSource.DataSource = typeof(Order_Management.OrderDetails);

            // Form1
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 607);
            Controls.Add(splitContainer1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "订单管理系统";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearchCustomer;
        private Button btnSearch;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private SplitContainer splitContainer1;
        private DataGridView dgvOrders;
        private DataGridView dgvDetails;
        private BindingSource orderBindingSource;
        private BindingSource orderDetailsBindingSource;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
    }
}
