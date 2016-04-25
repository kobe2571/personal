using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _12306Client
{
    public partial class Frm_Test : Form
    {
        public Frm_Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "[{'passenger_type_name':'\u5B66\u751F','isUserSelf':'Y','passenger_id_type_code':'1','passenger_name':'\u9648\u6D0B','total_times':'99','passenger_id_type_name':'\u4E8C\u4EE3\u8EAB\u4EFD\u8BC1','passenger_type':'3','passenger_id_no':'152825199201196019','mobile_no':'15942416031'},{'passenger_type_name':'\u5B66\u751F','isUserSelf':'N','passenger_id_type_code':'1','passenger_name':'\u4F55\u777F\u5A77','total_times':'99','passenger_id_type_name':'\u4E8C\u4EE3\u8EAB\u4EFD\u8BC1','passenger_type':'3','passenger_id_no':'150103198912201686','mobile_no':'13804260856'},{'passenger_type_name':'\u6210\u4EBA','isUserSelf':'N','passenger_id_type_code':'1','passenger_name':'\u4F55\u6167\u5A77','total_times':'99','passenger_id_type_name':'\u4E8C\u4EE3\u8EAB\u4EFD\u8BC1','passenger_type':'1','passenger_id_no':'150121198911246842','mobile_no':''}]";
            JSONParse.getPassengers(str);
        }
    }
}
