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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //textboxを編集できないようにする
            textBox1.ReadOnly = true;

            //dataGridViewの設定
            dataGridView1.ReadOnly = true;

            // 行ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns[0].HeaderText = "番号";
            dataGridView1.Columns[1].HeaderText = "氏名";
            dataGridView1.Columns[2].HeaderText = "電話番号";
            dataGridView1.Columns[3].HeaderText = "住所";
            dataGridView1.Columns[4].HeaderText = "生年月日";
            dataGridView1.Columns[5].HeaderText = "パスワード";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //データ削除の確認
            DialogResult result = MessageBox.Show("データを削除しますか？",
                "確認",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                //会員番号を基に削除
                using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //SQL
                        cmd.CommandText = "DELETE FROM t_product WHERE CD = @Cd;";
                        // パラメータセット
                        cmd.Parameters.Add("Cd", System.Data.DbType.String);
                        // データ削除
                        cmd.Parameters["Cd"].Value = textBox1.Text;
                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();
                    }
                }

                //Form1を取得
                Login form1 = new Login();
                //Form1を表示
                form1.Show();
                //Formを非表示
                this.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2を取得
            Menu form2 = new Menu();
            //Form2を表示
            form2.Show();
            //Form5を非表示
            this.Visible = false;
        }
    }
}
