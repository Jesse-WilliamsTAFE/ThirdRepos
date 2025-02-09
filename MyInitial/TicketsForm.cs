using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        bool mDiscount = false;
        bool mDiscount2 = false;

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount1.Checked)
                { mDiscount = true; }
            else { mDiscount = false; }
            if (chkDiscount2.Checked) 
                { mDiscount2 = true; }
            else { mDiscount2 = false; }


            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }
            if (radBack.Checked)
                { mSection = 4; }

            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount, mDiscount2);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private void chkDiscount2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscount2.Checked) { chkDiscount1.Checked = false; }
        }

        private void chkDiscount1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscount1.Checked) { chkDiscount2.Checked = false; }
        }
    }
}
