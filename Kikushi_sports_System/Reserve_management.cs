using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Kikushi_sports_System
{
    public partial class Reserve_management : Form
    {
        public Reserve_management()
        {
            InitializeComponent();
        }

        private void Reserve_management_Load(object sender, EventArgs e)
        {
            SQLiteConnection Res_mane_Con = new SQLiteConnection("Data Source=Reserve_Table.db");
            {
                Res_mane_Con.Open();
                SQLiteCommand cmd = Res_mane_Con.CreateCommand();
                // DataTableを生成する
                DataTable dataTable = new DataTable();

                //SQL生成(名前または番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,r_name,service,date,time FROM Res_table WHERE CD =@Cd";
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
