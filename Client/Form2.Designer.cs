namespace Client
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.txt_ph = new System.Windows.Forms.TextBox();
            this.txt_insert = new System.Windows.Forms.Button();
            this.txt_delete = new System.Windows.Forms.Button();
            this.txt_clear = new System.Windows.Forms.Button();
            this.BackF2 = new System.Windows.Forms.Button();
            this.cb_dep = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_pos = new System.Windows.Forms.ComboBox();
            this.cb_field = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(583, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.FormattingEnabled = true;
            this.txt_id.Location = new System.Drawing.Point(777, 82);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(88, 33);
            this.txt_id.TabIndex = 4;
            this.txt_id.SelectedIndexChanged += new System.EventHandler(this.txt_id_SelectedIndexChanged);
            this.txt_id.TextUpdate += new System.EventHandler(this.txt_id_TextUpdate);
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(264, 82);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.MaxLength = 50;
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(283, 35);
            this.txt_name.TabIndex = 5;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_add
            // 
            this.txt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add.Location = new System.Drawing.Point(264, 143);
            this.txt_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_add.MaxLength = 50;
            this.txt_add.Multiline = true;
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(283, 35);
            this.txt_add.TabIndex = 6;
            // 
            // txt_ph
            // 
            this.txt_ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ph.Location = new System.Drawing.Point(264, 264);
            this.txt_ph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ph.MaxLength = 10;
            this.txt_ph.Multiline = true;
            this.txt_ph.Name = "txt_ph";
            this.txt_ph.Size = new System.Drawing.Size(283, 35);
            this.txt_ph.TabIndex = 7;
            this.txt_ph.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Keyph);
            // 
            // txt_insert
            // 
            this.txt_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_insert.Location = new System.Drawing.Point(264, 409);
            this.txt_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_insert.Name = "txt_insert";
            this.txt_insert.Size = new System.Drawing.Size(162, 108);
            this.txt_insert.TabIndex = 8;
            this.txt_insert.Text = "Save";
            this.txt_insert.UseVisualStyleBackColor = true;
            this.txt_insert.Click += new System.EventHandler(this.txt_insert_Click);
            // 
            // txt_delete
            // 
            this.txt_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_delete.Location = new System.Drawing.Point(563, 411);
            this.txt_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(152, 108);
            this.txt_delete.TabIndex = 10;
            this.txt_delete.Text = "Delete";
            this.txt_delete.UseVisualStyleBackColor = true;
            this.txt_delete.Click += new System.EventHandler(this.txt_delete_Click);
            // 
            // txt_clear
            // 
            this.txt_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clear.Location = new System.Drawing.Point(854, 411);
            this.txt_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_clear.Name = "txt_clear";
            this.txt_clear.Size = new System.Drawing.Size(156, 106);
            this.txt_clear.TabIndex = 11;
            this.txt_clear.Text = "Clear";
            this.txt_clear.UseVisualStyleBackColor = true;
            this.txt_clear.Click += new System.EventHandler(this.txt_clear_Click);
            // 
            // BackF2
            // 
            this.BackF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.BackF2.Location = new System.Drawing.Point(29, 24);
            this.BackF2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackF2.Name = "BackF2";
            this.BackF2.Size = new System.Drawing.Size(111, 46);
            this.BackF2.TabIndex = 13;
            this.BackF2.Text = "Back";
            this.BackF2.UseVisualStyleBackColor = true;
            this.BackF2.Click += new System.EventHandler(this.BackF2_Click);
            // 
            // cb_dep
            // 
            this.cb_dep.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_dep.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dep.FormattingEnabled = true;
            this.cb_dep.Location = new System.Drawing.Point(767, 143);
            this.cb_dep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_dep.Name = "cb_dep";
            this.cb_dep.Size = new System.Drawing.Size(243, 33);
            this.cb_dep.TabIndex = 16;
            this.cb_dep.SelectedIndexChanged += new System.EventHandler(this.cb_dep_SelectedIndexChanged);
            this.cb_dep.TextChanged += new System.EventHandler(this.cb_dep_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(583, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Department:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(264, 205);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.MaxLength = 50;
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(283, 35);
            this.txt_email.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email Address:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(264, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(746, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Edit Linked Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(583, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 30);
            this.label7.TabIndex = 20;
            this.label7.Text = "Position:";
            // 
            // cb_pos
            // 
            this.cb_pos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_pos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pos.FormattingEnabled = true;
            this.cb_pos.Location = new System.Drawing.Point(709, 267);
            this.cb_pos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_pos.Name = "cb_pos";
            this.cb_pos.Size = new System.Drawing.Size(301, 33);
            this.cb_pos.TabIndex = 21;
            // 
            // cb_field
            // 
            this.cb_field.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_field.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_field.FormattingEnabled = true;
            this.cb_field.Location = new System.Drawing.Point(709, 205);
            this.cb_field.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_field.Name = "cb_field";
            this.cb_field.Size = new System.Drawing.Size(301, 33);
            this.cb_field.TabIndex = 22;
            this.cb_field.SelectedIndexChanged += new System.EventHandler(this.cb_field_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(583, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Field:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 572);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_field);
            this.Controls.Add(this.cb_pos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_dep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BackF2);
            this.Controls.Add(this.txt_clear);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.txt_insert);
            this.Controls.Add(this.txt_ph);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Employee Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.TextBox txt_ph;
        private System.Windows.Forms.Button txt_insert;
        private System.Windows.Forms.Button txt_delete;
        private System.Windows.Forms.Button txt_clear;
        private System.Windows.Forms.Button BackF2;
        private System.Windows.Forms.ComboBox cb_dep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_pos;
        private System.Windows.Forms.ComboBox cb_field;
        private System.Windows.Forms.Label label8;
    }
}