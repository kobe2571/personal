using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _12306Client
{
    public partial class Frm_TicketPrice : Form
    {
        public delegate void Handler();

        public Frm_TicketPrice()
        {
            InitializeComponent();
            initDialog();
            Handler handler = new Handler(getRandCode);
            handler.BeginInvoke(null, null);
        }

        public void initDialog()
        {
            string url = "https://kyfw.12306.cn/otn/leftTicketPrice/init";
            try
            {
                HttpHelper.getResponse(url, "GET", null);
            }
            catch (Exception)
            {
                MessageBox.Show("初始化失败！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void getRandCode()
        {
            string url = "https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module=other&rand=sjrand";
            pbx_randCode.Image = Image.FromStream(HttpHelper.getResponseImage(url));
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string startStation = txt_startStation.Text.Trim();
            string endStation = txt_endStation.Text.Trim();
            string date = dtp_startTime.Text.Trim();
            string randCode = txt_randCode.Text.Trim();

            string url = "https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn";
            string data = "randCode=" + randCode + "&rand=sjrand&_json_att=";
            string result = HttpHelper.getResponse(url, "POST", data);
            if(result.Substring(result.IndexOf("msg") + 6, 13).ToUpper().Equals("RANDCODERIGHT"))
            {
                startStation = StationInformation.getStationCode(startStation);
                endStation = StationInformation.getStationCode(endStation);
                url = "https://kyfw.12306.cn/otn/leftTicketPrice/query?leftTicketDTO.train_date=" + date + "&leftTicketDTO.from_station=" + startStation + "&leftTicketDTO.to_station=" + endStation + "&purpose_codes=ADULT&randCode=" + randCode + "";
                result = HttpHelper.getResponse(url, "GET", null);
                if (result.Substring(result.IndexOf("status") + 8, 4).ToUpper().Equals("TRUE"))
                {
                    DataTable dt = JSONParse.getTicketPrice(result);
                    dgv_ticketPrice.DataSource = dt;
                    dgv_ticketPrice.BackgroundColor = Color.White;
                }
            }

            txt_randCode.Clear();
            getRandCode();
        }

        private void pbx_randCode_Click(object sender, EventArgs e)
        {
            getRandCode();
        }
    }
}
