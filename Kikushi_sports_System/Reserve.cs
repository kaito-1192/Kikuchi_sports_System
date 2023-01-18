using System;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Kikushi_sports_System
{
    public partial class Reserve : Form
    {
        //SQLiteのコネクション設定
        SQLiteConnection ResCon = new SQLiteConnection("Data Source=Reserve_Table.db");
        public Reserve()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 予約画面を開いたら予約テーブルを作成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_Load(object sender, EventArgs e)
        {
            //DBに接続
            ResCon.Open();
            using (SQLiteCommand command = ResCon.CreateCommand())
            {
                command.CommandText =
                    "create table if not exists Res_table (rowCount INTEGER PRIMARY KEY AUTOINCREMENT,CD INTEGER,r_name TEXT,service TEXT,date TEXT,time TEXT)";
                command.ExecuteNonQuery();
            }
            //DB接続解除
            ResCon.Close();

            //会員番号を表示
            number_text.Text = Menu.cd;
            //会員番号を編集できないようにする
            number_text.ReadOnly = true;
        }
        /// <summary>
        /// 入力項目を内容確認画面に渡す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_check_button(object sender, EventArgs e)
        {
            //内容確認画面情報を取得
            Reserve_Check res_check = new Reserve_Check();
            //内容確認画面を表示
            res_check.Show();
            //予約画面を非表示
            this.Visible = false;

            //プルダウンで選んだ項目をstring型に変換
            string select_service = service_down.SelectedItem.ToString();
            string select_date = date_text.Value.ToShortDateString();
            string select_time = time_down.SelectedItem.ToString();

            //内容確認画面に渡す
            res_check.number_text.Text = number_text.Text;
            res_check.name_text.Text = nameText.Text;
            res_check.service_text.Text = select_service;
            res_check.date_text.Text = select_date;
            res_check.time_text.Text = select_time;
        }

        private void Back_button_Click(object sender, EventArgs e)
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
