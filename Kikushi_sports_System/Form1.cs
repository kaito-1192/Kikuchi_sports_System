using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Form1 : Form
    {
        public static string _name = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Form2取得
            //Form2 form2 = new Form2();
            ////Form2を表示
            //form2.Show();
            ////Form1を非表示
            //this.Visible = false;

            using (var con = new SQLiteConnection("Data Source=M_Table.db"))
            {

                //con.Open();
                //using (SQLiteCommand command = con.CreateCommand())
                //{
                //    command.CommandText =
                //        "create table if not exists t_product (CD INTEGER PRIMARY KEY AUTOINCREMENT,m_name TEXT,m_phonenumber TEXT,m_address TEXT,m_birth TEXT,m_pass TEXT)";
                //    command.ExecuteNonQuery();
                //}
                //con.Close();

                con.Open();
                SQLiteCommand cmd = con.CreateCommand();

                //Formを取得
                Form2 form2 = new Form2();

                // DataTableを生成します。
                var dataTable = new DataTable();

                //SQL生成(名前と番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,m_name ,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE m_name =@Name AND m_pass =@M_pass";
                //パラメータセット
                cmd.Parameters.Add("Name", System.Data.DbType.String);
                cmd.Parameters["Name"].Value = textBox1.Text;
                cmd.Parameters.Add("M_pass", System.Data.DbType.String);
                cmd.Parameters["M_pass"].Value = textBox2.Text;

                //datatableを初期化
                dataTable.Clear();
                //datatableにSQLの結果を格納
                dataTable.Load(cmd.ExecuteReader());

                //SQLが正しく実行されたかどうか(会員番号とパスワードが正しいか)
                if (dataTable.Rows.Count == 0)
                {
                    //会員番号　or　パスワードが違う
                    MessageBox.Show("入力された値が違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _name = textBox1.Text;
                    form2.Show();
                    this.Visible = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Visible = false;

            //using (var con = new SQLiteConnection("Data Source=M_Table.db"))
            //{
            //    con.Open();
            //    using (SQLiteCommand command = con.CreateCommand())
            //    {
            //        command.CommandText =
            //            "create table if not exists t_product (CD INTEGER PRIMARY KEY AUTOINCREMENT,m_name TEXT,m_phonenumber TEXT,m_address TEXT,m_birth TEXT,m_pass TEXT)";
            //        command.ExecuteNonQuery();
            //    }
            //    con.Close();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection("Data Source=M_Table.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table if not exists t_product (CD INTEGER PRIMARY KEY AUTOINCREMENT,m_name TEXT,m_phonenumber TEXT,m_address TEXT,m_birth TEXT,m_pass TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
