
namespace HR
{
    partial class Form9
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
            this.salName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackF4 = new System.Windows.Forms.Button();
            this.txt_trans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Bsly = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salName
            // 
            this.salName.Location = new System.Drawing.Point(399, 91);
            this.salName.Name = "salName";
            this.salName.Size = new System.Drawing.Size(177, 26);
            this.salName.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(304, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name:";
            // 
            // BackF4
            // 
            this.BackF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackF4.Location = new System.Drawing.Point(26, 20);
            this.BackF4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackF4.Name = "BackF4";
            this.BackF4.Size = new System.Drawing.Size(148, 50);
            this.BackF4.TabIndex = 23;
            this.BackF4.Text = "Back";
            this.BackF4.UseVisualStyleBackColor = true;
            this.BackF4.Click += new System.EventHandler(this.BackF4_Click);
            // 
            // txt_trans
            // 
            this.txt_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trans.Location = new System.Drawing.Point(309, 252);
            this.txt_trans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_trans.Multiline = true;
            this.txt_trans.Name = "txt_trans";
            this.txt_trans.Size = new System.Drawing.Size(267, 36);
            this.txt_trans.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "Transportation:";
            // 
            // txt_Bsly
            // 
            this.txt_Bsly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bsly.Location = new System.Drawing.Point(309, 186);
            this.txt_Bsly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Bsly.Multiline = true;
            this.txt_Bsly.Name = "txt_Bsly";
            this.txt_Bsly.Size = new System.Drawing.Size(267, 36);
            this.txt_Bsly.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Basic Salary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(229, 90);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(59, 26);
            this.txt_id.TabIndex = 26;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 341);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.salName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackF4);
            this.Controls.Add(this.txt_trans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Bsly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackF4;
        private System.Windows.Forms.TextBox txt_trans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Bsly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
    }
}