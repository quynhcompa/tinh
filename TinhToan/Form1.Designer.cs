namespace TinhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btchia);
            this.groupBox1.Controls.Add(this.btnhan);
            this.groupBox1.Controls.Add(this.bttru);
            this.groupBox1.Controls.Add(this.btcong);
            this.groupBox1.Controls.Add(this.txtkq);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(291, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính toán";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(104, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(164, 23);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(104, 82);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(164, 23);
            this.txt2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số b: ";
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(104, 123);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(164, 23);
            this.txtkq.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả: ";
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(103, 183);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(39, 23);
            this.btcong.TabIndex = 6;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            // 
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(148, 183);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(39, 23);
            this.bttru.TabIndex = 7;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            // 
            // btnhan
            // 
            this.btnhan.Location = new System.Drawing.Point(193, 183);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(39, 23);
            this.btnhan.TabIndex = 8;
            this.btnhan.Text = "x";
            this.btnhan.UseVisualStyleBackColor = true;
            // 
            // btchia
            // 
            this.btchia.Location = new System.Drawing.Point(238, 183);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(39, 23);
            this.btchia.TabIndex = 9;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btchia;
        private Button btnhan;
        private Button bttru;
        private Button btcong;
        private TextBox txtkq;
        private Label label3;
        private TextBox txt2;
        private Label label2;
        private TextBox txt1;
    }
}