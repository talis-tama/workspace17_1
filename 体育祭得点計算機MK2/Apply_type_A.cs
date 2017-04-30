using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 体育祭得点計算機MK2
{
    public partial class Apply_type_A : UserControl
    {
        public Apply_type_A()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }
    }
}
