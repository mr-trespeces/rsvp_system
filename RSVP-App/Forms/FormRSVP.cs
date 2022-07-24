using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyektoCSharp.Forms
{
    public partial class FormRSVP : Form
    {
        EventCoordinator eCoord;
        public FormRSVP()
        {
            InitializeComponent();
        }
        public FormRSVP(EventCoordinator e)
        {
            eCoord = e;
            InitializeComponent();
            lblRSVPList.Text = eCoord.getRSVPconfList();
            lblCustInfo.Text = eCoord.customerList();
            lblEventinfo.Text = eCoord.eventList();
        }

        private void txtBoxRsvpCustId_Enter(object sender, EventArgs e)
        {
            if (txtBoxRsvpCustId.Text == "0000")
            {
                txtBoxRsvpCustId.Text = "";
            }
        }

        private void txtBoxRsvpCustId_Leave(object sender, EventArgs e)
        {
            if (txtBoxRsvpCustId.Text == "")
            {
                txtBoxRsvpCustId.Text = "0000";
            }
        }

        private void txtBoxRsvpEvtId_Enter(object sender, EventArgs e)
        {
            if (txtBoxRsvpEvtId.Text == "0000")
            {
                txtBoxRsvpEvtId.Text = "";
            }
        }

        private void txtBoxRsvpEvtId_Leave(object sender, EventArgs e)
        {
            if (txtBoxRsvpEvtId.Text == "")
            {
                txtBoxRsvpEvtId.Text = "0000";
            }
        }

        private void txtBoxRsvpCustId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormRSVP_Load(object sender, EventArgs e)
        {

        }

        private void btnRsvpAdd_Click(object sender, EventArgs e)
        {
            if (eCoord.rsvpConfirmation(Int32.Parse(txtBoxRsvpCustId.Text) , Int32.Parse(txtBoxRsvpEvtId.Text)))
            {
                lblErrorAdding.ForeColor = Color.Green;
                lblErrorAdding.Text = "Registration Successfull";
            }
            else
            {
                lblErrorAdding.ForeColor = Color.Red;
                lblErrorAdding.Text = "Registration unsuccessfull";
            }
            lblRSVPList.Text = eCoord.getRSVPconfList();
            txtBoxRsvpEvtId.Text = "0000";
            txtBoxRsvpCustId.Text = "0000";

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lblErrorAdding.Text = "";
        }
    }
}
