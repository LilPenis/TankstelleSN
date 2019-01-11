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
        //Neues Tankstellen Objekt wird erzeugt + Konstruktor in Klasse Tankstelle wird ausgeführt
        Tankstelle tankstelle = new Tankstelle();
        public Form1()
        {
           InitializeComponent();
           
        }
        //Button für Säule 1 welcher Säule 1 Darstellt sobald Button gedrückt wird
        private void S1_Click(object sender, EventArgs e)
        {
            
            Zapfsäule Zapfsäule1 = tankstelle.Säulen.Find(t => t.Id == 1);
            Säule säule1 = new Säule(Zapfsäule1, tankstelle);
            säule1.Show();
            //S1.Enabled = false;

        }
        //Button für Säule 2 welcher Säule 2 Darstellt sobald Button gedrückt wird
        private void S2_Click(object sender, EventArgs e)
        {
            
            Zapfsäule Zapfsäule2 = tankstelle.Säulen.Find(t => t.Id == 2);
            Säule säule2 = new Säule(Zapfsäule2,tankstelle);
            säule2.Show();
            //S2.Enabled = false;
            


        }
        //Button für Säule 3 welcher Säule 3 Darstellt sobald Button gedrückt wird
        private void S3_Click(object sender, EventArgs e)
        {
           
            Zapfsäule Zapfsäule3 = tankstelle.Säulen.Find(t => t.Id == 3);
            Säule säule3 = new Säule(Zapfsäule3, tankstelle);
            säule3.Show();
            //S3.Enabled = false; 


        }
        //Button für Säule 4 welcher Säule 4 Darstellt sobald Button gedrückt wird
        private void S4_Click(object sender, EventArgs e)
        {
           
            Zapfsäule Zapfsäule4 = tankstelle.Säulen.Find(t => t.Id == 4);
            Säule säule4 = new Säule(Zapfsäule4, tankstelle);
            säule4.Show();
            //S4.Enabled = false;


        }
        //Schliesst Form
        private void CBM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
