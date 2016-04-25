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
    public partial class Frm_Login : Form
    {
        public delegate void ImageHandler();

        List<Point> pointList = new List<Point>();

        public Frm_Login()
        {
            InitializeComponent();
            InitLogin();
            ImageHandler handler = new ImageHandler(getImage);
            handler.BeginInvoke(null, null);
        }

        public void getImage()
        {
            string url = "https://kyfw.12306.cn/otn/passcodeNew/getPassCodeNew?module=login&rand=sjrand";

            Stream stream = HttpHelper.getResponseImage(url);

            try
            {
                pb_checkcode.Image = Image.FromStream(stream);
                //MessageBox.Show("刷新成功！", "提 醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("验证码获取失败！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_username.Text.Trim();
            string passWord = txt_password.Text.Trim();

            if(userName.Equals("") || passWord.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string str = "";
            foreach(var s in pointList)
            {
                str += "," + s.X + "," + s.Y;
            }
            str = str.TrimStart(',');

            if(!str.Equals(""))
            {
                string url = "https://kyfw.12306.cn/otn/passcodeNew/checkRandCodeAnsyn";
                string data = "randCode=" + str + "&rand=sjrand";

                string result = HttpHelper.getResponse(url, "POST", data);
                if ((result.Substring(result.IndexOf("msg") + 6, 4).ToUpper().Equals("TRUE")))
                {
                    string randCode = str.Replace(",", "%2C");
                    url = "https://kyfw.12306.cn/otn/login/loginAysnSuggest";
                    data = "loginUserDTO.user_name=" + userName + "&userDTO.password=" + passWord + "&randCode=" + randCode;
                    result = HttpHelper.getResponse(url, "POST", data);
                    if (result.Substring((result.IndexOf("loginCheck") + 13), 1).ToUpper().Equals("Y"))
                    {
                        url = "https://kyfw.12306.cn/otn/login/userLogin";
                        data = "_json_att=";
                        HttpHelper.getResponse(url, "POST", data);

                        url = "https://kyfw.12306.cn/otn/index/initMy12306";
                        result = HttpHelper.getResponse(url, "GET", null);

                        Frm_Main fmrMain = (Frm_Main)this.Owner;
                        fmrMain.LoginResult = result;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("登陆失败！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("登陆失败！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("请选择验证码！", "错 误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }

        private void pb_checkcode_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = new Point();
            point.X = e.X;
            point.Y = e.Y;

            if((point.Y > 43) && (point.Y < 108))
            {
                if((point.X > 5) && (point.X < 73))
                {
                    if (ckb_1_1.Checked)
                    {
                        ckb_1_1.Checked = false;
                        pointList.Remove(new Point(45, 45));
                    }
                    else
                    {
                        ckb_1_1.Checked = true;
                        pointList.Add(new Point(45, 45));
                    }
                }
                else if((point.X > 77) &&(point.X < 145))
                {
                    if (ckb_1_2.Checked)
                    {
                        ckb_1_2.Checked = false;
                        pointList.Remove(new Point(100, 45));
                    }
                    else
                    {
                        ckb_1_2.Checked = true;
                        pointList.Add(new Point(100, 45));
                    }
                }
                else if((point.X > 150) && (point.X < 215))
                {
                    if (ckb_1_3.Checked)
                    {
                        ckb_1_3.Checked = false;
                        pointList.Remove(new Point(180, 45));
                    }
                    else
                    {
                        ckb_1_3.Checked = true;
                        pointList.Add(new Point(180, 45));
                    }
                }
                else if ((point.X > 220) && (point.X < 288))
                {
                    if (ckb_1_4.Checked)
                    {
                        ckb_1_4.Checked = false;
                        pointList.Remove(new Point(250, 45));
                    }
                    else
                    {
                        ckb_1_4.Checked = true;
                        pointList.Add(new Point(250, 45));
                    }
                }
            }
            else if((point.Y > 113) && (point.Y < 180))
            {
                if((point.X > 5) && (point.X < 73))
                {
                    if (ckb_2_1.Checked)
                    {
                        ckb_2_1.Checked = false;
                        pointList.Remove(new Point(45, 145));
                    }
                    else
                    {
                        ckb_2_1.Checked = true;
                        pointList.Add(new Point(45, 145));
                    }
                }
                else if ((point.X > 77) && (point.X < 145))
                {
                    if (ckb_2_2.Checked)
                    {
                        ckb_2_2.Checked = false;
                        pointList.Remove(new Point(100, 145));
                    }
                    else
                    {
                        ckb_2_2.Checked = true;
                        pointList.Add(new Point(100, 145));
                    }
                }
                else if ((point.X > 150) && (point.X < 215))
                {
                    if (ckb_2_3.Checked)
                    {
                        ckb_2_3.Checked = false;
                        pointList.Remove(new Point(180, 145));
                    }
                    else
                    {
                        ckb_2_3.Checked = true;
                        pointList.Add(new Point(180, 145));
                    }
                }
                else if ((point.X > 220) && (point.X < 288))
                {
                    if (ckb_2_4.Checked)
                    {
                        ckb_2_4.Checked = false;
                        pointList.Remove(new Point(250, 145));
                    }
                    else
                    {
                        ckb_2_4.Checked = true;
                        pointList.Add(new Point(250, 145));
                    }
                }
            }
        }

        private void btn_refreshCode_Click(object sender, EventArgs e)
        {
            ckb_1_1.Checked = false;
            ckb_1_2.Checked = false;
            ckb_1_3.Checked = false;
            ckb_1_4.Checked = false;
            ckb_2_1.Checked = false;
            ckb_2_2.Checked = false;
            ckb_2_3.Checked = false;
            ckb_2_4.Checked = false;
            ImageHandler handler = new ImageHandler(getImage);
            handler.BeginInvoke(null, null);
        }

        private void InitLogin()
        {
            string url = "https://kyfw.12306.cn/otn/login/init";
            HttpHelper.getResponse(url, "GET", null);
        }
    }
}
