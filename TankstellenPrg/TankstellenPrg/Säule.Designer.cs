namespace TankstellenPrg
{
    partial class Säule
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
            this.S1B = new System.Windows.Forms.Button();
            this.S1D = new System.Windows.Forms.Button();
            this.S198 = new System.Windows.Forms.Button();
            this.SL1 = new System.Windows.Forms.Label();
            this.SFr1 = new System.Windows.Forms.Label();
            this.SLT1 = new System.Windows.Forms.TextBox();
            this.SFrT1 = new System.Windows.Forms.TextBox();
            this.SS1 = new System.Windows.Forms.Button();
            this.SC1 = new System.Windows.Forms.Button();
            this.SP1 = new System.Windows.Forms.Button();
            this.STT1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // S1B
            // 
            this.S1B.Location = new System.Drawing.Point(16, 132);
            this.S1B.Name = "S1B";
            this.S1B.Size = new System.Drawing.Size(191, 35);
            this.S1B.TabIndex = 4;
            this.S1B.Text = "BleiFrei";
            this.S1B.UseVisualStyleBackColor = true;
            this.S1B.Click += new System.EventHandler(this.S1B_Click);
            // 
            // S1D
            // 
            this.S1D.Location = new System.Drawing.Point(16, 100);
            this.S1D.Name = "S1D";
            this.S1D.Size = new System.Drawing.Size(191, 35);
            this.S1D.TabIndex = 3;
            this.S1D.Text = "Diesel";
            this.S1D.UseVisualStyleBackColor = true;
            this.S1D.Click += new System.EventHandler(this.S1D_Click);
            // 
            // S198
            // 
            this.S198.Location = new System.Drawing.Point(16, 164);
            this.S198.Name = "S198";
            this.S198.Size = new System.Drawing.Size(191, 35);
            this.S198.TabIndex = 5;
            this.S198.Text = "Super98";
            this.S198.UseVisualStyleBackColor = true;
            this.S198.Click += new System.EventHandler(this.S198_Click);
            // 
            // SL1
            // 
            this.SL1.AutoSize = true;
            this.SL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL1.Location = new System.Drawing.Point(12, 19);
            this.SL1.Name = "SL1";
            this.SL1.Size = new System.Drawing.Size(45, 24);
            this.SL1.TabIndex = 6;
            this.SL1.Text = "Liter";
            // 
            // SFr1
            // 
            this.SFr1.AutoSize = true;
            this.SFr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFr1.Location = new System.Drawing.Point(12, 61);
            this.SFr1.Name = "SFr1";
            this.SFr1.Size = new System.Drawing.Size(33, 24);
            this.SFr1.TabIndex = 7;
            this.SFr1.Text = "Fr.";
            this.SFr1.Click += new System.EventHandler(this.SFr1_Click);
            // 
            // SLT1
            // 
            this.SLT1.Location = new System.Drawing.Point(66, 19);
            this.SLT1.Multiline = true;
            this.SLT1.Name = "SLT1";
            this.SLT1.ReadOnly = true;
            this.SLT1.Size = new System.Drawing.Size(141, 25);
            this.SLT1.TabIndex = 8;
            // 
            // SFrT1
            // 
            this.SFrT1.Location = new System.Drawing.Point(66, 61);
            this.SFrT1.Multiline = true;
            this.SFrT1.Name = "SFrT1";
            this.SFrT1.ReadOnly = true;
            this.SFrT1.Size = new System.Drawing.Size(141, 25);
            this.SFrT1.TabIndex = 9;
            // 
            // SS1
            // 
            this.SS1.Enabled = false;
            this.SS1.Location = new System.Drawing.Point(111, 205);
            this.SS1.Name = "SS1";
            this.SS1.Size = new System.Drawing.Size(96, 39);
            this.SS1.TabIndex = 10;
            this.SS1.Text = "Stop";
            this.SS1.UseVisualStyleBackColor = true;
            this.SS1.Click += new System.EventHandler(this.SS1_Click);
            // 
            // SC1
            // 
            this.SC1.Location = new System.Drawing.Point(16, 205);
            this.SC1.Name = "SC1";
            this.SC1.Size = new System.Drawing.Size(96, 39);
            this.SC1.TabIndex = 11;
            this.SC1.Text = "Schliessen";
            this.SC1.UseVisualStyleBackColor = true;
            this.SC1.Click += new System.EventHandler(this.SC1_Click);
            // 
            // SP1
            // 
            this.SP1.Location = new System.Drawing.Point(16, 250);
            this.SP1.Name = "SP1";
            this.SP1.Size = new System.Drawing.Size(191, 39);
            this.SP1.TabIndex = 12;
            this.SP1.Text = "Bezahlen";
            this.SP1.UseVisualStyleBackColor = true;
            this.SP1.Visible = false;
            this.SP1.Click += new System.EventHandler(this.SP1_Click);
            // 
            // STT1
            // 
            this.STT1.Tick += new System.EventHandler(this.STT1_Tick);
            // 
            // Säule1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 306);
            this.ControlBox = false;
            this.Controls.Add(this.SP1);
            this.Controls.Add(this.SC1);
            this.Controls.Add(this.SS1);
            this.Controls.Add(this.SFrT1);
            this.Controls.Add(this.SLT1);
            this.Controls.Add(this.SFr1);
            this.Controls.Add(this.SL1);
            this.Controls.Add(this.S1B);
            this.Controls.Add(this.S1D);
            this.Controls.Add(this.S198);
            this.MaximumSize = new System.Drawing.Size(240, 345);
            this.MinimumSize = new System.Drawing.Size(240, 345);
            this.Name = "Säule1";
            this.Text = "Säule1";
            this.Load += new System.EventHandler(this.Säule1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button S1B;
        private System.Windows.Forms.Button S1D;
        private System.Windows.Forms.Button S198;
        private System.Windows.Forms.Label SL1;
        private System.Windows.Forms.Label SFr1;
        private System.Windows.Forms.TextBox SLT1;
        private System.Windows.Forms.TextBox SFrT1;
        private System.Windows.Forms.Button SS1;
        private System.Windows.Forms.Button SC1;
        private System.Windows.Forms.Button SP1;
        private System.Windows.Forms.Timer STT1;
    }
}