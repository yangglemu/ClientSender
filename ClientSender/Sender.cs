using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Xml;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;
using LumiSoft.Net.POP3.Client;
using LumiSoft.Net.Mail;

namespace ClientSender
{
    public partial class Sender : Form
    {
        //发送、接受邮箱及用户名
        string user, pwd;
        string fromMailBox, toMailBox;
        //在整点hour超出minute秒执行定时器任务,避免多地同时使用邮箱
        int minute;
        int hour;
        string shop;
        //数据库连接字符串
        string cs;
        /// <summary>
<<<<<<< HEAD
        /// richtextbox的内容
=======
        /// 窗体显示时赋值给rechtextbox
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
        /// </summary>
        StringBuilder sb = new StringBuilder();
        public Sender()
        {
            InitializeComponent();
<<<<<<< HEAD
            this.button_SelectDateToSend.Click += (obj, arg) =>
                {
                    var select = new DateSelect();
                    if (DialogResult.OK == select.ShowDialog(this))
                    {
                        SendMail(select.SelectedDate);
                    }
                };
=======
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
        }
        private void Sender_Shown(object sender, EventArgs e)
        {
            var doc = new XmlDocument();
<<<<<<< HEAD
            doc.Load(Application.StartupPath + @"\Mail.xml");
=======
            doc.Load(Application.StartupPath + "\\Mail.xml");
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
            this.shop = doc.SelectSingleNode("/config/shop").InnerText;
            this.fromMailBox = doc.SelectSingleNode("/config/from").InnerText;
            this.toMailBox = doc.SelectSingleNode("/config/to").InnerText;
            this.user = doc.SelectSingleNode("/config/user").InnerText;
            this.pwd = doc.SelectSingleNode("/config/pwd").InnerText;
            this.minute = int.Parse(doc.SelectSingleNode("/config/minute").InnerText);
            this.cs = string.Format("server=localhost;database={0};user=root;password=yuanbo960502;", this.shop);
            this.hour = DateTime.Now.Hour + 1;
<<<<<<< HEAD
            timer_tmp.Interval = 10 * 1000;// second
=======
            timer_tmp.Interval = 10 * 1000;//10 second
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
            timer_tmp.Start();
            var dt = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
            dt = new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59);
            SendMail(dt);
            this.Hide();
        }
<<<<<<< HEAD
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_QUERYENDSESSION:
                    if ((int)m.WParam == 0x11 && (int)m.LParam == 0x11)
                    {
                        Application.Exit();
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
=======
        private void Sender_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.button_Close_Click(null, null);
            }
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
        }
        private void Sender_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    this.button_Close_Click(null, null);
                    e.Cancel = true;
                    break;
                case CloseReason.ApplicationExitCall:
<<<<<<< HEAD
                    SendMail(DateTime.Now);
=======
                    try
                    {
                        SendMail(DateTime.Now);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("发送邮件出错：" + exp.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
                    break;
                default:
                    break;
            }
        }
<<<<<<< HEAD
        private void Sender_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.button_Close_Click(null, null);
            }
        }
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            richTextBox.Clear();
            richTextBox.Text = sb.ToString();
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
=======
        private void SetRichTextAndShowForm(string text)
        {
            this.Show();
            this.richTextBox.Clear();
            this.richTextBox.Text = text;
        }
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SetRichTextAndShowForm(sb.ToString());
            if(this.WindowState==FormWindowState.Minimized)
            this.WindowState = FormWindowState.Normal;
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
<<<<<<< HEAD
=======
        private void button_SelectDateToSend_Click(object sender, EventArgs e)
        {
            var select = new DateSelect();
            if (DialogResult.OK == select.ShowDialog(this))
            {
                SendMail(select.Date);
            }
        }
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        const int WM_QUERYENDSESSION = 0x11;
<<<<<<< HEAD
=======
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_QUERYENDSESSION:
                    if ((int)m.WParam == 0x11 && (int)m.LParam == 0x11)
                    {
                        Application.Exit();
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
        private void button_Clear_Click(object sender, EventArgs e)
        {
            this.richTextBox.Clear();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            SendMail(DateTime.Now);
        }
        private string CreateMailBody(DateTime datetime)
        {
            var date = datetime.ToString("yyyy-MM-dd");
            var xml = new XmlDocument();
            xml.AppendChild(xml.CreateXmlDeclaration("1.0", "utf-8", "no"));
            var root = xml.CreateElement(this.shop);
            xml.AppendChild(root);
            var goods = xml.CreateElement("goods");
            root.AppendChild(goods);
            var connection = new MySqlConnection(cs);
            connection.Open();
            var sql_goods = "select sj as tm,sum(kc) as sl from goods group by sj";
            var command = new MySqlCommand(sql_goods, connection);
            using (var dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    var good = xml.CreateElement("good");
                    good.SetAttribute("tm", dr.GetString(0));
                    good.SetAttribute("sl", dr.GetString(1));
                    goods.AppendChild(good);
                }
            }
            var sale_dbs = xml.CreateElement("sale_dbs");
            root.AppendChild(sale_dbs);
            var sql_sale_db = "select djh,sl,je,ss,zl,syy from sale_db where date(rq)='" + date + "'";
            command.CommandText = sql_sale_db;
            using (var dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    var sale_db = xml.CreateElement("sale_db");
                    sale_db.SetAttribute("djh", dr.GetString(0));
                    sale_db.SetAttribute("sl", dr.GetString(1));
                    sale_db.SetAttribute("je", dr.GetString(2));
                    sale_db.SetAttribute("ss", dr.GetString(3));
                    sale_db.SetAttribute("zl", dr.GetString(4));
                    sale_db.SetAttribute("syy", dr.GetString(5));
                    sale_dbs.AppendChild(sale_db);
                }
            }
            var sale_mxs = xml.CreateElement("sale_mxs");
            root.AppendChild(sale_mxs);
            var sql_sale_mx = "select sale_mx.djh as djh,sale_mx.sj as tm,sale_mx.sl as sl,"
                + "sale_mx.zq as zq,sale_mx.je as je from sale_mx join sale_db "
                + "on(sale_mx.djh=sale_db.djh) where date(sale_db.rq)='"
                + date + "'";
            command.CommandText = sql_sale_mx;
            using (var dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    var sale_mx = xml.CreateElement("sale_mx");
                    sale_mx.SetAttribute("djh", dr.GetString(0));
                    sale_mx.SetAttribute("tm", dr.GetString(1));
                    sale_mx.SetAttribute("sl", dr.GetString(2));
                    sale_mx.SetAttribute("zq", dr.GetString(3));
                    sale_mx.SetAttribute("je", dr.GetString(4));
                    sale_mxs.AppendChild(sale_mx);
                }
            }
            connection.Close();
            return xml.InnerXml;
        }
        private void SendMail(DateTime datetime)
        {
<<<<<<< HEAD
            var end = "------------------------------\r\n";
=======
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
            try
            {
                DeleteMail(datetime);
            }
            catch (Exception e)
            {
                sb.Append("DeleteMail Error: " + e.Message + "\r\n");
<<<<<<< HEAD
                sb.Append(end);
=======
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
                return;
            }
            var date = datetime.ToString("yyyy-MM-dd");
            var mail = new MailMessage(fromMailBox, toMailBox);
            mail.Subject = this.shop + "@" + date;
            mail.Body = CreateMailBody(datetime);
            mail.IsBodyHtml = false;
            using (var smtp = new SmtpClient("smtp.163.com", 25))
            {
                smtp.Credentials = new NetworkCredential(user, pwd);
                smtp.Timeout = 2000;
                try
                {
                    smtp.Send(mail);
                    sb.Append(datetime.ToString("yyyy-MM-dd HH:mm:ss") + "：发送成功！\r\n");
                }
                catch (SmtpException se)
                {
                    sb.Append(se.Message + "\r\n");
                }
            }
<<<<<<< HEAD
            sb.Append(end);
=======
            sb.Append("-----------------------------\r\n");
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
        }
        private void DeleteMail(DateTime datetime)
        {
            using (var pop3 = new POP3_Client())
            {
                pop3.Connect("pop.163.com", 995, true);
<<<<<<< HEAD
                pop3.Timeout = 2000;
=======
                pop3.Timeout = 3000;
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
                pop3.Login(user, pwd);
                var date = datetime.ToString("yyyy-MM-dd");
                var del = 0;
                foreach (POP3_ClientMessage m in pop3.Messages)
                {
                    var header = Mail_Message.ParseFromByte(m.HeaderToByte());
                    var ss = header.Subject.Split('@');
                    if (ss.Length != 2)
                    {
                        m.MarkForDeletion();
                        continue;
                    }
                    if (ss[0] == this.shop && ss[1] == date)
                    {
                        m.MarkForDeletion();
                        sb.Append("delete old mail: " + date + "\r\n");
                        del++;
                        continue;
                    }
                }
                sb.Append(string.Format("共{0}邮件，删除旧邮件{1}\r\n", pop3.Messages.Count, del));
                pop3.Disconnect();
            }
        }
        private void timer_tmp_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            if (now.Hour == this.hour && now.Minute == this.minute)
            {
<<<<<<< HEAD
                //停止用于启动主定时器的临时定时器
                timer_tmp.Stop();
=======
                this.timer_tmp.Stop();
>>>>>>> a9029ff461152641d6f0a30d0e49ca0b697fbee1
                SendMail(now);
                this.timer.Interval = 60 * 60 * 1000;//one hour
                this.timer.Start();
            }
        }
    }
}
