namespace DogrusalSifrelemeAffineChipper
{
    partial class DogrusalSifreleForm
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
            this.btnSifrele = new System.Windows.Forms.Button();
            this.lblFormul = new System.Windows.Forms.Label();
            this.lblAAnahtari = new System.Windows.Forms.Label();
            this.txtAAnahtari = new System.Windows.Forms.TextBox();
            this.txtBAnahtari = new System.Windows.Forms.TextBox();
            this.lblBAnahtari = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxMetin = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSifreliMetin = new System.Windows.Forms.RichTextBox();
            this.rtxtsifreli = new System.Windows.Forms.RichTextBox();
            this.rtxtcozulu = new System.Windows.Forms.RichTextBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.btnCoz = new System.Windows.Forms.Button();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSifrele
            // 
            this.btnSifrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSifrele.Location = new System.Drawing.Point(627, 7);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(153, 33);
            this.btnSifrele.TabIndex = 0;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // lblFormul
            // 
            this.lblFormul.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormul.AutoSize = true;
            this.lblFormul.Location = new System.Drawing.Point(521, 18);
            this.lblFormul.Name = "lblFormul";
            this.lblFormul.Size = new System.Drawing.Size(100, 16);
            this.lblFormul.TabIndex = 5;
            this.lblFormul.Text = "Formül: y=ax+b";
            // 
            // lblAAnahtari
            // 
            this.lblAAnahtari.AutoSize = true;
            this.lblAAnahtari.Location = new System.Drawing.Point(4, 17);
            this.lblAAnahtari.Name = "lblAAnahtari";
            this.lblAAnahtari.Size = new System.Drawing.Size(21, 16);
            this.lblAAnahtari.TabIndex = 1;
            this.lblAAnahtari.Text = "A:";
            // 
            // txtAAnahtari
            // 
            this.txtAAnahtari.Location = new System.Drawing.Point(31, 14);
            this.txtAAnahtari.Name = "txtAAnahtari";
            this.txtAAnahtari.Size = new System.Drawing.Size(100, 23);
            this.txtAAnahtari.TabIndex = 2;
            this.txtAAnahtari.Text = "3";
            // 
            // txtBAnahtari
            // 
            this.txtBAnahtari.Location = new System.Drawing.Point(163, 14);
            this.txtBAnahtari.Name = "txtBAnahtari";
            this.txtBAnahtari.Size = new System.Drawing.Size(100, 23);
            this.txtBAnahtari.TabIndex = 3;
            this.txtBAnahtari.Text = "2";
            // 
            // lblBAnahtari
            // 
            this.lblBAnahtari.AutoSize = true;
            this.lblBAnahtari.Location = new System.Drawing.Point(137, 17);
            this.lblBAnahtari.Name = "lblBAnahtari";
            this.lblBAnahtari.Size = new System.Drawing.Size(20, 16);
            this.lblBAnahtari.TabIndex = 4;
            this.lblBAnahtari.Text = "B:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 496);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pnl1);
            this.tabPage1.Controls.Add(this.richTextBoxSifreliMetin);
            this.tabPage1.Controls.Add(this.richTextBoxMetin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Şifrele";
            this.tabPage1.ToolTipText = "Metinleri Şifrele";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pnl2);
            this.tabPage2.Controls.Add(this.rtxtcozulu);
            this.tabPage2.Controls.Add(this.rtxtsifreli);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çöz";
            this.tabPage2.ToolTipText = "Şifrelenmiş Metinleri Çöz";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxMetin
            // 
            this.richTextBoxMetin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMetin.Location = new System.Drawing.Point(3, 23);
            this.richTextBoxMetin.Name = "richTextBoxMetin";
            this.richTextBoxMetin.Size = new System.Drawing.Size(782, 198);
            this.richTextBoxMetin.TabIndex = 1;
            this.richTextBoxMetin.Text = "";
            // 
            // richTextBoxSifreliMetin
            // 
            this.richTextBoxSifreliMetin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSifreliMetin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxSifreliMetin.Location = new System.Drawing.Point(3, 242);
            this.richTextBoxSifreliMetin.Name = "richTextBoxSifreliMetin";
            this.richTextBoxSifreliMetin.ReadOnly = true;
            this.richTextBoxSifreliMetin.Size = new System.Drawing.Size(782, 176);
            this.richTextBoxSifreliMetin.TabIndex = 3;
            this.richTextBoxSifreliMetin.Text = "";
            // 
            // rtxtsifreli
            // 
            this.rtxtsifreli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtsifreli.Location = new System.Drawing.Point(0, 30);
            this.rtxtsifreli.Name = "rtxtsifreli";
            this.rtxtsifreli.Size = new System.Drawing.Size(790, 190);
            this.rtxtsifreli.TabIndex = 0;
            this.rtxtsifreli.Text = "";
            // 
            // rtxtcozulu
            // 
            this.rtxtcozulu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtcozulu.Location = new System.Drawing.Point(1, 253);
            this.rtxtcozulu.Name = "rtxtcozulu";
            this.rtxtcozulu.ReadOnly = true;
            this.rtxtcozulu.Size = new System.Drawing.Size(790, 162);
            this.rtxtcozulu.TabIndex = 1;
            this.rtxtcozulu.Text = "";
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.txtAAnahtari);
            this.pnl1.Controls.Add(this.lblFormul);
            this.pnl1.Controls.Add(this.lblAAnahtari);
            this.pnl1.Controls.Add(this.btnSifrele);
            this.pnl1.Controls.Add(this.lblBAnahtari);
            this.pnl1.Controls.Add(this.txtBAnahtari);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl1.Location = new System.Drawing.Point(3, 424);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(785, 43);
            this.pnl1.TabIndex = 6;
            // 
            // txtA
            // 
            this.txtA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtA.Location = new System.Drawing.Point(39, 12);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 8;
            this.txtA.Text = "3";
            // 
            // lblA
            // 
            this.lblA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 15);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "A:";
            // 
            // btnCoz
            // 
            this.btnCoz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCoz.Location = new System.Drawing.Point(623, 5);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(153, 33);
            this.btnCoz.TabIndex = 6;
            this.btnCoz.Text = "Çöz";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // lblB
            // 
            this.lblB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(145, 15);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 10;
            this.lblB.Text = "B:";
            // 
            // txtB
            // 
            this.txtB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtB.Location = new System.Drawing.Point(171, 12);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 9;
            this.txtB.Text = "2";
            // 
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.Controls.Add(this.btnCoz);
            this.pnl2.Controls.Add(this.txtA);
            this.pnl2.Controls.Add(this.lblB);
            this.pnl2.Controls.Add(this.txtB);
            this.pnl2.Controls.Add(this.lblA);
            this.pnl2.Location = new System.Drawing.Point(6, 421);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(779, 43);
            this.pnl2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Şifrelenecek Metin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(0, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifreli Metin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Çözülmüş Metin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Şifrelenmiş Metin:";
            // 
            // DogrusalSifreleForm
            // 
            this.AcceptButton = this.btnSifrele;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "DogrusalSifreleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doğrusal Şifreleme";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Label lblFormul;
        private System.Windows.Forms.Label lblBAnahtari;
        private System.Windows.Forms.TextBox txtBAnahtari;
        private System.Windows.Forms.TextBox txtAAnahtari;
        private System.Windows.Forms.Label lblAAnahtari;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxMetin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBoxSifreliMetin;
        private System.Windows.Forms.RichTextBox rtxtcozulu;
        private System.Windows.Forms.RichTextBox rtxtsifreli;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;




    }
}

