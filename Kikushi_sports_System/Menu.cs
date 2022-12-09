using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            //ログイン画面情報取得
            Login form1 = new Login();
            //ログイン画面を表示
            form1.Show();
            //Menu画面を非表示
            this.Visible = false;
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            //検索画面情報を取得
            Search form5 = new Search();
            //検索画面を表示
            form5.Show();
            //会員メニュー画面を非表示
            this.Visible = false;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            //修正画面情報を取得
            Edit form6 = new Edit();
            //修正画面を表示
            form6.Show();
            //会員メニュー画面を非表示
            this.Visible = false;
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            //削除画面情報を取得
            Delete form8 = new Delete();
            //削除画面を表示
            form8.Show();
            //会員メニュー画面を非表示
            this.Visible = false;
        }
        /// <summary>
        /// ログイン画面から名前を取得、名前の情報を基に会員番号取得、結果を画面に表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {
            //テキストボックスを編集できないようにする
            textBox1.ReadOnly = true;

            //SQLiteのコネクション設定
            using (SQLiteConnection Menu_con = new SQLiteConnection("Data Source=m_table.db"))
            {
                
                //try
                //{
                //    con.Open();
                //    using (SQLiteTransaction trans = con.BeginTransaction())
                //    {
                //        //string型の会員番号表示変数
                //        string cd = null;
                //        SQLiteCommand cmd = con.CreateCommand();

                //        //CD(会員番号)カラムの中で最大の数値を参照
                //        cmd.CommandText = "SELECT MAX(CD) FROM t_product";
                //        //readerにSQLの結果を格納
                //        SQLiteDataReader reader = cmd.ExecuteReader();

                //        //データがある時
                //        while (reader.Read())
                //        {
                //            //cdに値を格納
                //            cd = reader.GetValue(0).ToString();
                //            //テキストボックスに表示
                //            textBox1.Text = cd;
                //        }

                //    }
                //}
                //finally
                //{
                //    con.Close();
                //}
                try
                {
                    //ログイン画面情報を取得
                    Login form1 = new Login();
                    //DBに接続
                    Menu_con.Open();
                    using (SQLiteTransaction trans = Menu_con.BeginTransaction())
                    {
                        //名前の変数
                        string cd = null;
                        SQLiteCommand cmd = Menu_con.CreateCommand();
                        cmd.CommandText = "SELECT CD FROM t_product WHERE m_name=@Name";
                        //名前検索のパラメータ
                        cmd.Parameters.Add("Name",DbType.String);
                        cmd.Parameters["Name"].Value = Login._name;
                        //SQLの実行
                        //結果をreaderに格納
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        //データがある時
                        while (reader.Read())
                        {
                            cd = reader.GetValue(0).ToString();
                            textBox1.Text = cd;
                        }
                    }
                }
                finally
                {
                    Menu_con.Close();
                }
            }
        }
    }
}
