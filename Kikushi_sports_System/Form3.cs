using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Kikushi_sports_System
{
    public partial class Form3 : Form
    {
        private bool _isOpen = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //テキストボックスののぞき見防止(テキストを＊で表示)
            textBox5.PasswordChar = '*';

            //テキストボックスののぞき見防止(テキストを＊で表示)
            textBox6.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1取得
            Form1 form1 = new Form1();
            //Form1を表示
            form1.Show();
            //Form3を非表示
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //form4を取得
            Form4 form4 = new Form4();
           
            //パスワードが4文字以上であれば次に進む
            if (textBox5.Text.Length > 3&&textBox5.Text==textBox6.Text)
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

       

        private void label10_Click(object sender, EventArgs e)
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
