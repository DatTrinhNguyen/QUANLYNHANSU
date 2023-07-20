
namespace QUANLYNHANSU
{
    partial class FormXacThuc
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
            this.components = new System.ComponentModel.Container();
            this.OTPButton = new System.Windows.Forms.Button();
            this.inputOTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OTPButton
            // 
            this.OTPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OTPButton.Location = new System.Drawing.Point(251, 246);
            this.OTPButton.Name = "OTPButton";
            this.OTPButton.Size = new System.Drawing.Size(257, 74);
            this.OTPButton.TabIndex = 8;
            this.OTPButton.Text = "Xác thực OTP";
            this.OTPButton.UseVisualStyleBackColor = true;
            this.OTPButton.Click += new System.EventHandler(this.OTPButton_Click);
            // 
            // inputOTP
            // 
            this.inputOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputOTP.Location = new System.Drawing.Point(251, 157);
            this.inputOTP.Name = "inputOTP";
            this.inputOTP.Size = new System.Drawing.Size(257, 30);
            this.inputOTP.TabIndex = 7;
            this.inputOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputOTP_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã OTP";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 30F);
            this.label2.Location = new System.Drawing.Point(296, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "02:00";
            // 
            // FormXacThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OTPButton);
            this.Controls.Add(this.inputOTP);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(702, 444);
            this.MinimumSize = new System.Drawing.Size(702, 444);
            this.Name = "FormXacThuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormXacThuc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormXacThuc_FormClosed);
            this.Load += new System.EventHandler(this.FormXacThuc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OTPButton;
        private System.Windows.Forms.TextBox inputOTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}