using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Kikushi_sports_System
{
    public partial class Reserve_menu : Form
    {
        public Reserve_menu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 予約実行画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_Click(object sender, EventArgs e)
        {
            //予約メニュー画面情報を取得
            Reserve Reserve = new Reserve();
            //予約メニュー画面を表示
            Reserve.Show();
            //会員メニュー画面を非表示
            this.Visible = false;
        }
        /// <summary>
        /// 予約管理画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_Management_Click(object sender, EventArgs e)
        {
            //予約メニュー画面情報を取得
            Reserve_management Res_Mana = new Reserve_management();
            //予約メニュー画面を表示
            Res_Mana.Show();
            //会員メニュー画面を非表示
            this.Visible = false;
        }
        /// <summary>
        /// 会員メニューに戻る処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Button_Click(object sender, EventArgs e)
        {
            //会員メニュー画面情報を取得
            Menu Menu = new Menu();
            //会員メニュー画面を表示
            Menu.Show();
            //検索画面を非表示
            this.Visible = false;
        }
        /// <summary>
        /// 予約テーブルがなかった時テーブルを作成する
        /// 予約テーブルを検索して、データがないときは予約管理画面に遷移できないようにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_menu_Load(object sender, EventArgs e)
        {
            SQLiteConnection ResCon = new SQLiteConnection("Data Source=Reserve_Table.db");
            {
                //DBに接続
                ResCon.Open();
                using (SQLiteCommand command = ResCon.CreateCommand())
                {
                    //テーブル作成
                    command.CommandText =
                        "create table if not exists Res_table (rowCount INTEGER PRIMARY KEY AUTOINCREMENT,CD INTEGER,r_name TEXT,service TEXT,date TEXT,time TEXT)";
                    command.ExecuteNonQuery();

                    
                    // DataTableを生成する
                    DataTable dataTable = new DataTable();

                    //SQL生成(名前または番号を基にデータを検索)
                    command.CommandText = "SELECT rowCount,CD,r_name,service,date,time FROM Res_table WHERE CD =@Cd";
                    //会員番号のパラメータ定義
                    command.Parameters.Add("Cd", DbType.String);
                    //会員番号のパラメータ
                    command.Parameters["Cd"].Value = Menu.cd;

                    //dataTableの初期化
                    dataTable.Clear();
                    //SQLの結果をdataTableに格納
                    dataTable.Load(command.ExecuteReader());

                    //detaTable予約が入っていないとき予約管理ボタンを押せないようにする
                    if (dataTable.Rows.Count == 0)
                    {
                        Reserve_management_button.Enabled = false;
                    }
                    //detaTable予約が入っているとき予約管理ボタンを押せるようにする
                    else
                    {
                        Reserve_management_button.Enabled = true;
                    }
                }
                //DB接続解除
                ResCon.Close();
            }
        }
    }
}
