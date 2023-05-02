using System.ComponentModel;
using System.Speech.Recognition;
using PNGTuber.Services;

namespace PNGTuber
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine oEscucha;
        int currentFrame = 0;
        Bitmap[] frames;
        Bitmap[] idleFrames;
        private int VolumeLevel = 2;
        private int Amplifier = 10;
        bool isTalking = false;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem ocultarBordeToolStripMenuItem;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            PrepareAudio();
            PrepareNotifyIcon();
            GC.Collect();
        }

        private void PrepareNotifyIcon()
        {
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "PNGTube Project";
            this.notifyIcon1.Visible = true;
            configuracionToolStripMenuItem = new ToolStripMenuItem
            {
                Text = "Configuration",
            };
        }

        void LoadData()
        {
            frames = ApngController.getFrames(Singleton.Instance.settings.TalkingImagePath);
            idleFrames = ApngController.getFrames(Singleton.Instance.settings.IdleImagePath);
            VolumeLevel = Singleton.Instance.settings.Volume;
            Amplifier = Singleton.Instance.settings.Amplifier;
            pictureBox1.Image = idleFrames[currentFrame];
            this.notifyIcon1.Icon = SystemIcons.Application;
            this.notifyIcon1.Visible = true;
        }
        void PrepareAudio()
        {
            this.oEscucha = new SpeechRecognitionEngine();
            this.oEscucha.SetInputToDefaultAudioDevice();
            this.oEscucha.LoadGrammar(new DictationGrammar());
            this.oEscucha.AudioLevelUpdated += this.StartTalking;
            this.oEscucha.RecognizeAsync(RecognizeMode.Multiple);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isTalking)
            {
                //Play talking animation
                if (currentFrame == frames.Length - 1)
                {
                    currentFrame = 0;
                }
                else
                {
                    currentFrame++;
                }
                pictureBox1.Image = frames[currentFrame];
            }
            else
            {
                //Play iddle animation
                if (currentFrame == idleFrames.Length - 1)
                {
                    currentFrame = 0;
                }
                else
                {
                    currentFrame++;
                }
                pictureBox1.Image = idleFrames[currentFrame];
            }
        }
        private void StartTalking(object sender, AudioLevelUpdatedEventArgs e)
        {
            if (((sender as SpeechRecognitionEngine).AudioLevel * Amplifier) > this.VolumeLevel)
            {
                //Apply talking image
                if (!isTalking)
                {
                    isTalking = true;
                    currentFrame = 0;
                }
                return;
            }
            //Show Idle image
            if (isTalking)
            {
                isTalking = false;
                currentFrame = 0;
            }
            //this.pictureBox1.Image = this._IdleImage;
        }
    }
}