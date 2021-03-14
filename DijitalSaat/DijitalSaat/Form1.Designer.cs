namespace DijitalSaat
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
            this.pnlSaniye1 = new System.Windows.Forms.Panel();
            this.pnlSaniye0 = new System.Windows.Forms.Panel();
            this.pnlDakika1 = new System.Windows.Forms.Panel();
            this.pnlIkiNokta = new System.Windows.Forms.Panel();
            this.lblIkiNokta = new System.Windows.Forms.Label();
            this.pnlDakika0 = new System.Windows.Forms.Panel();
            this.pnlSaat1 = new System.Windows.Forms.Panel();
            this.pnlSaat0 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlIkiNokta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSaniye1
            // 
            this.pnlSaniye1.Location = new System.Drawing.Point(381, 66);
            this.pnlSaniye1.Name = "pnlSaniye1";
            this.pnlSaniye1.Size = new System.Drawing.Size(40, 80);
            this.pnlSaniye1.TabIndex = 22;
            // 
            // pnlSaniye0
            // 
            this.pnlSaniye0.Location = new System.Drawing.Point(335, 66);
            this.pnlSaniye0.Name = "pnlSaniye0";
            this.pnlSaniye0.Size = new System.Drawing.Size(40, 80);
            this.pnlSaniye0.TabIndex = 21;
            // 
            // pnlDakika1
            // 
            this.pnlDakika1.Location = new System.Drawing.Point(274, 36);
            this.pnlDakika1.Name = "pnlDakika1";
            this.pnlDakika1.Size = new System.Drawing.Size(55, 110);
            this.pnlDakika1.TabIndex = 20;
            // 
            // pnlIkiNokta
            // 
            this.pnlIkiNokta.Controls.Add(this.lblIkiNokta);
            this.pnlIkiNokta.Location = new System.Drawing.Point(152, 36);
            this.pnlIkiNokta.Name = "pnlIkiNokta";
            this.pnlIkiNokta.Size = new System.Drawing.Size(55, 110);
            this.pnlIkiNokta.TabIndex = 18;
            // 
            // lblIkiNokta
            // 
            this.lblIkiNokta.AutoSize = true;
            this.lblIkiNokta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkiNokta.Location = new System.Drawing.Point(9, 27);
            this.lblIkiNokta.Name = "lblIkiNokta";
            this.lblIkiNokta.Size = new System.Drawing.Size(37, 55);
            this.lblIkiNokta.TabIndex = 0;
            this.lblIkiNokta.Text = ":";
            // 
            // pnlDakika0
            // 
            this.pnlDakika0.Location = new System.Drawing.Point(213, 36);
            this.pnlDakika0.Name = "pnlDakika0";
            this.pnlDakika0.Size = new System.Drawing.Size(55, 110);
            this.pnlDakika0.TabIndex = 19;
            // 
            // pnlSaat1
            // 
            this.pnlSaat1.Location = new System.Drawing.Point(91, 36);
            this.pnlSaat1.Name = "pnlSaat1";
            this.pnlSaat1.Size = new System.Drawing.Size(55, 110);
            this.pnlSaat1.TabIndex = 17;
            // 
            // pnlSaat0
            // 
            this.pnlSaat0.Location = new System.Drawing.Point(30, 36);
            this.pnlSaat0.Name = "pnlSaat0";
            this.pnlSaat0.Size = new System.Drawing.Size(55, 110);
            this.pnlSaat0.TabIndex = 16;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(524, 160);
            this.Controls.Add(this.pnlSaniye1);
            this.Controls.Add(this.pnlSaniye0);
            this.Controls.Add(this.pnlDakika1);
            this.Controls.Add(this.pnlIkiNokta);
            this.Controls.Add(this.pnlDakika0);
            this.Controls.Add(this.pnlSaat1);
            this.Controls.Add(this.pnlSaat0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.pnlIkiNokta.ResumeLayout(false);
            this.pnlIkiNokta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSaniye1;
        private System.Windows.Forms.Panel pnlSaniye0;
        private System.Windows.Forms.Panel pnlDakika1;
        private System.Windows.Forms.Panel pnlIkiNokta;
        private System.Windows.Forms.Label lblIkiNokta;
        private System.Windows.Forms.Panel pnlDakika0;
        private System.Windows.Forms.Panel pnlSaat1;
        private System.Windows.Forms.Panel pnlSaat0;
        private System.Windows.Forms.Timer timer;
    }
}

