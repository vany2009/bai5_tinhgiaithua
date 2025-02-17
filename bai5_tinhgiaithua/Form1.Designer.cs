namespace bai5_tinhgiaithua
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.TextBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.txtTinhGiaiThua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tinh giai thua";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ket qua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "nhap a";
            // 
            // lblkq
            // 
            this.lblkq.Location = new System.Drawing.Point(157, 129);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(100, 20);
            this.lblkq.TabIndex = 2;
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(157, 75);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 20);
            this.txtSo.TabIndex = 3;
            // 
            // txtTinhGiaiThua
            // 
            this.txtTinhGiaiThua.Location = new System.Drawing.Point(167, 189);
            this.txtTinhGiaiThua.Name = "txtTinhGiaiThua";
            this.txtTinhGiaiThua.Size = new System.Drawing.Size(90, 23);
            this.txtTinhGiaiThua.TabIndex = 4;
            this.txtTinhGiaiThua.Text = "Tinh giai thua";
            this.txtTinhGiaiThua.UseVisualStyleBackColor = true;
            this.txtTinhGiaiThua.Click += new System.EventHandler(this.txtTinhTong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTinhGiaiThua);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblkq;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button txtTinhGiaiThua;
    }
}

