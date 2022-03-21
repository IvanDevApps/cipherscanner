using System.Windows.Forms;

namespace CipherScannerApp
{
    partial class CipherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CipherForm));
            this.btnScan = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblProfile = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.profileBox = new System.Windows.Forms.ComboBox();
            this.autoBox = new System.Windows.Forms.ComboBox();
            this.speedBox = new System.Windows.Forms.ComboBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loadingBar = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(326, 94);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(99, 30);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "Scan";
            this.toolTip1.SetToolTip(this.btnScan, "Begin the scan.");
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtIP.Location = new System.Drawing.Point(231, 32);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(294, 27);
            this.txtIP.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtIP, "Enter IP Address or Domain Name\r\n\r\nExample: 127.0.0.1 or Google.com");
            // 
            // lblIP
            // 
            this.lblIP.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblIP.Location = new System.Drawing.Point(185, 28);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(40, 29);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "IP";
            this.lblIP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.Silver;
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.resultBox.ForeColor = System.Drawing.Color.Black;
            this.resultBox.Location = new System.Drawing.Point(168, 421);
            this.resultBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(452, 390);
            this.resultBox.TabIndex = 5;
            this.resultBox.Text = "";
            this.toolTip1.SetToolTip(this.resultBox, "All scan results will be displayed in this Text box.");
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblResult.Location = new System.Drawing.Point(168, 376);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(145, 43);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Results";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(531, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Example: 127.0.0.1";
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblType.Location = new System.Drawing.Point(182, 183);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(139, 31);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Scan Type";
            // 
            // lblProfile
            // 
            this.lblProfile.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProfile.Location = new System.Drawing.Point(452, 183);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(165, 31);
            this.lblProfile.TabIndex = 17;
            this.lblProfile.Text = "Scan Speed";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(521, 387);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 30);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Reset everything to Default.");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // profileBox
            // 
            this.profileBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.profileBox.DropDownWidth = 151;
            this.profileBox.FormattingEnabled = true;
            this.profileBox.Location = new System.Drawing.Point(182, 217);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(121, 24);
            this.profileBox.TabIndex = 29;
            this.toolTip1.SetToolTip(this.profileBox, resources.GetString("profileBox.ToolTip"));
            // 
            // autoBox
            // 
            this.autoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoBox.DropDownWidth = 221;
            this.autoBox.FormattingEnabled = true;
            this.autoBox.Location = new System.Drawing.Point(12, 40);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(121, 24);
            this.autoBox.TabIndex = 35;
            this.toolTip1.SetToolTip(this.autoBox, "Settings will be applied automatically based on your Scan Type choice.");
            this.autoBox.SelectedIndexChanged += new System.EventHandler(this.autoBox_SelectedIndexChanged);
            // 
            // speedBox
            // 
            this.speedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedBox.DropDownWidth = 221;
            this.speedBox.FormattingEnabled = true;
            this.speedBox.Location = new System.Drawing.Point(452, 216);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(121, 24);
            this.speedBox.TabIndex = 28;
            this.toolTip1.SetToolTip(this.speedBox, resources.GetString("speedBox.ToolTip"));
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPort.Location = new System.Drawing.Point(231, 63);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(294, 27);
            this.txtPort.TabIndex = 40;
            this.toolTip1.SetToolTip(this.txtPort, resources.GetString("txtPort.ToolTip"));
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "Auto setup";
            // 
            // loadingBar
            // 
            this.loadingBar.Location = new System.Drawing.Point(168, 816);
            this.loadingBar.MarqueeAnimationSpeed = 15;
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(452, 23);
            this.loadingBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingBar.TabIndex = 37;
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(168, 842);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(452, 20);
            this.lblLoading.TabIndex = 38;
            this.lblLoading.Text = "Scanning.... this may take some time.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(139, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(531, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 26);
            this.label3.TabIndex = 42;
            this.label3.Text = "Example: 20,80,8080";
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (224)))), ((int) (((byte) (224)))), ((int) (((byte) (224)))));
            this.ClientSize = new System.Drawing.Size(764, 1009);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.loadingBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.autoBox);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "CipherForm";
            this.ShowIcon = false;
            this.Text = "CipherScanner";
            ((System.ComponentModel.ISupportInitialize) (this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        public System.Windows.Forms.TextBox txtPort;
        public System.Windows.Forms.Label label1;

        private System.Windows.Forms.BindingSource bindingSource1;

        private System.Windows.Forms.Label lblLoading;

        private System.Windows.Forms.ProgressBar loadingBar;

        private System.Windows.Forms.ComboBox autoBox;
        private System.Windows.Forms.Label label2;

        public System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.ComboBox profileBox;

        private System.Windows.Forms.ToolTip toolTip1;

        private System.Windows.Forms.ComboBox speedBox;

        private System.Windows.Forms.Label lblProfile;

        private System.Windows.Forms.Label lblType;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.RichTextBox resultBox;
        public System.Windows.Forms.Label lblResult;

        public System.Windows.Forms.Label lblIP;

        public System.Windows.Forms.TextBox txtIP;

        public System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.ColorDialog colorDialog2;

        public System.Windows.Forms.Button btnScan;

        #endregion
    }
}