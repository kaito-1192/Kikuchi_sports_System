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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form6を取得
            Form6 form6 = new Form6();
            //Form6を表示
            form6.Show();
            //Form2を非表示
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Form6を取得
            Form8 form8 = new Form8();
            //Form6を表示
            form8.Show();
            //Form2を非表示
            this.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();

                    cmd.CommandText = "select MAX(CD) FROM product";
                    var exr = cmd.ExecuteReader();
                    textBox1.Text = exr["CD"] as string;
                }
            }
        }
    }
}
