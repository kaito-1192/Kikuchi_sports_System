using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Kikushi_sports_System
{
    public partial class Reserve_management : Form
    {
        //グリッドビューの列指定番号
        const int _RowNumber = 0;
        const int _MemberNumber = 1;
        const int _RName = 2;
        const int _Service = 3;
        const int _Date = 4;
        const int _Time = 5;
        public Reserve_management()
        {
            InitializeComponent();
        }

        private void Reserve_management_Load(object sender, EventArgs e)
        {
            //dataGridViewの編集をできなくする
            dataGridView1.ReadOnly = true;

            // 行ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;

            SQLiteConnection Res_mane_Con = new SQLiteConnection("Data Source=Reserve_Table.db");
            {
                Res_mane_Con.Open();
                SQLiteCommand cmd = Res_mane_Con.CreateCommand();
                // DataTableを生成する
                DataTable dataTable = new DataTable();

                //SQL生成(名前または番号を基にデータを検索)
                cmd.CommandText = "SELECT rowCount,CD,r_name,service,date,time FROM Res_table WHERE CD =@Cd";
                //会員番号のパラメータ定義
                cmd.Parameters.Add("Cd", DbType.String);
                //会員番号のパラメータ
                cmd.Parameters["Cd"].Value = Menu.cd;

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
                    dataGridView1.Columns[_RowNumber].HeaderText = "予約番号";
                    dataGridView1.Columns[_MemberNumber].HeaderText = "会員番号";
                    dataGridView1.Columns[_RName].HeaderText = "氏名";
                    dataGridView1.Columns[_Service].HeaderText = "利用施設";
                    dataGridView1.Columns[_Date].HeaderText = "日にち";
                    dataGridView1.Columns[_Time].HeaderText = "時間";
                }
            }
           
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            //会員メニュー画面情報を取得
            Reserve_menu Res_Menu = new Reserve_menu();
            //会員メニュー画面を表示
            Res_Menu.Show();
            //検索画面を非表示
            this.Visible = false;
        }
    }
}
