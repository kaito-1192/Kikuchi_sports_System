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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            //dataGridViewの設定
            dataGridView1.ReadOnly = true;
  
            // 行ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();

                // DataTableを生成します。
                var dataTable = new DataTable();

                //SQL生成(名前または番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,m_name,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE m_pass =@M_pass OR CD =@Cd";
                //パラメータセット
                cmd.Parameters.Add("Cd", System.Data.DbType.String);
                cmd.Parameters["Cd"].Value = textBox1.Text;
                cmd.Parameters.Add("M_pass", System.Data.DbType.String);
                cmd.Parameters["M_pass"].Value = textBox1.Text;

                //dataTableの初期化
                dataTable.Clear();
                //SQLの結果をdataTableに格納
                dataTable.Load(cmd.ExecuteReader());
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("検索結果がありませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //グリッドビューに表示
                    dataGridView1.DataSource = dataTable;

                    //グリッドビューの列名設定
                    dataGridView1.Columns[0].HeaderText = "番号";
                    dataGridView1.Columns[1].HeaderText = "氏名";
                    dataGridView1.Columns[2].HeaderText = "電話番号";
                    dataGridView1.Columns[3].HeaderText = "住所";
                    dataGridView1.Columns[4].HeaderText = "生年月日";
                    dataGridView1.Columns[5].HeaderText = "パスワード";
                }

                con.Close();
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