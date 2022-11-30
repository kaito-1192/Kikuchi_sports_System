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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //内容確認のテキストを編集できないようにする
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form3を取得
            Form3 form3 = new Form3();
            form3.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO t_product (m_name,m_phonenumber,m_address,m_birth,m_pass) VALUES(@m_name,@m_phonenumber,@m_address,@m_birth,@m_pass)";
                    cmd.Parameters.Add("m_name", System.Data.DbType.String);
                    cmd.Parameters.Add("m_phonenumber", System.Data.DbType.String);
                    cmd.Parameters.Add("m_address", System.Data.DbType.String);
                    cmd.Parameters.Add("m_birth", System.Data.DbType.String);
                    cmd.Parameters.Add("m_pass", System.Data.DbType.String);
                    //データ追加
                    cmd.Parameters["m_name"].Value = textBox1.Text;
                    cmd.Parameters["m_phonenumber"].Value = textBox2.Text;
                    cmd.Parameters["m_address"].Value = textBox3.Text;
                    cmd.Parameters["m_birth"].Value = textBox4.Text;
                    cmd.Parameters["m_pass"].Value = textBox5.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
            //登録完了メッセージ
            MessageBox.Show("登録が完了しました。","完了画面");
            //メニューに戻る
            Form1 form1 = new Form1();
            form1.Show();
            this.Visible = false;
        }
    }
}
