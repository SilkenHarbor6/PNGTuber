using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NAudio.CoreAudioApi;
using PNGTuber.Model;
using PNGTuber.Services;

namespace PNGTuber
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
            //LoadMultiMediaDevices();
            CheckForSettings();
        }

        private void CheckForSettings()
        {
            if (LocalStorageManager.CheckIntegrity(Singleton.Instance.settings))
            {
                this.trackBar1.Value = Math.Clamp(Singleton.Instance.settings.Volume, 1, 10);
                this.trackBar2.Value = Math.Clamp(Singleton.Instance.settings.Amplifier, 1, 10);
                this.idlePictureBox.Image = Image.FromFile(Singleton.Instance.settings.IdleImagePath);
                this.TalkingPictureBox.Image = Image.FromFile(Singleton.Instance.settings.TalkingImagePath);
            }
            else
            {
                Singleton.Instance.settings.Volume = 2;
                Singleton.Instance.settings.Amplifier = 10;
                Singleton.Instance.settings.isApng = false;
            }
        }

        private void LoadMultiMediaDevices()
        {
            //var enumerator = new MMDeviceEnumerator();
            //this.comboBox1.DataSource = (from endpoint in enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active) select endpoint.FriendlyName).ToList();
        }
        private void SelectIdleImage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg,*.gif, *.png) |*.jpg; *.jpeg;*.gif; *.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Do your magic
                    Singleton.Instance.settings.IdleImagePath = openFileDialog.FileName;
                    this.idlePictureBox.Image = Image.FromFile(Singleton.Instance.settings.IdleImagePath);
                }
            }
        }

        private void SelectTalkingImage(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg,*.gif, *.png) |*.jpg; *.jpeg;*.gif; *.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Do your magic
                    Singleton.Instance.settings.TalkingImagePath = openFileDialog.FileName;
                    this.TalkingPictureBox.Image = Image.FromFile(Singleton.Instance.settings.TalkingImagePath);
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Singleton.Instance.settings.Volume = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Singleton.Instance.settings.Amplifier = trackBar2.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (string.IsNullOrEmpty(Singleton.Instance.settings.TalkingImagePath))
            {
                MessageBox.Show("Error", "Please select a Talking Image", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrEmpty(Singleton.Instance.settings.IdleImagePath))
            {
                MessageBox.Show("Error", "Please select a Idle Image", MessageBoxButtons.OK);
                return;
            }
            LocalStorageManager.SaveConfig();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Singleton.Instance.settings.isApng=checkBox1.Checked;
        }
    }
}
