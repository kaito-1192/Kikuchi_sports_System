
namespace Kikushi_sports_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eyeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(281, 267);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(188, 65);
            this.Login_button.TabIndex = 0;
            this.Login_button.Text = "ログイン";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "会員登録";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Register_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(308, 86);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(125, 27);
            this.nameText.TabIndex = 2;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(308, 179);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(125, 27);
            this.passText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "パスワード";
            // 
            // eyeText
            // 
            this.eyeText.AutoSize = true;
            this.eyeText.Location = new System.Drawing.Point(439, 182);
            this.eyeText.Name = "eyeText";
            this.eyeText.Size = new System.Drawing.Size(30, 20);
            this.eyeText.TabIndex = 7;
            this.eyeText.Text = "👁";
            this.eyeText.Click += new System.EventHandler(this.eyeText_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eyeText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Login_button);
            this.Name = "Login";
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label eyeText;
    }
}

