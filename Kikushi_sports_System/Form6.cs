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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();

                //Formを取得
                Form7 form7 = new Form7();

                // DataTableを生成します。
                var dataTable = new DataTable();

                //SQL生成(名前または番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,m_name,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE CD =@Cd AND m_pass =@M_pass";
                //パラメータセット
                cmd.Parameters.Add("Cd", System.Data.DbType.String);
                cmd.Parameters["Cd"].Value = textBox1.Text;
                cmd.Parameters.Add("M_pass", System.Data.DbType.String);
                cmd.Parameters["M_pass"].Value = textBox2.Text;

                dataTable.Clear();
                dataTable.Load(cmd.ExecuteReader());
                form7.dataGridView1.DataSource = dataTable;

                //グリッドビューの列名設定
                form7.dataGridView1.Columns[0].HeaderText = "番号";
                form7.dataGridView1.Columns[1].HeaderText = "氏名";
                form7.dataGridView1.Columns[2].HeaderText = "電話番号";
                form7.dataGridView1.Columns[3].HeaderText = "住所";
                form7.dataGridView1.Columns[4].HeaderText = "生年月日";
                form7.dataGridView1.Columns[5].HeaderText = "パスワード";

                form7.textBox6.Text = textBox1.Text;

                form7.Show();
                this.Visible = false;
               
                con.Close();
            }
        }

    }
}
