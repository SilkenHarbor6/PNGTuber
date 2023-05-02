namespace PNGTuber
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            settingsToolStripMenuItem = new ToolStripMenuItem();
            toggleBorderToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 426);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 17;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(83, 35);
            panel1.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Text = "PNGTuber";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, toggleBorderToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 104);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(210, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // toggleBorderToolStripMenuItem
            // 
            toggleBorderToolStripMenuItem.Name = "toggleBorderToolStripMenuItem";
            toggleBorderToolStripMenuItem.Size = new Size(210, 24);
            toggleBorderToolStripMenuItem.Text = "Toggle Border";
            toggleBorderToolStripMenuItem.Click += toggleBorderToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(210, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(392, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.LimeGreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem toggleBorderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}