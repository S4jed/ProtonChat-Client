using Camera_NET;

using DirectShowLib;
using Newtonsoft.Json;
using ProtonChat.Types;
using Quobject.SocketIoClientDotNet.Client;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtonChat
{
    public partial class Form1 : Form
    {
        private CameraChoice _CameraChoice { get; set; }
        private Socket Server { get; set; }
        private ConnectionRequest Connection { get; set; }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _CameraChoice = new CameraChoice();
            _CameraChoice.UpdateDeviceList();

            if (_CameraChoice.Devices.Count > 0)
            {
                foreach (DsDevice Device in _CameraChoice.Devices)
                {
                    DeviceComboBox.Items.Add(Device.Name);
                }

                UpdateFrameTimer.Start();
            }

            Task.Run(() =>
            {
                Server = IO.Socket("http://localhost:3000/");

                Server.On("ProtonAddress", (data) =>
                {
                    LocalAddressTextBox.Text = JsonConvert.DeserializeObject<RemoteConnection>(data.ToString()).ProtonAddress;
                });

                Server.On("ConnectionRequest", (data) =>
                {
                    if (IsConnected())
                        return;

                    ConnectionRequest Response = JsonConvert.DeserializeObject<ConnectionRequest>(data.ToString());

                    if (Response.Response != Types.Response.Success)
                    {
                        MessageBox.Show($"Response Code: {Response.Response}");
                        return;
                    }

                    ClearChatBox();

                    Connection = Response;
                    ChatsTextBox.Text += $"Connected to: {Connection.Remote.ProtonAddress}{Environment.NewLine}";
                    SendMessageButton.Enabled = true;
                });

                Server.On("ConnectionClosed", (data) =>
                {
                    if (!IsConnected())
                        return;

                    SendMessageButton.Enabled = false;
                    ChatsTextBox.Text += $"Disconnected from: {Connection.Remote.ProtonAddress}{Environment.NewLine}";
                    Connection = null;
                });

                Server.On("Message", data =>
                {
                    if (!IsConnected())
                        return;

                    ClearChatBox();

                    Types.Message MessageContent = JsonConvert.DeserializeObject<Types.Message>(data.ToString());

                    if (MessageContent.Response == Response.RemoteNotConnected)
                    {
                        SendMessageButton.Enabled = false;
                        ChatsTextBox.Text += $"Disconnected from: {Connection.Remote.ProtonAddress}{Environment.NewLine}";
                        Connection = null;
                        return;
                    }

                    if (MessageContent.Response == Response.Success)
                        ChatsTextBox.Text += $"{MessageContent.Sender.ProtonAddress}: {MessageContent.Text}{Environment.NewLine}";
                });

                Server.On("UpdateFrame", data =>
                {
                    if (!IsConnected())
                        return;

                    UpdateFrame UpdateFrame = JsonConvert.DeserializeObject<UpdateFrame>(data.ToString());

                    if (UpdateFrame.Response == Response.RemoteNotConnected)
                    {
                        SendMessageButton.Enabled = false;
                        ChatsTextBox.Text += $"Disconnected from: {Connection.Remote.ProtonAddress}{Environment.NewLine}";
                        Connection = null;
                        return;
                    }

                    if (UpdateFrame.Response == Response.Success)
                        RemoteCameraPictureBox.Image = Image.FromStream(new MemoryStream(UpdateFrame.Frame));
                });
            });
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LocalCameraController.CameraCreated)
                LocalCameraController.CloseCamera();
        }

        private void DeviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DeviceComboBox.SelectedIndex < 0)
                    LocalCameraController.CloseCamera();
                else
                    LocalCameraController.SetCamera(_CameraChoice.Devices[DeviceComboBox.SelectedIndex].Mon, null);

                ResolutionComboBox.Items.Clear();

                if (!LocalCameraController.CameraCreated)
                    return;

                ResolutionList resolutions = Camera.GetResolutionList(LocalCameraController.Moniker);

                if (resolutions == null)
                    return;

                int SelectedCameraIndex = -1;

                for (int i = 0; i < resolutions.Count; i++)
                {
                    ResolutionComboBox.Items.Add(resolutions[i].ToString());

                    if (resolutions[i].CompareTo(LocalCameraController.Resolution) == 0)
                        SelectedCameraIndex = i;
                }

                if (SelectedCameraIndex >= 0)
                    ResolutionComboBox.SelectedIndex = SelectedCameraIndex;
            }
            catch
            {
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!IsConnected())
            {
                Server.Emit("RemoteConnection", JsonConvert.SerializeObject(new RemoteConnection(RemoteAddressTextBox.Text)));
                return;
            }

            MessageBox.Show($"You are already connected to {Connection.Remote.ProtonAddress}");
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if (IsConnected())
            {
                Server.Emit("Message", JsonConvert.SerializeObject(new Types.Message(MessageToSendTextBox.Text)));
                MessageToSendTextBox.Clear();
                return;
            }
        }

        private void ResolutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!LocalCameraController.CameraCreated)
                return;

            int SelectedCameraIndex = ResolutionComboBox.SelectedIndex;

            if (SelectedCameraIndex < 0)
                return;

            ResolutionList Resolutions = Camera.GetResolutionList(LocalCameraController.Moniker);

            if (Resolutions == null)
                return;

            if (SelectedCameraIndex >= Resolutions.Count)
                return;

            if (Resolutions[SelectedCameraIndex].CompareTo(LocalCameraController.Resolution) == 0)
                return;

            try
            {
                LocalCameraController.SetCamera(LocalCameraController.Moniker, Resolutions[SelectedCameraIndex]);
            }
            catch
            {
            }
        }

        private void UpdateFrameTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!IsConnected())
                    return;

                if (!LocalCameraController.CameraCreated)
                    return;

                Server.Emit("UpdateFrame", JsonConvert.SerializeObject(new UpdateFrame(LocalCameraController.SnapshotOutputImage().ToByteArray(ImageFormat.Jpeg))));
            }
            catch
            {
            }
        }

        private void MessageToSendTextBox_Enter(object sender, EventArgs e)
        {
            if (MessageToSendTextBox.Text == "Write something here...")
                MessageToSendTextBox.Clear();
        }

        private void RemoteAddressTextBox_Enter(object sender, EventArgs e)
        {
            if (RemoteAddressTextBox.Text == "Enter the Remote Address Here")
                RemoteAddressTextBox.Clear();
        }

        private void ChatsTextBox_Enter(object sender, EventArgs e)
        {
            ClearChatBox();
        }

        private void ClearChatBox()
        {
            if (ChatsTextBox.Text == "Chats will be displayed here")
                ChatsTextBox.Clear();
        }

        private bool IsConnected()
        {
            if (Connection == null)
                return false;

            if (!Connection.Connected)
                return false;

            return true;
        }

        private void MessageToSendTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Alt)
                SendMessageButton_Click(sender, e);
        }

        private void ChatsTextBox_TextChanged(object sender, EventArgs e)
        {
            ChatsTextBox.SelectionStart = ChatsTextBox.Text.Length;
            ChatsTextBox.ScrollToCaret();
        }
    }
}
