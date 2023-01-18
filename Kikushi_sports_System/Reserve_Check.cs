using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Reserve_Check : Form
    {
        public Reserve_Check()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 予約内容を編集できないようにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_Check_Load(object sender, EventArgs e)
        {
            this.number_text.ReadOnly = true;
            this.service_text.ReadOnly = true;
            this.date_text.ReadOnly = true;
            this.time_text.ReadOnly = true;
            this.name_text.ReadOnly = true;
        }

        private void Reserve_button_Click(object sender, EventArgs e)
        {
            SQLiteConnection ResCon = new SQLiteConnection("Data Source=Reserve_Table.db");
            {
                ResCon.Open();
                using (SQLiteTransaction trans = ResCon.BeginTransaction())
                {
                    SQLiteCommand cmd = ResCon.CreateCommand();
                    //インサート文
                   cmd.CommandText = "INSERT INTO Res_table(CD,r_name,service,date,time)VALUES(@CD,@r_name,@service,@date,@time)";

                    cmd.Parameters.Add("CD", DbType.String);
                    cmd.Parameters.Add("r_name", DbType.String);
                    cmd.Parameters.Add("service", DbType.String);
                    cmd.Parameters.Add("date", DbType.String);
                    cmd.Parameters.Add("time", DbType.String);

                    cmd.Parameters["CD"].Value = number_text.Text;
                    cmd.Parameters["r_name"].Value = number_text.Text;
                    cmd.Parameters["service"].Value = service_text.Text;
                    cmd.Parameters["date"].Value = date_text.Text;
                    cmd.Parameters["time"].Value = time_text.Text;    

                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();

                    //登録完了メッセージ
                    MessageBox.Show("登録が完了しました。", "完了画面");
                    //ログイン画面の情報を取得
                    Reserve_menu Res_Menu = new Reserve_menu();
                    //ログイン画面を表示
                    Res_Menu.Show();
                    //登録内容確認画面を非表示
                    this.Visible = false;

                }
            }
        }
    }
}
