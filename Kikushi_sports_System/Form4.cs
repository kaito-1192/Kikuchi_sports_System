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
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                //dataTebleを作成します
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Visible = false;

            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "DELETE FROM t_product WHERE CD = (SELECT COUNT(*) FROM t_product )";
                    //パラメータ
                    //cmd.Parameters.Add("count", System.Data.DbType.Int64);
                    //cmd.Parameters["Cd"].Value = int.Parse(textBox6.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }
    }
}
