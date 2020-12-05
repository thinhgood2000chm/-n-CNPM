namespace QuanLyCuaHang
{
    partial class ManageProduct
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteTextbox = new System.Windows.Forms.Button();
            this.txtStt = new System.Windows.Forms.Label();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.MaSP = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbSpicesToy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteTextbox);
            this.panel2.Controls.Add(this.txtStt);
            this.panel2.Controls.Add(this.txtMaSp);
            this.panel2.Controls.Add(this.MaSP);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.cbSpicesToy);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnChange);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtProducer);
            this.panel2.Controls.Add(this.txtNameProduct);
            this.panel2.Location = new System.Drawing.Point(418, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 382);
            this.panel2.TabIndex = 3;
            // 
            // btnDeleteTextbox
            // 
            this.btnDeleteTextbox.Location = new System.Drawing.Point(126, 306);
            this.btnDeleteTextbox.Name = "btnDeleteTextbox";
            this.btnDeleteTextbox.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteTextbox.TabIndex = 21;
            this.btnDeleteTextbox.Text = "Xóa dữ liệu textbox";
            this.btnDeleteTextbox.UseVisualStyleBackColor = true;
            this.btnDeleteTextbox.Click += new System.EventHandler(this.btnDeleteTextbox_Click);
            // 
            // txtStt
            // 
            this.txtStt.AutoSize = true;
            this.txtStt.ForeColor = System.Drawing.SystemColors.Control;
            this.txtStt.Location = new System.Drawing.Point(35, 13);
            this.txtStt.Name = "txtStt";
            this.txtStt.Size = new System.Drawing.Size(0, 13);
            this.txtStt.TabIndex = 20;
            // 
            // txtMaSp
            // 
            this.txtMaSp.Enabled = false;
            this.txtMaSp.Location = new System.Drawing.Point(95, 25);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(200, 20);
            this.txtMaSp.TabIndex = 0;
            this.txtMaSp.TextChanged += new System.EventHandler(this.txtMaSp_TextChanged);
            // 
            // MaSP
            // 
            this.MaSP.AutoSize = true;
            this.MaSP.Location = new System.Drawing.Point(22, 32);
            this.MaSP.Name = "MaSP";
            this.MaSP.Size = new System.Drawing.Size(71, 13);
            this.MaSP.TabIndex = 19;
            this.MaSP.Text = "Mã sản phẩm";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(126, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbSpicesToy
            // 
            this.cbSpicesToy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpicesToy.FormattingEnabled = true;
            this.cbSpicesToy.Items.AddRange(new object[] {
            "dưới 3 tuổi",
            "từ 3 đến 6 tuổi",
            "từ 6-15 tuổi",
            "trên 15 tuổi"});
            this.cbSpicesToy.Location = new System.Drawing.Point(94, 156);
            this.cbSpicesToy.Name = "cbSpicesToy";
            this.cbSpicesToy.Size = new System.Drawing.Size(131, 21);
            this.cbSpicesToy.TabIndex = 4;
            this.cbSpicesToy.SelectedIndexChanged += new System.EventHandler(this.cbSpicesToy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Loại đồ chơi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 266);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(95, 122);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 20);
            this.txtCost.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đơn giá";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(219, 233);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nơi sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ ĐỒ CHƠI";
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(96, 93);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(199, 20);
            this.txtProducer.TabIndex = 2;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(96, 60);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(200, 20);
            this.txtNameProduct.TabIndex = 1;
            this.txtNameProduct.TextChanged += new System.EventHandler(this.txtNameProduct_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 382);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(244, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "nhập tên sản phẩm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(138, 10);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 6;
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProduct";
            this.Text = "Quản lý sản phẩm ";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSpicesToy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label MaSP;
        private System.Windows.Forms.Label txtStt;
        private System.Windows.Forms.Button btnDeleteTextbox;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFind;
    }
}