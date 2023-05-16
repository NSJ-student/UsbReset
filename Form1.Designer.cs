
namespace UsbReset
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.listUsbDevice = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadUsbDevices = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDeviceID = new System.Windows.Forms.Label();
            this.lblPnpDeviceID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnUsbDisable = new System.Windows.Forms.Button();
            this.btnUsbEnable = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listUsbDevice
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listUsbDevice, 2);
            this.listUsbDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listUsbDevice.FormattingEnabled = true;
            this.listUsbDevice.ItemHeight = 12;
            this.listUsbDevice.Location = new System.Drawing.Point(3, 32);
            this.listUsbDevice.Name = "listUsbDevice";
            this.listUsbDevice.Size = new System.Drawing.Size(427, 190);
            this.listUsbDevice.TabIndex = 0;
            this.listUsbDevice.DoubleClick += new System.EventHandler(this.listUsbDevice_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMPORT List";
            // 
            // btnLoadUsbDevices
            // 
            this.btnLoadUsbDevices.Location = new System.Drawing.Point(355, 3);
            this.btnLoadUsbDevices.Name = "btnLoadUsbDevices";
            this.btnLoadUsbDevices.Size = new System.Drawing.Size(75, 23);
            this.btnLoadUsbDevices.TabIndex = 2;
            this.btnLoadUsbDevices.Text = "Load";
            this.btnLoadUsbDevices.UseVisualStyleBackColor = true;
            this.btnLoadUsbDevices.Click += new System.EventHandler(this.btnLoadUsbDevices_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listUsbDevice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadUsbDevices, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 225);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnUsbEnable);
            this.panel1.Controls.Add(this.btnUsbDisable);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblCaption);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblPnpDeviceID);
            this.panel1.Controls.Add(this.lblDeviceID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 165);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Device ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "PNP Device ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Caption";
            // 
            // lblDeviceID
            // 
            this.lblDeviceID.AutoSize = true;
            this.lblDeviceID.Location = new System.Drawing.Point(119, 14);
            this.lblDeviceID.Name = "lblDeviceID";
            this.lblDeviceID.Size = new System.Drawing.Size(11, 12);
            this.lblDeviceID.TabIndex = 1;
            this.lblDeviceID.Text = "-";
            // 
            // lblPnpDeviceID
            // 
            this.lblPnpDeviceID.AutoSize = true;
            this.lblPnpDeviceID.Location = new System.Drawing.Point(119, 36);
            this.lblPnpDeviceID.Name = "lblPnpDeviceID";
            this.lblPnpDeviceID.Size = new System.Drawing.Size(11, 12);
            this.lblPnpDeviceID.TabIndex = 1;
            this.lblPnpDeviceID.Text = "-";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(119, 58);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(11, 12);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "-";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Location = new System.Drawing.Point(119, 80);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(11, 12);
            this.lblCaption.TabIndex = 1;
            this.lblCaption.Text = "-";
            // 
            // btnUsbDisable
            // 
            this.btnUsbDisable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUsbDisable.Location = new System.Drawing.Point(95, 129);
            this.btnUsbDisable.Name = "btnUsbDisable";
            this.btnUsbDisable.Size = new System.Drawing.Size(75, 23);
            this.btnUsbDisable.TabIndex = 2;
            this.btnUsbDisable.Text = "Disable";
            this.btnUsbDisable.UseVisualStyleBackColor = true;
            this.btnUsbDisable.Click += new System.EventHandler(this.btnUsbDisable_Click);
            // 
            // btnUsbEnable
            // 
            this.btnUsbEnable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUsbEnable.Location = new System.Drawing.Point(14, 129);
            this.btnUsbEnable.Name = "btnUsbEnable";
            this.btnUsbEnable.Size = new System.Drawing.Size(75, 23);
            this.btnUsbEnable.TabIndex = 3;
            this.btnUsbEnable.Text = "Enable";
            this.btnUsbEnable.UseVisualStyleBackColor = true;
            this.btnUsbEnable.Click += new System.EventHandler(this.btnUsbEnable_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(119, 102);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(11, 12);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 433);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "COMPORT INFO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listUsbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadUsbDevices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPnpDeviceID;
        private System.Windows.Forms.Label lblDeviceID;
        private System.Windows.Forms.Button btnUsbEnable;
        private System.Windows.Forms.Button btnUsbDisable;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
    }
}

