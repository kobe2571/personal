using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace _12306Client
{
    class JSONParse
    {
        public static DataTable getLeftTicketsJArray(string response)
        {
            string[] columnsArray = {"车 次", "出发站", "到达站", "出发时间", "达到时间",
                                     "历 时", "商务座", "特等座", "一等座", "二等座", "高级软卧", "软 卧", "硬 卧", 
                                     "软 座", "硬 座", "无 座", "起售时间", "备 注"};

            DataTable dt = new DataTable();
            for (int m = 0; m < columnsArray.Length; m++)
            {
                dt.Columns.Add(columnsArray[m]);
            }

            JObject jsonObject = JObject.Parse(response);
            JArray jsonArray = (JArray)jsonObject["data"]["datas"];
            for (int i = 0; i < jsonArray.Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr["车 次"] = jsonArray[i]["station_train_code"].ToString();
                dr["出发站"] = jsonArray[i]["from_station_name"].ToString();
                dr["到达站"] = jsonArray[i]["to_station_name"].ToString();
                dr["出发时间"] = jsonArray[i]["start_time"].ToString();
                dr["达到时间"] = jsonArray[i]["arrive_time"].ToString();
                dr["历 时"] = jsonArray[i]["lishi"].ToString();
                dr["商务座"] = jsonArray[i]["swz_num"].ToString();
                dr["特等座"] = jsonArray[i]["tz_num"].ToString();
                dr["一等座"] = jsonArray[i]["zy_num"].ToString();
                dr["二等座"] = jsonArray[i]["ze_num"].ToString();
                dr["高级软卧"] = jsonArray[i]["gr_num"].ToString();
                dr["软 卧"] = jsonArray[i]["rw_num"].ToString();
                dr["硬 卧"] = jsonArray[i]["yw_num"].ToString();
                dr["软 座"] = jsonArray[i]["rz_num"].ToString();
                dr["硬 座"] = jsonArray[i]["yz_num"].ToString();
                dr["无 座"] = jsonArray[i]["wz_num"].ToString();

                if (jsonArray[i]["controlled_train_message"].ToString().Equals("正常车次，不受控"))
                {
                    dr["起售时间"] = jsonArray[i]["sale_time"].ToString().Insert(2, ":");
                    dr["备 注"] = "--";
                }
                else
                {
                    dr["备 注"] = jsonArray[i]["controlled_train_message"].ToString();
                }

                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static string getZhengWanDian(string response)
        {
            JObject jsonObject = JObject.Parse(response);

            try
            {
                if (jsonObject["data"]["flag"].ToString().ToUpper().Equals("TRUE"))
                {
                    return jsonObject["data"]["data"].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch(Exception)
            {
                return string.Empty;
            }
        }

        public static string[] getSalesiteData(string response)
        {
            JObject jsonObject = JObject.Parse(response);
            JArray jsonArray = (JArray)jsonObject["data"];
            string[] strData = new string[jsonArray.Count];

            for (int i = 0; i < jsonArray.Count; i++)
            {
                strData[i] = jsonArray[i]["chineseName"].ToString();
            }

            return strData;
        }

        public static string[] getSalesiteCityOrCounty(string response)
        {
            int start = response.IndexOf("data") + 7;
            // 注意C#中的 string.Substring 和 Java中的 String.subString 的不同！
            string strResult = response.Substring(start, response.Length - start - 38);
            string[] results = strResult.Split(',');
            string[] temp = new string[results.Length];
            for (int i = 0; i < results.Length; i++)
            {
                temp[i] = results[i].Substring(2, results[i].Length - 2 - 2);
            }

            return temp;
        }

        public static DataTable getSalesiteDatasource(string response)
        {
            string[] columnsArray = {"序号", "代售点名称", "地址", "营业时间", "窗口数量"};
            DataTable dt = new DataTable();
            for (int m = 0; m < columnsArray.Length; m++)
            {
                dt.Columns.Add(columnsArray[m]);
            }

            JObject jsonObject = JObject.Parse(response);
            JArray jsonArray = (JArray)jsonObject["data"]["datas"];
            for (int i = 0; i < jsonArray.Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr["序号"] = i + 1;
                dr["代售点名称"] = jsonArray[i]["agency_name"].ToString();
                dr["地址"] = jsonArray[i]["address"].ToString();
                dr["营业时间"] = jsonArray[i]["start_time_am"].ToString().Insert(2, ":") + " - " + jsonArray[i]["stop_time_pm"].ToString().Insert(2, ":");
                dr["窗口数量"] = jsonArray[i]["windows_quantity"].ToString();

                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static DataTable getTicketPrice(string response)
        {
            string[] columnsArray = {"车 次", "出发站", "到达站", "出发时间", "达到时间",
                                     "历 时", "商务座", "特等座", "一等座", "二等座", "高级软卧", "软 卧", "硬 卧", 
                                     "软 座", "硬 座", "无 座"};

            DataTable dt = new DataTable();
            for (int m = 0; m < columnsArray.Length; m++)
            {
                dt.Columns.Add(columnsArray[m]);
            }

            JObject jsonObject = JObject.Parse(response);
            JArray jsonArray = (JArray)jsonObject["data"];
            for (int i = 0; i < jsonArray.Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr["车 次"] = jsonArray[i]["queryLeftNewDTO"]["station_train_code"].ToString();
                dr["出发站"] = jsonArray[i]["queryLeftNewDTO"]["from_station_name"].ToString();
                dr["到达站"] = jsonArray[i]["queryLeftNewDTO"]["to_station_name"].ToString();
                dr["出发时间"] = jsonArray[i]["queryLeftNewDTO"]["start_time"].ToString();
                dr["达到时间"] = jsonArray[i]["queryLeftNewDTO"]["arrive_time"].ToString();
                dr["历 时"] = jsonArray[i]["queryLeftNewDTO"]["lishi"].ToString();
                dr["商务座"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["swz_price"].ToString());
                dr["特等座"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["tz_price"].ToString());
                dr["一等座"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["zy_price"].ToString());
                dr["二等座"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["ze_price"].ToString());
                dr["高级软卧"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["gr_price"].ToString());
                dr["软 卧"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["rw_price"].ToString());
                dr["硬 卧"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["yw_price"].ToString());
                dr["软 座"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["rz_price"].ToString());
                dr["硬 座"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["yz_price"].ToString());
                dr["无 座"] = convertToMoney(jsonArray[i]["queryLeftNewDTO"]["wz_price"].ToString());

                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static DataTable getPassengers(string response)
        {
            response = response.Substring(response.IndexOf("10009636"));
            response = response.Substring(response.IndexOf("passengers") + 11, response.IndexOf("pageSize") - response.IndexOf("passengers") - 18);

            string[] columnsArray = { "序号", "姓名", "证件类型", "证件号码", "手机/电话", "旅客类型" };
            DataTable dt = new DataTable();
            for (int m = 0; m < columnsArray.Length; m++)
            {
                dt.Columns.Add(columnsArray[m]);
            }

            JArray jsonArray = JArray.Parse(response);
            for (int i = 0; i < jsonArray.Count; i++)
            {
                DataRow dr = dt.NewRow();

                dr["序号"] = i + 1;
                dr["姓名"] = Util.unicode2string(jsonArray[i]["passenger_name"].ToString());
                dr["证件类型"] = Util.unicode2string(jsonArray[i]["passenger_id_type_name"].ToString());
                dr["证件号码"] = jsonArray[i]["passenger_id_no"].ToString();
                dr["手机/电话"] = jsonArray[i]["mobile_no"].ToString();
                dr["旅客类型"] = Util.unicode2string(jsonArray[i]["passenger_type_name"].ToString());

                dt.Rows.Add(dr);
            }

            return dt;
        }

        public static string convertToMoney(string param)
        {
            if (!param.Equals("--"))
            {
                long tempLong = long.Parse(param) / 10;
                return tempLong.ToString("C");
            }
            else
            {
                return "--";
            }
        }
    }
}
