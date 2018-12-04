namespace TankstellenPrg
{
    partial class Säule4
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
            this.S4B = new System.Windows.Forms.Button();
            this.S498 = new System.Windows.Forms.Button();
            this.S4D = new System.Windows.Forms.Button();
            this.SFrT4 = new System.Windows.Forms.TextBox();
            this.SLT4 = new System.Windows.Forms.TextBox();
            this.SFr4 = new System.Windows.Forms.Label();
            this.SL4 = new System.Windows.Forms.Label();
            this.SP4 = new System.Windows.Forms.Button();
            this.SC4 = new System.Windows.Forms.Button();
            this.SS4 = new System.Windows.Forms.Button();
            this.STT4 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // S4B
            // 
            this.S4B.Location = new System.Drawing.Point(16, 132);
            this.S4B.Name = "S4B";
            this.S4B.Size = new System.Drawing.Size(191, 35);
            this.S4B.TabIndex = 13;
            this.S4B.Text = "BleiFrei";
            this.S4B.UseVisualStyleBackColor = true;
            // 
            // S498
            // 
            this.S498.Location = new System.Drawing.Point(16, 164);
            this.S498.Name = "S498";
            this.S498.Size = new System.Drawing.Size(191, 35);
            this.S498.TabIndex = 11;
            this.S498.Text = "Super98";
            this.S498.UseVisualStyleBackColor = true;
            // 
            // S4D
            // 
            this.S4D.Location = new System.Drawing.Point(16, 100);
            this.S4D.Name = "S4D";
            this.S4D.Size = new System.Drawing.Size(191, 35);
            this.S4D.TabIndex = 12;
            this.S4D.Text = "Diesel";
            this.S4D.UseVisualStyleBackColor = true;
            this.S4D.Click += new System.EventHandler(this.S4D_Click);
            // 
            // SFrT4
            // 
            this.SFrT4.Location = new System.Drawing.Point(66, 61);
            this.SFrT4.Multiline = true;
            this.SFrT4.Name = "SFrT4";
            this.SFrT4.ReadOnly = true;
            this.SFrT4.Size = new System.Drawing.Size(141, 25);
            this.SFrT4.TabIndex = 26;
            // 
            // SLT4
            // 
            this.SLT4.Location = new System.Drawing.Point(66, 19);
            this.SLT4.Multiline = true;
            this.SLT4.Name = "SLT4";
            this.SLT4.ReadOnly = true;
            this.SLT4.Size = new System.Drawing.Size(141, 25);
            this.SLT4.TabIndex = 25;
            // 
            // SFr4
            // 
            this.SFr4.AutoSize = true;
            this.SFr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFr4.Location = new System.Drawing.Point(12, 61);
            this.SFr4.Name = "SFr4";
            this.SFr4.Size = new System.Drawing.Size(33, 24);
            this.SFr4.TabIndex = 24;
            this.SFr4.Text = "Fr.";
            // 
            // SL4
            // 
            this.SL4.AutoSize = true;
            this.SL4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL4.Location = new System.Drawing.Point(12, 19);
            this.SL4.Name = "SL4";
            this.SL4.Size = new System.Drawing.Size(45, 24);
            this.SL4.TabIndex = 23;
            this.SL4.Text = "Liter";
            // 
            // SP4
            // 
            this.SP4.Location = new System.Drawing.Point(16, 250);
            this.SP4.Name = "SP4";
            this.SP4.Size = new System.Drawing.Size(191, 39);
            this.SP4.TabIndex = 29;
            this.SP4.Text = "Bezahlen";
            this.SP4.UseVisualStyleBackColor = true;
            // 
            // SC4
            // 
            this.SC4.Location = new System.Drawing.Point(16, 205);
            this.SC4.Name = "SC4";
            this.SC4.Size = new System.Drawing.Size(96, 39);
            this.SC4.TabIndex = 28;
            this.SC4.Text = "Schliessen";
            this.SC4.UseVisualStyleBackColor = true;
            this.SC4.Click += new System.EventHandler(this.SC4_Click);
            // 
            // SS4
            // 
            this.SS4.Location = new System.Drawing.Point(111, 205);
            this.SS4.Name = "SS4";
            this.SS4.Size = new System.Drawing.Size(96, 39);
            this.SS4.TabIndex = 27;
            this.SS4.Text = "Stop";
            this.SS4.UseVisualStyleBackColor = true;
            this.SS4.Click += new System.EventHandler(this.SS4_Click);
            // 
            // STT4
            // 
            this.STT4.Tick += new System.EventHandler(this.STT4_Tick);
            // 
            // Säule4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 306);
            this.ControlBox = false;
            this.Controls.Add(this.SP4);
            this.Controls.Add(this.SC4);
            this.Controls.Add(this.SS4);
            this.Controls.Add(this.SFrT4);
            this.Controls.Add(this.SLT4);
            this.Controls.Add(this.SFr4);
            this.Controls.Add(this.SL4);
            this.Controls.Add(this.S4B);
            this.Controls.Add(this.S498);
            this.Controls.Add(this.S4D);
            this.MaximumSize = new System.Drawing.Size(240, 345);
            this.MinimumSize = new System.Drawing.Size(240, 345);
            this.Name = "Säule4";
            this.Text = "Säule4";
            this.Load += new System.EventHandler(this.Säule4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button S4B;
        private System.Windows.Forms.Button S498;
        private System.Windows.Forms.Button S4D;
        private System.Windows.Forms.TextBox SFrT4;
        private System.Windows.Forms.TextBox SLT4;
        private System.Windows.Forms.Label SFr4;
        private System.Windows.Forms.Label SL4;
        private System.Windows.Forms.Button SP4;
        private System.Windows.Forms.Button SC4;
        private System.Windows.Forms.Button SS4;
        private System.Windows.Forms.Timer STT4;
    }
}