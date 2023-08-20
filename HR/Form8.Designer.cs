
namespace HR
{
    partial class Form8
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
            this.Calendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_bookerID = new System.Windows.Forms.TextBox();
            this.cb_booker = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(29, 27);
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 0;
            this.Calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(519, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(731, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 26);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meeting Starts at:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(626, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "and Ends at:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "hh:mm";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(926, 25);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(74, 26);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(846, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(646, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(382, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Scheduler ID:";
            // 
            // txt_bookerID
            // 
            this.txt_bookerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_bookerID.Location = new System.Drawing.Point(519, 84);
            this.txt_bookerID.Name = "txt_bookerID";
            this.txt_bookerID.Size = new System.Drawing.Size(98, 35);
            this.txt_bookerID.TabIndex = 29;
            // 
            // cb_booker
            // 
            this.cb_booker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_booker.FormattingEnabled = true;
            this.cb_booker.Location = new System.Drawing.Point(731, 91);
            this.cb_booker.Name = "cb_booker";
            this.cb_booker.Size = new System.Drawing.Size(269, 28);
            this.cb_booker.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(382, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 274);
            this.panel1.TabIndex = 31;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_booker);
            this.Controls.Add(this.txt_bookerID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Calendar1);
            this.Name = "Form8";
            this.Text = "Book a Meeting";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_bookerID;
        private System.Windows.Forms.ComboBox cb_booker;
        private System.Windows.Forms.Panel panel1;
    }
}