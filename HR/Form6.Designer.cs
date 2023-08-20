
namespace HR
{
    partial class Form6
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
            this.txt_log = new System.Windows.Forms.Button();
            this.txt_reenter = new System.Windows.Forms.TextBox();
            this.txt_newPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_log
            // 
            this.txt_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(353, 322);
            this.txt_log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(208, 74);
            this.txt_log.TabIndex = 9;
            this.txt_log.Text = "Save";
            this.txt_log.UseVisualStyleBackColor = true;
            this.txt_log.Click += new System.EventHandler(this.txt_log_Click);
            // 
            // txt_reenter
            // 
            this.txt_reenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reenter.Location = new System.Drawing.Point(342, 209);
            this.txt_reenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_reenter.Multiline = true;
            this.txt_reenter.Name = "txt_reenter";
            this.txt_reenter.Size = new System.Drawing.Size(506, 56);
            this.txt_reenter.TabIndex = 8;
            this.txt_reenter.TextChanged += new System.EventHandler(this.txt_pas_TextChanged);
            // 
            // txt_newPass
            // 
            this.txt_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newPass.Location = new System.Drawing.Point(342, 106);
            this.txt_newPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_newPass.Multiline = true;
            this.txt_newPass.Name = "txt_newPass";
            this.txt_newPass.Size = new System.Drawing.Size(506, 54);
            this.txt_newPass.TabIndex = 7;
            this.txt_newPass.TextChanged += new System.EventHandler(this.txt_us_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Re-enter Passowrd:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "New Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(254, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Please enter your new password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.txt_reenter);
            this.Controls.Add(this.txt_newPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Password Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_log;
        private System.Windows.Forms.TextBox txt_reenter;
        private System.Windows.Forms.TextBox txt_newPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}