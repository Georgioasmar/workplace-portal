
namespace HR
{
    partial class FormProfile
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
            this.BackF2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_accUsername = new System.Windows.Forms.TextBox();
            this.txt_update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_dep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_isAdmin = new System.Windows.Forms.CheckBox();
            this.txt_ph = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_dep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BackF2
            // 
            this.BackF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BackF2.Location = new System.Drawing.Point(20, 25);
            this.BackF2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackF2.Name = "BackF2";
            this.BackF2.Size = new System.Drawing.Size(119, 37);
            this.BackF2.TabIndex = 23;
            this.BackF2.Text = "Back";
            this.BackF2.UseVisualStyleBackColor = true;
            this.BackF2.Click += new System.EventHandler(this.BackF2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(595, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Username:";
            // 
            // txt_accUsername
            // 
            this.txt_accUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_accUsername.Location = new System.Drawing.Point(764, 159);
            this.txt_accUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_accUsername.Multiline = true;
            this.txt_accUsername.Name = "txt_accUsername";
            this.txt_accUsername.Size = new System.Drawing.Size(189, 32);
            this.txt_accUsername.TabIndex = 24;
            // 
            // txt_update
            // 
            this.txt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update.Location = new System.Drawing.Point(205, 394);
            this.txt_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_update.Name = "txt_update";
            this.txt_update.Size = new System.Drawing.Size(283, 108);
            this.txt_update.TabIndex = 26;
            this.txt_update.Text = "Save";
            this.txt_update.UseVisualStyleBackColor = true;
            this.txt_update.Click += new System.EventHandler(this.txt_update_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(560, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 108);
            this.button1.TabIndex = 27;
            this.button1.Text = "Change Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(270, 217);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.MaxLength = 50;
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(283, 35);
            this.txt_email.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 36);
            this.label6.TabIndex = 39;
            this.label6.Text = "Email Address:";
            // 
            // cb_dep
            // 
            this.cb_dep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_dep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dep.FormattingEnabled = true;
            this.cb_dep.Location = new System.Drawing.Point(165, 25);
            this.cb_dep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_dep.Name = "cb_dep";
            this.cb_dep.Size = new System.Drawing.Size(189, 33);
            this.cb_dep.TabIndex = 38;
            this.cb_dep.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(593, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Department:";
            // 
            // cb_isAdmin
            // 
            this.cb_isAdmin.AutoSize = true;
            this.cb_isAdmin.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_isAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.cb_isAdmin.Location = new System.Drawing.Point(600, 273);
            this.cb_isAdmin.Name = "cb_isAdmin";
            this.cb_isAdmin.Size = new System.Drawing.Size(117, 34);
            this.cb_isAdmin.TabIndex = 36;
            this.cb_isAdmin.Text = "Admin";
            this.cb_isAdmin.UseVisualStyleBackColor = true;
            // 
            // txt_ph
            // 
            this.txt_ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ph.Location = new System.Drawing.Point(270, 276);
            this.txt_ph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ph.MaxLength = 10;
            this.txt_ph.Multiline = true;
            this.txt_ph.Name = "txt_ph";
            this.txt_ph.Size = new System.Drawing.Size(283, 35);
            this.txt_ph.TabIndex = 35;
            // 
            // txt_add
            // 
            this.txt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add.Location = new System.Drawing.Point(270, 155);
            this.txt_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_add.MaxLength = 50;
            this.txt_add.Multiline = true;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(283, 35);
            this.txt_add.TabIndex = 34;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(270, 94);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.MaxLength = 50;
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(283, 35);
            this.txt_name.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 36);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 36);
            this.label3.TabIndex = 30;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(593, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Employee ID:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_id.Location = new System.Drawing.Point(789, 94);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(72, 35);
            this.txt_id.TabIndex = 41;
            // 
            // txt_dep
            // 
            this.txt_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_dep.Location = new System.Drawing.Point(764, 217);
            this.txt_dep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_dep.Multiline = true;
            this.txt_dep.Name = "txt_dep";
            this.txt_dep.Size = new System.Drawing.Size(189, 35);
            this.txt_dep.TabIndex = 42;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 563);
            this.Controls.Add(this.txt_dep);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_dep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_isAdmin);
            this.Controls.Add(this.txt_ph);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_accUsername);
            this.Controls.Add(this.BackF2);
            this.Name = "FormProfile";
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackF2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_accUsername;
        private System.Windows.Forms.Button txt_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_dep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_isAdmin;
        private System.Windows.Forms.TextBox txt_ph;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_dep;
    }
}