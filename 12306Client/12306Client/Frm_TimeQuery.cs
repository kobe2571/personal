using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace _12306Client
{
    public partial class Frm_TimeQuery : Form
    {
        public delegate void ImageHandler();
        public delegate void InvokeHandler();
        public delegate void MessageHandler(string strStation, string strTrainCode, string strCheckCode);

        public Frm_TimeQuery()
        {
            InitializeComponent();
            reloadImage();
        }

        public void getImage()
        {
            string url = "https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module=other&rand=sjrand";
            Stream stream = HttpHelper.getResponseImage(url);

            try
            {
                pb_checkcode.Invoke(
                    new InvokeHandler(
                        delegate()
                        {
                            pb_checkcode.Image = Image.FromStream(stream);
                        }
                        )
                    );
            }
            catch (Exception)
            {
                MessageBox.Show("验证码获取失败！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void getMessage(string strStation, string strTrainCode, string strCheckCode)
        {
            string url = "https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn";
            string data = "randCode=" + strCheckCode + "&rand=sjrand";
            string response = HttpHelper.getResponse(url, "POST", data);


            url = "https://kyfw.12306.cn/otn/zwdch/query";
            string queryType = "";
            if (rdb_startstation.Checked)
            {
                queryType = "1";
            }
            else
            {
                queryType = "0";
            }

            strStation = HttpHelper.EncodingURI(strStation);
            string czEn = HttpHelper.EncodingURI(strStation).Replace('%', '-');

            data = "cxlx=" + queryType + "&czEn=" + czEn + "&cz=" + strStation + "&cc=" + strTrainCode + "&randCode=" + strCheckCode;
            response = HttpHelper.getResponse(url, "POST", data);

            if (!JSONParse.getZhengWanDian(response).Equals(string.Empty))
            {
                MessageBox.Show(JSONParse.getZhengWanDian(response), "信 息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_checkcode.Clear();
                reloadImage();
            }
            else
            {
                MessageBox.Show("列车正晚点查询失败！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_checkcode_Click(object sender, EventArgs e)
        {
            reloadImage();
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string strStation = txt_station.Text.Trim();
            string strTrainCode = txt_traincode.Text.Trim();
            string strCheckCode = txt_checkcode.Text.Trim();

            if (!strStation.Equals(""))
            {
                if (!strTrainCode.Equals(""))
                {
                    if (!strCheckCode.Equals(""))
                    {
                        MessageHandler handler = new MessageHandler(getMessage);
                        handler.BeginInvoke(strStation, strTrainCode, strCheckCode, null, null);
                    }
                    else
                    {
                        MessageBox.Show("请输入验证码！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("车次不能为空！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("车站名称不能为空！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void reloadImage()
        {
            ImageHandler handler = new ImageHandler(getImage);
            handler.BeginInvoke(null, null);
        }
    }
}
