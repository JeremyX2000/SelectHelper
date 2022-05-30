using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectHelper.Dialog
{
    public partial class OpenWorkspace : Form
    {
        MainForm mainform;
        public OpenWorkspace()
        {
            InitializeComponent();
        }
        public OpenWorkspace(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDig = new OpenFileDialog();
                openFileDig.Filter = "SXW files (*.sxw)|*.sxw|SMW files (*.smw)|*.smw|SXWU files (*.sxwu)|*.sxwu|SMWU files (*.smwu)|*.smwu";

                if (openFileDig.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = openFileDig.FileName;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainform.Openfile(textBox2.Text,textBox1.Text);
            this.Close();
        }
    }
}
