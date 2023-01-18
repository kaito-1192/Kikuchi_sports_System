using System;
using System.Windows.Forms;
namespace Kikushi_sports_System
{
    public partial class Register : Form
    {
        //のぞき見防止のbool変数
        private bool _isOpen = false;
        public Register()
        {
            InitializeComponent();
        }
        /// <summary>
        /// パスワード伏字処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Load(object sender, EventArgs e)
        {
            //パスワードののぞき見防止(テキストを＊で表示)
            passText.PasswordChar = '*';

            //パスワードののぞき見防止(テキストを＊で表示)
            passText2.PasswordChar = '*';
        }
        /// <summary>
        /// ログイン画面に戻る処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_button_Click(object sender, EventArgs e)
        {
            //ログイン画面情報を取得
            Login Login = new Login();
            //ログイン画面を表示
            Login.Show();
            //登録画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 入力項目に空値がないこと
        /// パスワードが4文字以上で入力されていること
        /// 第一パスワードと第二パスワードがいっちしていること
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_button_Click(object sender, EventArgs e)
        {

            //登録内容確認画面情報を取得
            Regi_check Regi_Check = new Regi_check();

            //パスワードが4文字以上で入力項目に空白がないとき
            if (passText.Text.Length > 3 &&passText.Text==passText2.Text&&nameText.Text!=""&&phoneText.Text!=""&&addressText.Text!=""&&birthText.Text!=""&&passText.Text!="")
            { 
            //登録内容確認画面を表示
            Regi_Check.Show();
            //登録画面を非表示
            this.Visible = false;

                //登録内容確認画面の内容確認のテキストに入力したテキスト内容を渡す
                Regi_Check.nameText.Text = nameText.Text;
                Regi_Check.phoneText.Text = phoneText.Text;
                Regi_Check.addressText.Text = addressText.Text;
                Regi_Check.birthText.Text = birthText.Text;
                Regi_Check.passText.Text = passText.Text;
            }
            //エラーメッセージ表示
            else
            {
                MessageBox.Show("入力エラー", "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
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
        /// <summary>
        /// 氏名項目の制約
        /// Backスペースは有効
        /// 数値は入力させない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }
            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 電話番号項目の制約
        ///  Backスペースは有効
        ///  文字は入力させない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void phoneText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }
            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 生年月日項目の制約
        ///  Backスペースは有効
        ///  文字は入力させない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void birthText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }
            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// パスワード項目項目の制約
        /// Backスペースは有効
        /// 数値は入力させない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passText_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }
            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 再入力パスワード項目項目の制約
        /// Backスペースは有効
        /// 数値は入力させない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passText2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b')
            {
                return;
            }
            //数値0～9以外が押された時はイベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar))
            {
                return;
            }
            else
            {
                e.Handled = true;
            }
        }

      
    }
}
