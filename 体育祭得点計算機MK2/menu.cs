using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace 体育祭得点計算機MK2
{
    public partial class menu : UserControl
    {
        public menu() { InitializeComponent(); }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.f2.Visible = false;
            Form1.f3.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("buckup.dat") == true)
            {
                StreamReader restore = new StreamReader("buckup.dat", System.Text.Encoding.GetEncoding("shift_jis"));
                int count = 0, buff;
                string data;
                while (restore.Peek() > -1)
                {
                    data = restore.ReadLine();
                    buff = int.Parse(data);
                    if (count == 0) { box.point11 = int.Parse(data); }
                    else if (count == 1) { box.point12 = int.Parse(data); }
                    else if (count == 2) { box.point13 = int.Parse(data); }
                    else if (count == 3) { box.point21 = int.Parse(data); }
                    else if (count == 4) { box.point22 = int.Parse(data); }
                    else if (count == 5) { box.point23 = int.Parse(data); }
                    else if (count == 6) { box.point31 = int.Parse(data); }
                    else if (count == 7) { box.point32 = int.Parse(data); }
                    else if (count == 8) { box.point33 = int.Parse(data); }
                    else if (count == 9) { box.point1a = int.Parse(data); }
                    else if (count == 10) { box.point1b = int.Parse(data); }
                    else if (count == 11) { box.point1c = int.Parse(data); }
                    else if (count == 12) { box.point1d = int.Parse(data); }
                    else if (count == 13) { box.point1e = int.Parse(data); }
                    else if (count == 14) { box.point1f = int.Parse(data); }
                    else if (count == 15) { box.point1g = int.Parse(data); }
                    else if (count == 16) { box.point1h = int.Parse(data); }
                    else if (count == 17) { box.point2a = int.Parse(data); }
                    else if (count == 18) { box.point2b = int.Parse(data); }
                    else if (count == 19) { box.point2c = int.Parse(data); }
                    else if (count == 20) { box.point2d = int.Parse(data); }
                    else if (count == 21) { box.point2e = int.Parse(data); }
                    else if (count == 22) { box.point2f = int.Parse(data); }
                    else if (count == 23) { box.point2g = int.Parse(data); }
                    else if (count == 24) { box.point2h = int.Parse(data); }
                    else if (count == 25) { box.point3a = int.Parse(data); }
                    else if (count == 26) { box.point3b = int.Parse(data); }
                    else if (count == 27) { box.point3c = int.Parse(data); }
                    else if (count == 28) { box.point3d = int.Parse(data); }
                    else if (count == 29) { box.point3e = int.Parse(data); }
                    else if (count == 30) { box.point3f = int.Parse(data); }
                    else if (count == 31) { box.point3g = int.Parse(data); }
                    else if (count == 32) { box.point3h = int.Parse(data); }
                    else if (count == 33)
                    {
                        if (buff == 0) { box.b1 = false; }
                        else if (buff == 1) { box.b1 = true; }
                    }
                    else if (count == 34)
                    {
                        if (buff == 0) { box.b2 = false; }
                        else if (buff == 1) { box.b2 = true; }
                    }
                    else if (count == 35)
                    {
                        if (buff == 0) { box.b3 = false; }
                        else if (buff == 1) { box.b3 = true; }
                    }
                    else if (count == 36)
                    {
                        if (buff == 0) { box.b4 = false; }
                        else if (buff == 1) { box.b4 = true; }
                    }
                    else if (count == 37)
                    {
                        if (buff == 0) { box.b5 = false; }
                        else if (buff == 1) { box.b5 = true; }
                    }
                    else if (count == 38)
                    {
                        if (buff == 0) { box.b6 = false; }
                        else if (buff == 1) { box.b6 = true; }
                    }
                    else if (count == 39)
                    {
                        if (buff == 0) { box.b7 = false; }
                        else if (buff == 1) { box.b7 = true; }
                    }
                    else if (count == 40)
                    {
                        if (buff == 0) { box.b8 = false; }
                        else if (buff == 1) { box.b8 = true; }
                    }
                    else if (count == 41)
                    {
                        if (buff == 0) { box.b9 = false; }
                        else if (buff == 1) { box.b9 = true; }
                    }
                    else if (count == 42)
                    {
                        if (buff == 0) { box.b10 = false; }
                        else if (buff == 1) { box.b10 = true; }
                    }
                    else if (count == 43)
                    {
                        if (buff == 0) { box.b11 = false; }
                        else if (buff == 1) { box.b11 = true; }
                    }
                    else if (count == 44)
                    {
                        if (buff == 0) { box.b12 = false; }
                        else if (buff == 1){ box.b12 = true; }
                    }
                    else if (count == 45)
                    {
                        if (buff == 0) { box.b13 = false; }
                        else if (buff == 1) { box.b13 = true; }
                    }
                    else if (count == 46)
                    {
                        if (buff == 0) { box.b14 = false; }
                        else if (buff == 1) { box.b14 = true; }
                    }
                    else if (count == 47)
                    {
                        if (buff == 0) { box.b15 = false; }
                        else if (buff == 1) { box.b15 = true; }
                    }
                    else if (count == 48)
                    {
                        if (buff == 0) { box.b16 = false; }
                        else if (buff == 1) { box.b16 = true; }
                    }
                    else if (count == 49)
                    {
                        if (buff == 0) { box.b17 = false; }
                        else if (buff == 1) { box.b17 = true; }
                    }
                    else if (count == 50)
                    {
                        if (buff == 0) { box.b18 = false; }
                        else if (buff == 1) { box.b18 = true; }
                    }
                    else if (count == 51)
                    {
                        if (buff == 0) { box.b19 = false; }
                        else if (buff == 1) { box.b19 = true; }
                    }
                    else if (count == 52)
                    {
                        if (buff == 0) { box.b20 = false; }
                        else if (buff == 1) { box.b20 = true; }
                    }
                    else if (count == 53)
                    {
                        if (buff == 0) { box.b21 = false; }
                        else if (buff == 1) { box.b21 = true; }
                    }
                    else if (count == 54)
                    {
                        if (buff == 0) { box.b22 = false; }
                        else if (buff == 1) { box.b22 = true; }
                    }
                    else if (count == 55)
                    {
                        if (buff == 0) { box.b23 = false; }
                        else if (buff == 1) { box.b23 = true; }
                    }
                    else if (count == 56)
                    {
                        if (buff == 0) { box.b24 = false; }
                        else if (buff == 1) { box.b24 = true; }
                    }
                    else if (count == 57)
                    {
                        if (buff == 0) { box.b25 = false; }
                        else if (buff == 1) { box.b25 = true; }
                    }
                    else if (count == 58)
                    {
                        if (buff == 0) { box.b26 = false; }
                        else if (buff == 1) { box.b26 = true; }
                    }
                    else if (count == 59)
                    {
                        if (buff == 0) { box.b27 = false; }
                        else if (buff == 1) { box.b27 = true; }
                    }
                    else if (count == 60)
                    {
                        if (buff == 0) { box.b28 = false; }
                        else if (buff == 1) { box.b28 = true; }
                    }
                    else if (count == 61)
                    {
                        if (buff == 0) { box.b29 = false; }
                        else if (buff == 1) { box.b29 = true; }
                    }
                    else if (count == 62)
                    {
                        if (buff == 0) { box.b30 = false; }
                        else if (buff == 1) { box.b30 = true; }
                    }
                    else if (count == 63)
                    {
                        if (buff == 0) { box.b31 = false; }
                        else if (buff == 1) { box.b31 = true; }
                    }
                    else if (count == 64)
                    {
                        if (buff == 0) { box.b32 = false; }
                        else if (buff == 1) { box.b32 = true; }
                    }
                    else if (count == 65)
                    {
                        if (buff == 0) { box.b33 = false; }
                        else if (buff == 1) { box.b33 = true; }
                    }
                    else if (count == 66)
                    {
                        if (buff == 0) { box.b34 = false; }
                        else if (buff == 1) { box.b34 = true; }
                    }
                    else if (count == 67)
                    {
                        if (buff == 0) { box.b35 = false; }
                        else if (buff == 1) { box.b35 = true; }
                    }
                    else if (count == 68)
                    {
                        if (buff == 0) { box.b36 = false; }
                        else if (buff == 1) { box.b36 = true; }
                    }
                    else if (count == 69)
                    {
                        if (buff == 0) { box.b37 = false; }
                        else if (buff == 1) { box.b37 = true; }
                    }
                    else if (count == 70)
                    {
                        if (buff == 0) { box.b38 = false; }
                        else if (buff == 1) { box.b38 = true; }
                    }
                    else if (count == 71)
                    {
                        if (buff == 0) { box.b39 = false; }
                        else if (buff == 1) { box.b39 = true; }
                    }
                    else if (count == 72)
                    {
                        if (buff == 0) { box.b40 = false; }
                        else if (buff == 1) { box.b40 = true; }
                    }
                    else if (count == 73)
                    {
                        if (buff == 0) { box.b41 = false; }
                        else if (buff == 1) { box.b41 = true; }
                    }
                    else if (count == 74)
                    {
                        if (buff == 0) { box.b42 = false; }
                        else if (buff == 1) { box.b42 = true; }
                    }
                    else if (count == 75)
                    {
                        if (buff == 0) { box.b43 = false; }
                        else if (buff == 1) { box.b43 = true; }
                    }
                    count += 1;
                }
                MessageBox.Show("完了しました", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter output = new StreamWriter("log.txt", false, System.Text.Encoding.GetEncoding("shift_jis"));
            string[] jhsclass = { "1年1組", "1年2組", "1年3組", "2年1組", "2年2組", "2年3組", "3年1組", "3年2組", "3年3組" };
            int[] jhs = { box.point11, box.point12, box.point13, box.point21, box.point22, box.point23, box.point31, box.point32, box.point33 };
            var rankjhs = new SortedDictionary<int, int>();
            output.Write("中学部" + output.NewLine);
            foreach (var s in jhs)
            {
                if (rankjhs.ContainsKey(s)) { rankjhs[s] += 1; }
                else { rankjhs.Add(s, 1); }
            }
            int order = 1;
            foreach (var s in rankjhs.Keys.Reverse())
            {
                int count = rankjhs[s];
                rankjhs[s] = order;
                order += count;
            }
            int jhscountcl = 0;
            int jhscountp = 0;
            foreach (var s in jhs)
            {
                output.Write("{0} {1}点->{2}", jhsclass[jhscountcl], jhs[jhscountp], rankjhs[s] + "位" + output.NewLine);
                jhscountcl += 1;
                jhscountp += 1;
            }
            string[] hsclass = { "1年A組", "1年B組", "1年C組", "1年D組", "1年E組", "1年F組", "1年G組", "1年H組", "2年A組", "2年B組", "2年C組", "2年D組", "2年E組", "2年F組", "2年G組", "2年H組", "3年A組", "3年B組", "3年C組", "3年D組", "3年E組", "3年F組", "3年G組", "3年H組" };
            int[] hs = { box.point1a, box.point1b, box.point1c, box.point1d, box.point1e, box.point1f, box.point1g, box.point1h, box.point2a, box.point2b, box.point2c, box.point2d, box.point2e, box.point2f, box.point2g, box.point2h, box.point3a, box.point3b, box.point3c, box.point3d, box.point3e, box.point3f, box.point3g, box.point3h };
            var rankhs = new SortedDictionary<int, int>();
            output.Write("高等部" + output.NewLine);
            foreach (var t in hs)
            {
                if (rankhs.ContainsKey(t))
                {
                    rankhs[t] += 1;
                }
                else
                {
                    rankhs.Add(t, 1);
                }
            }
            int order1 = 1;
            foreach (var t in rankhs.Keys.Reverse())
            {
                int counta = rankhs[t];
                rankhs[t] = order1;
                order1 += counta;
            }
            int hscountcl = 0;
            int hscountp = 0;
            foreach (var t in hs)
            {
                output.Write("{0} {1}点->{2}", hsclass[hscountcl], hs[hscountp], rankhs[t].ToString() + "位" + output.NewLine);
                hscountcl += 1;
                hscountp += 1;
            }
            output.Close();
            Process.Start("log.txt");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form1.f2.Visible = false;
            Form1.f1.Visible = true;
        }
    }
}
