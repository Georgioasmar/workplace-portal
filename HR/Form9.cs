using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            txt_id.Text = Form1.loggedID;
            DbFunctions.RetrieveEmployeeSalary(Form1.loggedID, ref salName, ref txt_Bsly, ref txt_trans);
            salName.ReadOnly = true;
            txt_Bsly.ReadOnly = true;
            txt_trans.ReadOnly = true;
            txt_id.ReadOnly = true;

        }

        private void BackF4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
