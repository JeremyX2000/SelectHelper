using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.UI;
using SuperMap.Data;
using SuperMap.Realspace;
using SelectHelper.Dialog;
using System.Diagnostics;
using SelectHelper.Hydrology;

namespace SelectHelper
{
    public partial class MainForm : Form
    {
        SceneControl m_SceneControl = null;
        private DatasourceConnectionInfo m_datasourceInfo;
        private WorkspaceConnectionInfo m_connectionInfo;
        int m_viewIndex;
        private Layer3DSettingGrid m_layer3DSettingGrid;
        private Layer3DSettingImage m_layer3DSettingImage;
        private Layer3DSettingVector m_layer3DSettingVector;
        Datasource m_datasource = null;
        public Hydrology.Hydrology hydrology = null;


        public MainForm()
        {
            InitializeComponent();
            m_viewIndex = 0;
            CreateSceneControl();
            BandMapControl();
            m_connectionInfo = new WorkspaceConnectionInfo();
            m_datasourceInfo = new DatasourceConnectionInfo();
            hydrology = new Hydrology.Hydrology(workspace1,layersControl1,mapControl1);
        }
        private void Initialize()
        {
            //控件绑定工作空间
            this.workspaceControl1.WorkspaceTree.Workspace = workspace1;
            this.m_SceneControl.Scene.Workspace = workspace1;
            this.layersControl1.Scene = this.m_SceneControl.Scene;
            
            //开启全屏防走样
            SuperMap.Data.Environment.IsSceneAntialias = true;
            this.m_SceneControl.IsFPSVisible = false;
            this.layersControl1.Layer3DsTree.ItemHeight = FontHeight + 5;

            //
            m_layer3DSettingGrid = new Layer3DSettingGrid();
            m_layer3DSettingImage = new Layer3DSettingImage(); ;
            m_layer3DSettingVector = new Layer3DSettingVector();
            m_layer3DSettingVector.Style.LineColor = Color.GreenYellow;
            m_layer3DSettingVector.Style.LineWidth = 0.2;
            this.workspaceControl1.WorkspaceTree.BeforeNodeContextMenuStripShow += new BeforeNodeContextMenuStripShowEventHandler(WorkspaceTree_BeforeNodeContextMenuStripShow);
            
            

        }
        public Dataset GetData(string name)
        {
            return m_datasource.Datasets[name];
        }
        private void WorkspaceTree_BeforeNodeContextMenuStripShow(object sender, BeforeNodeContextMenuStripShowEventArgs e)
        {
            try
            {
                ToolStripMenuItem toolStripMenuItemAddData = new ToolStripMenuItem();
                toolStripMenuItemAddData.Click += new EventHandler(toolStripMenuItemAddData_Click);
                if (m_viewIndex == 1)
                {
                   
                    toolStripMenuItemAddData.Text = "添加到地图";
                }
                else
                {
                    toolStripMenuItemAddData.Text = "添加到场景";
                }
                ToolStripMenuItem toolStripMenuItemOpenMap = new ToolStripMenuItem("打开地图");
                
                toolStripMenuItemOpenMap.Click += new EventHandler(toolStripMenuItemAddData_Click);

                ContextMenuStrip contextMenuStripWorkspaceTree = new ContextMenuStrip();
                WorkspaceTreeNodeBase treeNode = e.Node as WorkspaceTreeNodeBase;
                if ((treeNode.NodeType & WorkspaceTreeNodeDataType.Dataset) != WorkspaceTreeNodeDataType.Unknown)
                {
                    contextMenuStripWorkspaceTree.Items.AddRange(new ToolStripItem[] { toolStripMenuItemAddData });
                }
                else if (treeNode.NodeType == WorkspaceTreeNodeDataType.MapName)
                {
                    contextMenuStripWorkspaceTree.Items.AddRange(new ToolStripItem[] { toolStripMenuItemOpenMap });
                }
                workspaceControl1.WorkspaceTree.NodeContextMenuStrips[treeNode.NodeType] = contextMenuStripWorkspaceTree;
                this.workspaceControl1.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.Datasources] = contextMenuStripData;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        private void toolStripMenuItemAddData_Click(object sender, EventArgs e)
        {
            AddData();
        }
        private void AddData()
        {
            try
            {
                WorkspaceTreeNodeBase node = workspaceControl1.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
                WorkspaceTreeNodeDataType type = node.NodeType;
                if ((type & WorkspaceTreeNodeDataType.Dataset) != WorkspaceTreeNodeDataType.Unknown)
                {
                    type = WorkspaceTreeNodeDataType.Dataset;
                }
                switch (type)
                {
                    case WorkspaceTreeNodeDataType.Dataset:
                        {
                            Dataset dataset = node.GetData() as Dataset;

                            if (m_viewIndex == 1)
                            {
                                layersControl1.Map.Layers.Add(dataset, true);
                                layersControl1.Map.Refresh();
                            }
                            else if (m_viewIndex == 0)
                            {
                                if (dataset.Type == DatasetType.Grid)
                                {
                                    layersControl1.Scene.Layers.Add(dataset, m_layer3DSettingGrid, true);
                                }
                                else if (dataset.Type == DatasetType.Image)
                                {
                                    layersControl1.Scene.Layers.Add(dataset, m_layer3DSettingImage, true);
                                }
                                else
                                {
                                    layersControl1.Scene.Layers.Add(dataset, m_layer3DSettingVector, true);
                                }
                                layersControl1.Scene.Refresh();
                            }
                        }
                        break;
                    case WorkspaceTreeNodeDataType.MapName:
                        {
                            String mapName = node.GetData() as String;

                            if (layersControl1.Map != null)
                            {
                                mapControl1.Map.Open(mapName);
                                mapControl1.Map.Refresh();
                            }
                            else if (layersControl1.Scene != null && !layersControl1.Scene.Layers.Contains(mapName))
                            {
                                layersControl1.Scene.Layers.Add(mapName, Layer3DType.Map, true, mapName);
                                m_SceneControl.Scene.Refresh();
                            }
                        }
                        break;
                    case WorkspaceTreeNodeDataType.SceneName:
                        {
                            String sceneName = node.GetData() as String;
                            if (layersControl1.Scene != null)
                            {
                                layersControl1.Scene.Open(sceneName);
                                m_SceneControl.Scene.Refresh();
                            }
                        }
                        break;
                    case WorkspaceTreeNodeDataType.SymbolMarker:
                        {
                            SymbolLibraryDialog.ShowDialog(workspace1.Resources, SymbolType.Marker);
                        }
                        break;
                    case WorkspaceTreeNodeDataType.SymbolLine:
                        {
                            SymbolLibraryDialog.ShowDialog(workspace1.Resources, SymbolType.Line);
                        }
                        break;
                    case WorkspaceTreeNodeDataType.SymbolFill:
                        {
                            SymbolLibraryDialog.ShowDialog(workspace1.Resources, SymbolType.Fill);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            { }
        }
        private void BandMapControl()
        {
            this.mapControl1.Map.Workspace = workspace1;
            //this.layersControl1.Map = this.mapControl1.Map;

        }
        private void CreateSceneControl()
        {
            if(m_SceneControl==null || m_SceneControl.IsDisposed)
            {
                m_SceneControl=new SceneControl();
                m_SceneControl.Action = Action3D.Pan;
                m_SceneControl.BackColor = Color.White;
                m_SceneControl.Dock = DockStyle.Fill;
                m_SceneControl.IsAlwaysUpdate = false;
                m_SceneControl.IsCursorCustomized=false;
                m_SceneControl.IsFPSVisible = true;
                m_SceneControl.IsKeyboardNavigationEnabled = false;
                m_SceneControl.IsMouseNavigationEnabled = true;
                m_SceneControl.IsStatusBarVisible = true;
                m_SceneControl.IsWaitCursorEnabled = false;
                m_SceneControl.Location = new System.Drawing.Point(3, 3);
                m_SceneControl.Margin = new System.Windows.Forms.Padding(0);
                m_SceneControl.Name = "m_sceneControl";
                m_SceneControl.Size = new System.Drawing.Size(475, 356);
                m_SceneControl.TabIndex = 0;
                this.Sence.Controls.Add(m_SceneControl);
                m_SceneControl.Scene.Workspace = workspace1;
                this.Initialize();

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            OpenWorkspace openWorkspace = new OpenWorkspace(this);
            openWorkspace.Show();
        }
        public String[] GetDatasetName()
        {
            if (m_datasource != null)
            {
                String[] res = new String[m_datasource.Datasets.Count];
                Int32 index = 0;
                foreach (Dataset dataset in m_datasource.Datasets)
                {
                    res[index++] = dataset.Name;
                }
                return res;
            }
            return null;
            
            
        }
        public void Openfile(string path,string password)
        {
            try
            {
                m_connectionInfo.Server = path;
                m_connectionInfo.Type = this.GetType(System.IO.Path.GetExtension(path).ToUpper().Replace(".", String.Empty));
                m_connectionInfo.Name = System.IO.Path.GetFileNameWithoutExtension(path);
                m_connectionInfo.Password = password;
                bool bOpen = workspace1.Open(m_connectionInfo);
                if (!bOpen)
                {
                    MessageBox.Show("打开工作空间失败！");
                    return;
                }
                Scene scene = this.m_SceneControl.Scene;
                scene.Workspace = workspace1;
                bOpen = scene.Open("Model");
                if (!bOpen)
                {
                    MessageBox.Show("打开场景失败");
                    return;

                }
                return;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        public void Createfile(String path,String password,Int32 ver,String type,String name)
        {
            try
            {
               
                m_connectionInfo.Version = this.GetVersion(ver);
                m_connectionInfo.Type = this.GetType(type);
                m_connectionInfo.Server = System.IO.Path.Combine(path, name + "." + type);
                m_connectionInfo.Name = name;
                m_connectionInfo.Password = password;
                workspace1.Create(m_connectionInfo);

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        public void SaveAsfile(String path, String password, Int32 ver, String type, String name)
        {
            try
            {
                

                m_connectionInfo.Version = this.GetVersion(ver);
                m_connectionInfo.Type = this.GetType(type);
                m_connectionInfo.Server = System.IO.Path.Combine(path, name + "." + type);
                m_connectionInfo.Name = name;
                m_connectionInfo.Password = password;
                workspace1.SaveAs(m_connectionInfo);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        private WorkspaceType GetType(String type)
        {
            WorkspaceType result = WorkspaceType.Default;

            switch (type.ToUpper())
            {
                case "SMW":
                    {
                        result = WorkspaceType.SMW;
                    }
                    break;
                case "SXW":
                    {
                        result = WorkspaceType.SXW;
                    }
                    break;
                case "SMWU":
                    {
                        result = WorkspaceType.SMWU;
                    }
                    break;
                case "SXWU":
                    {
                        result = WorkspaceType.SXWU;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }
        private WorkspaceVersion GetVersion(Int32 selectIndex)
        {
            WorkspaceVersion version = WorkspaceVersion.SFC50;
            switch (selectIndex)
            {
                case 0:
                    {
                        version = WorkspaceVersion.UGC60;
                    }
                    break;
                case 1:
                    {
                        version = WorkspaceVersion.UGC20;
                    }
                    break;
                case 2:
                    {
                        version = WorkspaceVersion.SFC60;
                    }
                    break;
                default:
                    break;
            }

            return version;
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_SceneControl.Dispose();
            workspace1.Close();
            workspace1.Dispose();
            
        }

        private void 创建工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateWorkspace createWorkspace = new CreateWorkspace(this);
            createWorkspace.ShowDialog();
        }

        private void 另存工作空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsWorkspace saveAsWorkspace = new SaveAsWorkspace(this);
            saveAsWorkspace.ShowDialog();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_connectionInfo.Server != null)
            {
                workspace1.Save();
            }
          
        }
        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "UDB File(*.udb)|*.udb";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    m_datasourceInfo.Server = openFileDialog.FileName;
                    m_datasourceInfo.EngineType = EngineType.UDB;
                    m_datasourceInfo.Alias= System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    m_datasource=workspace1.Datasources.Open(m_datasourceInfo);
                    
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "udb文件*.udb|*.udb";
                if (saveFileDialog.ShowDialog() ==DialogResult.OK)
                {
                    
                    m_datasourceInfo.Server=saveFileDialog.FileName;
                    m_datasourceInfo.EngineType=EngineType.UDB;
                    m_datasourceInfo.Alias = System.IO.Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                    workspace1.Datasources.Create(m_datasourceInfo);
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 1)
            {
                layersControl1.Map =mapControl1.Map;
                m_viewIndex = 1;
                
            }
            else
            {
                layersControl1.Scene = m_SceneControl.Scene;
                m_viewIndex = 0;
            }
        }

        private void 河流长度计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HydrologyAnalystForm hydrologyAnalystForm = new HydrologyAnalystForm(this);
            hydrologyAnalystForm.ShowDialog();
        }
    }
}
