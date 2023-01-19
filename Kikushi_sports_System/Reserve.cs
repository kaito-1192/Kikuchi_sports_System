using System;
using System.Windows.Forms;
namespace Kikushi_sports_System
{
    public partial class Reserve : Form
    {
        public Reserve()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 会員番号の編集をできないようにする＆プルダウンで選ぶ項目の編集をできないようにする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_Load(object sender, EventArgs e)
        {
            //会員番号を表示
            number_text.Text = Menu.cd;
            //会員番号を編集できないようにする
            number_text.ReadOnly = true;
        }
        /// <summary>
        /// 入力項目を内容確認画面に渡す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_check_button(object sender, EventArgs e)
        {
           
            
            if (nameText.Text != "" &&service_down.SelectedIndex.ToString()!="-1"
                &&time_down.SelectedIndex.ToString()!="-1") { 
                //内容確認画面情報を取得
                Reserve_Check res_check = new Reserve_Check();
                //内容確認画面を表示
                res_check.Show();
                //予約画面を非表示
                this.Visible = false;

                //プルダウンで選んだ項目をstring型に変換
                string select_service = service_down.SelectedItem.ToString();
                string select_time = time_down.SelectedItem.ToString();

                //カレンダーで選んだ日付をstring型に変換
                string select_date = date_text.Value.ToShortDateString();

                //内容確認画面に渡す
                //会員番号
                res_check.number_text.Text = number_text.Text;
                //氏名
                res_check.name_text.Text = nameText.Text;
                //利用施設
                res_check.service_text.Text = select_service;
                //日付
                res_check.date_text.Text = select_date;
                //時間
                res_check.time_text.Text = select_time;

            }
            //エラーメッセージ表示
            else
            {
                MessageBox.Show("入力エラー", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 予約メニューに遷移する処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_button_Click(object sender, EventArgs e)
        {
            //会員メニュー画面情報を取得
            Reserve_menu Res_Menu = new Reserve_menu();
            //会員メニュー画面を表示
            Res_Menu.Show();
            //検索画面を非表示
            this.Visible = false;
        }
    }
}
