﻿namespace ABD
{
    partial class frmMonHoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtSoTC = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số TC";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(118, 32);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(241, 22);
            this.txtTenMH.TabIndex = 2;
            // 
            // txtSoTC
            // 
            this.txtSoTC.Location = new System.Drawing.Point(440, 33);
            this.txtSoTC.Name = "txtSoTC";
            this.txtSoTC.Size = new System.Drawing.Size(100, 22);
            this.txtSoTC.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(559, 32);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(656, 32);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 105);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoTC);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonHoc";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtSoTC;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}