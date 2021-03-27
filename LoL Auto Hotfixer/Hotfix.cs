using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using LoL_Auto_Hotfixer.Properties;

//Memoryhackers.org
//https://memoryhackers.org/members/byyasin.15524/
//Discord : Yasin#0443
// My Github : https://github.com/ByYasin  ;)

namespace LoL_Auto_Hotfixer
{
    public partial class Hotfix : Form
    {
        public Hotfix()
        {
            InitializeComponent();
        }

        private void exitlabel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllBytes(@textBox2.Text + "stub.dll", Resources.stub);
            File.WriteAllBytes(@textBox2.Text + "League of Legends.exe", Resources.League_of_Legends);
            MessageBox.Show("[TR] Hotfix başarılı! (Zevkli oyunlar dilerim.) \n\n [ENG] Hotfix successful! (I wish you fun games.)", "Memoryhackers.org!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        string file = "";
        string a = "\\";

        private void Hotfix_Load(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    textBox1.Text = file; // for full location
                                          //textBox2.Text = Path.GetFileName(Path.GetDirectoryName(file)); // for last folder name
                    textBox2.Text = Path.GetDirectoryName(Path.GetFullPath(file));
                    textBox2.Text = textBox2.Text + a;
                }
                catch (IOException)
                {
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = file;
        }
    }
}
