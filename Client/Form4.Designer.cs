namespace Client
{
    partial class Form4
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
            this.txt_search = new System.Windows.Forms.Button();
            this.txt_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_empID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Bsly = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_trans = new System.Windows.Forms.TextBox();
            this.BackF4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.salName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(553, 335);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(161, 92);
            this.txt_search.TabIndex = 0;
            this.txt_search.Text = "Search";
            this.txt_search.UseVisualStyleBackColor = true;
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // txt_update
            // 
            this.txt_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_update.Location = new System.Drawing.Point(282, 335);
            this.txt_update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_update.Name = "txt_update";
            this.txt_update.Size = new System.Drawing.Size(147, 92);
            this.txt_update.TabIndex = 1;
            this.txt_update.Text = "Save";
            this.txt_update.UseVisualStyleBackColor = true;
            this.txt_update.Click += new System.EventHandler(this.txt_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "employeeID:";
            // 
            // txt_empID
            // 
            this.txt_empID.FormattingEnabled = true;
            this.txt_empID.Location = new System.Drawing.Point(268, 52);
            this.txt_empID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.Size = new System.Drawing.Size(161, 28);
            this.txt_empID.TabIndex = 4;
            this.txt_empID.SelectedIndexChanged += new System.EventHandler(this.txt_empID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Basic Salary:";
            // 
            // txt_Bsly
            // 
            this.txt_Bsly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bsly.Location = new System.Drawing.Point(268, 146);
            this.txt_Bsly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Bsly.Multiline = true;
            this.txt_Bsly.Name = "txt_Bsly";
            this.txt_Bsly.Size = new System.Drawing.Size(609, 45);
            this.txt_Bsly.TabIndex = 7;
            this.txt_Bsly.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bsx_txt);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transportation:";
            // 
            // txt_trans
            // 
            this.txt_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trans.Location = new System.Drawing.Point(268, 247);
            this.txt_trans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trans.Multiline = true;
            this.txt_trans.Name = "txt_trans";
            this.txt_trans.Size = new System.Drawing.Size(609, 55);
            this.txt_trans.TabIndex = 9;
            this.txt_trans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trans_txt);
            // 
            // BackF4
            // 
            this.BackF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackF4.Location = new System.Drawing.Point(747, 38);
            this.BackF4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackF4.Name = "BackF4";
            this.BackF4.Size = new System.Drawing.Size(148, 50);
            this.BackF4.TabIndex = 14;
            this.BackF4.Text = "Back";
            this.BackF4.UseVisualStyleBackColor = true;
            this.BackF4.Click += new System.EventHandler(this.BackF4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(447, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // salName
            // 
            this.salName.Location = new System.Drawing.Point(542, 56);
            this.salName.Name = "salName";
            this.salName.Size = new System.Drawing.Size(183, 26);
            this.salName.TabIndex = 16;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 544);
            this.Controls.Add(this.salName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackF4);
            this.Controls.Add(this.txt_trans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Bsly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_empID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_update);
            this.Controls.Add(this.txt_search);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form4";
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_search;
        private System.Windows.Forms.Button txt_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_empID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Bsly;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_trans;
        private System.Windows.Forms.Button BackF4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salName;
    }
}