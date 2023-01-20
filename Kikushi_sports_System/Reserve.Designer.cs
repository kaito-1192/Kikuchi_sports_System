
    partial class Reserve
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
            this.number_text = new System.Windows.Forms.TextBox();
            this.date_text = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.service_down = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time_down = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number_text
            // 
            this.number_text.Location = new System.Drawing.Point(86, 55);
            this.number_text.Name = "number_text";
            this.number_text.Size = new System.Drawing.Size(125, 27);
            this.number_text.TabIndex = 0;
            // 
            // date_text
            // 
            this.date_text.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_text.Location = new System.Drawing.Point(356, 184);
            this.date_text.Name = "date_text";
            this.date_text.Size = new System.Drawing.Size(125, 27);
            this.date_text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "会員番号";
            // 
            // service_down
            // 
            this.service_down.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.service_down.FormattingEnabled = true;
            this.service_down.Items.AddRange(new object[] {
            "ジム",
            "プール",
            "温泉",
            "体育館"});
            this.service_down.Location = new System.Drawing.Point(86, 184);
            this.service_down.Name = "service_down";
            this.service_down.Size = new System.Drawing.Size(125, 28);
            this.service_down.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "利用施設";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "日付";
            // 
            // time_down
            // 
            this.time_down.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_down.FormattingEnabled = true;
            this.time_down.Items.AddRange(new object[] {
            "10時00分",
            "10時30分",
            "11時00分",
            "11時30分",
            "12時00分",
            "12時30分",
            "13時00分",
            "13時30分",
            "14時00分",
            "14時30分",
            "15時00分",
            "15時30分",
            "16時00分",
            "16時30分",
            "17時00分",
            "17時30分",
            "18時00分"});
            this.time_down.Location = new System.Drawing.Point(84, 297);
            this.time_down.Name = "time_down";
            this.time_down.Size = new System.Drawing.Size(127, 28);
            this.time_down.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "時間";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "予約内容確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reserve_check_button);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "氏名";
            // 
            // nameText
            // 
            this.nameText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameText.Location = new System.Drawing.Point(356, 55);
            this.nameText.Name = "nameText";
            this.nameText.ShortcutsEnabled = false;
            this.nameText.Size = new System.Drawing.Size(125, 27);
            this.nameText.TabIndex = 12;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(636, 378);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(135, 60);
            this.Back_button.TabIndex = 13;
            this.Back_button.Text = "前の画面に戻る";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.time_down);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.service_down);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_text);
            this.Controls.Add(this.number_text);
            this.Name = "Reserve";
            this.Text = "予約画面";
            this.Load += new System.EventHandler(this.Reserve_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number_text;
        private System.Windows.Forms.DateTimePicker date_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox service_down;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox time_down;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button Back_button;
    }
