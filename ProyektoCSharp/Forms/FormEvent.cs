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
    public partial class FormEvent : Form
    {
        EventCoordinator eCoord;
        public FormEvent()
        {
            InitializeComponent();
        }
        public FormEvent(EventCoordinator e)
        {
            eCoord = e;
            InitializeComponent();
            lblEventList.Text = eCoord.eventList();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
        }

        private void iconButton3_Click_1(object sender, EventArgs e)
        {
            if (txtBoxEvtName.Text == "e.g. Title" || txtBoxEvtVenue.Text == "e.g. Place" || txtBoxEvtDay.Text == "00"
                || txtBoxEvtMonth.Text == "00" || txtBoxEvtYear.Text == "0000" || txtBoxEvtHour.Text == "00"
                || txtBoxEvtMin.Text == "00" || txtBoxEvtAttendees.Text == "0000"  )
            {
                MessageBox.Show("Please enter a value");
            }
            else
            {
                Date eventDate = new Date(Convert.ToInt32(txtBoxEvtDay.Text), Convert.ToInt32(txtBoxEvtMonth.Text), Convert.ToInt32(txtBoxEvtYear.Text), Convert.ToInt32(txtBoxEvtHour.Text), Convert.ToInt32(txtBoxEvtMin.Text));
                if (eCoord.addEvent(txtBoxEvtName.Text, txtBoxEvtVenue.Text, eventDate, Convert.ToInt32(txtBoxEvtAttendees.Text)))
                {
                    lblAttendeeError.ForeColor = Color.Green;
                    lblAttendeeError.Text = "Successfully added!";
                }
                else
                {
                    lblAttendeeError.ForeColor = Color.Red;
                    lblAttendeeError.Text = "Venue already reserved";
                }
                lblEventList.Text = eCoord.eventList();             
                txtBoxEvtName.Text = "e.g. Title";
                txtBoxEvtVenue.Text = "e.g. Place";
                txtBoxEvtDay.Text = "00";
                txtBoxEvtMonth.Text = "00";
                txtBoxEvtYear.Text = "0000";
                txtBoxEvtHour.Text = "00";
                txtBoxEvtMin.Text = "00";
                txtBoxEvtAttendees.Text = "0000";
                
            }
        }

        private void txtBoxEvtName_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtName.Text == "e.g. Title")
            {
                txtBoxEvtName.Text = "";
            }
        }

        private void txtBoxEvtName_Leave(object sender, EventArgs e)
        {
            if (txtBoxEvtName.Text == "")
            {
                txtBoxEvtName.Text = "e.g. Title";
            }
        }

        private void txtBoxEvtVenue_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtVenue.Text == "e.g. Place")
            {
                txtBoxEvtVenue.Text = "";
            }
        }

        private void txtBoxEvtVenue_Leave(object sender, EventArgs e)
        {
            if (txtBoxEvtVenue.Text == "")
            {
                txtBoxEvtVenue.Text = "e.g. Place";
            }
        }

        private void txtBoxEvtDay_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtDay.Text == "00")
            {
                txtBoxEvtDay.Text = "";
            }
        }

        private void txtBoxEvtDay_Leave(object sender, EventArgs e)
        {
            if (txtBoxEvtDay.Text == "")
            {
                txtBoxEvtDay.Text = "00";
            }
            if(!(Int32.Parse(txtBoxEvtDay.Text) >= 1 && Int32.Parse(txtBoxEvtDay.Text) <= 31))
            {
                lblDateError.Text = "Enter a valid day! \ne.g. 1 to 31.";
                this.ActiveControl = txtBoxEvtDay;
            }
            else
            {
                lblDateError.Text = "";
            }
        }

        private void txtBoxEvtMonth_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtMonth.Text == "00")
            {
                txtBoxEvtMonth.Text = "";
            }
        }

        private void txtBoxEvtMonth_Leave(object sender, EventArgs e)
        {
            if (txtBoxEvtMonth.Text == "")
            {
                txtBoxEvtMonth.Text = "00";
            }
            if (!(Int32.Parse(txtBoxEvtMonth.Text) >= 1 && Int32.Parse(txtBoxEvtMonth.Text) <= 12))
            {
                lblDateError.Text = "Enter a valid month! \ne.g. 1 to 12.";
                this.ActiveControl = txtBoxEvtMonth;
            }
            else
            {
                lblDateError.Text = "";
            }
        }

        private void txtBoxEvtYear_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtYear.Text == "0000")
            {
                txtBoxEvtYear.Text = "";
            }
        }

        private void txtBoxEvtYear_Leave(object sender, EventArgs e)
        {
            DateTime currDate = DateTime.Today;
            if (txtBoxEvtYear.Text == "")
            {
                txtBoxEvtYear.Text = "0000";
            }
            if (!(currDate.Year <= Int32.Parse(txtBoxEvtYear.Text)))
            {
                lblDateError.Text = "Enter a valid year! \ne.g. " + currDate.Year+" or up ";
                this.ActiveControl = txtBoxEvtYear;
            }
            else
            {
                lblDateError.Text = "";
            }
        }

        private void txtBoxEvtHour_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtHour.Text == "00")
            {
                txtBoxEvtHour.Text = "";
            }
        }

        private void txtBoxEvtHour_Leave(object sender, EventArgs e)
        {
            if (txtBoxEvtHour.Text == "")
            {
                txtBoxEvtHour.Text = "00";
            }
            if (!(Int32.Parse(txtBoxEvtHour.Text) >= 0 && Int32.Parse(txtBoxEvtHour.Text) <= 24))
            {
                lblDateError.Text = "Enter a valid 24hr format! \ne.g. 0 to 24.";
                this.ActiveControl = txtBoxEvtHour;
            }
            else
            {
                lblDateError.Text = "";
            }
        }

        private void txtBoxEvtMin_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtMin.Text == "00")
            {
                txtBoxEvtMin.Text = "";
            }
        }

        private void txtBoxEvtMin_Leave(object sender, EventArgs e)
        {
            if (txtBoxEvtMin.Text == "")
            {
                txtBoxEvtMin.Text = "00";
            }
            if (!(Int32.Parse(txtBoxEvtMin.Text) >= 0 && Int32.Parse(txtBoxEvtMin.Text) <= 59))
            {
                lblDateError.Text = "Enter a valid minutes in 24hr format! \ne.g. 0 to 59.";
                this.ActiveControl = txtBoxEvtMin;
            }
            else
            {
                lblDateError.Text = "";
            }
        }

        private void txtBoxEvtAttendees_Enter(object sender, EventArgs e)
        {
            if (txtBoxEvtAttendees.Text == "0000")
            {
                txtBoxEvtAttendees.Text = "";
            }
        }

        private void txtBoxEvtAttendees_Leave(object sender, EventArgs e)
        {
            if (txtBoxEvtAttendees.Text == "")
            {
                txtBoxEvtAttendees.Text = "0000";
            }
            if (!(Int32.Parse(txtBoxEvtAttendees.Text) >= 0 && Int32.Parse(txtBoxEvtAttendees.Text) <= 9999) )
            {
                lblAttendeeError.Text = "Max 9999 attendees only";
                this.ActiveControl = txtBoxEvtAttendees;
            }
        }

        private void txtBoxEvtDay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnEvtDetails_Click(object sender, EventArgs e)
        {
            int eid;
            if (Int32.TryParse(txtBoxgetEventId.Text, out eid))
            {
                lblEventInfo.Text = eCoord.getEventInfoById(eid);
            }
            else
            {
               lblGetIdError.Text = "Enter Valid ID";
            }
        }

        private void txtBoxEvtAttendees_KeyPress(object sender, KeyPressEventArgs e)
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

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            lblAttendeeError.Text = "";
        }
    }
}
