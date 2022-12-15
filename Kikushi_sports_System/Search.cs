using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Search : Form
    {
        //グリッドビューの列指定番号
        const int _Number = 0;
        const int _Name = 1;
        const int _PhoneNumber = 2;
        const int _Address = 3;
        const int _Birth = 4;
        const int _Pass = 5;
        public Search()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 検索画面を開いたらグリッドビューの設定をする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serach_Load(object sender, EventArgs e)
        {
            //dataGridViewの編集をできなくする
            dataGridView1.ReadOnly = true;
  
            // 行ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;
        }

        /// <summary>
        /// 検索画面を押したとき入力された項目を基に情報を検索する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Button_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Searcon = new SQLiteConnection("Data Source=m_table.db"))
            {
                Searcon.Open();
                SQLiteCommand cmd = Searcon.CreateCommand();

                // DataTableを生成する
                DataTable dataTable = new DataTable();

                //SQL生成(名前または番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,m_name,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE m_pass =@M_pass OR CD =@Cd";
                //会員番号のパラメータ定義
                cmd.Parameters.Add("Cd",DbType.String);
                //会員番号のパラメータ
                cmd.Parameters["Cd"].Value = textBox1.Text;
                //パスワードのパラメータ定義
                cmd.Parameters.Add("M_pass",DbType.String);
                //パスワードのパラメータ
                cmd.Parameters["M_pass"].Value = textBox1.Text;

                //dataTableの初期化
                dataTable.Clear();
                //SQLの結果をdataTableに格納
                dataTable.Load(cmd.ExecuteReader());
                //detaTableに結果がないとき(行が0のとき)エラーメッセージを表示
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("検索結果がありませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //グリッドビューに表示
                    dataGridView1.DataSource = dataTable;

                    //グリッドビューの列名設定
                    dataGridView1.Columns[_Number].HeaderText = "番号";
                    dataGridView1.Columns[_Name].HeaderText = "氏名";
                    dataGridView1.Columns[_PhoneNumber].HeaderText = "電話番号";
                    dataGridView1.Columns[_Address].HeaderText = "住所";
                    dataGridView1.Columns[_Birth].HeaderText = "生年月日";
                    dataGridView1.Columns[_Pass].HeaderText = "パスワード";
                }

                Searcon.Close();
            }
        }


        private void Back_Button_Click(object sender, EventArgs e)
        {
            //Form2を取得
            Menu Menu = new Menu();
            //Form2を表示
            Menu.Show();
            //Form5を非表示
            this.Visible = false;
        }

       
    }
}