
    partial class Edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.birthText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(774, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "電話番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "生年月日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "パスワード";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(51, 290);
            this.nameText.MaxLength = 10;
            this.nameText.Name = "nameText";
            this.nameText.ShortcutsEnabled = false;
            this.nameText.Size = new System.Drawing.Size(125, 27);
            this.nameText.TabIndex = 6;
            this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameText_KeyPress);
            // 
            // phoneText
            // 
            this.phoneText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.phoneText.Location = new System.Drawing.Point(196, 290);
            this.phoneText.MaxLength = 15;
            this.phoneText.Name = "phoneText";
            this.phoneText.ShortcutsEnabled = false;
            this.phoneText.Size = new System.Drawing.Size(125, 27);
            this.phoneText.TabIndex = 7;
            this.phoneText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(51, 379);
            this.addressText.MaxLength = 50;
            this.addressText.Name = "addressText";
            this.addressText.ShortcutsEnabled = false;
            this.addressText.Size = new System.Drawing.Size(125, 27);
            this.addressText.TabIndex = 8;
            // 
            // birthText
            // 
            this.birthText.Location = new System.Drawing.Point(196, 379);
            this.birthText.MaxLength = 8;
            this.birthText.Name = "birthText";
            this.birthText.ShortcutsEnabled = false;
            this.birthText.Size = new System.Drawing.Size(125, 27);
            this.birthText.TabIndex = 9;
            this.birthText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birthText_KeyPress);
            // 
            // passText
            // 
            this.passText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passText.Location = new System.Drawing.Point(459, 377);
            this.passText.MaxLength = 8;
            this.passText.Name = "passText";
            this.passText.ShortcutsEnabled = false;
            this.passText.Size = new System.Drawing.Size(125, 27);
            this.passText.TabIndex = 10;
            this.passText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passText_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "修正";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "番号";
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(51, 213);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(39, 27);
            this.numberText.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "※空白・ハイフンなし・小文字";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "※空白・ハイフンなし・小文字";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "※4文字以上 8文字以内";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(655, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "メニューに戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(212, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "例 19900101";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.birthText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Edit";
            this.Text = "修正";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox birthText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label12;
}
