namespace TankstellenPrg
{
    partial class Säule3
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
            this.S3D = new System.Windows.Forms.Button();
            this.S3B = new System.Windows.Forms.Button();
            this.S398 = new System.Windows.Forms.Button();
            this.SFrT3 = new System.Windows.Forms.TextBox();
            this.SLT3 = new System.Windows.Forms.TextBox();
            this.SFr3 = new System.Windows.Forms.Label();
            this.SL3 = new System.Windows.Forms.Label();
            this.SP3 = new System.Windows.Forms.Button();
            this.SC3 = new System.Windows.Forms.Button();
            this.SS3 = new System.Windows.Forms.Button();
            this.STT3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // S3D
            // 
            this.S3D.Location = new System.Drawing.Point(16, 100);
            this.S3D.Name = "S3D";
            this.S3D.Size = new System.Drawing.Size(191, 35);
            this.S3D.TabIndex = 9;
            this.S3D.Text = "Diesel";
            this.S3D.UseVisualStyleBackColor = true;
            this.S3D.Click += new System.EventHandler(this.S3D_Click_1);
            // 
            // S3B
            // 
            this.S3B.Location = new System.Drawing.Point(16, 132);
            this.S3B.Name = "S3B";
            this.S3B.Size = new System.Drawing.Size(191, 35);
            this.S3B.TabIndex = 10;
            this.S3B.Text = "BleiFrei";
            this.S3B.UseVisualStyleBackColor = true;
            // 
            // S398
            // 
            this.S398.Location = new System.Drawing.Point(16, 164);
            this.S398.Name = "S398";
            this.S398.Size = new System.Drawing.Size(191, 35);
            this.S398.TabIndex = 11;
            this.S398.Text = "Super98";
            this.S398.UseVisualStyleBackColor = true;
            // 
            // SFrT3
            // 
            this.SFrT3.Location = new System.Drawing.Point(66, 61);
            this.SFrT3.Multiline = true;
            this.SFrT3.Name = "SFrT3";
            this.SFrT3.ReadOnly = true;
            this.SFrT3.Size = new System.Drawing.Size(141, 25);
            this.SFrT3.TabIndex = 22;
            // 
            // SLT3
            // 
            this.SLT3.Location = new System.Drawing.Point(66, 19);
            this.SLT3.Multiline = true;
            this.SLT3.Name = "SLT3";
            this.SLT3.ReadOnly = true;
            this.SLT3.Size = new System.Drawing.Size(141, 25);
            this.SLT3.TabIndex = 21;
            // 
            // SFr3
            // 
            this.SFr3.AutoSize = true;
            this.SFr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFr3.Location = new System.Drawing.Point(12, 61);
            this.SFr3.Name = "SFr3";
            this.SFr3.Size = new System.Drawing.Size(33, 24);
            this.SFr3.TabIndex = 20;
            this.SFr3.Text = "Fr.";
            // 
            // SL3
            // 
            this.SL3.AutoSize = true;
            this.SL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL3.Location = new System.Drawing.Point(12, 19);
            this.SL3.Name = "SL3";
            this.SL3.Size = new System.Drawing.Size(45, 24);
            this.SL3.TabIndex = 19;
            this.SL3.Text = "Liter";
            // 
            // SP3
            // 
            this.SP3.Location = new System.Drawing.Point(16, 250);
            this.SP3.Name = "SP3";
            this.SP3.Size = new System.Drawing.Size(191, 39);
            this.SP3.TabIndex = 25;
            this.SP3.Text = "Bezahlen";
            this.SP3.UseVisualStyleBackColor = true;
            // 
            // SC3
            // 
            this.SC3.Location = new System.Drawing.Point(16, 205);
            this.SC3.Name = "SC3";
            this.SC3.Size = new System.Drawing.Size(96, 39);
            this.SC3.TabIndex = 24;
            this.SC3.Text = "Schliessen";
            this.SC3.UseVisualStyleBackColor = true;
            this.SC3.Click += new System.EventHandler(this.SC3_Click);
            // 
            // SS3
            // 
            this.SS3.Location = new System.Drawing.Point(111, 205);
            this.SS3.Name = "SS3";
            this.SS3.Size = new System.Drawing.Size(96, 39);
            this.SS3.TabIndex = 23;
            this.SS3.Text = "Stop";
            this.SS3.UseVisualStyleBackColor = true;
            this.SS3.Click += new System.EventHandler(this.SS3_Click_1);
            // 
            // STT3
            // 
            this.STT3.Tick += new System.EventHandler(this.STT3_Tick_1);
            // 
            // Säule3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 306);
            this.ControlBox = false;
            this.Controls.Add(this.SP3);
            this.Controls.Add(this.SC3);
            this.Controls.Add(this.SS3);
            this.Controls.Add(this.SFrT3);
            this.Controls.Add(this.SLT3);
            this.Controls.Add(this.SFr3);
            this.Controls.Add(this.SL3);
            this.Controls.Add(this.S3D);
            this.Controls.Add(this.S3B);
            this.Controls.Add(this.S398);
            this.MaximumSize = new System.Drawing.Size(240, 345);
            this.MinimumSize = new System.Drawing.Size(240, 345);
            this.Name = "Säule3";
            this.Text = "Säule3";
            this.Load += new System.EventHandler(this.Säule3_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button S3D;
        private System.Windows.Forms.Button S3B;
        private System.Windows.Forms.Button S398;
        private System.Windows.Forms.TextBox SFrT3;
        private System.Windows.Forms.TextBox SLT3;
        private System.Windows.Forms.Label SFr3;
        private System.Windows.Forms.Label SL3;
        private System.Windows.Forms.Button SP3;
        private System.Windows.Forms.Button SC3;
        private System.Windows.Forms.Button SS3;
        private System.Windows.Forms.Timer STT3;
    }
}