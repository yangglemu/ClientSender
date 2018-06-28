namespace ClientSender
{
    partial class Sender
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.notifyIcon_ClientSender = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_NotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer_tmp = new System.Windows.Forms.Timer(this.components);
            this.button_SelectDateToSend = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip_NotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(567, 540);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(649, 241);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(103, 23);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "清除内容";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(649, 442);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(103, 23);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "安全退出";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(649, 289);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(103, 23);
            this.button_Close.TabIndex = 3;
            this.button_Close.Text = "关闭窗口";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // notifyIcon_ClientSender
            // 
            this.notifyIcon_ClientSender.ContextMenuStrip = this.contextMenuStrip_NotifyIcon;
            this.notifyIcon_ClientSender.Icon = global::ClientSender.Properties.Resources.yuan;
            this.notifyIcon_ClientSender.Text = "ClientSender is running!";
            this.notifyIcon_ClientSender.Visible = true;
            // 
            // contextMenuStrip_NotifyIcon
            // 
            this.contextMenuStrip_NotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip_NotifyIcon.Name = "contextMenuStrip_NotifyIcon";
            this.contextMenuStrip_NotifyIcon.Size = new System.Drawing.Size(125, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示ToolStripMenuItem.Text = "显示窗口";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "安全退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1800000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer_tmp
            // 
            this.timer_tmp.Interval = 10000;
            this.timer_tmp.Tick += new System.EventHandler(this.timer_tmp_Tick);
            // 
            // button_SelectDateToSend
            // 
            this.button_SelectDateToSend.Location = new System.Drawing.Point(649, 391);
            this.button_SelectDateToSend.Name = "button_SelectDateToSend";
            this.button_SelectDateToSend.Size = new System.Drawing.Size(103, 23);
            this.button_SelectDateToSend.TabIndex = 2;
            this.button_SelectDateToSend.Text = "择期发送";
            this.button_SelectDateToSend.UseVisualStyleBackColor = true;
            this.button_SelectDateToSend.Click += new System.EventHandler(this.button_SelectDateToSend_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(596, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 5);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(685, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "00%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "本次共发送 00 封邮件";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_SelectDateToSend);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.richTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::ClientSender.Properties.Resources.yuan;
            this.MaximizeBox = false;
            this.Name = "Sender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientSender";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sender_FormClosing);
            this.Shown += new System.EventHandler(this.Sender_Shown);
            this.Resize += new System.EventHandler(this.Sender_Resize);
            this.contextMenuStrip_NotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.NotifyIcon notifyIcon_ClientSender;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer_tmp;
        private System.Windows.Forms.Button button_SelectDateToSend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

