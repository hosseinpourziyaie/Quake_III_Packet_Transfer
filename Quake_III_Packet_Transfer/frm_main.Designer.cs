namespace Quake_III_Packet_Transfer
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.rtxt_serverresponse = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.Location = new System.Drawing.Point(259, 338);
            this.txt_data.MaxLength = 256;
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(253, 27);
            this.txt_data.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.txt_data, "Fake Request Data");
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(12, 338);
            this.txt_address.MaxLength = 36;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(241, 27);
            this.txt_address.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.txt_address, "Server Address");
            // 
            // lbl_data
            // 
            this.lbl_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(255, 321);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(72, 16);
            this.lbl_data.TabIndex = 5;
            this.lbl_data.Text = "Send Data:";
            this.mainToolTip.SetToolTip(this.lbl_data, "Fake Request Data");
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.Location = new System.Drawing.Point(9, 321);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(101, 16);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Server Address:";
            this.mainToolTip.SetToolTip(this.lbl_address, "Server Address");
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_send.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(518, 338);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(138, 27);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send Packet";
            this.mainToolTip.SetToolTip(this.btn_send, "Send heartbeat & Recive Response for Checcking Servers Status \r\nUse to Sure about" +
        " Server IP & Port Correction ");
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // rtxt_serverresponse
            // 
            this.rtxt_serverresponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxt_serverresponse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_serverresponse.Location = new System.Drawing.Point(12, 12);
            this.rtxt_serverresponse.MaxLength = 2048;
            this.rtxt_serverresponse.Name = "rtxt_serverresponse";
            this.rtxt_serverresponse.Size = new System.Drawing.Size(643, 306);
            this.rtxt_serverresponse.TabIndex = 3;
            this.rtxt_serverresponse.Text = "";
            // 
            // frm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 372);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.rtxt_serverresponse);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(683, 348);
            this.Name = "frm_main";
            this.Text = "Quake_III_Packet_Transfer[UDP]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_address;
        public System.Windows.Forms.TextBox txt_data;
        public System.Windows.Forms.TextBox txt_address;
        public System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.RichTextBox rtxt_serverresponse;
    }
}