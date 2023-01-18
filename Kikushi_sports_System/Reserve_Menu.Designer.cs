
namespace Kikushi_sports_System
{
    partial class Reserve_menu
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
            this.Reserve_button = new System.Windows.Forms.Button();
            this.Reserve_management_button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reserve_button
            // 
            this.Reserve_button.Location = new System.Drawing.Point(315, 73);
            this.Reserve_button.Name = "Reserve_button";
            this.Reserve_button.Size = new System.Drawing.Size(183, 95);
            this.Reserve_button.TabIndex = 0;
            this.Reserve_button.Text = "予約する";
            this.Reserve_button.UseVisualStyleBackColor = true;
            this.Reserve_button.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Reserve_management_button
            // 
            this.Reserve_management_button.Location = new System.Drawing.Point(315, 258);
            this.Reserve_management_button.Name = "Reserve_management_button";
            this.Reserve_management_button.Size = new System.Drawing.Size(183, 98);
            this.Reserve_management_button.TabIndex = 1;
            this.Reserve_management_button.Text = "予約管理";
            this.Reserve_management_button.UseVisualStyleBackColor = true;
            this.Reserve_management_button.Click += new System.EventHandler(this.Reserve_Management_Click);
            // 
            // back_Button
            // 
            this.back_Button.Location = new System.Drawing.Point(636, 367);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(128, 59);
            this.back_Button.TabIndex = 2;
            this.back_Button.Text = "前の画面に戻る";
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // Reserve_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.Reserve_management_button);
            this.Controls.Add(this.Reserve_button);
            this.Name = "Reserve_menu";
            this.Text = "予約メニュー";
            this.Load += new System.EventHandler(this.Reserve_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reserve_button;
        private System.Windows.Forms.Button Reserve_management_button;
        private System.Windows.Forms.Button back_Button;
    }
}