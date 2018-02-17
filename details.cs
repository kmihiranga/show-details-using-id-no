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
    public partial class new_id_details : Form
    {
        public string newValue;
        public string newSub;
        public string newTotal;
        public Int32 newTotalValue;
        public string newSub2;
        public Int32 newTotalValue1;
        public Int32 newSum;
        
        public new_id_details()
        {
            InitializeComponent();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            newValue = Convert.ToString(txtid.Text);

            if (newValue.Length == 12)
            {
                newSub = newValue.Substring(0, 4);
                newTotal = newSub;
                newTotalValue = Convert.ToInt32(newTotal);
                newSub2 = newValue.Substring(4, 3);
                newTotalValue1 = Convert.ToInt32(newSub2);


                if (newTotalValue1 >= 1 && newTotalValue1 <= 366)  // male birthday
                {
                    if (newTotalValue1 <= 31) // January
                    {
                        newSum = newTotalValue1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "January" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 31 && newTotalValue1 <= 59)//February
                    {
                        newSum = newTotalValue1 - 31;
                        txtbd.Text = (newTotalValue.ToString() + " " + "February" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 59 && newTotalValue1 <= 90)//March
                    {
                        newSum = (newTotalValue1 - 59) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "March" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 90 && newTotalValue1 <= 120) // April
                    {
                        newSum = (newTotalValue1 - 90) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "April" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 120 && newTotalValue1 <= 151) //May
                    {
                        newSum = (newTotalValue1 - 120) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "May" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 151 && newTotalValue1 <= 181) //June
                    {
                        newSum = (newTotalValue1 - 151) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "June" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 181 && newTotalValue1 <= 212) //July 
                    {
                        newSum = (newTotalValue1 - 181) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "July" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 212 && newTotalValue1 <= 243) //August
                    {
                        newSum = (newTotalValue1 - 212) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "August" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 243 && newTotalValue1 <= 273) //September
                    {
                        newSum = (newTotalValue1 - 243) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "September" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 273 && newTotalValue1 <= 304) //Octomber
                    {
                        newSum = (newTotalValue1 - 273) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "Octomber" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 304 && newTotalValue1 <= 334) //November
                    {
                        newSum = (newTotalValue1 - 304) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "November" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 334 && newTotalValue1 <= 366) //December
                    {
                        newSum = (newTotalValue1 - 334) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "December" + " " + newSum.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a valid Identity Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (newTotalValue1 > 500 && newTotalValue1 <= 866)   // Female Birthday
                {
                    if (newTotalValue1 <= 531) // january
                    {
                        newSum = Math.Abs(500 - newTotalValue1); //convert into a positive number 
                        txtbd.Text = (newTotalValue.ToString() + " " + "January" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 531 && newTotalValue1 <= 559) // february
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 31));
                        txtbd.Text = (newTotalValue.ToString() + " " + "February" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 559 && newTotalValue1 <= 590)  // March
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 59)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "March" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 590 && newTotalValue1 <= 620)  // april
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 90)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "April" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 620 && newTotalValue1 <= 651)  // May
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 120)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "May" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 651 && newTotalValue1 <= 681) // June
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 151)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "June" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 681 && newTotalValue1 <= 712) // July
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 181)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "July" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 712 && newTotalValue1 <= 743)  //August
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 212)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "August" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 743 && newTotalValue1 <= 773) // September
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 243)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "September" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 773 && newTotalValue1 <= 804)  // Octomber
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 273)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "October" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 804 && newTotalValue1 <= 834)  // November
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 304)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "November" + " " + newSum.ToString());
                    }
                    else if (newTotalValue1 > 834 && newTotalValue1 <= 865)  // December
                    {
                        newSum = Math.Abs(500 - (newTotalValue1 - 334)) - 1;
                        txtbd.Text = (newTotalValue.ToString() + " " + "December" + " " + newSum.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Please Check your Number Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Age Code 
                    
                }
                
            }
            else
            {
                MessageBox.Show("Please Check the Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (newValue.Length == 12)
            {
                string dateNow = DateTime.Now.Year.ToString();
                Int32 dateValue = Convert.ToInt32(dateNow);

                newSub = newValue.Substring(0, 4);
                Int32 totalSum = Convert.ToInt32(newSub);
                Int32 dateSum = (dateValue - totalSum);

                txtag.Text = dateSum.ToString();
            }
            else
            {
                txtag.Text = "Please Check Number!";
            }

            // Gender Code 

            if (newValue.Length == 12)
            {
                newSub2 = newValue.Substring(4, 3);
                Int32 totalGender = Convert.ToInt32(newSub2);

                if (totalGender >= 1 && totalGender <= 366)
                {
                    txtgn.Text = "Male";
                }
                else if (totalGender > 500 && totalGender <= 866)
                {
                    txtgn.Text = "Female";
                }
                else
                {
                    MessageBox.Show("Please check the Number Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtgn.Text = "Please Check Number!";
            }
           
        }

        private void buttonnew_Click(object sender, EventArgs e)
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

        private void new_id_details_Load(object sender, EventArgs e)
        {
            txtid.Focus();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
            txtid.MaxLength = 12;
        }

        private void buttonok_KeyPress(object sender, KeyPressEventArgs e) // enter key 
        {
          

        }// end of code
    }
}
