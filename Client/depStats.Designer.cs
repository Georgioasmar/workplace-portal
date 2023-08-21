
namespace Client
{
    partial class depStats
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butt_backSal = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button_toExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(811, 437);
            this.dataGridView1.TabIndex = 1;
            // 
            // butt_backSal
            // 
            this.butt_backSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butt_backSal.Location = new System.Drawing.Point(21, 30);
            this.butt_backSal.Name = "butt_backSal";
            this.butt_backSal.Size = new System.Drawing.Size(217, 86);
            this.butt_backSal.TabIndex = 4;
            this.butt_backSal.Text = "Back";
            this.butt_backSal.UseVisualStyleBackColor = true;
            this.butt_backSal.Click += new System.EventHandler(this.butt_backSal_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(266, 53);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(566, 39);
            this.searchBox.TabIndex = 5;
            this.searchBox.Text = "Search by Department";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            // 
            // button_toExcel
            // 
            this.button_toExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_toExcel.Location = new System.Drawing.Point(859, 30);
            this.button_toExcel.Name = "button_toExcel";
            this.button_toExcel.Size = new System.Drawing.Size(217, 86);
            this.button_toExcel.TabIndex = 7;
            this.button_toExcel.Text = "Export to Excel";
            this.button_toExcel.UseVisualStyleBackColor = true;
            this.button_toExcel.Click += new System.EventHandler(this.button_toExcel_Click);
            // 
            // depStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 597);
            this.Controls.Add(this.button_toExcel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.butt_backSal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "depStats";
            this.Text = "Department Statistics";
            this.Load += new System.EventHandler(this.depStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butt_backSal;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button_toExcel;
    }
}