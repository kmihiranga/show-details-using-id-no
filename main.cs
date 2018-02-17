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
    public partial class Form1 : Form
    {
        public Int32 inputValue;
        public string value;
        public string sub;
        public string str;
        Int32 sum;
       


        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {            

        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            txtid.Focus();
           
            //string numid = Convert.ToString(txtid.Text);
            
            

                value = Convert.ToString(txtid.Text);




                if (value.Length == 9)
                {
                    sub = value.Substring(0, 2);
                    string total = "19" + sub;
                    Int32 totalValue = Convert.ToInt32(total);

                    if (totalValue % 4 != 0 || totalValue % 4 == 0)
                    {

                        string sub2 = value.Substring(2, 3);
                        Int32 totalValue1 = Convert.ToInt32(sub2);



                        if (totalValue1 >= 1 && totalValue1 <= 366)
                        {

                            if (totalValue1 <= 31) // January
                            {
                                sum = (totalValue1); // calculation for get the date 
                                txtbd.Text = (totalValue.ToString() + " " + "January" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 31 && totalValue1 <= 59) //February
                            {
                                sum = (totalValue1 - 31);
                                txtbd.Text = (totalValue.ToString() + " " + "February" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 59 && totalValue1 <= 90) //March
                            {
                                sum = (totalValue1 - 59) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "March" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 90 && totalValue1 <= 120) //April
                            {
                                sum = (totalValue1 - 90) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "April" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 120 && totalValue1 <= 151) //May
                            {
                                sum = (totalValue1 - 120) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "May" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 151 && totalValue1 <= 181) //June
                            {
                                sum = (totalValue1 - 151) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "June" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 181 && totalValue1 <= 212) //July
                            {
                                sum = (totalValue1 - 181) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "July" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 212 && totalValue1 <= 243) //August
                            {
                                sum = (totalValue1 - 212) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "August" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 243 && totalValue1 <= 273) //September
                            {
                                sum = (totalValue1 - 243) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "September" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 273 && totalValue1 <= 304) //Octomber
                            {
                                sum = (totalValue1 - 273) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "October" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 304 && totalValue1 <= 334) //November
                            {
                                sum = (totalValue1 - 304) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "November" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 334 && totalValue1 <= 366) //December
                            {
                                sum = (totalValue1 - 334) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "December" + " " + sum.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Something Wrong! Please Check the ID Number.");
                            }
                        }
                        else if (totalValue1 > 500 && totalValue1 <= 866) //Female Birth Day begins with +500 for days
                        {
                            if (totalValue1 <= 531) //January
                            {
                                sum = Math.Abs(500 - totalValue1); //convert into a positive number 
                                txtbd.Text = (totalValue.ToString() + " " + "January" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 531 && totalValue1 <= 559)//February
                            {
                                sum = Math.Abs(500 - (totalValue1 - 31));
                                txtbd.Text = (totalValue.ToString() + " " + "February" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 559 && totalValue1 <= 590)//March
                            {
                                sum = Math.Abs(500 - (totalValue1 - 59)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "March" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 590 && totalValue1 <= 620)//April
                            {
                                sum = Math.Abs(500 - (totalValue1 - 90)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "April" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 620 && totalValue1 <= 651)//May
                            {
                                sum = Math.Abs(500 - (totalValue1 - 120)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "May" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 651 && totalValue1 <= 681)//June
                            {
                                sum = Math.Abs(500 - (totalValue1 - 151)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "June" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 681 && totalValue1 <= 712)//July
                            {
                                sum = Math.Abs(500 - (totalValue1 - 181)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "July" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 712 && totalValue1 <= 743)//August
                            {
                                sum = Math.Abs(500 - (totalValue1 - 212)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "August" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 743 && totalValue1 <= 773)//September
                            {
                                sum = Math.Abs(500 - (totalValue1 - 243)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "September" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 773 && totalValue1 <= 804)//Octomber
                            {
                                sum = Math.Abs(500 - (totalValue1 - 273)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "October" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 804 && totalValue1 <= 834)//November
                            {
                                sum = Math.Abs(500 - (totalValue1 - 304)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "November" + " " + sum.ToString());
                            }
                            else if (totalValue1 > 834 && totalValue1 <= 865)//December
                            {
                                sum = Math.Abs(500 - (totalValue1 - 334)) - 1;
                                txtbd.Text = (totalValue.ToString() + " " + "December" + " " + sum.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Something Wrong! Please Check the ID Number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Check Your ID Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Check You Entered Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter 9 Digit Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                // Gender Code 
                if (value.Length == 9)
                {
                    sub = value.Substring(2, 3);
                    Int32 totalGender = Convert.ToInt32(sub);

                    if (totalGender >= 1 && totalGender <= 366) // check male number
                    {
                        txtgn.Text = "Male";
                    }
                    else if (totalGender > 500) // check female number
                    {
                        txtgn.Text = "Female";
                    }
                    else
                    {
                        MessageBox.Show("Please Check your Number Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtgn.Text = "Please Check Number!";
                }

                // Age Code 
                if (value.Length == 9)
                {

                    string dateNow = DateTime.Now.Year.ToString(); // get the year in now
                    Int32 dateValue = Convert.ToInt32(dateNow); // convert year in to a int value

                    sub = value.Substring(0, 2);
                    string totalDate = "19" + sub;
                    Int32 totalSum = Convert.ToInt32(totalDate);

                    Int32 dateSum = (dateValue - totalSum);

                    txtag.Text = dateSum.ToString();
                }
                else
                {
                    txtag.Text = "Please Check Number!";
                }

            }        
                          

        private void buttonok_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void buttonnew_Click(object sender, EventArgs e) // button new
        {
            txtid.Text = "";
            txtbd.Text = "";
            txtgn.Text = "";
            txtag.Text = "";
            txtid.Focus();

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {

            DialogResult Exit;
            Exit = MessageBox.Show("Are you want to Exit!.", "Exit National Identity Card", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Exit == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
                txtid.Focus();
            }
        }

        private void provinceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            province_form MainForm = new province_form();
            MainForm.Show();
            this.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newIdentityCardNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newIDNumberGenerateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_id nw = new new_id();
            nw.Show();
            this.Show();

        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            about_us ab = new about_us();
            ab.Show();
            this.Show();
        }

        private void newIDDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new_id_details n = new new_id_details();
            n.Show();
            this.Show();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e) // Validation Handling only enter Numbers
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            txtid.MaxLength = 9;
        }
    }
}
