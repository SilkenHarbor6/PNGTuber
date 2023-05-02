namespace PNGTuber
{
    partial class Configuration
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            idlePictureBox = new PictureBox();
            TalkingPictureBox = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idlePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TalkingPictureBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(74, 300);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 0;
            button1.Text = "Idle Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SelectIdleImage;
            // 
            // button2
            // 
            button2.Location = new Point(299, 300);
            button2.Name = "button2";
            button2.Size = new Size(142, 29);
            button2.TabIndex = 1;
            button2.Text = "Talking Image";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SelectTalkingImage;
            // 
            // button3
            // 
            button3.Location = new Point(323, 348);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Continue";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(593, 45);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(56, 284);
            trackBar1.TabIndex = 4;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(520, 45);
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Orientation = Orientation.Vertical;
            trackBar2.Size = new Size(56, 284);
            trackBar2.TabIndex = 5;
            trackBar2.Value = 1;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(513, 6);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 6;
            label1.Text = "Amplifier";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(592, 6);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 7;
            label2.Text = "Volume";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // idlePictureBox
            // 
            idlePictureBox.Location = new Point(12, 12);
            idlePictureBox.Name = "idlePictureBox";
            idlePictureBox.Size = new Size(223, 282);
            idlePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            idlePictureBox.TabIndex = 8;
            idlePictureBox.TabStop = false;
            // 
            // TalkingPictureBox
            // 
            TalkingPictureBox.Location = new Point(259, 12);
            TalkingPictureBox.Name = "TalkingPictureBox";
            TalkingPictureBox.Size = new Size(223, 282);
            TalkingPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            TalkingPictureBox.TabIndex = 9;
            TalkingPictureBox.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(48, 350);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 24);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "is Animated PNG?";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Configuration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 627);
            Controls.Add(checkBox1);
            Controls.Add(TalkingPictureBox);
            Controls.Add(idlePictureBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Configuration";
            Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)idlePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TalkingPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label1;
        private Label label2;
        private PictureBox idlePictureBox;
        private PictureBox TalkingPictureBox;
        private CheckBox checkBox1;
    }
}