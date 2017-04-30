using System;
using System.Windows.Forms;

namespace 体育祭得点計算機MK2
{
    public partial class Form1 : Form
    {
        public static main f1;
        public static menu f2;
        public static select f3;
        public static Apply_type_A f4;
        public Form1()
        {
            InitializeComponent();
            Text = "体育祭得点計算機";
            f1 = new main();
            f2 = new menu();
            f3 = new select();
            f4 = new Apply_type_A();
            panel1.Controls.Add(f1);
            panel1.Controls.Add(f2);
            panel1.Controls.Add(f3);
            panel1.Controls.Add(f4);
            f1.Visible = true;
            f2.Visible = false;
            f3.Visible = false;
            f4.Visible = false;
        }
        private void Form1_Load(object sender,EventArgs e) { }
        private void panel1_Paint(object sender,PaintEventArgs e) { }
    }
}
