namespace GUI.SACH
{
    partial class FormDeleteSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tim_button = new System.Windows.Forms.Button();
            this.xoa_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.masach_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongton_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach_col,
            this.tensach_col,
            this.theloai_col,
            this.tacgia_col,
            this.dongia_col,
            this.soluongton_col});
            this.dataGridView1.Location = new System.Drawing.Point(28, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(819, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // tim_button
            // 
            this.tim_button.Location = new System.Drawing.Point(240, 22);
            this.tim_button.Name = "tim_button";
            this.tim_button.Size = new System.Drawing.Size(49, 23);
            this.tim_button.TabIndex = 3;
            this.tim_button.Text = "Search";
            this.tim_button.UseVisualStyleBackColor = true;
            // 
            // xoa_button
            // 
            this.xoa_button.Location = new System.Drawing.Point(798, 49);
            this.xoa_button.Name = "xoa_button";
            this.xoa_button.Size = new System.Drawing.Size(49, 23);
            this.xoa_button.TabIndex = 4;
            this.xoa_button.Text = "Delete";
            this.xoa_button.UseVisualStyleBackColor = true;
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(416, 320);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(49, 23);
            this.close_button.TabIndex = 5;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            // 
            // masach_col
            // 
            this.masach_col.HeaderText = "Mã sách";
            this.masach_col.Name = "masach_col";
            // 
            // tensach_col
            // 
            this.tensach_col.HeaderText = "Tên sách";
            this.tensach_col.Name = "tensach_col";
            // 
            // theloai_col
            // 
            this.theloai_col.HeaderText = "Thể loại";
            this.theloai_col.Name = "theloai_col";
            // 
            // tacgia_col
            // 
            this.tacgia_col.HeaderText = "Tác giả";
            this.tacgia_col.Name = "tacgia_col";
            // 
            // dongia_col
            // 
            this.dongia_col.HeaderText = "Đơn giá";
            this.dongia_col.Name = "dongia_col";
            // 
            // soluongton_col
            // 
            this.soluongton_col.HeaderText = "Số lượng tồn";
            this.soluongton_col.Name = "soluongton_col";
            // 
            // FormDeleteSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 355);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.xoa_button);
            this.Controls.Add(this.tim_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormDeleteSach";
            this.Text = "Xóa sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongton_col;
        private System.Windows.Forms.Button tim_button;
        private System.Windows.Forms.Button xoa_button;
        private System.Windows.Forms.Button close_button;
    }
}