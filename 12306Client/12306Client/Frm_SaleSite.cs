using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _12306Client
{
    public partial class Frm_SaleSite : Form
    {
        public Frm_SaleSite()
        {
            InitializeComponent();
            cmb_province.SelectedIndex = 0;
            cmb_city.SelectedIndex = 0;
            cmb_county.SelectedIndex = 0;
        }

        private void Frm_SaleSite_Load(object sender, EventArgs e)
        {
            getProvinceData();
        }

        public void getProvinceData()
        {
            string strUrl = "https://kyfw.12306.cn/otn/userCommon/allProvince";
            string response = HttpHelper.getResponse(strUrl, "GET", null);
            string[] strData = JSONParse.getSalesiteData(response);

            for(int i = 0; i < strData.Length; i++)
            {
                cmb_province.Items.Add(strData[i]);
            }
        }

        public void getCityData(string provinceName)
        {
            string strUrl = "https://kyfw.12306.cn/otn/queryAgencySellTicket/queryAgentSellCity?province=" + provinceName;
            string response = HttpHelper.getResponse(strUrl, "GET", null);
            string[] strData = JSONParse.getSalesiteCityOrCounty(response);

            for (int i = 0; i < strData.Length; i++)
            {
                if(!strData[i].Trim().Equals(""))
                {
                    cmb_city.Items.Add(strData[i]);
                }
            }
        }

        public void getCountyData(string provinceName, string cityName)
        {
            string strUrl = "https://kyfw.12306.cn/otn/queryAgencySellTicket/queryAgentSellCounty?province=" + provinceName + "&city=" + cityName;
            string response = HttpHelper.getResponse(strUrl, "GET", null);
            string[] strData = JSONParse.getSalesiteCityOrCounty(response);

            for (int i = 0; i < strData.Length; i++)
            {
                if (!strData[i].Trim().Equals(""))
                {
                    cmb_county.Items.Add(strData[i]);
                }
            }
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            string province = cmb_province.SelectedItem.ToString();
            string city = cmb_city.SelectedItem.ToString();
            string county = cmb_county.SelectedItem.ToString();

            string strUrl = "https://kyfw.12306.cn/otn/queryAgencySellTicket/query?province=" + province + "&city=" + city + "&county=";

            if (!province.Equals("请选择省") && !province.Equals(""))
            {
                if (!city.Equals("请选择市") && !city.Equals(""))
                {
                    if (((cmb_county.Items.Count > 1) && (!county.Equals("请选择区/县"))) || (county.Equals("请选择区/县") && (cmb_county.Items.Count == 1)))
                    {
                        if (!county.Equals("请选择区/县"))
                        {
                            strUrl += county;
                        }

                        string response = HttpHelper.getResponse(strUrl, "GET", null);
                        dgv_salesiteList.DataSource = JSONParse.getSalesiteDatasource(response);
                        dgv_salesiteList.BackgroundColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show("请选择区/县", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请选择市！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择省！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmb_province_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(!cmb_province.SelectedItem.ToString().Equals("请选择省"))
            {
                cmb_county.Items.Clear();
                cmb_city.Items.Clear();
                cmb_county.Items.Add("请选择区/县");
                cmb_city.Items.Add("请选择市");
                cmb_county.SelectedIndex = 0;
                cmb_city.SelectedIndex = 0;
                getCityData(cmb_province.SelectedItem.ToString());
            }
        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmb_city.SelectedItem.ToString().Equals("请选择市"))
            {
                cmb_county.Items.Clear();
                cmb_county.Items.Add("请选择区/县");
                cmb_county.SelectedIndex = 0;
                getCountyData(cmb_province.SelectedItem.ToString(), cmb_city.SelectedItem.ToString());
            }
        }
    }
}
