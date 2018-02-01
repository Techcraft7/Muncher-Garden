using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muncher_Garden;

namespace Muncher_Garden
{
    public partial class Row : UserControl
    {
        private Muncher[] munchers = new Muncher[5];
        public Row()
        {
            InitializeComponent();
        }

        internal Muncher[] Munchers { get => munchers; set => munchers = value; }

        public void SetSlot(MuncherSlots slot, TypesOfMunchers type)
        {
            Munchers[(byte)slot - 1] = new Muncher(type, slot);
            switch (slot)
            {
                case MuncherSlots.a:
                    a.Image = Muncher.TypeToBitmap(type);
                    break;
                case MuncherSlots.b:
                    b.Image = Muncher.TypeToBitmap(type);
                    break;
                case MuncherSlots.c:
                    c.Image = Muncher.TypeToBitmap(type);
                    break;
                case MuncherSlots.d:
                    d.Image = Muncher.TypeToBitmap(type);
                    break;
                case MuncherSlots.e:
                    e.Image = Muncher.TypeToBitmap(type);
                    break;
            }
        }
    }
}
