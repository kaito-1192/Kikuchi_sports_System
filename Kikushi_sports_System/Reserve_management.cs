﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

    public partial class Reserve_management : Form
    {
        SQLiteConnection Res_mane_Con = new SQLiteConnection("Data Source=Reserve_Table.db");

        //グリッドビューの列指定番号
        const int _RowNumber = 0;
        const int _MemberNumber = 1;
        const int _RName = 2;
        const int _Service = 3;
        const int _Date = 4;
        const int _Time = 5;
        public Reserve_management()
        {
            InitializeComponent();
        }

        private void Reserve_management_Load(object sender, EventArgs e)
        {
            //dataGridViewの編集をできなくする
            dataGridView1.ReadOnly = true;

            // 行ヘッダー非表示
            dataGridView1.RowHeadersVisible = false;

            //SQLiteConnection Res_mane_Con = new SQLiteConnection("Data Source=Reserve_Table.db");
            //{
                Res_mane_Con.Open();
                SQLiteCommand cmd = Res_mane_Con.CreateCommand();
                // DataTableを生成する
                DataTable dataTable = new DataTable();

                //SQL生成(名前または番号を基にデータを検索)
                cmd.CommandText = "SELECT rowCount,CD,r_name,service,date,time FROM Res_table WHERE CD =@Cd";
                //会員番号のパラメータ定義
                cmd.Parameters.Add("Cd", DbType.String);
                //会員番号のパラメータ
                cmd.Parameters["Cd"].Value = Menu.cd;

                //dataTableの初期化
                dataTable.Clear();
                //SQLの結果をdataTableに格納
                dataTable.Load(cmd.ExecuteReader());

                //detaTableに結果がないとき(行が0のとき)エラーメッセージを表示
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("検索結果がありませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //グリッドビューに表示
                    dataGridView1.DataSource = dataTable;

                    //グリッドビューの列名設定
                    dataGridView1.Columns[_RowNumber].HeaderText = "予約番号";
                    dataGridView1.Columns[_MemberNumber].HeaderText = "会員番号";
                    dataGridView1.Columns[_RName].HeaderText = "氏名";
                    dataGridView1.Columns[_Service].HeaderText = "利用施設";
                    dataGridView1.Columns[_Date].HeaderText = "日にち";
                    dataGridView1.Columns[_Time].HeaderText = "時間";
                }
            Res_mane_Con.Close();
            //}

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            //会員メニュー画面情報を取得
            Reserve_menu Res_Menu = new Reserve_menu();
            //会員メニュー画面を表示
            Res_Menu.Show();
            //検索画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 予約の削除機能処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Button_Click(object sender, EventArgs e)
        {
                Res_mane_Con.Open();
                
                    SQLiteCommand cmd = Res_mane_Con.CreateCommand();

                    if (Reserve_Number_Text.Text != "")
                    {
                        // DataTableを生成する
                        DataTable dataTable = new DataTable();

                        //SQL生成(名前または番号を基にデータを検索)
                        cmd.CommandText = "SELECT rowCount,CD,r_name,service,date,time FROM Res_table WHERE CD = @Cd AND rowCount = @RowCount;";
                        cmd.Parameters.Add("Cd", DbType.String);
                        cmd.Parameters["Cd"].Value = Menu.cd;
                        cmd.Parameters.Add("RowCount", DbType.String);
                        cmd.Parameters["RowCount"].Value = Reserve_Number_Text.Text;

                        //dataTableの初期化
                        dataTable.Clear();
                        //SQLの結果をdataTableに格納
                        dataTable.Load(cmd.ExecuteReader());

                        //detaTableに結果がないとき(行が0のとき)エラーメッセージを表示
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("検索結果がありませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //データ削除の確認
                            DialogResult result = MessageBox.Show("データを削除しますか？",
                                "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            //Yes
                            if (result == DialogResult.Yes)
                            {
                                using (SQLiteTransaction trans = Res_mane_Con.BeginTransaction())
                                {
                                    //SQL
                                    cmd.CommandText = "DELETE FROM  Res_table WHERE CD = @Cd AND rowCount = @RowCount;";
                                    cmd.Parameters.Add("Cd", DbType.String);
                                    cmd.Parameters["Cd"].Value = Menu.cd;
                                    cmd.Parameters.Add("RowCount", DbType.String);
                                    cmd.Parameters["RowCount"].Value = Reserve_Number_Text.Text;

                                    cmd.ExecuteNonQuery();
                                    // コミット
                                    trans.Commit();

                                    Reserve_menu resMenu = new Reserve_menu();
                                    resMenu.Show();
                                    this.Visible = false;
                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("入力エラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Res_mane_Con.Close();
                
        }

        private void Reserve_Number_Text_KeyPress(object sender, KeyPressEventArgs e)
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
    }
