namespace Bai01_Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lBoxMessage = new System.Windows.Forms.ListBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message:";
            // 
            // txtClientIP
            // 
            this.txtClientIP.Enabled = false;
            this.txtClientIP.Location = new System.Drawing.Point(69, 13);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(183, 20);
            this.txtClientIP.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(68, 246);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(261, 67);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // lBoxMessage
            // 
            this.lBoxMessage.FormattingEnabled = true;
            this.lBoxMessage.Location = new System.Drawing.Point(69, 54);
            this.lBoxMessage.Name = "lBoxMessage";
            this.lBoxMessage.Size = new System.Drawing.Size(260, 173);
            this.lBoxMessage.TabIndex = 4;
            this.lBoxMessage.SelectedIndexChanged += new System.EventHandler(this.lBoxMessage_SelectedIndexChanged);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(351, 54);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "Files";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(351, 161);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 6;
            this.btnImg.Text = "Image";
            this.btnImg.UseVisualStyleBackColor = true;
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(351, 108);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(75, 23);
            this.btnMusic.TabIndex = 7;
            this.btnMusic.Text = "Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(351, 249);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 64);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 337);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lBoxMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtClientIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chat Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lBoxMessage;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnSend;
    }
}

