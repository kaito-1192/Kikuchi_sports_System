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

        private void back_Button_Click(object sender, EventArgs e)
        {
            //会員メニュー画面情報を取得
            Menu Menu = new Menu();
            //会員メニュー画面を表示
            Menu.Show();
            //検索画面を非表示
            this.Visible = false;
        }

        private void Reserve_menu_Load(object sender, EventArgs e)
        {
            //SQLiteConnection Res_mane_Con = new SQLiteConnection("Data Source=Reserve_Table.db");
            //{
            //    Res_mane_Con.Open();
            //    SQLiteCommand cmd = Res_mane_Con.CreateCommand();
            //    // DataTableを生成する
            //    DataTable dataTable = new DataTable();

            //    //SQL生成(名前または番号を基にデータを検索)
            //    cmd.CommandText = "SELECT CD,service,date,time FROM Res_table WHERE CD =@Cd";
            //    //会員番号のパラメータ定義
            //    cmd.Parameters.Add("Cd", DbType.String);
            //    //会員番号のパラメータ
            //    cmd.Parameters["Cd"].Value = Menu.cd;

            //    //dataTableの初期化
            //    dataTable.Clear();
            //    //SQLの結果をdataTableに格納
            //    dataTable.Load(cmd.ExecuteReader());

            //    //detaTableに結果がないとき(行が0のとき)エラーメッセージを表示
            //    if (dataTable.Rows.Count == 0)
            //    {
            //        Reserve_management_button.Enabled = false;
            //    }
            //    else
            //    {
            //        Reserve_management_button.Enabled = true;
            //    }
            //}
        }
    }
}
