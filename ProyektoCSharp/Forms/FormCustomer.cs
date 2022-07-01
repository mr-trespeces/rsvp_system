using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyektoCSharp.Forms
{
    public partial class FormCustomer : Form
    {
        EventCoordinator eCoord;
        public FormCustomer()
        {
            InitializeComponent();
        }
        public FormCustomer(EventCoordinator e)
        {
            eCoord = e;
            InitializeComponent();
            lblCustList.Text = eCoord.customerList();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int cid;
            if (Int32.TryParse(txtBoxGetCustId.Text, out cid))
            {
                lblCustInfoById.Text = eCoord.getCustomerInfoById(cid);
            }
            else
            {
               lblDelConfirm.Text = "Enter Valid Id";
            }     
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string strRegex = @"^\d{3}-\d{3}-\d{4}$";
            Regex re = new Regex(strRegex);
            if (txtBoxFname.Text == "e.g John" || txtBoxLname.Text == "e.g. Doe" || txtBoxPhone.Text == "XXX-XXX-XXXX")
            {
                lblAddingConfirm.Text = "Enter a valid data!";
            }
            else if (!re.IsMatch(txtBoxPhone.Text))
            {
                lblAddingConfirm.Text = "Enter a valid number \nHint: XXX-XXX-XXXX";
            }
            else
            {
                eCoord.addCustomer(txtBoxFname.Text, txtBoxLname.Text, txtBoxPhone.Text);
                lblCustList.Text = eCoord.customerList();
                lblAddingConfirm.ForeColor = Color.Green;
                lblAddingConfirm.Text = "Successfully Added!";
                txtBoxFname.Text = "e.g John";
                txtBoxLname.Text = "e.g. Doe";
                txtBoxPhone.Text = "XXX-XXX-XXXX";
            }  
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int cid;
            if (Int32.TryParse(txtBoxGetCustId.Text, out cid))
            {      
                if (eCoord.deleteCustomer(cid))
                {
                    DialogResult exit = MessageBox.Show("Are you sure you want to delete this person?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (exit == DialogResult.OK)
                    {
                        eCoord.deleteCustomer(cid);
                        lblCustList.Text = eCoord.customerList();
                        lblCustInfoById.Text = "";
                        lblDelConfirm.Text = "Successfully Deleted";
                    }
                }              
            }
            else
            {
                lblDelConfirm.Text = "Enter valid Id";
            }
        }

        private void txtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBoxFname_Leave(object sender, EventArgs e)
        {
            if (txtBoxFname.Text == "")
            {
                txtBoxFname.Text = "e.g John";
            }
        }

        private void txtBoxFname_Enter(object sender, EventArgs e)
        {
            if (txtBoxFname.Text == "e.g John")
            {
                txtBoxFname.Text = "";
            }
        }

        private void txtBoxLname_Enter(object sender, EventArgs e)
        {
            if (txtBoxLname.Text == "e.g. Doe")
            {
                txtBoxLname.Text = "";
            }
        }

        private void txtBoxLname_Leave(object sender, EventArgs e)
        {
            if (txtBoxLname.Text == "")
            {
                txtBoxLname.Text = "e.g. Doe";
            }
        }

        private void txtBoxPhone_Enter(object sender, EventArgs e)
        {
            if (txtBoxPhone.Text == "XXX-XXX-XXXX")
            {
                txtBoxPhone.Text = "";
            }
            toolTip1.Show("Hint: XXX-XXX-XXXX", txtBoxPhone, 100, 20, 1500);
        }

        private void txtBoxPhone_Leave(object sender, EventArgs e)
        {
            if (txtBoxPhone.Text == "")
            {
                txtBoxPhone.Text = "XXX-XXX-XXXX";
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lblAddingConfirm.Text = "";
            lblDelConfirm.Text = "";
        }
    }
}
