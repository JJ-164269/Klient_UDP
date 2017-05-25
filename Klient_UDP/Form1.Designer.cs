namespace Klient_UDP
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
            this.My_Port = new System.Windows.Forms.NumericUpDown();
            this.Address = new System.Windows.Forms.TextBox();
            this.Message = new System.Windows.Forms.TextBox();
            this.Info_connect = new System.Windows.Forms.ListBox();
            this.Send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.My_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // My_Port
            // 
            this.My_Port.Location = new System.Drawing.Point(369, 23);
            this.My_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.My_Port.Name = "My_Port";
            this.My_Port.Size = new System.Drawing.Size(275, 20);
            this.My_Port.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(135, 23);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(138, 20);
            this.Address.TabIndex = 1;
            // 
            // Message
            // 
            this.Message.Location = new System.Drawing.Point(12, 67);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(697, 109);
            this.Message.TabIndex = 2;
            this.Message.Text = "Write a message";
            // 
            // Info_connect
            // 
            this.Info_connect.FormattingEnabled = true;
            this.Info_connect.Location = new System.Drawing.Point(12, 198);
            this.Info_connect.Name = "Info_connect";
            this.Info_connect.Size = new System.Drawing.Size(697, 134);
            this.Info_connect.TabIndex = 3;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(313, 354);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(106, 39);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 405);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Info_connect);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.My_Port);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.My_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown My_Port;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.ListBox Info_connect;
        private System.Windows.Forms.Button Send;
    }
}

