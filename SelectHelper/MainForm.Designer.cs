namespace SelectHelper
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存工作空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选址辅助决策ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.辅助项目选址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水库比选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.坝体模型模拟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输水道模型模拟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水文要数分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇水面积计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.汇水量计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.河流长度计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.河流比降计算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.环境影响分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.影响环境分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.环境变化分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.workspaceControl1 = new SuperMap.UI.WorkspaceControl();
            this.layersControl1 = new SuperMap.UI.LayersControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Sence = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mapControl1 = new SuperMap.UI.MapControl();
            this.workspace1 = new SuperMap.Data.Workspace(this.components);
            this.contextMenuStripData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStripData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.项目管理ToolStripMenuItem,
            this.选址辅助决策ToolStripMenuItem,
            this.水文要数分析ToolStripMenuItem,
            this.环境影响分析ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.创建工作空间ToolStripMenuItem,
            this.另存工作空间ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.打开ToolStripMenuItem.Text = "打开工作空间";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // 创建工作空间ToolStripMenuItem
            // 
            this.创建工作空间ToolStripMenuItem.Name = "创建工作空间ToolStripMenuItem";
            this.创建工作空间ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.创建工作空间ToolStripMenuItem.Text = "创建工作空间";
            this.创建工作空间ToolStripMenuItem.Click += new System.EventHandler(this.创建工作空间ToolStripMenuItem_Click);
            // 
            // 另存工作空间ToolStripMenuItem
            // 
            this.另存工作空间ToolStripMenuItem.Name = "另存工作空间ToolStripMenuItem";
            this.另存工作空间ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.另存工作空间ToolStripMenuItem.Text = "另存工作空间";
            this.另存工作空间ToolStripMenuItem.Click += new System.EventHandler(this.另存工作空间ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 项目管理ToolStripMenuItem
            // 
            this.项目管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目信息ToolStripMenuItem,
            this.用户信息ToolStripMenuItem,
            this.其他数据ToolStripMenuItem});
            this.项目管理ToolStripMenuItem.Name = "项目管理ToolStripMenuItem";
            this.项目管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.项目管理ToolStripMenuItem.Text = "项目管理";
            // 
            // 项目信息ToolStripMenuItem
            // 
            this.项目信息ToolStripMenuItem.Name = "项目信息ToolStripMenuItem";
            this.项目信息ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.项目信息ToolStripMenuItem.Text = "项目信息";
            // 
            // 用户信息ToolStripMenuItem
            // 
            this.用户信息ToolStripMenuItem.Name = "用户信息ToolStripMenuItem";
            this.用户信息ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.用户信息ToolStripMenuItem.Text = "用户信息";
            // 
            // 其他数据ToolStripMenuItem
            // 
            this.其他数据ToolStripMenuItem.Name = "其他数据ToolStripMenuItem";
            this.其他数据ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.其他数据ToolStripMenuItem.Text = "其他数据";
            // 
            // 选址辅助决策ToolStripMenuItem
            // 
            this.选址辅助决策ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.辅助项目选址ToolStripMenuItem,
            this.水库比选ToolStripMenuItem,
            this.坝体模型模拟ToolStripMenuItem,
            this.输水道模型模拟ToolStripMenuItem});
            this.选址辅助决策ToolStripMenuItem.Name = "选址辅助决策ToolStripMenuItem";
            this.选址辅助决策ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.选址辅助决策ToolStripMenuItem.Text = "选址辅助决策";
            // 
            // 辅助项目选址ToolStripMenuItem
            // 
            this.辅助项目选址ToolStripMenuItem.Name = "辅助项目选址ToolStripMenuItem";
            this.辅助项目选址ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.辅助项目选址ToolStripMenuItem.Text = "辅助项目选址";
            // 
            // 水库比选ToolStripMenuItem
            // 
            this.水库比选ToolStripMenuItem.Name = "水库比选ToolStripMenuItem";
            this.水库比选ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.水库比选ToolStripMenuItem.Text = "水库比选";
            // 
            // 坝体模型模拟ToolStripMenuItem
            // 
            this.坝体模型模拟ToolStripMenuItem.Name = "坝体模型模拟ToolStripMenuItem";
            this.坝体模型模拟ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.坝体模型模拟ToolStripMenuItem.Text = "坝体模型模拟";
            // 
            // 输水道模型模拟ToolStripMenuItem
            // 
            this.输水道模型模拟ToolStripMenuItem.Name = "输水道模型模拟ToolStripMenuItem";
            this.输水道模型模拟ToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.输水道模型模拟ToolStripMenuItem.Text = "输水道模型模拟";
            // 
            // 水文要数分析ToolStripMenuItem
            // 
            this.水文要数分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.汇水面积计算ToolStripMenuItem,
            this.汇水量计算ToolStripMenuItem,
            this.河流长度计算ToolStripMenuItem,
            this.河流比降计算ToolStripMenuItem});
            this.水文要数分析ToolStripMenuItem.Name = "水文要数分析ToolStripMenuItem";
            this.水文要数分析ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.水文要数分析ToolStripMenuItem.Text = "水文要数分析";
            // 
            // 汇水面积计算ToolStripMenuItem
            // 
            this.汇水面积计算ToolStripMenuItem.Name = "汇水面积计算ToolStripMenuItem";
            this.汇水面积计算ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.汇水面积计算ToolStripMenuItem.Text = "汇水面积计算";
            // 
            // 汇水量计算ToolStripMenuItem
            // 
            this.汇水量计算ToolStripMenuItem.Name = "汇水量计算ToolStripMenuItem";
            this.汇水量计算ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.汇水量计算ToolStripMenuItem.Text = "汇水量计算";
            // 
            // 河流长度计算ToolStripMenuItem
            // 
            this.河流长度计算ToolStripMenuItem.Name = "河流长度计算ToolStripMenuItem";
            this.河流长度计算ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.河流长度计算ToolStripMenuItem.Text = "河流长度计算";
            this.河流长度计算ToolStripMenuItem.Click += new System.EventHandler(this.河流长度计算ToolStripMenuItem_Click);
            // 
            // 河流比降计算ToolStripMenuItem
            // 
            this.河流比降计算ToolStripMenuItem.Name = "河流比降计算ToolStripMenuItem";
            this.河流比降计算ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.河流比降计算ToolStripMenuItem.Text = "河流比降计算";
            // 
            // 环境影响分析ToolStripMenuItem
            // 
            this.环境影响分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.影响环境分析ToolStripMenuItem,
            this.环境变化分析ToolStripMenuItem});
            this.环境影响分析ToolStripMenuItem.Name = "环境影响分析ToolStripMenuItem";
            this.环境影响分析ToolStripMenuItem.Size = new System.Drawing.Size(134, 28);
            this.环境影响分析ToolStripMenuItem.Text = "环境影响分析";
            // 
            // 影响环境分析ToolStripMenuItem
            // 
            this.影响环境分析ToolStripMenuItem.Name = "影响环境分析ToolStripMenuItem";
            this.影响环境分析ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.影响环境分析ToolStripMenuItem.Text = "影响环境分析";
            // 
            // 环境变化分析ToolStripMenuItem
            // 
            this.环境变化分析ToolStripMenuItem.Name = "环境变化分析ToolStripMenuItem";
            this.环境变化分析ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.环境变化分析ToolStripMenuItem.Text = "环境变化分析";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1384, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 772);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1384, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1384, 707);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.workspaceControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.layersControl1);
            this.splitContainer2.Size = new System.Drawing.Size(285, 707);
            this.splitContainer2.SplitterDistance = 338;
            this.splitContainer2.TabIndex = 0;
            // 
            // workspaceControl1
            // 
            this.workspaceControl1.AllowDefaultAction = true;
            this.workspaceControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workspaceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceControl1.Location = new System.Drawing.Point(0, 0);
            this.workspaceControl1.Name = "workspaceControl1";
            this.workspaceControl1.Size = new System.Drawing.Size(285, 338);
            this.workspaceControl1.TabIndex = 0;
            // 
            // 
            // 
            this.workspaceControl1.WorkspaceToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.workspaceControl1.WorkspaceToolBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.workspaceControl1.WorkspaceToolBar.Location = new System.Drawing.Point(0, 0);
            this.workspaceControl1.WorkspaceToolBar.Name = "WorkspaceToolBar";
            this.workspaceControl1.WorkspaceToolBar.Size = new System.Drawing.Size(285, 33);
            this.workspaceControl1.WorkspaceToolBar.TabIndex = 0;
            // 
            // 
            // 
            this.workspaceControl1.WorkspaceTree.AllowDrop = true;
            this.workspaceControl1.WorkspaceTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workspaceControl1.WorkspaceTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workspaceControl1.WorkspaceTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceControl1.WorkspaceTree.ItemHeight = 26;
            this.workspaceControl1.WorkspaceTree.Location = new System.Drawing.Point(0, 66);
            this.workspaceControl1.WorkspaceTree.Name = "WorkspaceTree";
            this.workspaceControl1.WorkspaceTree.SelectedNodes = new System.Windows.Forms.TreeNode[0];
            this.workspaceControl1.WorkspaceTree.Size = new System.Drawing.Size(285, 272);
            this.workspaceControl1.WorkspaceTree.TabIndex = 1;
            this.workspaceControl1.WorkspaceTree.Workspace = null;
            // 
            // layersControl1
            // 
            this.layersControl1.AutoSize = true;
            this.layersControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layersControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layersControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersControl1.Location = new System.Drawing.Point(0, 0);
            this.layersControl1.Map = null;
            this.layersControl1.Name = "layersControl1";
            this.layersControl1.Scene = null;
            this.layersControl1.Size = new System.Drawing.Size(285, 365);
            this.layersControl1.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Sence);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1095, 707);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Sence
            // 
            this.Sence.Location = new System.Drawing.Point(4, 28);
            this.Sence.Name = "Sence";
            this.Sence.Padding = new System.Windows.Forms.Padding(3);
            this.Sence.Size = new System.Drawing.Size(1087, 675);
            this.Sence.TabIndex = 2;
            this.Sence.Text = "场景";
            this.Sence.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mapControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1087, 675);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "地图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mapControl1
            // 
            this.mapControl1.Action = SuperMap.UI.Action.Select2;
            this.mapControl1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(3, 3);
            this.mapControl1.Margin = new System.Windows.Forms.Padding(72, 33, 72, 33);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(1081, 669);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // workspace1
            // 
            this.workspace1.Caption = "UntitledWorkspace";
            this.workspace1.Description = "";
            this.workspace1.DesktopInfo = "";
            // 
            // contextMenuStripData
            // 
            this.contextMenuStripData.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem1,
            this.新建ToolStripMenuItem});
            this.contextMenuStripData.Name = "contextMenuStripData";
            this.contextMenuStripData.Size = new System.Drawing.Size(117, 64);
            // 
            // 打开ToolStripMenuItem1
            // 
            this.打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1";
            this.打开ToolStripMenuItem1.Size = new System.Drawing.Size(116, 30);
            this.打开ToolStripMenuItem1.Text = "打开";
            this.打开ToolStripMenuItem1.Click += new System.EventHandler(this.打开ToolStripMenuItem1_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 794);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStripData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private SuperMap.UI.LayersControl layersControl1;
        private System.Windows.Forms.TabControl TabControl;
        private SuperMap.Data.Workspace workspace1;
        private System.Windows.Forms.TabPage Sence;
        private System.Windows.Forms.ToolStripMenuItem 项目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选址辅助决策ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 辅助项目选址ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水库比选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 坝体模型模拟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输水道模型模拟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水文要数分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇水面积计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 汇水量计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 河流长度计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 河流比降计算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 环境影响分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 影响环境分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 环境变化分析ToolStripMenuItem;
        private SuperMap.UI.WorkspaceControl workspaceControl1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建工作空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存工作空间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private SuperMap.UI.MapControl mapControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripData;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
    }
}

