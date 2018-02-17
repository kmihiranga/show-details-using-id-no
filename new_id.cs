using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nic_form
{
    public partial class new_id : Form
    {
        public new_id()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {

        }

        private void new_id_Load(object sender, EventArgs e)
        {
            txtold.Focus();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldnum;

            oldnum = Convert.ToString(txtold.Text);           


            if (oldnum.Length == 9)
            {
                string sub = oldnum.Substring(0, 5);
                string sub2 = oldnum.Substring(5, 4);
                
                txtnew.Text = "19" + sub + "0" + sub2 ;

            }
            else 
            {
                MessageBox.Show("Please Check the Number!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtold.Text = "";
            txtnew.Text = "";
            txtold.Focus();
        }

        private void txtold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            txtold.MaxLength = 9;
        }
    }
}
