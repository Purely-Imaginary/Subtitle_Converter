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

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream;
            
           
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() != DialogResult.OK) return;

            var path = ofd.FileName;
            address = path;
            var bufor = "";
            bufor = File.ReadAllText(path);
            dgv.Rows.Add(13);
            dgv.Rows[0].Cells[0].Value = "Linii"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[0].Cells[1].Value = bufor.Count(x => x == '\n');
            
            dgv.Rows[1].Cells[0].Value = "ć"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[1].Cells[1].Value = bufor.Count(x => x == 'æ');

            dgv.Rows[2].Cells[0].Value = "ę"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[2].Cells[1].Value = bufor.Count(x => x == 'ê');
            
            dgv.Rows[3].Cells[0].Value = "ś"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[3].Cells[1].Value = bufor.Count(x => x == 'œ');
            
            dgv.Rows[4].Cells[0].Value = "Ś"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[4].Cells[1].Value = bufor.Count(x => x == 'Œ');
            
            dgv.Rows[5].Cells[0].Value = "ż"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[5].Cells[1].Value = bufor.Count(x => x == '¿');
            
            dgv.Rows[6].Cells[0].Value = "Ż"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[6].Cells[1].Value = bufor.Count(x => x == '¯');

            dgv.Rows[7].Cells[0].Value = "ą"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[7].Cells[1].Value = bufor.Count(x => x == '¹');
            
            dgv.Rows[8].Cells[0].Value = "ń"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[8].Cells[1].Value = bufor.Count(x => x == 'ñ');
            
            dgv.Rows[9].Cells[0].Value = "ł"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[9].Cells[1].Value = bufor.Count(x => x == '³');
            
            dgv.Rows[10].Cells[0].Value = "Ł"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[10].Cells[1].Value = bufor.Count(x => x == '£');
            
            dgv.Rows[11].Cells[0].Value = "ź"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[11].Cells[1].Value = bufor.Count(x => x == 'Ÿ');
            
            dgv.Rows[12].Cells[0].Value = "Ź"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[12].Cells[1].Value = "No data";//bufor.Count(x => x == '£');
            
            dgv.Rows[13].Cells[0].Value = "XX"; //ILE LINII ||| LINIA -> LINII
            dgv.Rows[13].Cells[1].Value = "XX";//bufor.Count(x => x == '£');
            

            
            
            var om = bufor.Count(x => x == '¹');
            var ni = bufor.Count(x => x == 'ñ');
            var uy = bufor.Count(x => x == '³');


            // ê - ę | œ - ś | ¿ - ż | ¹ - ą | ñ - ń | ³ - ł
            /*
            a1.Text = nextLine.ToString();
            a2.Text = ci.ToString();
            a3.Text = em.ToString();
            a4.Text = si.ToString();
            a5.Text = rzy.ToString();
            a6.Text = om.ToString();
            a7.Text = ni.ToString();
            a8.Text = uy.ToString();
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (address == "") return;
            var bufor = "";
            bufor = File.ReadAllText(address);
            // ê - ę | œ - ś | ¿ - ż | ¹ - ą | ñ - ń | ³ - ł | ¯ - Ż | Œ - Ś | Ÿ - ź |  - Ź | £ - Ł
            bufor = bufor.Replace('æ', 'ć');
            bufor = bufor.Replace('ê', 'ę');
            bufor = bufor.Replace('œ', 'ś');
            bufor = bufor.Replace('¿', 'ż');
            bufor = bufor.Replace('¹', 'ą');
            bufor = bufor.Replace('ñ', 'ń');
            bufor = bufor.Replace('³', 'ł');
            bufor = bufor.Replace('Ÿ', 'ź');
            bufor = bufor.Replace('Œ', 'Ś');
            bufor = bufor.Replace('¯', 'Ż');
            bufor = bufor.Replace('£', 'Ł');

            var savePath = address;

            File.WriteAllText(savePath,bufor);
            label9.Text = "done";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = "bgfhsdjbgdjk";
        }
    }
}