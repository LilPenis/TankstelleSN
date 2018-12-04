namespace TankstellenPrg
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.S1 = new System.Windows.Forms.Button();
            this.S2 = new System.Windows.Forms.Button();
            this.S3 = new System.Windows.Forms.Button();
            this.S4 = new System.Windows.Forms.Button();
            this.CBM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // S1
            // 
            this.S1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.S1.Location = new System.Drawing.Point(126, 503);
            this.S1.Name = "S1";
            this.S1.Size = new System.Drawing.Size(144, 36);
            this.S1.TabIndex = 14;
            this.S1.Text = "Säule 1";
            this.S1.UseVisualStyleBackColor = true;
            this.S1.Click += new System.EventHandler(this.S1_Click);
            // 
            // S2
            // 
            this.S2.Location = new System.Drawing.Point(460, 450);
            this.S2.Name = "S2";
            this.S2.Size = new System.Drawing.Size(144, 36);
            this.S2.TabIndex = 15;
            this.S2.Text = "Säule 2";
            this.S2.UseVisualStyleBackColor = true;
            this.S2.Click += new System.EventHandler(this.S2_Click);
            // 
            // S3
            // 
            this.S3.Location = new System.Drawing.Point(492, 521);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(144, 36);
            this.S3.TabIndex = 16;
            this.S3.Text = "Säule 3";
            this.S3.UseVisualStyleBackColor = true;
            this.S3.Click += new System.EventHandler(this.S3_Click);
            // 
            // S4
            // 
            this.S4.Location = new System.Drawing.Point(865, 491);
            this.S4.Name = "S4";
            this.S4.Size = new System.Drawing.Size(144, 36);
            this.S4.TabIndex = 17;
            this.S4.Text = "Säule 4";
            this.S4.UseVisualStyleBackColor = true;
            this.S4.Click += new System.EventHandler(this.S4_Click);
            // 
            // CBM
            // 
            this.CBM.Location = new System.Drawing.Point(860, 670);
            this.CBM.Name = "CBM";
            this.CBM.Size = new System.Drawing.Size(136, 47);
            this.CBM.TabIndex = 18;
            this.CBM.Text = "Schliessen";
            this.CBM.UseVisualStyleBackColor = true;
            this.CBM.Click += new System.EventHandler(this.CBM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlBox = false;
            this.Controls.Add(this.CBM);
            this.Controls.Add(this.S4);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.S2);
            this.Controls.Add(this.S1);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Form1";
            this.Text = "Tankstelle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button S1;
        private System.Windows.Forms.Button S2;
        private System.Windows.Forms.Button S3;
        private System.Windows.Forms.Button S4;
        private System.Windows.Forms.Button CBM;
    }
}

