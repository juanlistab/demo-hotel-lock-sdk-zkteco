using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace TestDemo
{
    public partial class Form1 : Form
    {

        int m_portnum = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cobBaud.Items.Clear();
            cobBaud.Items.Add("9600");
            cobBaud.Items.Add("19200");
            cobBaud.Items.Add("38400");
            cobBaud.Items.Add("57600");
            cobBaud.Items.Add("115200");
            cobBaud.SelectedIndex = 4;
            this.m_portnum = Convert.ToInt16("0" + textBox1.Text.Trim());
        }

        void AddResInfo(string info)
        {
            texBRes.Text = info + "\r\n" + texBRes.Text;
        }
        /// <summary>
        /// open port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int st = 0;
            this.m_portnum = Convert.ToInt32("0" + textBox1.Text.Trim());
            if (radioButton1.Checked == false) this.m_portnum = 0;
            int baud = Convert.ToInt32(cobBaud.Text.Trim());
            st = Common.devCommand.OpenPort(this.m_portnum, baud, true);
            if (st < 4)
            {
                Common.devCommand.ClosePort(m_portnum);
                AddResInfo("open port fail,error code：" + st.ToString());
            }
            else
               AddResInfo("open port success！");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// close port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Common.devCommand.ClosePort(m_portnum);
            AddResInfo("close port！");
        }
        /// <summary>
        /// Device buzzer设备蜂鸣
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int st = 0;
            st = Common.devCommand.DevBuzzer(1, 2);
            if (st < 4)
                AddResInfo("buzzer fail，error code：" + st.ToString());
            else
                AddResInfo("operation success！");
        }
        /// <summary>
        /// read card which is not record card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int st = 0;
            string carddata = "";
            st=Common.devCommand.ReadCard(ref carddata,true);
            if (st < 0)
                AddResInfo("operation fail,error code：" + st.ToString());
            else
                AddResInfo("return data：" + carddata.ToString());
        }
        /// <summary>
        /// clear card type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            int st = 0;
            st = Common.devCommand.ClearCard(1, true);
            if (st < 0)
                AddResInfo("operation fail,error code：" + st.ToString());
            else
                AddResInfo("clear card success！");
        }
        /// <summary>
        /// clear card data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            int st = 0;
            st = Common.devCommand.ClearCard(2, true);
            if (st < 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("success！");
        }

        /// <summary>
        /// Getting version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button30_Click(object sender, EventArgs e)
        {
            string ver="";
            Common.devCommand.GetVersion(22,ref ver);
            AddResInfo(ver);
        }
        /// <summary>
        /// getting record card information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            //StringBuilder lockinfo =new StringBuilder(2048);
            //StringBuilder retstr =new StringBuilder(7680);
            //int res= Common.devCommand.ReadCardS70(lockinfo, retstr, true);

            StringBuilder lockinfo = new StringBuilder(2048);
            StringBuilder retstr =new StringBuilder(7680);
            int res = Common.devCommand.ReadCardS70(lockinfo, retstr, true);

            if (res > 0)
                AddResInfo(lockinfo.ToString() + "\r\n" + retstr.ToString());
            else
                AddResInfo("operation fail, error code：" + res.ToString());
        }
        /// <summary>
        /// Getting information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            Common.devCommand.GetRegInfo(regid, regkey);
            AddResInfo("regid:" + regid.ToString() + "\r\nregkey:" + regkey.ToString());
        }
StringBuilder regid = new StringBuilder(256),regkey = new StringBuilder(256);
        /// <summary>
        /// Getting valid date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            int res= Common.devCommand.ChkReg(regid.ToString(), regkey.ToString(), true);
            AddResInfo("days left:" + res+"day");
        }
        byte[] skver = new byte[1];
        byte[] initpwd = new byte[2];
        int saler = 0, hotelid = 0;
        /// <summary>
        /// getting parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            Common.devCommand.GetDevParms(skver, initpwd, ref saler, ref hotelid);
            AddResInfo("agreement version：" + skver[0] +"password of authorizing card："+ initpwd[0].ToString("X2") + initpwd[1].ToString("X2")+"number of agent：" + saler+"number of hotel：" + hotelid);
        }
        /// <summary>
        /// register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
         int res = Common.devCommand.WriteKey(textBox2.Text);
         if (res < 0)
             AddResInfo("register fail,error code：" + res);
         else
             AddResInfo("register success");
        }
        /// <summary>
        /// authorizing card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button28_Click(object sender, EventArgs e)
        {
            int st = 0;
            Int16 tim = 20;
            string data = "00" + ((tim & 0x7F) + 128).ToString("X2"); ;//"00"+[value]  is 80 means the lock will keep warning
            //st = Common.devCommand.WriteCard(CardType.card_Authorization, 66, DateTime.Now.ToString("yyyyMMddHHmm"), data, data.Length, true);
            st = Common.devCommand.WriteCard(CardType.card_Authorization, 66, DateTime.Now.ToString("202001031400"), data, data.Length, true);

            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Authorization);
        }
        /// <summary>
        /// close card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            int st = 0;
            string data = "0100";//fixed value
            st = Common.devCommand.WriteCard(CardType.card_Lock, 66, DateTime.Now.ToString("yyyyMMddHHmm"), data,data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Lock);
        }
        /// <summary>
        /// reard record card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            int st = 0;
            string data = "FF";//fixed value
            st = Common.devCommand.WriteCard(CardType.card_Record, 70, "202012121000", data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Record);
        }
        /// <summary>
        /// room number card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            int st = 0;
            byte buildcode = 1, floorcode = 1, roomcode = 1, subcode = 0;//range from 0-255  0-255  0-255  0-15
            string data = buildcode.ToString("X2") + floorcode.ToString("X2") + roomcode.ToString("X2") + subcode.ToString("X2");
            st = Common.devCommand.WriteCard(CardType.card_Room_number, 66, DateTime.Now.ToString("yyyyMMddHHmm"), data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type：" + CardType.card_Room_number);
        }
        /// <summary>
        /// time sync card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            int st = 0;
            string data = DateTime.Now.ToString("yyyyMMddHHmm");//
            //st = Common.devCommand.WriteCard(CardType.card_Time, 66, DateTime.Now.AddDays(1).ToString("yyyyMMddHHmm"), data, data.Length, true);
            st = Common.devCommand.WriteCard(CardType.card_Time, 66, "202001031400", data, data.Length, true);

            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Time);
        }
        /// <summary>
        /// lost card 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            int st = 0;
            int cnum = 20;
            string data = cnum.ToString("X6") + "00";//00 disable present card number  01 disable card whose number is less than present number
            st = Common.devCommand.WriteCard(CardType.card_Loss_report, 66, DateTime.Now.AddDays(1).ToString("yyyyMMddHHmm"), data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Loss_report);
        }
        /// <summary>
        /// Lost card 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            int st = 0;
            int cnum = 20;
            string data = cnum.ToString("X6") + "01";//00 disable present card  01 disable card whose card number is less than present one
            st = Common.devCommand.WriteCard(CardType.card_Loss_report, 66, DateTime.Now.AddDays(1).ToString("yyyyMMddHHmm"), data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Loss_report);
        }
        /// <summary>
        /// group number card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            int st = 0;
            string data = "01";//00 clear certain number  01setting certain number  02clear all 03setting all
            data += "010101010101";//6 group number   0-255   HEX
            st = Common.devCommand.WriteCard(CardType.card_Group_number_setting, 66, DateTime.Now.AddDays(1).ToString("yyyyMMddHHmm"), data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation succuss!card type is：" + CardType.card_Group_number_setting);
        }
        /// <summary>
        /// guest card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            int st = 0;
            string data = "0101010100";//0F125001: building = 15(0F)、floor = 18(12)、room = 80(50)、subroom = 1(01)，baseband value = 0，change to HEX string
            st= Common.devCommand.WriteCard(CardType.card_Guest,66,"202001031300",data,data.Length, true);
            if (st != 0)
                AddResInfo("operation fail,error code：" + st.ToString());
            else
                AddResInfo("operation success，data：\r\n" + "66:202001031300:0F12500100");
        }
        /// <summary>
        /// check out card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            int st = 0;
            string data = "";//fixed value
            st = Common.devCommand.WriteCard(CardType.card_Check_out, 66, "201305051200", data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail,error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is ：" + CardType.card_Check_out);
        }
        /// <summary>
        /// group number card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            int st = 0;
            TimeSpan endt = DateTime.Now.AddHours(10).TimeOfDay, start = DateTime.Now.TimeOfDay;
            string data = "00";//fixed value
            data +=(DateTime.Now.Date+ endt).ToString("HHmm");
            data += "0101";//two group card HEX
            string dtstr = DateTime.Now.AddDays(1).ToString("yyyyMMdd") + (DateTime.Now.Date + start).ToString("HHmm");
            st = Common.devCommand.WriteCard(CardType.card_Group_number, 66, dtstr, data, data.Length, true);
            if (st != 0)
                AddResInfo("operation faial，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Group_number);
        }
        /// <summary>
        /// emergency card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            int st = 0;
            TimeSpan endt = DateTime.Now.AddHours(10).TimeOfDay, start = DateTime.Now.TimeOfDay;
            string data = "00";//00=normal,01=open door locked inside,02=keep open,03=keep open/open door locked inside
            data += (DateTime.Now.Date + endt).ToString("HHmm");
            data += "0000";//fixed value
            string dtstr = DateTime.Now.AddDays(1).ToString("yyyyMMdd") + (DateTime.Now.Date + start).ToString("HHmm");
            st = Common.devCommand.WriteCard(CardType.card_Emergency, 66, dtstr, data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card typs is：" + CardType.card_Emergency);
        }
        /// <summary>
        /// master card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button25_Click(object sender, EventArgs e)
        {
            int st = 0;
            TimeSpan endt = DateTime.Now.AddHours(10).TimeOfDay, start = DateTime.Now.TimeOfDay;
            string data = "00";//00=normal,01=open door locked inside,02=keep open,03=keep open/open door locked inside
            data += (DateTime.Now.Date + endt).ToString("HHmm");
            data += "0000";//fixed value
            string dtstr = DateTime.Now.AddDays(1).ToString("yyyyMMdd") + (DateTime.Now.Date + start).ToString("HHmm");
            st = Common.devCommand.WriteCard(CardType.card_Master_control, 66, dtstr, data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Master_control);
        }
        /// <summary>
        /// building
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button26_Click(object sender, EventArgs e)
        {
            int st = 0;
            TimeSpan endt = DateTime.Now.AddHours(10).TimeOfDay, start = DateTime.Now.TimeOfDay;
            string data = "00";//00=normal,01=open door locked inside,02=keep open,03=keep open/open door locked inside
            data += (DateTime.Now.Date + endt).ToString("HHmm");
            data += "0100";//building number+00    HEX
            string dtstr = DateTime.Now.AddDays(1).ToString("yyyyMMdd") + (DateTime.Now.Date + start).ToString("HHmm");
            st = Common.devCommand.WriteCard(CardType.card_Building, 66, dtstr, data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("operation success!card type is：" + CardType.card_Building);
        }
        /// <summary>
        /// floor card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button27_Click(object sender, EventArgs e)
        {
            int st = 0;
            TimeSpan endt = DateTime.Now.AddHours(10).TimeOfDay, start = DateTime.Now.TimeOfDay;
            string data = "00";//00=normal,01=open door locked inside,02=keep open,03=keep open/open door locked inside
            data += (DateTime.Now.Date + endt).ToString("HHmm");
            data += "0101";//building number+floor number  HEX
            string dtstr = DateTime.Now.AddDays(1).ToString("yyyyMMdd") + (DateTime.Now.Date + start).ToString("HHmm");
            st = Common.devCommand.WriteCard(CardType.card_Floor, 66, dtstr, data, data.Length, true);
            if (st != 0)
                AddResInfo("operation fail，error code：" + st.ToString());
            else
                AddResInfo("opeartion success!card type：" + CardType.card_Floor);
        }
    }
}
