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
    public partial class CreateWorkspace : Form
    {
        MainForm mainForm;
        public CreateWorkspace()
        {
            InitializeComponent();
            
        }
        public CreateWorkspace(MainForm mainform)
        {
            InitializeComponent();
            InitializeCultureResources();
            this.comboBoxCreateSDBVersion.SelectedIndexChanged += new EventHandler(comboBoxCreateSDBVersion_SelectedIndexChanged);
            comboBoxCreateSDBVersion.SelectedIndex = 0;
            this.mainForm = mainform;

        }
        private void InitializeCultureResources()
        {
            this.comboBoxCreateSDBVersion.Items.AddRange(new object[] {
                    "UGC 6.0版本",
                    "UGC 2.0版本",
                    "SFC 6.0版本"});

        }
        private void comboBoxCreateSDBVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCreateSDBVersion.SelectedIndex == 0)
                {
                    comboBoxCreateSDBType.Items.Clear();
                    comboBoxCreateSDBType.Items.Add("SMWU");
                    comboBoxCreateSDBType.Items.Add("SXWU");
                }
                else
                {
                    comboBoxCreateSDBType.Items.Clear();
                    comboBoxCreateSDBType.Items.Add("SMW");
                    comboBoxCreateSDBType.Items.Add("SXW");
                }

                comboBoxCreateSDBType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void buttonCreateSDBOK_Click(object sender, EventArgs e)
        {
            mainForm.Createfile(textBoxCreateSDBPath.Text, textBoxCreateSDBPassword.Text, comboBoxCreateSDBVersion.SelectedIndex, comboBoxCreateSDBType.SelectedItem as String, textBoxCreateSDBName.Text);
            this.Close();
        }

        private void buttonCreateSDBFile_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDig = new FolderBrowserDialog();

                if (folderBrowserDig.ShowDialog() == DialogResult.OK)
                {
                    textBoxCreateSDBPath.Text = folderBrowserDig.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        
    }
}
