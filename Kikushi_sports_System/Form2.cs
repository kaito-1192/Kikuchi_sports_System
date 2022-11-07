using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kikushi_sports_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1取得
            Form1 form1 = new Form1();
            //Form1を表示
            form1.Show();
            //Form2を非表示
            this.Visible = false;
        }
    }
}
