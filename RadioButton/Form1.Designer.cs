﻿namespace RadioButton
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
            this.grGioiTinh = new System.Windows.Forms.GroupBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.grGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grGioiTinh
            // 
            this.grGioiTinh.Controls.Add(this.rbNu);
            this.grGioiTinh.Controls.Add(this.rbNam);
            this.grGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grGioiTinh.Location = new System.Drawing.Point(247, 147);
            this.grGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grGioiTinh.Name = "grGioiTinh";
            this.grGioiTinh.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grGioiTinh.Size = new System.Drawing.Size(379, 246);
            this.grGioiTinh.TabIndex = 0;
            this.grGioiTinh.TabStop = false;
            this.grGioiTinh.Text = "Giới Tính";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Checked = true;
            this.rbNu.Location = new System.Drawing.Point(58, 120);
            this.rbNu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(69, 33);
            this.rbNu.TabIndex = 1;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(58, 62);
            this.rbNam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(89, 33);
            this.rbNam.TabIndex = 0;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.grGioiTinh);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grGioiTinh.ResumeLayout(false);
            this.grGioiTinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grGioiTinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
    }
}

