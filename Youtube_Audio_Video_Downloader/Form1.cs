using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using VideoLibrary;

namespace YoutubeDownloader
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Download_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() {Description = "Set the path to download" })
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var youtube = YouTube.Default;
                        var video = await youtube.GetVideoAsync(YoutubeURL_textBox.Text);

                        if(Converter_comboBox.Text == "MP3")
                        {
                            File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".mp3", await video.GetBytesAsync());
                        }

                        if (Converter_comboBox.Text == "MP4")
                        {
                            File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".mp4", await video.GetBytesAsync());
                        }

                        if (Converter_comboBox.Text == "AVI")
                        {
                            File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".avi", await video.GetBytesAsync());
                        }

                        if (Converter_comboBox.Text == "WAV")
                        {
                            File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName + ".wav", await video.GetBytesAsync());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failed to decrypt URL!");
                    }
                }
            }

        }
    }
}
