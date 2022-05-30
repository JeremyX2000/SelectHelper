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
    public partial class SaveAsWorkspace : Form
    {
        MainForm mainForm;
        public SaveAsWorkspace()
        {
            InitializeComponent();
        }
        public SaveAsWorkspace(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.comboBoxSaveSDBVersion.Items.AddRange(new object[] {
                    "UGC 6.0版本",
                    "UGC 2.0版本",
                    "SFC 6.0版本"});

            this.comboBoxSaveSDBVersion.SelectedIndexChanged += new EventHandler(comboBoxSaveSDBVersion_SelectedIndexChanged);
            comboBoxSaveSDBVersion.SelectedIndex = 0;
        }

        private void comboBoxSaveSDBVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxSaveSDBVersion.SelectedIndex == 0)
                {
                    comboBoxSaveSDBType.Items.Clear();
                    comboBoxSaveSDBType.Items.Add("SMWU");
                    comboBoxSaveSDBType.Items.Add("SXWU");
                }
                else
                {
                    comboBoxSaveSDBType.Items.Clear();
                    comboBoxSaveSDBType.Items.Add("SMW");
                    comboBoxSaveSDBType.Items.Add("SXW");
                }

                comboBoxSaveSDBType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

        }

        private void buttonSaveSDBOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDig = new FolderBrowserDialog();

                if (folderBrowserDig.ShowDialog() == DialogResult.OK)
                {
                    textBoxSaveSDBFilePath.Text = folderBrowserDig.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void buttonSaveSDBOK_Click(object sender, EventArgs e)
        {
            mainForm.SaveAsfile(textBoxSaveSDBFilePath.Text, textBoxSaveSDBPassword.Text, comboBoxSaveSDBVersion.SelectedIndex, comboBoxSaveSDBType.SelectedItem as String, textBoxSaveSDBName.Text);
            this.Close();
        }
    }
}
