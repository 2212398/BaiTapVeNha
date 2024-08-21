namespace ListBox
{
    partial class Form1
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
            this.lblDanhsach = new System.Windows.Forms.Label();
            this.listSelectionMode = new System.Windows.Forms.ListBox();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.ListChon = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhsach
            // 
            this.lblDanhsach.AutoSize = true;
            this.lblDanhsach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDanhsach.Location = new System.Drawing.Point(112, 65);
            this.lblDanhsach.Name = "lblDanhsach";
            this.lblDanhsach.Size = new System.Drawing.Size(176, 20);
            this.lblDanhsach.TabIndex = 0;
            this.lblDanhsach.Text = "Danh sách sinh viên lớp";
            // 
            // listSelectionMode
            // 
            this.listSelectionMode.ForeColor = System.Drawing.Color.Blue;
            this.listSelectionMode.FormattingEnabled = true;
            this.listSelectionMode.ItemHeight = 20;
            this.listSelectionMode.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Hoang Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung"});
            this.listSelectionMode.Location = new System.Drawing.Point(91, 114);
            this.listSelectionMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listSelectionMode.Name = "listSelectionMode";
            this.listSelectionMode.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listSelectionMode.Size = new System.Drawing.Size(223, 284);
            this.listSelectionMode.TabIndex = 1;
            this.listSelectionMode.SelectedIndexChanged += new System.EventHandler(this.listSelectionMode_SelectedIndexChanged);
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDanhSachChon.Location = new System.Drawing.Point(501, 65);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(278, 20);
            this.lblDanhSachChon.TabIndex = 2;
            this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // ListChon
            // 
            this.ListChon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ListChon.FormattingEnabled = true;
            this.ListChon.ItemHeight = 20;
            this.ListChon.Location = new System.Drawing.Point(505, 114);
            this.ListChon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListChon.Name = "ListChon";
            this.ListChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListChon.Size = new System.Drawing.Size(223, 284);
            this.ListChon.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(351, 175);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Chọn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(351, 256);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 44);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ListChon);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.listSelectionMode);
            this.Controls.Add(this.lblDanhsach);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "ListBoxs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhsach;
        private System.Windows.Forms.ListBox listSelectionMode;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.ListBox ListChon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
    }
}

