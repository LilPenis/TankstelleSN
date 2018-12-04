namespace TankstellenPrg
{
    partial class Säule2
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
            this.S2D = new System.Windows.Forms.Button();
            this.S2B = new System.Windows.Forms.Button();
            this.S298 = new System.Windows.Forms.Button();
            this.SFrT2 = new System.Windows.Forms.TextBox();
            this.SLT2 = new System.Windows.Forms.TextBox();
            this.SFr2 = new System.Windows.Forms.Label();
            this.SL2 = new System.Windows.Forms.Label();
            this.SP2 = new System.Windows.Forms.Button();
            this.SC2 = new System.Windows.Forms.Button();
            this.SS2 = new System.Windows.Forms.Button();
            this.STT2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // S2D
            // 
            this.S2D.Location = new System.Drawing.Point(16, 100);
            this.S2D.Name = "S2D";
            this.S2D.Size = new System.Drawing.Size(191, 35);
            this.S2D.TabIndex = 12;
            this.S2D.Text = "Diesel";
            this.S2D.UseVisualStyleBackColor = true;
            this.S2D.Click += new System.EventHandler(this.S2D_Click);
            // 
            // S2B
            // 
            this.S2B.Location = new System.Drawing.Point(16, 132);
            this.S2B.Name = "S2B";
            this.S2B.Size = new System.Drawing.Size(191, 35);
            this.S2B.TabIndex = 13;
            this.S2B.Text = "BleiFrei";
            this.S2B.UseVisualStyleBackColor = true;
            // 
            // S298
            // 
            this.S298.Location = new System.Drawing.Point(16, 164);
            this.S298.Name = "S298";
            this.S298.Size = new System.Drawing.Size(191, 35);
            this.S298.TabIndex = 14;
            this.S298.Text = "Super98";
            this.S298.UseVisualStyleBackColor = true;
            // 
            // SFrT2
            // 
            this.SFrT2.Location = new System.Drawing.Point(66, 61);
            this.SFrT2.Multiline = true;
            this.SFrT2.Name = "SFrT2";
            this.SFrT2.ReadOnly = true;
            this.SFrT2.Size = new System.Drawing.Size(141, 25);
            this.SFrT2.TabIndex = 18;
            // 
            // SLT2
            // 
            this.SLT2.Location = new System.Drawing.Point(66, 19);
            this.SLT2.Multiline = true;
            this.SLT2.Name = "SLT2";
            this.SLT2.ReadOnly = true;
            this.SLT2.Size = new System.Drawing.Size(141, 25);
            this.SLT2.TabIndex = 17;
            // 
            // SFr2
            // 
            this.SFr2.AutoSize = true;
            this.SFr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFr2.Location = new System.Drawing.Point(12, 61);
            this.SFr2.Name = "SFr2";
            this.SFr2.Size = new System.Drawing.Size(33, 24);
            this.SFr2.TabIndex = 16;
            this.SFr2.Text = "Fr.";
            // 
            // SL2
            // 
            this.SL2.AutoSize = true;
            this.SL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL2.Location = new System.Drawing.Point(12, 19);
            this.SL2.Name = "SL2";
            this.SL2.Size = new System.Drawing.Size(45, 24);
            this.SL2.TabIndex = 15;
            this.SL2.Text = "Liter";
            // 
            // SP2
            // 
            this.SP2.Location = new System.Drawing.Point(16, 250);
            this.SP2.Name = "SP2";
            this.SP2.Size = new System.Drawing.Size(191, 39);
            this.SP2.TabIndex = 21;
            this.SP2.Text = "Bezahlen";
            this.SP2.UseVisualStyleBackColor = true;
            // 
            // SC2
            // 
            this.SC2.Location = new System.Drawing.Point(16, 205);
            this.SC2.Name = "SC2";
            this.SC2.Size = new System.Drawing.Size(96, 39);
            this.SC2.TabIndex = 20;
            this.SC2.Text = "Schliessen";
            this.SC2.UseVisualStyleBackColor = true;
            this.SC2.Click += new System.EventHandler(this.SC2_Click);
            // 
            // SS2
            // 
            this.SS2.Location = new System.Drawing.Point(111, 205);
            this.SS2.Name = "SS2";
            this.SS2.Size = new System.Drawing.Size(96, 39);
            this.SS2.TabIndex = 19;
            this.SS2.Text = "Stop";
            this.SS2.UseVisualStyleBackColor = true;
            this.SS2.Click += new System.EventHandler(this.SS2_Click);
            // 
            // STT2
            // 
            this.STT2.Tick += new System.EventHandler(this.STT2_Tick);
            // 
            // Säule2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 306);
            this.ControlBox = false;
            this.Controls.Add(this.SP2);
            this.Controls.Add(this.SC2);
            this.Controls.Add(this.SS2);
            this.Controls.Add(this.SFrT2);
            this.Controls.Add(this.SLT2);
            this.Controls.Add(this.SFr2);
            this.Controls.Add(this.SL2);
            this.Controls.Add(this.S2D);
            this.Controls.Add(this.S2B);
            this.Controls.Add(this.S298);
            this.MaximumSize = new System.Drawing.Size(240, 345);
            this.MinimumSize = new System.Drawing.Size(240, 345);
            this.Name = "Säule2";
            this.Text = "Säule2";
            this.Load += new System.EventHandler(this.Säule2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button S2D;
        private System.Windows.Forms.Button S2B;
        private System.Windows.Forms.Button S298;
        private System.Windows.Forms.TextBox SFrT2;
        private System.Windows.Forms.TextBox SLT2;
        private System.Windows.Forms.Label SFr2;
        private System.Windows.Forms.Label SL2;
        private System.Windows.Forms.Button SP2;
        private System.Windows.Forms.Button SC2;
        private System.Windows.Forms.Button SS2;
        private System.Windows.Forms.Timer STT2;
    }
}