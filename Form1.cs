using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitleConverter
{
    public partial class Form1 : Form
    {
        private string address;

        public Form1()
        {
            InitializeComponent();
        }

        

        public static string[][] Characters =
        {
            new [] {"æ", "ć"},
            new [] {"ê", "ę"},
            new [] {"œ", "ś"},
            new [] {"¿", "ż"},
            new [] {"¹", "ą"},
            new [] {"ñ", "ń"},
            new [] {"³", "ł"},
            new [] {"Ÿ", "ź"},
            new [] {"Œ", "Ś"},
            new [] {"¯", "Ż"},
            new [] {"£", "Ł"},
            new [] {"Ê", "Ę"},
            new [] {"¥", "Ą"},
        };
        private void button1_Click(object sender, EventArgs e)
        {
            
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK) return;

            var path = ofd.FileName;
            address = path;
            var bufor = "";
            bufor = File.ReadAllText(path);
            dgv.Rows.Clear();
            dgv.Rows.Add();
            dgv.Rows[0].Cells[0].Value = "Linii"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[0].Cells[1].Value = bufor.Count(x => x == '\n');
            int i = 1;
            foreach (var s in Characters)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = s[0]; 
                dgv.Rows[i].Cells[1].Value = bufor.Count(x => x == s[0][0]);
                i++;
            }
            
        }

        public static bool Convert(string filepath)
        {
            if (filepath == "") return false;
            var bufor = "";
            bufor = File.ReadAllText(filepath);
            
            foreach (var s in Characters)
            {
                bufor = bufor.Replace(s[0],s[1]);
            }
            var savePath = filepath;

            File.WriteAllText(savePath, bufor);
            return true;
        }

        public static int Analysis(string filepath)
        {
            var splitter = filepath.Split('.');
            var extension = splitter[splitter.Length - 1];

            var bufor = File.ReadAllText(filepath);
            var lineCount = bufor.Count(x => x == '\n');
            var charCount = 0;
            foreach (var s in Characters)
            {
                charCount += bufor.Count(x => x == s[0][0]);
            }

            if (extension == "srt") charCount*=5;
            return charCount*100 / lineCount;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Convert(address);
            label9.Text = "done";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var mw = new MultiWindow();
            mw.Show();
        }
    }
}