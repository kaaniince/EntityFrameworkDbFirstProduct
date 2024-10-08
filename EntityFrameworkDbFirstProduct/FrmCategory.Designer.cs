
namespace EntityFrameworkDbFirstProduct
{
    partial class FrmCategory
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtCategoryId = new TextBox();
            label2 = new Label();
            txtCategoryName = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            btnList = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(120, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Category ID";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(481, 286);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(120, 27);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(145, 23);
            txtCategoryId.TabIndex = 3;
            txtCategoryId.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 62);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(120, 59);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(145, 23);
            txtCategoryName.TabIndex = 5;
            txtCategoryName.TextChanged += textBox2_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(120, 194);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(120, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(120, 288);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(145, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            btnList.Location = new Point(120, 113);
            btnList.Name = "btnList";
            btnList.Size = new Size(145, 23);
            btnList.TabIndex = 9;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 323);
            Controls.Add(btnList);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(txtCategoryId);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "FrmCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Category ";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtCategoryId;
        private Label label2;
        private TextBox txtCategoryName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSearch;
        private Button btnList;
    }
}
