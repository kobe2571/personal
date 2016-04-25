using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _12306Client
{
    public partial class Frm_Main : Form
    {
        private string loginResult;
        public string LoginResult
        {
            set
            {
                loginResult = value;
            }
        }

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void tsm_leftticket_Click(object sender, EventArgs e)
        {
            Frm_LeftTicket frmLeftTicket = new Frm_LeftTicket();
            frmLeftTicket.ShowDialog();
        }

        private void tsm_login_Click(object sender, EventArgs e)
        {
            Frm_Login frmLogin = new Frm_Login();
            frmLogin.Owner = this;
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                frmLogin.Close();
                if (!loginResult.Equals(""))
                {
                    MessageBox.Show(loginResult);
                }
            }
        }

        private void tsm_time_Click(object sender, EventArgs e)
        {
            Frm_TimeQuery frmTimeQuery = new Frm_TimeQuery();
            frmTimeQuery.ShowDialog();
        }

        private void tsm_salesite_Click(object sender, EventArgs e)
        {
            Frm_SaleSite frmSaleSite = new Frm_SaleSite();
            frmSaleSite.ShowDialog();
        }

        private void tsm_ticketprice_Click(object sender, EventArgs e)
        {
            Frm_TicketPrice frmTicketPrice = new Frm_TicketPrice();
            frmTicketPrice.ShowDialog();
        }
    }
}
