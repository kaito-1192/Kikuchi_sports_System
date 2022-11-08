using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Kikushi_sports_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2取得
            Form2 form2 = new Form2();
            //Form2を表示
            form2.Show();
            //Form1を非表示
            this.Visible = false;

            using (var con = new SQLiteConnection("Data Source=M_Table.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "create table if not exists t_product (CD INTEGER PRIMARY KEY AUTOINCREMENT,m_name TEXT,m_phonenumber INTEGER,m_address TEXT,m_birth INTEGER)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
