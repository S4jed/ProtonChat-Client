namespace ProtonChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeviceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChatsTextBox = new System.Windows.Forms.RichTextBox();
            this.LocalCameraController = new Camera_NET.CameraControl();
            this.ResolutionComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageToSendTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoteAddressTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LocalAddressTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.UpdateFrameTimer = new System.Windows.Forms.Timer(this.components);
            this.RemoteCameraPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RemoteCameraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceComboBox
            // 
            this.DeviceComboBox.FormattingEnabled = true;
            this.DeviceComboBox.Location = new System.Drawing.Point(90, 14);
            this.DeviceComboBox.Name = "DeviceComboBox";
            this.DeviceComboBox.Size = new System.Drawing.Size(170, 21);
            this.DeviceComboBox.TabIndex = 2;
            this.DeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.DeviceComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Webcam:";
            // 
            // ChatsTextBox
            // 
            this.ChatsTextBox.Location = new System.Drawing.Point(12, 428);
            this.ChatsTextBox.Name = "ChatsTextBox";
            this.ChatsTextBox.Size = new System.Drawing.Size(520, 121);
            this.ChatsTextBox.TabIndex = 6;
            this.ChatsTextBox.Text = "Chats will be displayed here";
            this.ChatsTextBox.TextChanged += new System.EventHandler(this.ChatsTextBox_TextChanged);
            this.ChatsTextBox.Enter += new System.EventHandler(this.ChatsTextBox_Enter);
            // 
            // LocalCameraController
            // 
            this.LocalCameraController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocalCameraController.DirectShowLogFilepath = "";
            this.LocalCameraController.Location = new System.Drawing.Point(548, 316);
            this.LocalCameraController.Name = "LocalCameraController";
            this.LocalCameraController.Size = new System.Drawing.Size(310, 233);
            this.LocalCameraController.TabIndex = 1;
            // 
            // ResolutionComboBox
            // 
            this.ResolutionComboBox.FormattingEnabled = true;
            this.ResolutionComboBox.Location = new System.Drawing.Point(373, 15);
            this.ResolutionComboBox.Name = "ResolutionComboBox";
            this.ResolutionComboBox.Size = new System.Drawing.Size(170, 21);
            this.ResolutionComboBox.TabIndex = 2;
            this.ResolutionComboBox.SelectedIndexChanged += new System.EventHandler(this.ResolutionComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resolution:";
            // 
            // MessageToSendTextBox
            // 
            this.MessageToSendTextBox.Location = new System.Drawing.Point(552, 181);
            this.MessageToSendTextBox.Multiline = true;
            this.MessageToSendTextBox.Name = "MessageToSendTextBox";
            this.MessageToSendTextBox.Size = new System.Drawing.Size(306, 91);
            this.MessageToSendTextBox.TabIndex = 13;
            this.MessageToSendTextBox.Text = "Write something here...";
            this.MessageToSendTextBox.Enter += new System.EventHandler(this.MessageToSendTextBox_Enter);
            this.MessageToSendTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MessageToSendTextBox_KeyUp);
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Enabled = false;
            this.SendMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMessageButton.Location = new System.Drawing.Point(631, 278);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(152, 32);
            this.SendMessageButton.TabIndex = 12;
            this.SendMessageButton.Text = "Send Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remote Address:";
            // 
            // RemoteAddressTextBox
            // 
            this.RemoteAddressTextBox.Location = new System.Drawing.Point(687, 78);
            this.RemoteAddressTextBox.Name = "RemoteAddressTextBox";
            this.RemoteAddressTextBox.Size = new System.Drawing.Size(170, 20);
            this.RemoteAddressTextBox.TabIndex = 4;
            this.RemoteAddressTextBox.Text = "Enter the Remote Address Here";
            this.RemoteAddressTextBox.Enter += new System.EventHandler(this.RemoteAddressTextBox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proton-Address:";
            // 
            // LocalAddressTextBox
            // 
            this.LocalAddressTextBox.Location = new System.Drawing.Point(688, 42);
            this.LocalAddressTextBox.Name = "LocalAddressTextBox";
            this.LocalAddressTextBox.ReadOnly = true;
            this.LocalAddressTextBox.Size = new System.Drawing.Size(170, 20);
            this.LocalAddressTextBox.TabIndex = 4;
            this.LocalAddressTextBox.Text = "Waiting...";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.Location = new System.Drawing.Point(571, 114);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(268, 42);
            this.ConnectButton.TabIndex = 7;
            this.ConnectButton.Text = "Connect to the Remote Address";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // UpdateFrameTimer
            // 
            this.UpdateFrameTimer.Tick += new System.EventHandler(this.UpdateFrameTimer_Tick);
            // 
            // RemoteCameraPictureBox
            // 
            this.RemoteCameraPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemoteCameraPictureBox.Location = new System.Drawing.Point(12, 42);
            this.RemoteCameraPictureBox.Name = "RemoteCameraPictureBox";
            this.RemoteCameraPictureBox.Size = new System.Drawing.Size(520, 380);
            this.RemoteCameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoteCameraPictureBox.TabIndex = 14;
            this.RemoteCameraPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 561);
            this.Controls.Add(this.RemoteCameraPictureBox);
            this.Controls.Add(this.MessageToSendTextBox);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ChatsTextBox);
            this.Controls.Add(this.LocalAddressTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoteAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResolutionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeviceComboBox);
            this.Controls.Add(this.LocalCameraController);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ProtonChat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RemoteCameraPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox DeviceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ChatsTextBox;
        private Camera_NET.CameraControl LocalCameraController;
        private System.Windows.Forms.ComboBox ResolutionComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MessageToSendTextBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RemoteAddressTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LocalAddressTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Timer UpdateFrameTimer;
        private System.Windows.Forms.PictureBox RemoteCameraPictureBox;
    }
}

