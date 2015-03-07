using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket client;
        private void button1_Click(object sender, EventArgs e)
        {
            if (client ==null)
            {//新建客户端socket
                client = new Socket(AddressFamily.InterNetwork ,SocketType.Stream ,ProtocolType.Tcp );
                try
                {
                    client.Connect(IPAddress.Parse(txtip.Text.Trim()), int.Parse(txtport.Text.Trim()));
                    label3.Text = "连接成功";
                    label3.ForeColor = Color.Green;
                    //开启新线程接受服务器发来的消息
                    ThreadPool.QueueUserWorkItem(new WaitCallback((cliobj) =>
                    {
                        Socket clientcom = cliobj as Socket;
                        while (true)
                        {
                            byte[] buffer = new byte[1024 * 1024 * 1];
                            //接收消息
                            int r = clientcom.Receive(buffer);
                            string m = Encoding.UTF8.GetString(buffer, 0, r);
                            //跨线程修改textbox的值
                            textBox3.Invoke(new Action<string>(x =>
                            {
                                textBox3.AppendText("服务器发来信息" + x + Environment.NewLine);

                            }), m);
                        }
                    }), client);
                
                }
                catch (Exception)
                {

                    MessageBox.Show("发生错误，请关闭重试");
                }
                //连接服务器
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (client !=null)
            {
                try
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(textBox1.Text.Trim());
                    //发送消息到服务器
                    client.Send(buffer);
                    textBox1.Clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("发生错误，请关闭重试");
                }
               
            }
        }

      
     
      
    }
}
