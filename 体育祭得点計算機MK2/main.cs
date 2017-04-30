using System;
using System.Windows.Forms;

namespace 体育祭得点計算機MK2
{
    public partial class main : UserControl
    {
        public main()
        {
            InitializeComponent();
            textBox1.Text = box.point11.ToString();
            textBox2.Text = box.point12.ToString();
            textBox3.Text = box.point13.ToString();
            textBox4.Text = box.point21.ToString();
            textBox5.Text = box.point22.ToString();
            textBox6.Text = box.point23.ToString();
            textBox7.Text = box.point31.ToString();
            textBox8.Text = box.point32.ToString();
            textBox9.Text = box.point33.ToString();
            textBox10.Text = box.point1a.ToString();
            textBox11.Text = box.point1b.ToString();
            textBox12.Text = box.point1c.ToString();
            textBox13.Text = box.point1d.ToString();
            textBox14.Text = box.point1e.ToString();
            textBox15.Text = box.point1f.ToString();
            textBox16.Text = box.point1g.ToString();
            textBox17.Text = box.point1h.ToString();
            textBox18.Text = box.point2a.ToString();
            textBox19.Text = box.point2b.ToString();
            textBox20.Text = box.point2c.ToString();
            textBox21.Text = box.point2d.ToString();
            textBox22.Text = box.point2e.ToString();
            textBox23.Text = box.point2f.ToString();
            textBox24.Text = box.point2g.ToString();
            textBox25.Text = box.point2h.ToString();
            textBox26.Text = box.point3a.ToString();
            textBox27.Text = box.point3b.ToString();
            textBox28.Text = box.point3c.ToString();
            textBox29.Text = box.point3d.ToString();
            textBox30.Text = box.point3e.ToString();
            textBox31.Text = box.point3f.ToString();
            textBox32.Text = box.point3g.ToString();
            textBox33.Text = box.point3h.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1.f1.Visible = false;
            Form1.f2.Visible = true;
        }
    }
}
