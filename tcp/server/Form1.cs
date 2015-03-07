using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, Socket> dic = new Dictionary<string, Socket>();
        Socket skcon = null;
        private void listen_Click(object sender, EventArgs e)
        {
            if (skcon ==null)
            {
                skcon = new Socket(AddressFamily.InterNetwork,SocketType.Stream ,ProtocolType.Tcp );//创建服务端socket
                
                try
                {
                    skcon.Bind(new IPEndPoint(IPAddress.Parse(txtip.Text.Trim()), int.Parse(txtport.Text.Trim())));//绑定本地ip，port
                    skcon.Listen(100);//开始监听
                    label4.Text = "开始监听。。";
                    label4.ForeColor = Color.Green;
                    ThreadPool.QueueUserWorkItem(new WaitCallback((skObj) =>
                    {
                        Socket skconnp = skObj as Socket;
                        while (true)
                        {
                            Socket skcommunication = skconnp.Accept();//开启另一现成连接每个过来的客户端
                            string userinfo = skcommunication.RemoteEndPoint.ToString();
                            if (!dic.ContainsKey(userinfo))
                            {
                                dic.Add(userinfo, skcommunication);//把炼联入的客户端加到字典中
                            }//跨线程修改消息框控件 
                            txtmessage.Invoke(new Action<string>((m) =>
                            {
                                txtmessage.AppendText("客户端" + m + "上线了" + Environment.NewLine);
                            }), userinfo);
                            //跨线程修改客户端列表
                            listcontents.Invoke(new Action<string>((m) =>
                            {
                                listcontents.Items.Add(m);
                            }), userinfo);
                            //开启新线程接收客户端发来的消息
                            ThreadPool.QueueUserWorkItem(new WaitCallback((skObjc) =>
                            {
                                Socket skcomm = skObjc as Socket;
                                while (true)
                                {
                                    byte[] buffer = new byte[1024 * 1024 * 2];
                                    //接收消息
                                    int r = skcomm.Receive(buffer);

                                    if (r == 0)
                                    {
                                        txtmessage.Invoke(new Action<string>(new Action<string>((x) =>
                                        {

                                            txtmessage.AppendText("主机" + x + "下线" + Environment.NewLine);
                                        })), skcomm.RemoteEndPoint.ToString());
                                        listcontents.Invoke(new Action<string>((x) =>
                                        {
                                            listcontents.Items.Remove(x);//移除下线客户端
                                        }), skcomm.RemoteEndPoint.ToString());
                                        dic.Remove(skcomm.RemoteEndPoint.ToString());//移除下线客户端对应的socket
                                        break;
                                    }
                                    else
                                    {
                                        string message = Encoding.UTF8.GetString(buffer, 0, r);
                                        //跨线程修改消息框内容
                                        txtmessage.Invoke(new Action<string>((x) =>
                                        {
                                            txtmessage.AppendText("客户端" + skcomm.RemoteEndPoint.ToString() + "发来信息" + x + Environment.NewLine);
                                        }), message);
                                    }
                                }

                            }), skcommunication);


                        }


                    }), skcon);
                }
                catch (Exception)
                {

                    MessageBox.Show("发生错误，请关闭重试");
                }
                
               
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listcontents .SelectedItem !=null)
            {//从字典中得到对与应客户端建立的socket
                try
                {
                    Socket client = dic[listcontents.SelectedItem.ToString()];
                    string message = txtsend.Text.Trim();
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    //向客户端发送信息
                    client.Send(buffer);
                    txtmessage.AppendText("服务器向客户端" + client.RemoteEndPoint.ToString() + "信息" + message + Environment.NewLine);
                    txtsend.Clear();
                }
                catch (Exception)
                {

                    MessageBox.Show("发生错误，请关闭重试");
                }
                

            }
            else
            {
                MessageBox.Show("请选择一个客户端");
            }
        }

   

    }
}
