namespace WindowsFormsApp
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
            this._connectedClientsLabel = new System.Windows.Forms.Label();
            this._connectedClientsTextBox = new System.Windows.Forms.TextBox();
            this._clientCommandTextBox = new System.Windows.Forms.TextBox();
            this._sendCommandButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._portLabel = new System.Windows.Forms.Label();
            this._portTextBox = new System.Windows.Forms.TextBox();
            this._startServerButton = new System.Windows.Forms.Button();
            this._stopServerButton = new System.Windows.Forms.Button();
            this._statusTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.19096F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.80904F));
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
            this.tableLayoutPanel2.Controls.Add(this._connectedClientsLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._connectedClientsTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this._clientCommandTextBox, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this._sendCommandButton, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(508, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 219);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _connectedClientsLabel
            // 
            this._connectedClientsLabel.AutoSize = true;
            this._connectedClientsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._connectedClientsLabel.Location = new System.Drawing.Point(3, 0);
            this._connectedClientsLabel.Name = "_connectedClientsLabel";
            this._connectedClientsLabel.Size = new System.Drawing.Size(138, 26);
            this._connectedClientsLabel.TabIndex = 0;
            this._connectedClientsLabel.Text = "Connected Clients:";
            this._connectedClientsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _connectedClientsTextBox
            // 
            this._connectedClientsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._connectedClientsTextBox.Location = new System.Drawing.Point(147, 3);
            this._connectedClientsTextBox.Name = "_connectedClientsTextBox";
            this._connectedClientsTextBox.ReadOnly = true;
            this._connectedClientsTextBox.Size = new System.Drawing.Size(139, 22);
            this._connectedClientsTextBox.TabIndex = 1;
            this._connectedClientsTextBox.Text = "0";
            this._connectedClientsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _clientCommandTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._clientCommandTextBox, 2);
            this._clientCommandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._clientCommandTextBox.Location = new System.Drawing.Point(3, 45);
            this._clientCommandTextBox.Multiline = true;
            this._clientCommandTextBox.Name = "_clientCommandTextBox";
            this._clientCommandTextBox.Size = new System.Drawing.Size(283, 139);
            this._clientCommandTextBox.TabIndex = 3;
            // 
            // _sendCommandButton
            // 
            this.tableLayoutPanel2.SetColumnSpan(this._sendCommandButton, 2);
            this._sendCommandButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sendCommandButton.Location = new System.Drawing.Point(3, 190);
            this._sendCommandButton.Name = "_sendCommandButton";
            this._sendCommandButton.Size = new System.Drawing.Size(283, 26);
            this._sendCommandButton.TabIndex = 2;
            this._sendCommandButton.Text = "Send Command";
            this._sendCommandButton.UseVisualStyleBackColor = true;
            this._sendCommandButton.Click += new System.EventHandler(this.SendCommandButtonHandler);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this._portLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this._portTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this._startServerButton, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this._stopServerButton, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(508, 228);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.787234F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.21277F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(289, 219);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // _portLabel
            // 
            this._portLabel.AutoSize = true;
            this._portLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portLabel.Location = new System.Drawing.Point(3, 1);
            this._portLabel.Name = "_portLabel";
            this._portLabel.Size = new System.Drawing.Size(138, 25);
            this._portLabel.TabIndex = 2;
            this._portLabel.Text = "Listen on Port:";
            this._portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _portTextBox
            // 
            this._portTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._portTextBox.Location = new System.Drawing.Point(147, 4);
            this._portTextBox.Name = "_portTextBox";
            this._portTextBox.Size = new System.Drawing.Size(139, 22);
            this._portTextBox.TabIndex = 3;
            this._portTextBox.Text = "5000";
            this._portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _startServerButton
            // 
            this._startServerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startServerButton.Location = new System.Drawing.Point(147, 37);
            this._startServerButton.Name = "_startServerButton";
            this._startServerButton.Size = new System.Drawing.Size(139, 179);
            this._startServerButton.TabIndex = 0;
            this._startServerButton.Text = "Start Server";
            this._startServerButton.UseVisualStyleBackColor = true;
            this._startServerButton.Click += new System.EventHandler(this.StartServerButtonHandler);
            // 
            // _stopServerButton
            // 
            this._stopServerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stopServerButton.Location = new System.Drawing.Point(3, 37);
            this._stopServerButton.Name = "_stopServerButton";
            this._stopServerButton.Size = new System.Drawing.Size(138, 179);
            this._stopServerButton.TabIndex = 1;
            this._stopServerButton.Text = "Stop Server";
            this._stopServerButton.UseVisualStyleBackColor = true;
            this._stopServerButton.Click += new System.EventHandler(this.StopServerButtonHandler);
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
            this._statusTextBox.Size = new System.Drawing.Size(499, 444);
            this._statusTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Server";
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
        private System.Windows.Forms.TextBox _statusTextBox;
        private System.Windows.Forms.Button _startServerButton;
        private System.Windows.Forms.Button _stopServerButton;
        private System.Windows.Forms.Label _portLabel;
        private System.Windows.Forms.TextBox _portTextBox;
        private System.Windows.Forms.Label _connectedClientsLabel;
        private System.Windows.Forms.TextBox _connectedClientsTextBox;
        private System.Windows.Forms.Button _sendCommandButton;
        private System.Windows.Forms.TextBox _clientCommandTextBox;
    }
}

