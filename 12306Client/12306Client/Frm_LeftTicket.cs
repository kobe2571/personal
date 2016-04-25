using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _12306Client
{
    public partial class Frm_LeftTicket : Form
    {
        private string strNotify = null;
        private string url = null;

        public Frm_LeftTicket()
        {
            InitializeComponent();
            cmb_ticketType.SelectedIndex = 0;
        }

        public delegate void parseDataDelegate(string url);
        public delegate void InvokeHandler();

        private void btn_queryTickets_Click(object sender, EventArgs e)
        {
            string strStartStation = txt_startStation.Text.Trim();
            string strEndStation = txt_endStation.Text.Trim();
            string strTicketType = cmb_ticketType.SelectedItem.ToString();
            string strStartTime = dtp_startTime.Text.Trim();

            strNotify = strStartStation + " 到 " + strEndStation + " " + strTicketType + " 信息";

            if(strTicketType.Equals("成人票"))
            {
                strTicketType = "ADULT";
            }
            else
            {
                strTicketType = "0X00";
            }

            if (!strStartStation.Equals(string.Empty) && !(strStartStation = StationInformation.getStationCode(strStartStation)).Equals(string.Empty))
            {
                if (!strEndStation.Equals(string.Empty) && !(strEndStation = StationInformation.getStationCode(strEndStation)).Equals(string.Empty))
                {
                    url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=" + strTicketType + "&queryDate=" + strStartTime + "&from_station=" + strStartStation + "&to_station=" + strEndStation + "";

                    parseDataDelegate pdd = new parseDataDelegate(parseData);
                    pdd.BeginInvoke(url, null, null);
                }
                else
                {
                    MessageBox.Show("目的地输入无效，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("出发地输入无效，请重新输入！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void parseData(string url)
        {
            string response = HttpHelper.getResponse(url, "GET", null);

            try
            {
                this.dgv_ticketShow.Invoke(
                    new InvokeHandler(
                        delegate() {
                            this.dgv_ticketShow.DataSource = null;
                            this.dgv_ticketShow.DataSource = JSONParse.getLeftTicketsJArray(response);
                            this.dgv_ticketShow.BackgroundColor = Color.White;
                }));
                
                MessageBox.Show(strNotify + "查询完毕！", "信 息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("查询失败！异常错误！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void tmt_login_Click(object sender, EventArgs e)
        {
            Frm_Login frmLogin = new Frm_Login();
            frmLogin.ShowDialog();
        }
    }
}
