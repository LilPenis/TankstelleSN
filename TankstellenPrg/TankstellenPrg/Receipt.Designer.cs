namespace TankstellenPrg
{
    partial class Receipt
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Betrag = new System.Windows.Forms.TextBox();
            this.bezogeneLiter = new System.Windows.Forms.TextBox();
            this.Bezahlt = new System.Windows.Forms.TextBox();
            this.Rückgeld = new System.Windows.Forms.TextBox();
            this.BbL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DieslTank = new System.Windows.Forms.TextBox();
            this.BleifreiTank = new System.Windows.Forms.TextBox();
            this.Super98Tank = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Betrag
            // 
            this.Betrag.Location = new System.Drawing.Point(103, 8);
            this.Betrag.MaximumSize = new System.Drawing.Size(141, 25);
            this.Betrag.MinimumSize = new System.Drawing.Size(141, 25);
            this.Betrag.Multiline = true;
            this.Betrag.Name = "Betrag";
            this.Betrag.ReadOnly = true;
            this.Betrag.Size = new System.Drawing.Size(141, 25);
            this.Betrag.TabIndex = 4;
            this.Betrag.TextChanged += new System.EventHandler(this.Betrag_TextChanged);
            // 
            // bezogeneLiter
            // 
            this.bezogeneLiter.Location = new System.Drawing.Point(113, 62);
            this.bezogeneLiter.MaximumSize = new System.Drawing.Size(141, 25);
            this.bezogeneLiter.MinimumSize = new System.Drawing.Size(141, 25);
            this.bezogeneLiter.Multiline = true;
            this.bezogeneLiter.Name = "bezogeneLiter";
            this.bezogeneLiter.ReadOnly = true;
            this.bezogeneLiter.Size = new System.Drawing.Size(141, 25);
            this.bezogeneLiter.TabIndex = 5;
            // 
            // Bezahlt
            // 
            this.Bezahlt.Location = new System.Drawing.Point(103, 103);
            this.Bezahlt.MaximumSize = new System.Drawing.Size(141, 25);
            this.Bezahlt.MinimumSize = new System.Drawing.Size(141, 25);
            this.Bezahlt.Multiline = true;
            this.Bezahlt.Name = "Bezahlt";
            this.Bezahlt.ReadOnly = true;
            this.Bezahlt.Size = new System.Drawing.Size(141, 25);
            this.Bezahlt.TabIndex = 6;
            // 
            // Rückgeld
            // 
            this.Rückgeld.Location = new System.Drawing.Point(103, 145);
            this.Rückgeld.MaximumSize = new System.Drawing.Size(141, 25);
            this.Rückgeld.MinimumSize = new System.Drawing.Size(141, 25);
            this.Rückgeld.Multiline = true;
            this.Rückgeld.Name = "Rückgeld";
            this.Rückgeld.ReadOnly = true;
            this.Rückgeld.Size = new System.Drawing.Size(141, 25);
            this.Rückgeld.TabIndex = 7;
            // 
            // BbL
            // 
            this.BbL.AutoSize = true;
            this.BbL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BbL.Location = new System.Drawing.Point(-5, 9);
            this.BbL.Name = "BbL";
            this.BbL.Size = new System.Drawing.Size(33, 24);
            this.BbL.TabIndex = 11;
            this.BbL.Text = "Fr.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fr.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fr.";
            // 
            // DieslTank
            // 
            this.DieslTank.Location = new System.Drawing.Point(103, 176);
            this.DieslTank.MaximumSize = new System.Drawing.Size(141, 25);
            this.DieslTank.MinimumSize = new System.Drawing.Size(141, 25);
            this.DieslTank.Multiline = true;
            this.DieslTank.Name = "DieslTank";
            this.DieslTank.ReadOnly = true;
            this.DieslTank.Size = new System.Drawing.Size(141, 25);
            this.DieslTank.TabIndex = 15;
            // 
            // BleifreiTank
            // 
            this.BleifreiTank.Location = new System.Drawing.Point(103, 207);
            this.BleifreiTank.MaximumSize = new System.Drawing.Size(141, 25);
            this.BleifreiTank.MinimumSize = new System.Drawing.Size(141, 25);
            this.BleifreiTank.Multiline = true;
            this.BleifreiTank.Name = "BleifreiTank";
            this.BleifreiTank.ReadOnly = true;
            this.BleifreiTank.Size = new System.Drawing.Size(141, 25);
            this.BleifreiTank.TabIndex = 16;
            // 
            // Super98Tank
            // 
            this.Super98Tank.Location = new System.Drawing.Point(103, 238);
            this.Super98Tank.MaximumSize = new System.Drawing.Size(141, 25);
            this.Super98Tank.MinimumSize = new System.Drawing.Size(141, 25);
            this.Super98Tank.Multiline = true;
            this.Super98Tank.Name = "Super98Tank";
            this.Super98Tank.ReadOnly = true;
            this.Super98Tank.Size = new System.Drawing.Size(141, 25);
            this.Super98Tank.TabIndex = 17;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Super98Tank);
            this.Controls.Add(this.BleifreiTank);
            this.Controls.Add(this.DieslTank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BbL);
            this.Controls.Add(this.Rückgeld);
            this.Controls.Add(this.Bezahlt);
            this.Controls.Add(this.bezogeneLiter);
            this.Controls.Add(this.Betrag);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox Betrag;
        private System.Windows.Forms.TextBox bezogeneLiter;
        private System.Windows.Forms.TextBox Bezahlt;
        private System.Windows.Forms.TextBox Rückgeld;
        private System.Windows.Forms.Label BbL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DieslTank;
        private System.Windows.Forms.TextBox BleifreiTank;
        private System.Windows.Forms.TextBox Super98Tank;
    }
}