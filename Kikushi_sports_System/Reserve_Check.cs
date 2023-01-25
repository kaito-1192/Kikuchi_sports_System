using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

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
            //会員番号のテキストボックス
            this.number_text.ReadOnly = true;
            //利用施設のテキストボックス
            this.service_text.ReadOnly = true;
            //日付のテキストボックス
            this.date_text.ReadOnly = true;
            //時間のテキストボックス
            this.time_text.ReadOnly = true;
            //名前のテキストボックス
            this.name_text.ReadOnly = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_button_Click(object sender, EventArgs e)
        {
         //コネクション設定
            SQLiteConnection ResCon = new SQLiteConnection("Data Source=Reserve_Table.db");
            {
                //DBの接続解除
                ResCon.Open();
                using (SQLiteTransaction trans = ResCon.BeginTransaction())
                {
                    SQLiteCommand cmd = ResCon.CreateCommand();
                    //インサート文
                   cmd.CommandText = "INSERT INTO Res_table(CD,r_name,service,date,time)VALUES(@CD,@r_name,@service,@date,@time)";

                    //会員番号のパラメータ定義
                    cmd.Parameters.Add("CD", DbType.String);
                    //氏名のパラメータ定義
                    cmd.Parameters.Add("r_name", DbType.String);
                    //利用施設のパラメータ定義
                    cmd.Parameters.Add("service", DbType.String);
                    //日付のパラメータ定義
                    cmd.Parameters.Add("date", DbType.String);
                    //時間のパラメータ定義
                    cmd.Parameters.Add("time", DbType.String);

                    //会員番号のパラメータ
                    cmd.Parameters["CD"].Value = number_text.Text;
                    //氏名のパラメータ
                    cmd.Parameters["r_name"].Value = name_text.Text;
                    //利用施設のパラメータ
                    cmd.Parameters["service"].Value = service_text.Text;
                    //日付のパラメータ
                    cmd.Parameters["date"].Value = date_text.Text;
                    //時間のパラメータ
                    cmd.Parameters["time"].Value = time_text.Text;    

                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();

                    //登録完了メッセージ
                    MessageBox.Show("予約が完了しました。", "完了画面");
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
