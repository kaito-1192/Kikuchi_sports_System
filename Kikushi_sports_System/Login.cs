using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Login : Form
    { 
        //SQLiteのコネクション設定
        SQLiteConnection LogCon = new SQLiteConnection("Data Source=M_Table.db");
        //Menu画面に渡す氏名の変数
        public static string _name = "";
        //のぞき見防止のbool変数
        private bool _isOpen = false;

        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DBに接続、名前とパスワードで認証
        /// 登録された名前とパスワードが一致していたらMenu画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_button_Click(object sender, EventArgs e)
        {
            //DBに接続
            LogCon.Open();
            SQLiteCommand cmd = LogCon.CreateCommand();

            //Menu画面情報を取得
            Menu Menu = new Menu();

            // DataTableを生成
            DataTable dataTable = new DataTable();

            //SQL生成(名前と番号を基にデータを検索)
            cmd.CommandText = "SELECT CD,m_name ,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE m_name =@Name AND m_pass =@M_pass";
            //名前のパラメータ定義
            cmd.Parameters.Add("Name",DbType.String);
            //名前のパラメータ
            cmd.Parameters["Name"].Value = nameText.Text;
            //パスワードのパラメータ定義
            cmd.Parameters.Add("M_pass",DbType.String);
            //名前のパラメータ
            cmd.Parameters["M_pass"].Value = passText.Text;

            //datatableを初期化
            dataTable.Clear();
            //datatableにSQLの結果を格納
            dataTable.Load(cmd.ExecuteReader());

            //detaTableに結果がないとき(行が0のとき)エラーメッセージを表示
            if (dataTable.Rows.Count == 0)
            {
                //会員番号　or　パスワードが違う
                MessageBox.Show("入力された値が違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //入力した名前を変数に格納
                _name = nameText.Text;
                //会員メニュー画面を表示
                Menu.Show();
                //ログイン画面を非表示
                this.Visible = false;
            }
        }
        /// <summary>
        /// まだ登録していない場合、登録画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Click(object sender, EventArgs e)
        {
            //登録画面情報取得
            Register Register = new Register();
            //登録画面表示
            Register.Show();
            //ログイン画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// Login画面を表示したら、tableを作成する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            //DBに接続
            LogCon.Open();
            using (SQLiteCommand command = LogCon.CreateCommand())
            {
                command.CommandText =
                    "create table if not exists t_product (CD INTEGER PRIMARY KEY AUTOINCREMENT,m_name TEXT,m_phonenumber TEXT,m_address TEXT,m_birth TEXT,m_pass TEXT)";
                command.ExecuteNonQuery();
            }
            //DB接続解除
            LogCon.Close();
            //テキストボックスののぞき見防止(テキストを＊で表示)
            passText.PasswordChar = '*';
        }

        /// <summary>
        /// 目のマークを押したとき、パスワード非表示を解除
        /// もう一度押したとき、再度パスワード非表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eyeText_Click(object sender, EventArgs e)
        {
            if (!_isOpen)
            {
                //目を押したとき、テキスト表示
                passText.PasswordChar = default;
                _isOpen = true;
               
            }
            else if (_isOpen)
            {
                //もう一度押したとき、テキスト非表示
                passText.PasswordChar = '*';
                _isOpen = false;
            }
        }
    }
}
