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
        bool isBorderHidden = false;
        Image idleImage;
        Image talkingImage;
        public Form1()
        {
            InitializeComponent();
            if (Singleton.Instance.settings.isApng)
            {
                LoadApngData();
            }
            else
            {
                LoadPngData();
            }
            PrepareAudio();
            GC.Collect();
            notifyIcon1.Icon = SystemIcons.Application;
        }
        void LoadPngData()
        {
            idleImage = Image.FromFile(Singleton.Instance.settings.IdleImagePath);
            talkingImage = Image.FromFile(Singleton.Instance.settings.TalkingImagePath);
            pictureBox1.Image = idleImage;
        }
        void LoadApngData()
        {
            this.timer1.Enabled = true;
            frames = ApngController.getFrames(Singleton.Instance.settings.TalkingImagePath);
            idleFrames = ApngController.getFrames(Singleton.Instance.settings.IdleImagePath);
            pictureBox1.Image = idleFrames[currentFrame];
        }
        void PrepareAudio()
        {
            this.oEscucha = new SpeechRecognitionEngine();
            this.oEscucha.SetInputToDefaultAudioDevice();
            this.oEscucha.LoadGrammar(new DictationGrammar());
            this.oEscucha.AudioLevelUpdated += this.StartTalking;
            this.oEscucha.RecognizeAsync(RecognizeMode.Multiple);
            VolumeLevel = Singleton.Instance.settings.Volume;
            Amplifier = Singleton.Instance.settings.Amplifier;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!this.timer1.Enabled)
                return;
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
                if (Singleton.Instance.settings.isApng)
                {
                    //Apply talking image
                    if (!isTalking)
                    {
                        isTalking = true;
                        currentFrame = 0;
                    }
                    return;
                }
                else
                {
                    this.pictureBox1.Image = talkingImage;
                    return;
                }
            }
            else
            {
                if (Singleton.Instance.settings.isApng)
                {
                    if (isTalking)
                    {
                        isTalking = false;
                        currentFrame = 0;
                    }
                }
                else
                {
                    this.pictureBox1.Image = idleImage;
                }
            }
        }

        private void toggleBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isBorderHidden)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                isBorderHidden = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.None;
                isBorderHidden = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}