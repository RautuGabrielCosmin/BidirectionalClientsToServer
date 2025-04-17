namespace WindowsFormsAppClient
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._sendCommandButton = new System.Windows.Forms.Button();
            this._commandTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._connectButton = new System.Windows.Forms.Button();
            this._disconnectButton = new System.Windows.Forms.Button();
            this._portLabel = new System.Windows.Forms.Label();
            this._ipAddressLabel = new System.Windows.Forms.Label();
            this._ipAddressTextBox = new System.Windows.Forms.TextBox();
            this._portTextBox = new System.Windows.Forms.TextBox();
            this._statusTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.78196F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.21804F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._statusTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this._sendCommandButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this._commandTextBox, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(505, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.4269F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5731F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 219);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _sendCommandButton
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._sendCommandButton, 2);
            this._sendCommandButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sendCommandButton.Location = new System.Drawing.Point(3, 173);
            this._sendCommandButton.Name = "_sendCommandButton";
            this._sendCommandButton.Size = new System.Drawing.Size(286, 43);
            this._sendCommandButton.TabIndex = 0;
            this._sendCommandButton.Text = "Send Command";
            this._sendCommandButton.UseVisualStyleBackColor = true;
            this._sendCommandButton.Click += new System.EventHandler(this.SendCommandButtonHandler);
            // 
            // _commandTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._commandTextBox, 2);
            this._commandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._commandTextBox.Location = new System.Drawing.Point(3, 50);
            this._commandTextBox.Multiline = true;
            this._commandTextBox.Name = "_commandTextBox";
            this.tableLayoutPanel2.SetRowSpan(this._commandTextBox, 2);
            this._commandTextBox.Size = new System.Drawing.Size(286, 117);
            this._commandTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this._connectButton, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this._disconnectButton, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this._portLabel, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this._ipAddressLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._ipAddressTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this._portTextBox, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(505, 228);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.54546F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.45455F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 219);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // _connectButton
            // 
            this._connectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._connectButton.Location = new System.Drawing.Point(149, 188);
            this._connectButton.Name = "_connectButton";
            this._connectButton.Size = new System.Drawing.Size(140, 28);
            this._connectButton.TabIndex = 0;
            this._connectButton.Text = "Connect";
            this._connectButton.UseVisualStyleBackColor = true;
            this._connectButton.Click += new System.EventHandler(this.ConnectButtonHandler);
            // 
            // _disconnectButton
            // 
            this._disconnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._disconnectButton.Location = new System.Drawing.Point(3, 188);
            this._disconnectButton.Name = "_disconnectButton";
            this._disconnectButton.Size = new System.Drawing.Size(140, 28);
            this._disconnectButton.TabIndex = 1;
            this._disconnectButton.Text = "Disconnect";
            this._disconnectButton.UseVisualStyleBackColor = true;
            this._disconnectButton.Click += new System.EventHandler(this.DisconnectButtonHandler);
            // 
            // _portLabel
            // 
            this._portLabel.AutoSize = true;
            this._portLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portLabel.Location = new System.Drawing.Point(3, 155);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(140, 30);
            this._portLabel.TabIndex = 2;
            this._portLabel.Text = "Port:";
            this._portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _ipAddressLabel
            // 
            this._ipAddressLabel.AutoSize = true;
            this._ipAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ipAddressLabel.Location = new System.Drawing.Point(3, 124);
            this._ipAddressLabel.Name = "_ipAddressLabel";
            this._ipAddressLabel.Size = new System.Drawing.Size(140, 31);
            this._ipAddressLabel.TabIndex = 3;
            this._ipAddressLabel.Text = "IP Address:";
            this._ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _ipAddressTextBox
            // 
            this._ipAddressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ipAddressTextBox.Location = new System.Drawing.Point(149, 127);
            this._ipAddressTextBox.Multiline = true;
            this._ipAddressTextBox.Name = "_ipAddressTextBox";
            this._ipAddressTextBox.Size = new System.Drawing.Size(140, 25);
            this._ipAddressTextBox.TabIndex = 4;
            this._ipAddressTextBox.Text = "127.0.0.1/";
            this._ipAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _portTextBox
            // 
            this._portTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portTextBox.Location = new System.Drawing.Point(149, 158);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(140, 22);
            this._portTextBox.TabIndex = 5;
            this._portTextBox.Text = "5000";
            this._portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _statusTextBox
            // 
            this._statusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._statusTextBox.Location = new System.Drawing.Point(3, 3);
            this._statusTextBox.Multiline = true;
            this._statusTextBox.Name = "_statusTextBox";
            this._statusTextBox.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this._statusTextBox, 2);
            this._statusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._statusTextBox.Size = new System.Drawing.Size(496, 444);
            this._statusTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Client";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox _commandTextBox;
        private System.Windows.Forms.Button _connectButton;
        private System.Windows.Forms.Button _disconnectButton;
        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.Label _ipAddressLabel;
        private System.Windows.Forms.TextBox _ipAddressTextBox;
        private System.Windows.Forms.TextBox _portTextBox;
        private System.Windows.Forms.TextBox _statusTextBox;
        private System.Windows.Forms.Button _sendCommandButton;
    }
}

