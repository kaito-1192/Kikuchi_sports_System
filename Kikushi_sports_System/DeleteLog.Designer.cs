
    partial class DeleteLog
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "前の画面に戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "パスワードを入力";
            // 
            // passText
            // 
            this.passText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passText.Location = new System.Drawing.Point(320, 206);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(125, 27);
            this.passText.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "番号を入力";
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(320, 99);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(125, 27);
            this.numberText.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "本人確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Check_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "👁";
            this.label3.Click += new System.EventHandler(this.eyeText_Click);
            // 
            // DeleteLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.button1);
            this.Name = "DeleteLog";
            this.Text = "認証";
            this.Load += new System.EventHandler(this.EditLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
