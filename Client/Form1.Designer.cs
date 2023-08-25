namespace Client
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_us = new System.Windows.Forms.TextBox();
            this.txt_pas = new System.Windows.Forms.TextBox();
            this.txt_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passowrd:";
            // 
            // txt_us
            // 
            this.txt_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_us.Location = new System.Drawing.Point(232, 91);
            this.txt_us.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_us.Multiline = true;
            this.txt_us.Name = "txt_us";
            this.txt_us.Size = new System.Drawing.Size(618, 54);
            this.txt_us.TabIndex = 2;
            this.txt_us.TextChanged += new System.EventHandler(this.txt_us_TextChanged);
            this.txt_us.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_us_KeyPress);
            // 
            // txt_pas
            // 
            this.txt_pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pas.Location = new System.Drawing.Point(232, 194);
            this.txt_pas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_pas.Multiline = true;
            this.txt_pas.Name = "txt_pas";
            this.txt_pas.PasswordChar = '*';
            this.txt_pas.Size = new System.Drawing.Size(618, 56);
            this.txt_pas.TabIndex = 3;
            this.txt_pas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pas_KeyPress);
            // 
            // txt_log
            // 
            this.txt_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(354, 284);
            this.txt_log.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(208, 115);
            this.txt_log.TabIndex = 4;
            this.txt_log.Text = "Login";
            this.txt_log.UseVisualStyleBackColor = true;
            this.txt_log.Click += new System.EventHandler(this.txt_log_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.txt_pas);
            this.Controls.Add(this.txt_us);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_us;
        private System.Windows.Forms.TextBox txt_pas;
        private System.Windows.Forms.Button txt_log;
    }
}

