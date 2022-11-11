using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Kikushi_sports_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1取得
            Form2 form2 = new Form2();
            //Form1を表示
            form2.Show();
            //Form2を非表示
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //form4を取得
            Form4 form4 = new Form4();
            //form4を表示
            form4.Show();
            //form3を非表示
            this.Visible = false;

            //form4の内容確認のテキストに入力したテキストを反映
            form4.textBox1.Text = textBox1.Text;
            form4.textBox2.Text = textBox2.Text;
            form4.textBox3.Text = textBox3.Text;
            form4.textBox4.Text = textBox4.Text;

        }
    }
}
