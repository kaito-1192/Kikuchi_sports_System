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

                //SQL生成(名前と番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,m_name ,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE CD =@Cd AND m_pass =@M_pass";
                //パラメータセット
                cmd.Parameters.Add("Cd", System.Data.DbType.String); 
                cmd.Parameters["Cd"].Value = textBox1.Text;
                cmd.Parameters.Add("M_pass", System.Data.DbType.String);
                cmd.Parameters["M_pass"].Value = textBox2.Text;

                //datatableを初期化
                dataTable.Clear();
                //datatableにSQLの結果を格納
                dataTable.Load(cmd.ExecuteReader());
                //form7のグリッドビューに情報表示
                form7.dataGridView1.DataSource = dataTable;

                //SQLが正しく実行されたかどうか(会員番号とパスワードが正しいか)
                if (dataTable.Rows.Count==0)
                {
                    //会員番号　or　パスワードが違う
                    MessageBox.Show("入力された値が違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    form7.Show();
                    this.Visible = false;

                   
                }
                //グリッドビューの列名設定
                form7.dataGridView1.Columns[0].HeaderText = "番号";
                form7.dataGridView1.Columns[1].HeaderText = "氏名";
                form7.dataGridView1.Columns[2].HeaderText = "電話番号";
                form7.dataGridView1.Columns[3].HeaderText = "住所";
                form7.dataGridView1.Columns[4].HeaderText = "生年月日";
                form7.dataGridView1.Columns[5].HeaderText = "パスワード";

                //form7に会員番号を渡す
                form7.textBox6.Text = textBox1.Text;
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2を取得
            Form2 form2 = new Form2();
            //Form2を表示
            form2.Show();
            //Form5を非表示
            this.Visible = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //テキストボックスを編集できないようにする
            textBox3.ReadOnly = true;
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
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
                        textBox3.Text = cd;
                    }
                }
                con.Close();
            }
        }
    }
}
