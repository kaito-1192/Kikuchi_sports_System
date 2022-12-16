
namespace Kikushi_sports_System
{
    partial class Regi_check
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
            this.button1 = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.birthText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "前の画面に戻る";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackRegi_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(188, 76);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(125, 27);
            this.nameText.TabIndex = 2;
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(444, 76);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(125, 27);
            this.phoneText.TabIndex = 3;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(188, 170);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(125, 27);
            this.addressText.TabIndex = 4;
            // 
            // birthText
            // 
            this.birthText.Location = new System.Drawing.Point(444, 162);
            this.birthText.Name = "birthText";
            this.birthText.Size = new System.Drawing.Size(125, 27);
            this.birthText.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "登録";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Reg_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "電話番号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "生年月日";
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(188, 251);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(125, 27);
            this.passText.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "パスワード";
            // 
            // eye
            // 
            this.eye.AutoSize = true;
            this.eye.Location = new System.Drawing.Point(320, 251);
            this.eye.Name = "eye";
            this.eye.Size = new System.Drawing.Size(30, 20);
            this.eye.TabIndex = 13;
            this.eye.Text = "👁";
            this.eye.Click += new System.EventHandler(this.eyeText_Click);
            // 
            // Regi_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.birthText);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.button1);
            this.Name = "Regi_check";
            this.Text = "登録内容確認";
            this.Load += new System.EventHandler(this.RegiCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox nameText;
        public System.Windows.Forms.TextBox phoneText;
        public System.Windows.Forms.TextBox addressText;
        public System.Windows.Forms.TextBox birthText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label eye;
    }
}