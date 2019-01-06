using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TankstellenPrg
{
    public partial class Form1 : Form
    {
        Tankstelle tankstelle = new Tankstelle();
        public Form1()
        {
           InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void S1_Click(object sender, EventArgs e)
        {
            
            Zapfsäule Zapfsäule1 = tankstelle.säulen.Find(t => t.Id == 1);
            Säule säule1 = new Säule(Zapfsäule1, tankstelle);
            säule1.Show();

        }

        private void S2_Click(object sender, EventArgs e)
        {
            
            Zapfsäule Zapfsäule2 = tankstelle.säulen.Find(t => t.Id == 2);
            Säule säule2 = new Säule(Zapfsäule2,tankstelle);
            säule2.Show();
            


        }

        private void S3_Click(object sender, EventArgs e)
        {
           
            Zapfsäule Zapfsäule3 = tankstelle.säulen.Find(t => t.Id == 3);
            Säule säule3 = new Säule(Zapfsäule3, tankstelle);
            säule3.Show();


        }

        private void S4_Click(object sender, EventArgs e)
        {
           
            Zapfsäule Zapfsäule4 = tankstelle.säulen.Find(t => t.Id == 4);
            Säule säule4 = new Säule(Zapfsäule4, tankstelle);
            säule4.Show();


        }

        private void CBM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
