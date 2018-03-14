namespace Bai02_Client
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtSelection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnBua = new System.Windows.Forms.Button();
            this.btnKeo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(136, 274);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(142, 20);
            this.txtResult.TabIndex = 10;
            // 
            // txtSelection
            // 
            this.txtSelection.Location = new System.Drawing.Point(136, 39);
            this.txtSelection.Name = "txtSelection";
            this.txtSelection.Size = new System.Drawing.Size(142, 20);
            this.txtSelection.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your Selection";
            // 
            // btnBao
            // 
            this.btnBao.Location = new System.Drawing.Point(315, 128);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(99, 80);
            this.btnBao.TabIndex = 13;
            this.btnBao.Text = "Bao";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnBua
            // 
            this.btnBua.Location = new System.Drawing.Point(170, 128);
            this.btnBua.Name = "btnBua";
            this.btnBua.Size = new System.Drawing.Size(99, 80);
            this.btnBua.TabIndex = 12;
            this.btnBua.Text = "Bua";
            this.btnBua.UseVisualStyleBackColor = true;
            this.btnBua.Click += new System.EventHandler(this.btnBua_Click);
            // 
            // btnKeo
            // 
            this.btnKeo.Location = new System.Drawing.Point(38, 128);
            this.btnKeo.Name = "btnKeo";
            this.btnKeo.Size = new System.Drawing.Size(99, 80);
            this.btnKeo.TabIndex = 11;
            this.btnKeo.Text = "Keo";
            this.btnKeo.UseVisualStyleBackColor = true;
            this.btnKeo.Click += new System.EventHandler(this.btnKeo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 336);
            this.Controls.Add(this.btnBao);
            this.Controls.Add(this.btnBua);
            this.Controls.Add(this.btnKeo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSelection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtSelection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnBua;
        private System.Windows.Forms.Button btnKeo;
    }
}

