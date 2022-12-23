using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Edit : Form
    {
        //グリッドビューの列指定番号
        const int _Number = 0;
        const int _Name = 1;
        const int _PhoneNumber = 2;
        const int _Address = 3;
        const int _Birth = 4;
        const int _Pass = 5;
        public Edit()
        {
            InitializeComponent();
        }
        /// <summary>
        /// テキストボックス＆グリッドビューの編集できないようにする
        /// グリッドビューのヘッダー設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Load(object sender, EventArgs e)
        {
            //会員番号の項目を編集できないようにする
            numberText.ReadOnly = true;

            //グリッドビューを編集をできなくする
            dataGridView1.ReadOnly = true;

            // グリッドビューの行ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;

            //グリッドビューのヘッダー名を定義
            dataGridView1.Columns[_Number].HeaderText = "番号";
            dataGridView1.Columns[_Name].HeaderText = "氏名";
            dataGridView1.Columns[_PhoneNumber].HeaderText = "電話番号";
            dataGridView1.Columns[_Address].HeaderText = "住所";
            dataGridView1.Columns[_Birth].HeaderText = "生年月日";
            dataGridView1.Columns[_Pass].HeaderText = "パスワード";
        }

        /// <summary>
        /// 修正確認ダイアログを表示
        /// YESであれば入力された項目に上書きする
        /// NOであれば上書きしない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Button_Click(object sender, EventArgs e)
        {
            //データ修正の確認
            DialogResult result = MessageBox.Show("データを修正しますか？",
                "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //YESの場合
            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection Edicon = new SQLiteConnection("Data Source=m_table.db"))
                {
                    //DB接続
                    Edicon.Open();
                    using (SQLiteTransaction trans = Edicon.BeginTransaction())
                    {
                        SQLiteCommand cmd = Edicon.CreateCommand();
                        //パスワードが4文字以下かつ各項目に空白があれば修正しない
                        if (passText.Text.Length > 3 && nameText.Text != "" && phoneText.Text != "" && addressText.Text != "" && birthText.Text != "" && passText.Text != "")
                        {
                            cmd.CommandText =
                                "UPDATE t_product set m_name = @M_name, m_phonenumber = @M_phonenumber, m_address = @M_address, m_birth = @M_birth, m_pass = @M_pass WHERE CD = @Cd ;";
                            // 名前のパラメータ定義
                            cmd.Parameters.Add("M_name",DbType.String);
                            //電話番号のパラメータ定義
                            cmd.Parameters.Add("M_phonenumber",DbType.String);
                            //住所のパラメータ定義
                            cmd.Parameters.Add("M_address",DbType.String);
                            //生年月日のパラメータ定義
                            cmd.Parameters.Add("M_birth",DbType.String);
                            //パスワードのパラメータ定義
                            cmd.Parameters.Add("M_pass",DbType.String);
                            //会員番号のパラメータ定義
                            cmd.Parameters.Add("Cd",DbType.String);
                            // 名前のパラメータ
                            cmd.Parameters["M_name"].Value = nameText.Text;
                            //電話番号のパラメータ
                            cmd.Parameters["M_phonenumber"].Value = phoneText.Text;
                            //住所のパラメータ
                            cmd.Parameters["M_address"].Value = addressText.Text;
                            //生年月日のパラメータ
                            cmd.Parameters["M_birth"].Value = birthText.Text;
                            //パスワードのパラメータ
                            cmd.Parameters["M_pass"].Value = passText.Text;
                            //会員番号のパラメータ
                            cmd.Parameters["Cd"].Value = numberText.Text;

                            cmd.ExecuteNonQuery();
                            // コミット
                            trans.Commit();

                            //修正完了メッセージ
                            MessageBox.Show("修正が完了しました。", "完了画面");
                            //会員メニュー情報を取得
                            Menu Menu = new Menu();
                            //会員メニューを表示
                            Menu.Show();
                            //修正画面を非表示
                            this.Visible = false;
                            Edicon.Close();
                        }
                        //NOの場合
                        else
                        {
                            MessageBox.Show("入力エラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 会員メニュー画面に戻る処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Button_Click(object sender, EventArgs e)
        {
            //会員メニュー情報を取得
            Menu Menu = new Menu();
            //会員メニューを表示
            Menu.Show();
            //修正画面を非表示
            this.Visible = false;
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
        ///  電話番号項目の制約
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
    }
}
