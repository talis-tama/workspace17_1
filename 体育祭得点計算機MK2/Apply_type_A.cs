using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 体育祭得点計算機MK2
{
    public partial class Apply_type_A : UserControl
    {
        public Apply_type_A() { InitializeComponent(); }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                button1.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                label2.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (box.b1 == false)
                {
                    button1.Enabled = false;
                    label2.Text = "登録済み";
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label2.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (box.b2 == false)
                {
                    button1.Enabled = false;
                    label2.Text = "登録済み";
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label2.Text = "1位5点 2位4点 3位3点 4位2点" + Environment.NewLine + "参加点なし";
                if (box.b3 == false)
                {
                    button1.Enabled = false;
                    label2.Text = "登録済み";
                }
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label2.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (box.b4 == false)
                {
                    button1.Enabled = false;
                    label2.Text = "登録済み";
                }
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label2.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点あり";
                if (box.b5 == false)
                {
                    button1.Enabled = false;
                    label2.Text = "登録済み";
                }
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label2.Text = "1位20点 2位15点 3位10点 4位5点" + Environment.NewLine + "参加点なし";
                if (box.b6 == false)
                {
                    button1.Enabled = false;
                    label2.Text = "登録済み";
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            Regex reg = new Regex(@"[^0-9]");
            Match m = reg.Match(tb.Text);
            if (m.Success)
            {
                MessageBox.Show("半角数字以外は入力しないでください。");
                tb.Text = reg.Replace(tb.Text, "");
            }
            if (tb.MaxLength == tb.Text.Length)
            {
                int i = tb.TabIndex + 1;
                foreach (Control c in Controls)
                {
                    if (c.TabIndex == i)
                    {
                        c.Focus();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.f4.Visible = false;
            Form1.f3.Visible = true;
        }
    }
}
