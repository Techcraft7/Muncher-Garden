using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Muncher_Garden
{
    public enum TypesOfMunchers : byte
    {
        Normal = 1, Bronze = 2, Silver, Gold, Rainbow
    }
    public enum MuncherSlots : byte
    {
        a = 1, b = 2, c, d, e
    }
    class Muncher
    {
        public static double UpPrice = 100;
        public static double BuyPrice = 50;
        public static TypesOfMunchers? MuncherType = null;
        public static MuncherSlots? slot = null;
        public Muncher(TypesOfMunchers _type, MuncherSlots _slot)
        {
            MuncherType = _type;
            slot = _slot;
        }
        public void GenerateBuds()
        {
            switch (MuncherType)
            {
                case TypesOfMunchers.Normal:
                    Form1.buds += 1;
                    break;
                case TypesOfMunchers.Bronze:
                    Form1.buds += 2;
                    break;
                case TypesOfMunchers.Silver:
                    Form1.buds += 3;
                    break;
                case TypesOfMunchers.Gold:
                    Form1.buds += 4;
                    break;
                case TypesOfMunchers.Rainbow:
                    Form1.buds += 5;
                    break;
            }
        }
        public static Bitmap TypeToBitmap(TypesOfMunchers type)
        {
            Bitmap output = null;
            switch (type)
            {
                case TypesOfMunchers.Normal:
                    output = new Bitmap(Resource1.n);
                    break;
                case TypesOfMunchers.Bronze:
                    output = new Bitmap(Resource1.b);
                    break;
                case TypesOfMunchers.Silver:
                    output = new Bitmap(Resource1.s);
                    break;
                case TypesOfMunchers.Gold:
                    output = new Bitmap(Resource1.g);
                    break;
                case TypesOfMunchers.Rainbow:
                    output = new Bitmap(Resource1.r);
                    break;
            }
            return output;
        }
        public byte TypeToByte()
        {
            return ((byte)MuncherType);
        }
        public byte SlotToByte()
        {
            return ((byte)slot);
        }
        public MuncherSlots ByteToSlot(byte input)
        {
            return ((MuncherSlots)input);
        }
        public static void Upgrade(decimal row, decimal col)
        {
            int _row = Convert.ToInt32(row);
            int _col = Convert.ToInt32(col);
            Console.WriteLine(_row);
            Console.WriteLine(_col);
            if (Form1.buds >= UpPrice)
            {
                if (Form1.rows[_row - 1].Munchers[_col - 1] != null)
                {
                    UpPrice += 10;
                    foreach (Row a in Form1.rows)
                    {
                        string[] names = { "row" };
                        if (Form1.rows[_row - 1].Munchers[_col - 1].TypeToByte() < Convert.ToByte(5))
                        {
                            if (a.Name.ToString().ToLower().Split(names, StringSplitOptions.RemoveEmptyEntries)[0] == row.ToString())
                            {
                                Console.WriteLine(new string(a.Name.ToString().Split(names, StringSplitOptions.RemoveEmptyEntries)));
                                Form1.buds += -UpPrice;
                                a.SetSlot((MuncherSlots)col, ((TypesOfMunchers)(a.Munchers[_col - 1].TypeToByte()) + 1));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Muncher was maxed out!");
                            goto foo;
                        }
                    }
                    foo:
                    return;
                }
                else
                {
                    MessageBox.Show("There is not a muncher in selected spot.");
                }
            }
        }
        public static void Buy()
        {
            bool done = false;
            if (Form1.buds >= BuyPrice)
            {
                Form1.buds += -BuyPrice;
                foreach (Row a in Form1.rows)
                {
                    for (byte i = 0; i != 5; i++)
                    {
                        Console.WriteLine(i);
                        if (a.Munchers[i] == null && done == false)
                        {
                            a.Munchers[i] = new Muncher(TypesOfMunchers.Normal, ((MuncherSlots)i + 1));
                            a.SetSlot(a.Munchers[i].ByteToSlot(Convert.ToByte(i + 1)), TypesOfMunchers.Normal);
                            done = true;
                        }
                    }
                }
            }
        }
    }
}
