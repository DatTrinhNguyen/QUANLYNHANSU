
namespace QUANLYNHANSU
{
    partial class FormQuenMatKhau
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
            this.sentOTPButton = new System.Windows.Forms.Button();
            this.inputGmail = new System.Windows.Forms.TextBox();
            this.inputUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sentOTPButton
            // 
            this.sentOTPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentOTPButton.Location = new System.Drawing.Point(248, 239);
            this.sentOTPButton.Name = "sentOTPButton";
            this.sentOTPButton.Size = new System.Drawing.Size(257, 74);
            this.sentOTPButton.TabIndex = 9;
            this.sentOTPButton.Text = "Gửi mã OTP";
            this.sentOTPButton.UseVisualStyleBackColor = true;
            this.sentOTPButton.Click += new System.EventHandler(this.sentOTPButton_Click);
            // 
            // inputGmail
            // 
            this.inputGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGmail.Location = new System.Drawing.Point(248, 162);
            this.inputGmail.Name = "inputGmail";
            this.inputGmail.Size = new System.Drawing.Size(257, 30);
            this.inputGmail.TabIndex = 8;
            this.inputGmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputGmail_KeyPress);
            // 
            // inputUsername
            // 
            this.inputUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputUsername.Location = new System.Drawing.Point(248, 75);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(257, 30);
            this.inputUsername.TabIndex = 7;
            this.inputUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputUsername_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tài khoản";
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 404);
            this.Controls.Add(this.sentOTPButton);
            this.Controls.Add(this.inputGmail);
            this.Controls.Add(this.inputUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(702, 444);
            this.MinimumSize = new System.Drawing.Size(702, 444);
            this.Name = "FormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormQuenMatKhau";
            this.Load += new System.EventHandler(this.FormQuenMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sentOTPButton;
        private System.Windows.Forms.TextBox inputGmail;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}