
namespace Kikushi_sports_System
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.birthText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.passText2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "氏名";
            // 
            // nameText
            // 
            this.nameText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nameText.Location = new System.Drawing.Point(119, 62);
            this.nameText.Name = "nameText";
            this.nameText.ShortcutsEnabled = false;
            this.nameText.Size = new System.Drawing.Size(125, 27);
            this.nameText.TabIndex = 1;
            this.nameText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameText_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // phoneText
            // 
            this.phoneText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.phoneText.Location = new System.Drawing.Point(424, 62);
            this.phoneText.Name = "phoneText";
            this.phoneText.ShortcutsEnabled = false;
            this.phoneText.Size = new System.Drawing.Size(140, 27);
            this.phoneText.TabIndex = 3;
            this.phoneText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneText_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "電話番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "住所";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "生年月日";
            // 
            // addressText
            // 
            this.addressText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addressText.Location = new System.Drawing.Point(119, 150);
            this.addressText.Name = "addressText";
            this.addressText.ShortcutsEnabled = false;
            this.addressText.Size = new System.Drawing.Size(125, 27);
            this.addressText.TabIndex = 7;
            // 
            // birthText
            // 
            this.birthText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.birthText.Location = new System.Drawing.Point(424, 150);
            this.birthText.Name = "birthText";
            this.birthText.ShortcutsEnabled = false;
            this.birthText.Size = new System.Drawing.Size(140, 27);
            this.birthText.TabIndex = 8;
            this.birthText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birthText_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(671, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "前の画面に戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "内容確認";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "パスワード";
            // 
            // passText
            // 
            this.passText.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passText.Location = new System.Drawing.Point(119, 243);
            this.passText.Name = "passText";
            this.passText.ShortcutsEnabled = false;
            this.passText.Size = new System.Drawing.Size(125, 27);
            this.passText.TabIndex = 14;
            this.passText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passText_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "※4文字以上";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "👁";
            this.label10.Click += new System.EventHandler(this.eyeText_Click);
            // 
            // passText2
            // 
            this.passText2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.passText2.Location = new System.Drawing.Point(424, 239);
            this.passText2.Name = "passText2";
            this.passText2.ShortcutsEnabled = false;
            this.passText2.Size = new System.Drawing.Size(125, 27);
            this.passText2.TabIndex = 17;
            this.passText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passText2_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "パスワード(再入力)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "※空白・ハイフンなし";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "※空白・ハイフンなし";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "例 19900101";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passText2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.birthText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "登録";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox birthText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox passText2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
    }
}