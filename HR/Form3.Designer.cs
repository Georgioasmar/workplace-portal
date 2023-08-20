namespace HR
{
    partial class Form3
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
            this.txt_welcome = new System.Windows.Forms.Label();
            this.txt_mg = new System.Windows.Forms.Button();
            this.txt_salary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mySalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIgnOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_welcome
            // 
            this.txt_welcome.AutoSize = true;
            this.txt_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_welcome.Location = new System.Drawing.Point(321, 58);
            this.txt_welcome.Name = "txt_welcome";
            this.txt_welcome.Size = new System.Drawing.Size(281, 36);
            this.txt_welcome.TabIndex = 0;
            this.txt_welcome.Text = "Welcome Message";
            this.txt_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_mg
            // 
            this.txt_mg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mg.Location = new System.Drawing.Point(81, 142);
            this.txt_mg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_mg.Name = "txt_mg";
            this.txt_mg.Size = new System.Drawing.Size(328, 80);
            this.txt_mg.TabIndex = 1;
            this.txt_mg.Text = "Employee Manager";
            this.txt_mg.UseVisualStyleBackColor = true;
            this.txt_mg.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(485, 142);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(335, 80);
            this.txt_salary.TabIndex = 2;
            this.txt_salary.Text = "Salary manager";
            this.txt_salary.UseVisualStyleBackColor = true;
            this.txt_salary.Click += new System.EventHandler(this.txt_salary_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(81, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 80);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myProfileToolStripMenuItem,
            this.toolStripSeparator1,
            this.mySalaryToolStripMenuItem,
            this.resetPasswordToolStripMenuItem,
            this.sIgnOutToolStripMenuItem});
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.usernameToolStripMenuItem.Text = "Username";
            this.usernameToolStripMenuItem.Click += new System.EventHandler(this.usernameToolStripMenuItem_Click);
            this.usernameToolStripMenuItem.DoubleClick += new System.EventHandler(this.usernameToolStripMenuItem_DoubleClick);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            this.myProfileToolStripMenuItem.Click += new System.EventHandler(this.myProfileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // mySalaryToolStripMenuItem
            // 
            this.mySalaryToolStripMenuItem.Name = "mySalaryToolStripMenuItem";
            this.mySalaryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mySalaryToolStripMenuItem.Text = "My Salary";
            this.mySalaryToolStripMenuItem.Click += new System.EventHandler(this.mySalaryToolStripMenuItem_Click);
            // 
            // resetPasswordToolStripMenuItem
            // 
            this.resetPasswordToolStripMenuItem.Name = "resetPasswordToolStripMenuItem";
            this.resetPasswordToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.resetPasswordToolStripMenuItem.Text = "Reset Password";
            this.resetPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetPasswordToolStripMenuItem_Click);
            // 
            // sIgnOutToolStripMenuItem
            // 
            this.sIgnOutToolStripMenuItem.Name = "sIgnOutToolStripMenuItem";
            this.sIgnOutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sIgnOutToolStripMenuItem.Text = "Sign Out";
            this.sIgnOutToolStripMenuItem.Click += new System.EventHandler(this.sIgnOutToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(485, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 80);
            this.button2.TabIndex = 19;
            this.button2.Text = "Departments Stats";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_mg);
            this.Controls.Add(this.txt_welcome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_welcome;
        private System.Windows.Forms.Button txt_mg;
        private System.Windows.Forms.Button txt_salary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIgnOutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}