using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SubtitleConverter
{
    public partial class MultiWindow : Form
    {
        public List<string> TextfileList = new List<string>();
        public MultiWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filelist = Directory.GetFiles(DirectoryTextBox.Text);
            TextfileList.Clear();
            int txtCount = 0, srtCount = 0;
            foreach (var s in filelist)
            {
                var splitter = s.Split('.');
                var extension = splitter[splitter.Length - 1];
                if (extension == "txt")
                {
                    TextfileList.Add(s);
                    txtCount++;
                    
                }
                if (extension == "srt")
                {
                    TextfileList.Add(s);
                    srtCount++;
                }
               
            }

            foreach (var filepath in TextfileList)
            {
                txtListLabel.Text += filepath + " - " + Form1.Analysis(filepath) + "\n";
            }

            srtFilesCountLabel.Text = srtCount.ToString();
            srtFilesCountLabel.ForeColor = Color.Green;

            txtFilesCountLabel.Text = txtCount.ToString();
            txtFilesCountLabel.ForeColor = Color.Green;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtListLabel.Text = "";
            foreach (var file in TextfileList)
            {
                txtListLabel.Text += file + " ";
                if (Form1.Convert(file))
                    txtListLabel.Text += "OK\n";
                else
                    txtListLabel.Text += "Błąd\n";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
