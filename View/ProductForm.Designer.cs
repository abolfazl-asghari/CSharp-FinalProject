namespace View
{
    partial class ProductForm
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
            dgvProduct = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRefresh = new Button();
            btnSave = new Button();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            //
            // dgvProduct
            //
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(114, 198);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(488, 150);
            dgvProduct.TabIndex = 8;
            dgvProduct.CellClick += dgvProduct_CellClick;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(422, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(322, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnRefresh
            //
            btnRefresh.Location = new Point(114, 35);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnSave
            //
            btnSave.Location = new Point(218, 35);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(114, 87);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 15);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Title:";
            //
            // txtTitle
            //
            txtTitle.Location = new Point(218, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(384, 23);
            txtTitle.TabIndex = 0;
            //
            // lblUnitPrice
            //
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(114, 128);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(61, 15);
            lblUnitPrice.TabIndex = 10;
            lblUnitPrice.Text = "Unit Price:";
            //
            // txtUnitPrice
            //
            txtUnitPrice.Location = new Point(218, 125);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(384, 23);
            txtUnitPrice.TabIndex = 1;
            //
            // lblQuantity
            //
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(114, 167);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity:";
            //
            // txtQuantity
            //
            txtQuantity.Location = new Point(218, 164);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(384, 23);
            txtQuantity.TabIndex = 2;
            //
            // btnBack
            //
            btnBack.Location = new Point(510, 35);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back To Main";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // ProductForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(lblUnitPrice);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(dgvProduct);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRefresh);
            Controls.Add(btnSave);
            Name = "ProductForm";
            Text = "Product";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRefresh;
        private Button btnSave;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnBack;
    }
}
