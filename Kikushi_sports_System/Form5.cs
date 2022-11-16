﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=m_table.db"))
            {
                con.Open();
                SQLiteCommand cmd = con.CreateCommand();

                // DataTableを生成します。
                var dataTable = new DataTable();

                cmd.CommandText = "SELECT CD,m_name,m_phonenumber,m_address,m_birth FROM t_product WHERE m_name =@M_name OR CD =@Cd";
                cmd.Parameters.Add("Cd", System.Data.DbType.String);
                cmd.Parameters["Cd"].Value = textBox1.Text;
                cmd.Parameters.Add("M_name", System.Data.DbType.String);
                cmd.Parameters["M_name"].Value = textBox1.Text;


                dataTable.Clear();
                dataTable.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns[0].HeaderText = "番号";
                dataGridView1.Columns[1].HeaderText = "氏名";
                dataGridView1.Columns[2].HeaderText = "電話番号";
                dataGridView1.Columns[3].HeaderText = "住所";
                dataGridView1.Columns[4].HeaderText = "生年月日";

                con.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Form2を取得
            Form2 form2 = new Form2();
            //Form2を表示
            form2.Show();
            //Form5を非表示
            this.Visible = false;
        }
    }
}