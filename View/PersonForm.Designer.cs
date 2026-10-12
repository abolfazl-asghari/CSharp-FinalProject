namespace View
{
    partial class PersonForm
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
            btnSave = new Button();
            btnRefresh = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            dgvPerson = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            //
            // btnSave
            //
            btnSave.Location = new Point(217, 26);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            //
            // btnRefresh
            //
            btnRefresh.Location = new Point(113, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            //
            // btnUpdate
            //
            btnUpdate.Location = new Point(321, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(421, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            //
            // lblFirstName
            //
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(113, 88);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 8;
            lblFirstName.Text = "First Name:";
            //
            // lblLastName
            //
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(113, 136);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(66, 15);
            lblLastName.TabIndex = 9;
            lblLastName.Text = "Last Name:";
            //
            // txtFName
            //
            txtFName.Location = new Point(190, 85);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(411, 23);
            txtFName.TabIndex = 0;
            //
            // txtLName
            //
            txtLName.Location = new Point(190, 133);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(411, 23);
            txtLName.TabIndex = 1;
            //
            // dgvPerson
            //
            dgvPerson.AllowUserToAddRows = false;
            dgvPerson.AllowUserToDeleteRows = false;
            dgvPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(113, 189);
            dgvPerson.MultiSelect = false;
            dgvPerson.Name = "dgvPerson";
            dgvPerson.ReadOnly = true;
            dgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerson.Size = new Size(488, 150);
            dgvPerson.TabIndex = 7;
            dgvPerson.CellClick += dgvPerson_CellClick;
            //
            // btnBack
            //
            btnBack.Location = new Point(509, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 23);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back To Main";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            //
            // PersonForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(dgvPerson);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRefresh);
            Controls.Add(btnSave);
            Name = "PersonForm";
            Text = "Person";
            Load += PersonForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnRefresh;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtFName;
        private TextBox txtLName;
        private DataGridView dgvPerson;
        private Button btnBack;
    }
}
