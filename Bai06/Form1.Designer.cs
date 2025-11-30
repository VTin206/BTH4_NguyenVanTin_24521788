namespace Bai06
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCoppy = new System.Windows.Forms.Button();
            this.btnDich = new System.Windows.Forms.Button();
            this.btnNguon = new System.Windows.Forms.Button();
            this.txtDich = new System.Windows.Forms.TextBox();
            this.txtNguon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tooltipTrangThai = new System.Windows.Forms.ToolTip(this.components);
            this.statusstripTrangThai = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusstripTrangThai.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCoppy);
            this.groupBox1.Controls.Add(this.btnDich);
            this.groupBox1.Controls.Add(this.btnNguon);
            this.groupBox1.Controls.Add(this.txtDich);
            this.groupBox1.Controls.Add(this.txtNguon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(557, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // btnCoppy
            // 
            this.btnCoppy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoppy.ForeColor = System.Drawing.Color.Black;
            this.btnCoppy.Location = new System.Drawing.Point(209, 141);
            this.btnCoppy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCoppy.Name = "btnCoppy";
            this.btnCoppy.Size = new System.Drawing.Size(147, 31);
            this.btnCoppy.TabIndex = 6;
            this.btnCoppy.Text = "Sao Chép";
            this.btnCoppy.UseVisualStyleBackColor = true;
            this.btnCoppy.Click += new System.EventHandler(this.btnCoppy_Click);
            // 
            // btnDich
            // 
            this.btnDich.Location = new System.Drawing.Point(504, 92);
            this.btnDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDich.Name = "btnDich";
            this.btnDich.Size = new System.Drawing.Size(41, 24);
            this.btnDich.TabIndex = 5;
            this.btnDich.Text = "...";
            this.btnDich.UseVisualStyleBackColor = true;
            this.btnDich.Click += new System.EventHandler(this.btnDich_Click);
            // 
            // btnNguon
            // 
            this.btnNguon.Location = new System.Drawing.Point(504, 31);
            this.btnNguon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNguon.Name = "btnNguon";
            this.btnNguon.Size = new System.Drawing.Size(41, 24);
            this.btnNguon.TabIndex = 4;
            this.btnNguon.Text = "...";
            this.btnNguon.UseVisualStyleBackColor = true;
            this.btnNguon.Click += new System.EventHandler(this.btnNguon_Click);
            // 
            // txtDich
            // 
            this.txtDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDich.Location = new System.Drawing.Point(223, 92);
            this.txtDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDich.Name = "txtDich";
            this.txtDich.ReadOnly = true;
            this.txtDich.Size = new System.Drawing.Size(277, 23);
            this.txtDich.TabIndex = 3;
            // 
            // txtNguon
            // 
            this.txtNguon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNguon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNguon.Location = new System.Drawing.Point(223, 32);
            this.txtNguon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNguon.Name = "txtNguon";
            this.txtNguon.ReadOnly = true;
            this.txtNguon.Size = new System.Drawing.Size(277, 23);
            this.txtNguon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường dẫn thư mục đích";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn thư mục nguồn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(24, 234);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(557, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến Trình Sao Chép";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 39);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(506, 27);
            this.progressBar1.TabIndex = 0;
            // 
            // statusstripTrangThai
            // 
            this.statusstripTrangThai.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusstripTrangThai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusstripTrangThai.Location = new System.Drawing.Point(0, 327);
            this.statusstripTrangThai.Name = "statusstripTrangThai";
            this.statusstripTrangThai.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusstripTrangThai.Size = new System.Drawing.Size(600, 22);
            this.statusstripTrangThai.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 349);
            this.Controls.Add(this.statusstripTrangThai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Sao Chép Tập Tin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusstripTrangThai.ResumeLayout(false);
            this.statusstripTrangThai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCoppy;
        private System.Windows.Forms.Button btnDich;
        private System.Windows.Forms.Button btnNguon;
        private System.Windows.Forms.TextBox txtDich;
        private System.Windows.Forms.TextBox txtNguon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip tooltipTrangThai;
        private System.Windows.Forms.StatusStrip statusstripTrangThai;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

