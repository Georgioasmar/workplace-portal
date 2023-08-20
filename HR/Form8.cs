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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (Form1.loggedID != null)
            {
                if (Form1.loggedAdmin)
                {
                    cb_booker.Items.Add(Form3.fullName);
                    cb_booker.Items.Add("System Admin");
                    cb_booker.Text = Form3.fullName;
                }
                else
                {
                    txt_bookerID.Text = Form1.loggedID;
                    cb_booker.Items.Add(Form3.fullName);
                    cb_booker.Text = Form3.fullName;
                }
            }
            else if(Form1.loggedID == null)
            {
                cb_booker.Items.Add("System Admin");
                cb_booker.Text = "System Admin";
            }
        }
    }
}
