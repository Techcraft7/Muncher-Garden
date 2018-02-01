using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muncher_Garden
{
    public partial class Form1 : Form
    {
        public static double buds = 0;
        public static Row[] rows = new Row[5];
        public Form1()
        {
            InitializeComponent();
            row1.SetSlot(MuncherSlots.a, TypesOfMunchers.Normal);
            rows[0] = row1;
            rows[1] = row2;
            rows[2] = row3;
            buds = 1000;
            rows[3] = row4;
            rows[4] = row5;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void clickme_Click(object sender, EventArgs e)
        {
            counter.Text = String.Format("Buds: {0}", buds);
            Random rng = new Random();
            int RandomTick = rng.Next(0, 5001);
            if (RandomTick >= 4000)
            {
                foreach (Muncher i in row1.Munchers)
                {
                    if (i != null)
                    {
                        UDTXT();
                        i.GenerateBuds();
                    }
                }
            }
        }
        private void UDTXT()
        {
            counter.Text = String.Format("Buds: {0}", buds);
            up.Text = Muncher.UpPrice.ToString();
            bp.Text = Muncher.BuyPrice.ToString();
        }
        private void upgradeclickme_Click(object sender, EventArgs e)
        {
            Muncher.Upgrade(selrow.Value, selcol.Value);
            UDTXT();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Muncher.Buy();
        }
    }
}
