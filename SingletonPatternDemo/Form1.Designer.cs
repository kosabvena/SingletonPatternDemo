namespace SingletonPatternDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInfo = new Label();
            txtMessage = new TextBox();
            txtLog = new TextBox();
            btnLog = new Button();
            btnCreateSecond = new Button();
            btnShowLog = new Button();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(10, 4);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(292, 40);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Singleton: все кнопки работают с одним \r\nи тем же Logger.Instance";
            lblInfo.Click += label1_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(10, 57);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(468, 27);
            txtMessage.TabIndex = 1;
            txtMessage.Text = "Тестовое сообщение";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(10, 125);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(468, 174);
            txtLog.TabIndex = 2;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(10, 90);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(138, 29);
            btnLog.TabIndex = 3;
            btnLog.Text = "Записать в лог";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnCreateSecond
            // 
            btnCreateSecond.Location = new Point(154, 90);
            btnCreateSecond.Name = "btnCreateSecond";
            btnCreateSecond.Size = new Size(177, 29);
            btnCreateSecond.TabIndex = 4;
            btnCreateSecond.Text = "Проверить экземпляр";
            btnCreateSecond.UseVisualStyleBackColor = true;
            btnCreateSecond.Click += btnCreateSecond_Click;
            // 
            // btnShowLog
            // 
            btnShowLog.Location = new Point(337, 90);
            btnShowLog.Name = "btnShowLog";
            btnShowLog.Size = new Size(141, 29);
            btnShowLog.TabIndex = 5;
            btnShowLog.Text = "Показать лог";
            btnShowLog.UseVisualStyleBackColor = true;
            btnShowLog.Click += btnShowLog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 318);
            Controls.Add(btnShowLog);
            Controls.Add(btnCreateSecond);
            Controls.Add(btnLog);
            Controls.Add(txtLog);
            Controls.Add(txtMessage);
            Controls.Add(lblInfo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private TextBox txtMessage;
        private TextBox txtLog;
        private Button btnLog;
        private Button btnCreateSecond;
        private Button btnShowLog;
    }
}
