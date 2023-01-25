using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

    public partial class Delete : Form
    {
        //グリッドビューの列指定番号
        //会員番号
        const int _Number = 0;
        //氏名
        const int _Name = 1;
        //電話番号
        const int _PhoneNumber = 2;
        //住所
        const int _Address = 3;
        //生年月日
        const int _Birth = 4;
        //パスワード
        const int _Pass = 5;
        public Delete()
        {
            InitializeComponent();
        }
        /// <summary>
        /// テキストボックス＆グリッドビューの編集できないようにする
        /// グリッドビューのヘッダー設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Load(object sender, EventArgs e)
        {
            //textboxを編集できないようにする
            numberText.ReadOnly = true;

            //dataGridViewの編集をできなくする
            dataGridView1.ReadOnly = true;

            // 行ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;

            //データ内容の文字数に応じてセルの大きさを変える
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //グリッドビューのヘッダー名を定義
            //会員番号
            dataGridView1.Columns[_Number].HeaderText = "番号";
            //氏名
            dataGridView1.Columns[_Name].HeaderText = "氏名";
            //電話番号
            dataGridView1.Columns[_PhoneNumber].HeaderText = "電話番号";
            //住所
            dataGridView1.Columns[_Address].HeaderText = "住所";
            //生年月日
            dataGridView1.Columns[_Birth].HeaderText = "生年月日";
            //パスワード
            dataGridView1.Columns[_Pass].HeaderText = "パスワード";
        }
        /// <summary>
        /// 削除確認ダイアログを表示
        /// YESであれば会員番号をもとに削除する
        /// NOであれば削除しない
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Del_Button_Click(object sender, EventArgs e)
        {
            //データ削除の確認
            DialogResult result = MessageBox.Show("データを削除しますか？",
                "確認",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            //Yes
            if (result == DialogResult.Yes)
            {
                //会員番号を基に削除
                using (SQLiteConnection Delcon = new SQLiteConnection("Data Source=m_table.db"))
                {
                    //DB接続
                    Delcon.Open();
                    using (SQLiteTransaction trans = Delcon.BeginTransaction())
                    {
                        SQLiteCommand cmd = Delcon.CreateCommand();
                        //SQL
                        cmd.CommandText = "DELETE FROM t_product WHERE CD = @Cd;";
                        //会員番号のパラメータ定義
                        cmd.Parameters.Add("Cd",DbType.String);
                        //会員番号のパラメータ
                        cmd.Parameters["Cd"].Value = numberText.Text;

                        cmd.ExecuteNonQuery();
                        // コミット
                        trans.Commit();
                    }
                }

                //ログイン画面情報を取得
                Login Login = new Login();
                //ログイン画面を表示
                Login.Show();
                //削除画を非表示
                this.Visible = false;
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            //会員メニュー画面情報を取得
            Menu Menu = new Menu();
            //会員メニュー画面を表示
            Menu.Show();
            //削除画面を非表示
            this.Visible = false;
        }
    }

