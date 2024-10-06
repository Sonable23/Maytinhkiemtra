namespace Maytinhkiemtra
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtso2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtso1 = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số Thứ 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "CALCULATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số Thứ 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kết quả";
            // 
            // txtso2
            // 
            this.txtso2.Location = new System.Drawing.Point(452, 195);
            this.txtso2.Name = "txtso2";
            this.txtso2.Size = new System.Drawing.Size(100, 22);
            this.txtso2.TabIndex = 13;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(360, 333);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 22);
            this.txtKQ.TabIndex = 11;
            // 
            // txtso1
            // 
            this.txtso1.Location = new System.Drawing.Point(251, 195);
            this.txtso1.Name = "txtso1";
            this.txtso1.Size = new System.Drawing.Size(100, 22);
            this.txtso1.TabIndex = 12;
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(452, 250);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(75, 23);
            this.btnTru.TabIndex = 10;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(251, 250);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 9;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;

            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(452, 279);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(75, 23);
            this.btnChia.TabIndex = 8;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;

            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(251, 279);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 23);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtso2);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtso1);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtso2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtso1;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
    }
}

