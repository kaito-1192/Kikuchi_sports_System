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
        /// テキストボックス非表示処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Register_Load(object sender, EventArgs e)
        {
            //テキストボックスののぞき見防止(テキストを＊で表示)
            textBox5.PasswordChar = '*';

            //テキストボックスののぞき見防止(テキストを＊で表示)
            textBox6.PasswordChar = '*';
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            //ログイン画面情報を取得
            Login form1 = new Login();
            //ログイン画面を表示
            form1.Show();
            //登録画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 入力項目に空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check_button_Click(object sender, EventArgs e)
        {

            //form4を取得
            Regi_check form4 = new Regi_check();

            //パスワードが4文字以上であれば次に進む
            if (textBox5.Text.Length > 3 &&textBox5.Text==textBox6.Text)
            { 
            //form4を表示
            form4.Show();
            //form3を非表示
            this.Visible = false;

                //form4の内容確認のテキストに入力したテキストを反映
                form4.textBox1.Text = textBox1.Text;
                form4.textBox2.Text = textBox2.Text;
                form4.textBox3.Text = textBox3.Text;
                form4.textBox4.Text = textBox4.Text;
                form4.textBox5.Text = textBox5.Text;
            }
            //エラーメッセージ表示
            else
            {
                MessageBox.Show("入力エラー", "エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

       

        private void eyeText_Click(object sender, EventArgs e)
        {
            if (!_isOpen)
            {
                //目を押したとき、テキスト表示
                textBox5.PasswordChar = default;
                _isOpen = true;
            }
            else if (_isOpen)
            {
                //もう一度押したとき、テキスト非表示
                textBox5.PasswordChar = '*';
                _isOpen = false;
            }
        }
    }
}
