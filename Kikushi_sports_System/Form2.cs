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
            //テキストボックスを編集できないようにする
            textBox1.ReadOnly = true;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                try
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        //string型の会員番号表示変数
                        string cd = null;
                        SQLiteCommand cmd = con.CreateCommand();

                        //CD(会員番号)カラムの中で最大の数値を参照
                        cmd.CommandText = "SELECT MAX(CD) FROM t_product";
                        //readerにSQLの結果を格納
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        //データがある時
                        while (reader.Read())
                        {
                            //cdに値を格納
                            cd = reader.GetValue(0).ToString();
                            //テキストボックスに表示
                            textBox1.Text = cd;
                        }
                        //会員がだれもいないとき、登録画面しか選べないようにする
                        if (cd =="")
                        {
                            button3.Enabled = false;
                            button4.Enabled = false;
                            button5.Enabled = false;
                        }

                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
