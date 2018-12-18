namespace TankstellenPrg
{
    partial class Payment
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
            this.PB = new System.Windows.Forms.Button();
            this.Zä = new System.Windows.Forms.Button();
            this.Zw = new System.Windows.Forms.Button();
            this.Fü = new System.Windows.Forms.Button();
            this.Hun = new System.Windows.Forms.Button();
            this.BezahlBetrag = new System.Windows.Forms.TextBox();
            this.WasBezahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Feuf = new System.Windows.Forms.Button();
            this.Zwei = new System.Windows.Forms.Button();
            this.Ei = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(12, 223);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(168, 32);
            this.PB.TabIndex = 0;
            this.PB.Text = "Pay";
            this.PB.UseVisualStyleBackColor = true;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            // 
            // Zä
            // 
            this.Zä.Location = new System.Drawing.Point(12, 149);
            this.Zä.Name = "Zä";
            this.Zä.Size = new System.Drawing.Size(72, 31);
            this.Zä.TabIndex = 1;
            this.Zä.Text = "10CHF";
            this.Zä.UseVisualStyleBackColor = true;
            this.Zä.Click += new System.EventHandler(this.Zä_Click);
            // 
            // Zw
            // 
            this.Zw.Location = new System.Drawing.Point(108, 149);
            this.Zw.Name = "Zw";
            this.Zw.Size = new System.Drawing.Size(72, 31);
            this.Zw.TabIndex = 2;
            this.Zw.Text = "20CHF";
            this.Zw.UseVisualStyleBackColor = true;
            this.Zw.Click += new System.EventHandler(this.Zw_Click);
            // 
            // Fü
            // 
            this.Fü.Location = new System.Drawing.Point(12, 186);
            this.Fü.Name = "Fü";
            this.Fü.Size = new System.Drawing.Size(72, 31);
            this.Fü.TabIndex = 3;
            this.Fü.Text = "50CHF";
            this.Fü.UseVisualStyleBackColor = true;
            this.Fü.Click += new System.EventHandler(this.Fü_Click);
            // 
            // Hun
            // 
            this.Hun.Location = new System.Drawing.Point(108, 186);
            this.Hun.Name = "Hun";
            this.Hun.Size = new System.Drawing.Size(72, 31);
            this.Hun.TabIndex = 4;
            this.Hun.Text = "100CHF";
            this.Hun.UseVisualStyleBackColor = true;
            this.Hun.Click += new System.EventHandler(this.Hun_Click);
            // 
            // BezahlBetrag
            // 
            this.BezahlBetrag.Location = new System.Drawing.Point(51, 12);
            this.BezahlBetrag.Name = "BezahlBetrag";
            this.BezahlBetrag.ReadOnly = true;
            this.BezahlBetrag.Size = new System.Drawing.Size(141, 20);
            this.BezahlBetrag.TabIndex = 5;
            // 
            // WasBezahl
            // 
            this.WasBezahl.Location = new System.Drawing.Point(51, 38);
            this.WasBezahl.Name = "WasBezahl";
            this.WasBezahl.ReadOnly = true;
            this.WasBezahl.Size = new System.Drawing.Size(141, 20);
            this.WasBezahl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fr.";
            // 
            // Feuf
            // 
            this.Feuf.Location = new System.Drawing.Point(128, 100);
            this.Feuf.Name = "Feuf";
            this.Feuf.Size = new System.Drawing.Size(52, 43);
            this.Feuf.TabIndex = 9;
            this.Feuf.Text = "5CHF";
            this.Feuf.UseVisualStyleBackColor = true;
            this.Feuf.Click += new System.EventHandler(this.Feuf_Click);
            // 
            // Zwei
            // 
            this.Zwei.Location = new System.Drawing.Point(70, 100);
            this.Zwei.Name = "Zwei";
            this.Zwei.Size = new System.Drawing.Size(52, 43);
            this.Zwei.TabIndex = 10;
            this.Zwei.Text = "2CHF";
            this.Zwei.UseVisualStyleBackColor = true;
            this.Zwei.Click += new System.EventHandler(this.Zwei_Click);
            // 
            // Ei
            // 
            this.Ei.Location = new System.Drawing.Point(12, 100);
            this.Ei.Name = "Ei";
            this.Ei.Size = new System.Drawing.Size(52, 43);
            this.Ei.TabIndex = 11;
            this.Ei.Text = "1CHF";
            this.Ei.UseVisualStyleBackColor = true;
            this.Ei.Click += new System.EventHandler(this.Ei_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 277);
            this.ControlBox = false;
            this.Controls.Add(this.Ei);
            this.Controls.Add(this.Zwei);
            this.Controls.Add(this.Feuf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WasBezahl);
            this.Controls.Add(this.BezahlBetrag);
            this.Controls.Add(this.Hun);
            this.Controls.Add(this.Fü);
            this.Controls.Add(this.Zw);
            this.Controls.Add(this.Zä);
            this.Controls.Add(this.PB);
            this.MaximumSize = new System.Drawing.Size(217, 316);
            this.MinimumSize = new System.Drawing.Size(217, 316);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PB;
        private System.Windows.Forms.Button Zä;
        private System.Windows.Forms.Button Zw;
        private System.Windows.Forms.Button Fü;
        private System.Windows.Forms.Button Hun;
        private System.Windows.Forms.TextBox BezahlBetrag;
        private System.Windows.Forms.TextBox WasBezahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Feuf;
        private System.Windows.Forms.Button Zwei;
        private System.Windows.Forms.Button Ei;
    }
}