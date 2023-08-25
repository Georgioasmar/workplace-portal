namespace Client
{
    partial class Form5
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
            this.txt_insert = new System.Windows.Forms.Button();
            this.txt_accPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dlt = new System.Windows.Forms.Button();
            this.txt_Exit = new System.Windows.Forms.Button();
            this.checkBox_admin = new System.Windows.Forms.CheckBox();
            this.checkBox_changePass = new System.Windows.Forms.CheckBox();
            this.txt_accUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_insert
            // 
            this.txt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert.Location = new System.Drawing.Point(305, 296);
            this.txt_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_insert.Name = "txt_insert";
            this.txt_insert.Size = new System.Drawing.Size(142, 111);
            this.txt_insert.TabIndex = 0;
            this.txt_insert.Text = "Save";
            this.txt_insert.UseVisualStyleBackColor = true;
            this.txt_insert.Click += new System.EventHandler(this.txt_insrt_Click);
            // 
            // txt_accPassword
            // 
            this.txt_accPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_accPassword.Location = new System.Drawing.Point(238, 166);
            this.txt_accPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_accPassword.Multiline = true;
            this.txt_accPassword.Name = "txt_accPassword";
            this.txt_accPassword.Size = new System.Drawing.Size(600, 46);
            this.txt_accPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // txt_dlt
            // 
            this.txt_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dlt.Location = new System.Drawing.Point(513, 296);
            this.txt_dlt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dlt.Name = "txt_dlt";
            this.txt_dlt.Size = new System.Drawing.Size(146, 111);
            this.txt_dlt.TabIndex = 6;
            this.txt_dlt.Text = "Delete";
            this.txt_dlt.UseVisualStyleBackColor = true;
            // 
            // txt_Exit
            // 
            this.txt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txt_Exit.Location = new System.Drawing.Point(701, 29);
            this.txt_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Exit.Name = "txt_Exit";
            this.txt_Exit.Size = new System.Drawing.Size(137, 42);
            this.txt_Exit.TabIndex = 7;
            this.txt_Exit.Text = "Back";
            this.txt_Exit.UseVisualStyleBackColor = true;
            this.txt_Exit.Click += new System.EventHandler(this.txt_Exit_Click);
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.Location = new System.Drawing.Point(238, 247);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(186, 24);
            this.checkBox_admin.TabIndex = 8;
            this.checkBox_admin.Text = "Give Admin Privileges";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            this.checkBox_admin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_changePass
            // 
            this.checkBox_changePass.AutoSize = true;
            this.checkBox_changePass.Location = new System.Drawing.Point(457, 247);
            this.checkBox_changePass.Name = "checkBox_changePass";
            this.checkBox_changePass.Size = new System.Drawing.Size(381, 24);
            this.checkBox_changePass.TabIndex = 9;
            this.checkBox_changePass.Text = "Prompt user to change password after initial login";
            this.checkBox_changePass.UseVisualStyleBackColor = true;
            this.checkBox_changePass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // txt_accUsername
            // 
            this.txt_accUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_accUsername.Location = new System.Drawing.Point(238, 89);
            this.txt_accUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_accUsername.Multiline = true;
            this.txt_accUsername.Name = "txt_accUsername";
            this.txt_accUsername.Size = new System.Drawing.Size(600, 45);
            this.txt_accUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 499);
            this.Controls.Add(this.checkBox_changePass);
            this.Controls.Add(this.checkBox_admin);
            this.Controls.Add(this.txt_Exit);
            this.Controls.Add(this.txt_dlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_accPassword);
            this.Controls.Add(this.txt_accUsername);
            this.Controls.Add(this.txt_insert);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form5";
            this.Text = "Account Creation Page";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_insert;
        private System.Windows.Forms.TextBox txt_accPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txt_dlt;
        private System.Windows.Forms.Button txt_Exit;
        private System.Windows.Forms.CheckBox checkBox_admin;
        private System.Windows.Forms.CheckBox checkBox_changePass;
        private System.Windows.Forms.TextBox txt_accUsername;
        private System.Windows.Forms.Label label1;
    }
}