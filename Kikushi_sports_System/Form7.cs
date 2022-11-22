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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            textBox6.ReadOnly = true;

            dataGridView1.Columns[0].HeaderText = "番号";
            dataGridView1.Columns[1].HeaderText = "氏名";
            dataGridView1.Columns[2].HeaderText = "電話番号";
            dataGridView1.Columns[3].HeaderText = "住所";
            dataGridView1.Columns[4].HeaderText = "生年月日";
            dataGridView1.Columns[5].HeaderText = "パスワード";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    
                    if (textBox5.Text.Length > 3 && textBox1.Text!=""&& textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""&& textBox5.Text != "")
                    {
                        cmd.CommandText =
                            "UPDATE t_product set m_name = @M_name, m_phonenumber = @M_phonenumber, m_address = @M_address, m_birth = @M_birth, m_pass = @M_pass WHERE CD = @Cd ;";
                        // パラメータセット
                        cmd.Parameters.Add("M_name", System.Data.DbType.String);
                        cmd.Parameters.Add("M_phonenumber", System.Data.DbType.String);
                        cmd.Parameters.Add("M_address", System.Data.DbType.String);
                        cmd.Parameters.Add("M_birth", System.Data.DbType.String);
                        cmd.Parameters.Add("M_pass", System.Data.DbType.String);
                        cmd.Parameters.Add("Cd", System.Data.DbType.String);
                        // データ修正
                        cmd.Parameters["M_name"].Value = textBox1.Text;
                        cmd.Parameters["M_phonenumber"].Value = textBox2.Text;
                        cmd.Parameters["M_address"].Value = textBox3.Text;
                        cmd.Parameters["M_birth"].Value = textBox4.Text;
                        cmd.Parameters["M_pass"].Value = textBox5.Text;
                        cmd.Parameters["Cd"].Value = textBox6.Text;
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();

                        //修正完了メッセージ
                        MessageBox.Show("修正が完了しました。", "完了画面");
                        //メニューに戻る
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("入力エラー。※パスワードは4文字以上です", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }
    }
}
