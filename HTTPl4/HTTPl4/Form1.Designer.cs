namespace HTTPl4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ServerCommunication = new System.Windows.Forms.RichTextBox();
            this.IPA = new System.Windows.Forms.TextBox();
            this.IPL = new System.Windows.Forms.Label();
            this.ConnectBut = new System.Windows.Forms.Button();
            this.UserRequests = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ServerCommunication
            // 
            this.ServerCommunication.Location = new System.Drawing.Point(12, 12);
            this.ServerCommunication.Name = "ServerCommunication";
            this.ServerCommunication.ReadOnly = true;
            this.ServerCommunication.Size = new System.Drawing.Size(417, 426);
            this.ServerCommunication.TabIndex = 1;
            this.ServerCommunication.Text = "";
            // 
            // IPA
            // 
            this.IPA.Location = new System.Drawing.Point(435, 30);
            this.IPA.Name = "IPA";
            this.IPA.Size = new System.Drawing.Size(120, 20);
            this.IPA.TabIndex = 2;
            // 
            // IPL
            // 
            this.IPL.AutoSize = true;
            this.IPL.Location = new System.Drawing.Point(435, 12);
            this.IPL.Name = "IPL";
            this.IPL.Size = new System.Drawing.Size(17, 13);
            this.IPL.TabIndex = 3;
            this.IPL.Text = "IP";
            // 
            // ConnectBut
            // 
            this.ConnectBut.Location = new System.Drawing.Point(435, 56);
            this.ConnectBut.Name = "ConnectBut";
            this.ConnectBut.Size = new System.Drawing.Size(75, 23);
            this.ConnectBut.TabIndex = 4;
            this.ConnectBut.Text = "Connect";
            this.ConnectBut.UseVisualStyleBackColor = true;
            this.ConnectBut.Click += new System.EventHandler(this.ConnectBut_Click);
            // 
            // UserRequests
            // 
            this.UserRequests.Location = new System.Drawing.Point(468, 126);
            this.UserRequests.Name = "UserRequests";
            this.UserRequests.Size = new System.Drawing.Size(289, 96);
            this.UserRequests.TabIndex = 5;
            this.UserRequests.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserRequests);
            this.Controls.Add(this.ConnectBut);
            this.Controls.Add(this.IPL);
            this.Controls.Add(this.IPA);
            this.Controls.Add(this.ServerCommunication);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox ServerCommunication;
        private System.Windows.Forms.TextBox IPA;
        private System.Windows.Forms.Label IPL;
        private System.Windows.Forms.Button ConnectBut;
        private System.Windows.Forms.RichTextBox UserRequests;
        private System.Windows.Forms.Button button1;
    }
}

