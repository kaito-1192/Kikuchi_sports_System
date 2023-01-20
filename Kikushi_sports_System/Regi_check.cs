using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

    public partial class Regi_check : Form
    {
        //のぞき見防止のbool変数
        private bool _isOpen = false;
        public Regi_check()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 画面を開いたとき、すべての項目の編集をできなくする　＆
        /// パスワードの伏字処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegiCheck_Load(object sender, EventArgs e)
        {
            //内容確認のテキストを編集できないようにする
            nameText.ReadOnly = true;
            phoneText.ReadOnly = true;
            addressText.ReadOnly = true;
            birthText.ReadOnly = true;
            passText.ReadOnly = true;

            //テキストボックスののぞき見防止(テキストを＊で表示)
            passText.PasswordChar = '*';
        }

        /// <summary>
        /// 前の登録画面に戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackRegi_Click(object sender, EventArgs e)
        {
            //登録画面の情報を取得
            Register Register = new Register();
            //登録画面を表示
            Register.Show();
            //登録内容確認画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 情報の登録処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reg_Button_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection regCon = new SQLiteConnection("Data Source=m_table.db"))
            {
                //DB接続
                regCon.Open();
                using (SQLiteTransaction trans = regCon.BeginTransaction())
                {
                    SQLiteCommand cmd = regCon.CreateCommand();
                    //インサート文
                    cmd.CommandText = "INSERT INTO t_product (m_name,m_phonenumber,m_address,m_birth,m_pass) VALUES(@m_name,@m_phonenumber,@m_address,@m_birth,@m_pass)";
                   //名前のパラメータ定義
                    cmd.Parameters.Add("m_name",DbType.String);
                   //電話番号のパラメータ定義
                    cmd.Parameters.Add("m_phonenumber",DbType.String);
                    //住所のパラメータ定義
                    cmd.Parameters.Add("m_address",DbType.String);
                    //生年月日のパラメータ定義
                    cmd.Parameters.Add("m_birth",DbType.String);
                    //パスワードのパラメータ定義
                    cmd.Parameters.Add("m_pass",DbType.String);
                    //名前のパラメータ
                    cmd.Parameters["m_name"].Value = nameText.Text;
                    //電話番号のパラメータ
                    cmd.Parameters["m_phonenumber"].Value = phoneText.Text;
                    //住所のパラメータ
                    cmd.Parameters["m_address"].Value = addressText.Text;
                    //生年月日のパラメータ
                    cmd.Parameters["m_birth"].Value = birthText.Text;
                    //パスワードのパラメータ
                    cmd.Parameters["m_pass"].Value = passText.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
            //登録完了メッセージ
            MessageBox.Show("登録が完了しました。","完了画面");
            //ログイン画面の情報を取得
            Login Login = new Login();
            //ログイン画面を表示
            Login.Show();
            //登録内容確認画面を非表示
            this.Visible = false;
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
