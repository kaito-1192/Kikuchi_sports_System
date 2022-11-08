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
            using (SQLiteConnection con=new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                using(SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO t_product (m_name,m_phonenumber,m_address,m_birth) VALUES(@m_name,@m_phonenumber,@m_address,@m_birth)";
                    cmd.Parameters.Add("m_name", System.Data.DbType.String);
                    cmd.Parameters.Add("m_phonenumber", System.Data.DbType.Int64);
                    cmd.Parameters.Add("m_address", System.Data.DbType.String);
                    cmd.Parameters.Add("m_birth",System.Data.DbType.Int64);
                    //データ追加
                    cmd.Parameters["m_name"].Value = textBox1.Text;
                    cmd.Parameters["m_phonenumber"].Value = int.Parse(textBox2.Text);
                    cmd.Parameters["m_address"].Value = textBox3.Text;
                    cmd.Parameters["m_birth"].Value = int.Parse(textBox4.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }

            Form4 form4 = new Form4();
            form4.Show();
            this.Visible = false;

            //using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            //{
            //    //dataTebleを作成します
            //    var dataTable = new DataTable();
            //    //SQLの実行
            //    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
            //    adapter.Fill(dataTable);
            //    dataGridView1.DataSource = dataTable;

            //}
        }
    }
}
