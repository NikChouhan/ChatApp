using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatApp
{
    public partial class Form1 : Form
    {

        Socket socket;
        EndPoint epLocal, epRemote;
        public Form1()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            textIPHost.Text = GetLocalIP();

        }

        private String GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress IP in host.AddressList)
            {
                if (IP.AddressFamily == AddressFamily.InterNetwork)
                {
                    return IP.ToString();
                }
            }
            return "127.0.0.1";

        }

        private void MessageCallBack(IAsyncResult asyncResult)
        {
            try
            {
                int size = socket.EndReceiveFrom(asyncResult, ref epRemote);

                if (size > 0)
                {
                    byte[]? buffer = new byte[size];

                    buffer = asyncResult.AsyncState as byte[];

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string receivedmessage = encoding.GetString(buffer);

                    convoBox.Items.Add("Jarvis: " + receivedmessage);
                }

                byte[] buf2 = new byte[1500];
                socket.BeginReceiveFrom(buf2, 0, buf2.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buf2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message, caption:"Error!", icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.OK);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                byte[] message = new byte[1500];
                message = encoding.GetBytes(messageBox.Text);

                socket.Send(message);

                convoBox.Items.Add("You: " + messageBox.Text);

                messageBox.Clear();
            }

            catch(Exception e4)
            {
                MessageBox.Show(text: e4.Message, caption: "Error!", icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textIPHost.Text), Convert.ToInt32(textPortHost.Text));
                socket.Bind(epLocal);
                epRemote = new IPEndPoint(IPAddress.Parse(textIPClient.Text), Convert.ToInt32(textPortClient.Text));
                socket.Connect(epRemote);

                byte[] buf3 = new byte[1500];
                socket.BeginReceiveFrom(buf3, 0, buf3.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buf3);

                button1.Enabled = false;
                button1.Text = "Connected.";
                convoBox.Focus();
            }
            catch (Exception e2)
            {
                MessageBox.Show(text: e2.Message, caption: "Error!", icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.OK);
            }
        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}