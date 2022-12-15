using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class EditLog : Form
    {
        //のぞき見防止のbool変数
        private bool _isOpen = false;
        public EditLog()
        {
            InitializeComponent();
        }

        private void EditLog_Load(object sender, EventArgs e)
        {
            //テキストボックスののぞき見防止(テキストを＊で表示)
            textBox2.PasswordChar = '*';
        }

    /// <summary>
    /// 認証処理
    /// パスワードと番号が一致していたら次の画面へ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
        private void Check_Button_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection editCon = new SQLiteConnection("Data Source=m_table.db"))
            {
                editCon.Open();
                SQLiteCommand cmd = editCon.CreateCommand();

                //修正画面情報を取得
                Edit Edit = new Edit();

                // DataTableを生成
                DataTable dataTable = new DataTable();

                //SQL生成(名前と番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,m_name ,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE CD =@Cd AND m_pass =@M_pass";
                //会員番号のパラメータ定義
                cmd.Parameters.Add("Cd",DbType.String);
                //会員番号のパラメータ
                cmd.Parameters["Cd"].Value = textBox1.Text;
                //パスワードのパラメータ定義
                cmd.Parameters.Add("M_pass",DbType.String);
                //パスワードのパラメータ
                cmd.Parameters["M_pass"].Value = textBox2.Text;

                //datatableを初期化
                dataTable.Clear();
                //datatableにSQLの結果を格納
                dataTable.Load(cmd.ExecuteReader());
                //form7のグリッドビューに情報表示
                Edit.dataGridView1.DataSource = dataTable;

                //detaTableに結果がないとき(行が0のとき)エラーメッセージを表示
                if (dataTable.Rows.Count==0)
                {
                    //会員番号　or　パスワードが違う
                    MessageBox.Show("入力された値が違います。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //修正画面を表示
                    Edit.Show();
                    //修正認証画面を非表示
                    this.Visible = false;
                }
              
                //修正画面に会員番号を渡す
                Edit.textBox6.Text = textBox1.Text;
                editCon.Close();
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            //会員メニュー情報を取得
            Menu form2 = new Menu();
            //会員メニュー画面を表示
            form2.Show();
            //修正認証画面を非表示
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
                textBox2.PasswordChar = default;
                _isOpen = true;
            }
            else if (_isOpen)
            {
                //もう一度押したとき、テキスト非表示
                textBox2.PasswordChar = '*';
                _isOpen = false;
            }
        }
    }
}
