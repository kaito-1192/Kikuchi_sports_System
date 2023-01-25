using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

    public partial class Search : Form
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
        public Search()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 検索画面を開いたらグリッドビューの設定をする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serach_Load(object sender, EventArgs e)
        {
        //dataGridViewの編集をできなくする
        dataGridView1.ReadOnly = true;

        // 行ヘッダー非表示
        dataGridView1.RowHeadersVisible = false;
        //データ内容の文字数に応じてセルの大きさを変える
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

    }

        /// <summary>
        /// 検索画面を押したとき入力された番号 or パスワードを基に情報を検索する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Button_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection Searcon = new SQLiteConnection("Data Source=m_table.db"))
            {
                //DB接続
                Searcon.Open();
                SQLiteCommand cmd = Searcon.CreateCommand();

                // DataTableを生成する
                DataTable dataTable = new DataTable();

                //SQL生成(名前または番号を基にデータを検索)
                cmd.CommandText = "SELECT CD,m_name,m_phonenumber,m_address,m_birth,m_pass FROM t_product WHERE CD=@cdd AND  m_pass = @M_pass OR CD =@Cd ";
                //会員番号のパラメータ定義
                cmd.Parameters.Add("Cd",DbType.String);
                //会員番号のパラメータ
                cmd.Parameters["Cd"].Value = inputText.Text;
                //認証用会員番号のパラメータ定義
                cmd.Parameters.Add("Cdd", DbType.String);
                //認証用会員番号のパラメータ
                cmd.Parameters["Cdd"].Value = Menu.cd;
                //パスワードのパラメータ定義
                cmd.Parameters.Add("M_pass",DbType.String);
                //パスワードのパラメータ
                cmd.Parameters["M_pass"].Value = inputText.Text;

                //dataTableの初期化
                dataTable.Clear();
                //SQLの結果をdataTableに格納
                dataTable.Load(cmd.ExecuteReader());

                //detaTableに結果がないとき(行が0のとき)エラーメッセージを表示
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("検索結果がありませんでした。" +
                        "自分の会員番号かパスワードを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //グリッドビューに表示
                    dataGridView1.DataSource = dataTable;

                    //グリッドビューの列名設定
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

                 //DB接続解除
                Searcon.Close();
            }
        }

        /// <summary>
        /// 会員メニュー画面に戻る処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Button_Click(object sender, EventArgs e)
        {
            //会員メニュー画面情報を取得
            Menu Menu = new Menu();
            //会員メニュー画面を表示
            Menu.Show();
            //検索画面を非表示
            this.Visible = false;
        }

       
    }
