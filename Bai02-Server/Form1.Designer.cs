namespace Bai02_Server
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
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnKeo = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnBao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Result";
            // 
            // txtSelection
            // 
            this.txtSelection.Location = new System.Drawing.Point(120, 21);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(142, 20);
            this.txtSelection.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(120, 256);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(142, 20);
            this.txtResult.TabIndex = 3;
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(31, 75);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(99, 80);
            this.btnKeo.TabIndex = 4;
            this.btnKeo.Text = "Keo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(163, 75);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(99, 80);
            this.btnBua.TabIndex = 5;
            this.btnBua.Text = "Bua";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(308, 75);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(99, 80);
            this.btnBao.TabIndex = 6;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 316);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnKeo;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnBao;
    }
}

