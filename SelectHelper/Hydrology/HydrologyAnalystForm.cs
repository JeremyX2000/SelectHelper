using SuperMap.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectHelper.Hydrology
{
    public partial class HydrologyAnalystForm : Form
    {
        MainForm mainForm;
        public HydrologyAnalystForm()
        {
            InitializeComponent();
        }
        public HydrologyAnalystForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            String[] datasetnames=mainForm.GetDatasetName();
            if(datasetnames!=null)
            foreach (String datasetname in datasetnames)
            {
                comboBox1.Items.Add(datasetname);
            }
            comboBox1.SelectedIndex = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=comboBox1.SelectedItem.ToString();
            DatasetGrid res=(DatasetGrid)mainForm.GetData(name);
            mainForm.hydrology.FlowLength(res,null,true,null,textBox2.Text);
        }
    }
}
