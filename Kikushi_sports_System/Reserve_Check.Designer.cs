

    partial class Reserve_Check
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
            this.service_text = new System.Windows.Forms.TextBox();
            this.date_text = new System.Windows.Forms.TextBox();
            this.time_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Reserve_button = new System.Windows.Forms.Button();
            this.name_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number_text
            // 
            this.number_text.Location = new System.Drawing.Point(118, 66);
            this.number_text.Name = "number_text";
            this.number_text.Size = new System.Drawing.Size(125, 27);
            this.number_text.TabIndex = 0;
            // 
            // service_text
            // 
            this.service_text.Location = new System.Drawing.Point(118, 204);
            this.service_text.Name = "service_text";
            this.service_text.Size = new System.Drawing.Size(125, 27);
            this.service_text.TabIndex = 1;
            // 
            // date_text
            // 
            this.date_text.Location = new System.Drawing.Point(370, 204);
            this.date_text.Name = "date_text";
            this.date_text.Size = new System.Drawing.Size(125, 27);
            this.date_text.TabIndex = 2;
            // 
            // time_text
            // 
            this.time_text.Location = new System.Drawing.Point(118, 310);
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(125, 27);
            this.time_text.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "会員番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "利用施設";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "日付";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "時間";
            // 
            // Reserve_button
            // 
            this.Reserve_button.Location = new System.Drawing.Point(253, 366);
            this.Reserve_button.Name = "Reserve_button";
            this.Reserve_button.Size = new System.Drawing.Size(105, 43);
            this.Reserve_button.TabIndex = 8;
            this.Reserve_button.Text = "予約確定";
            this.Reserve_button.UseVisualStyleBackColor = true;
            this.Reserve_button.Click += new System.EventHandler(this.Reserve_button_Click);
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(370, 66);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(125, 27);
            this.name_text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "氏名";
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(666, 379);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(122, 59);
            this.Back_button.TabIndex = 11;
            this.Back_button.Text = "前の画面に戻る";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Reserve_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.Reserve_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_text);
            this.Controls.Add(this.date_text);
            this.Controls.Add(this.service_text);
            this.Controls.Add(this.number_text);
            this.Name = "Reserve_Check";
            this.Text = "予約内容確認";
            this.Load += new System.EventHandler(this.Reserve_Check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox number_text;
        public System.Windows.Forms.TextBox service_text;
        public System.Windows.Forms.TextBox date_text;
        public System.Windows.Forms.TextBox time_text;
        private System.Windows.Forms.Button Reserve_button;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox name_text;
    private System.Windows.Forms.Button Back_button;
}
