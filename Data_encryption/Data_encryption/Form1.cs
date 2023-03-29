using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Data_encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            txb_input.Clear();
            string line;
            openFileDialog1.ShowDialog();
            StreamReader fload = new StreamReader(openFileDialog1.FileName);
                txb_seed.Text = fload.ReadLine();
                while ((line = fload.ReadLine()) != null)
                {
                    txb_input.Text = line;
                }
            fload.Close();
        }

        private void btn_cypher_Click(object sender, EventArgs e)
        {
            string text = txb_input.Text;
            Random rnd = new Random(Convert.ToInt32(txb_seed.Text));
            foreach (var ch in text)
            {
                int c = Convert.ToInt32(ch);
                txb_output.Text += Convert.ToChar(c + rnd.Next(10, 30));
            }
        }

        private void btn_decypher_Click(object sender, EventArgs e)
        {
            txb_output.Clear();
            string text = txb_input.Text;
            Random rnd = new Random(Convert.ToInt32(txb_seed.Text));
            foreach (var ch in text)
            {
                int c = Convert.ToInt32(ch);
                txb_output.Text += Convert.ToChar(c - rnd.Next(10, 30));
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            StreamWriter fwrite = new StreamWriter(saveFileDialog1.FileName);
            fwrite.WriteLine(txb_seed.Text);
            fwrite.WriteLine(txb_output.Text);
            fwrite.Close();
        }
    }
}
