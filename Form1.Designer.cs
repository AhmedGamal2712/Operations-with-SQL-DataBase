namespace WinFormsApp1
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
            btnAdd = new Button();
            btnDelete = new Button();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(563, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 70);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(563, 353);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 71);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(109, 49);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(191, 35);
            txtUserName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(109, 107);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(191, 35);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(109, 165);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(191, 35);
            txtPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 64);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 8;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 122);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 180);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 57);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 11;
            label4.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(420, 49);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(191, 29);
            txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(563, 90);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 69);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(563, 262);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 75);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(432, 239);
            dataGridView1.TabIndex = 15;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 472);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}
