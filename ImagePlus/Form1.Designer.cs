namespace ImagePlus
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.modList = new System.Windows.Forms.ComboBox();
            this.out_format = new System.Windows.Forms.ComboBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.out_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.path_i = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.PictureBox();
            this.input = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stop_v = new System.Windows.Forms.Button();
            this.start_v = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modsList_v = new System.Windows.Forms.ComboBox();
            this.su_oper = new System.Windows.Forms.ComboBox();
            this.sel_script = new System.Windows.Forms.Button();
            this.save_video = new System.Windows.Forms.Button();
            this.open_video = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.output_v = new System.Windows.Forms.TextBox();
            this.input_v = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.检查程序完整性AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系作者LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无法显示帮助DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.modList);
            this.tabPage1.Controls.Add(this.out_format);
            this.tabPage1.Controls.Add(this.stop);
            this.tabPage1.Controls.Add(this.start);
            this.tabPage1.Controls.Add(this.saveFile);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.openFile);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.out_path);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.path_i);
            this.tabPage1.Controls.Add(this.output);
            this.tabPage1.Controls.Add(this.input);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 380);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图片";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // modList
            // 
            this.modList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modList.FormattingEnabled = true;
            this.modList.Location = new System.Drawing.Point(352, 99);
            this.modList.Name = "modList";
            this.modList.Size = new System.Drawing.Size(400, 25);
            this.modList.TabIndex = 5;
            // 
            // out_format
            // 
            this.out_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.out_format.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.out_format.FormattingEnabled = true;
            this.out_format.Items.AddRange(new object[] {
            "png",
            "jpg",
            "webp"});
            this.out_format.Location = new System.Drawing.Point(352, 68);
            this.out_format.Name = "out_format";
            this.out_format.Size = new System.Drawing.Size(400, 25);
            this.out_format.TabIndex = 5;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(670, 340);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(92, 34);
            this.stop.TabIndex = 4;
            this.stop.Text = "强制中断(&T)";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(572, 340);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(92, 34);
            this.start.TabIndex = 4;
            this.start.Text = "开始(&S)";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(720, 39);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(32, 23);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "...";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.out_sel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(290, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "渲染模型";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(720, 6);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(32, 23);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "...";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(290, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "输出格式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(290, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "输出文件";
            // 
            // out_path
            // 
            this.out_path.Location = new System.Drawing.Point(352, 39);
            this.out_path.Name = "out_path";
            this.out_path.ReadOnly = true;
            this.out_path.Size = new System.Drawing.Size(362, 23);
            this.out_path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "源文件";
            // 
            // path_i
            // 
            this.path_i.Location = new System.Drawing.Point(352, 6);
            this.path_i.Name = "path_i";
            this.path_i.ReadOnly = true;
            this.path_i.Size = new System.Drawing.Size(362, 23);
            this.path_i.TabIndex = 1;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(6, 195);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(278, 179);
            this.output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.output.TabIndex = 0;
            this.output.TabStop = false;
            this.output.Click += new System.EventHandler(this.output_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(6, 3);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(278, 182);
            this.input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.input.TabIndex = 0;
            this.input.TabStop = false;
            this.input.Click += new System.EventHandler(this.input_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stop_v);
            this.tabPage2.Controls.Add(this.start_v);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "视频";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stop_v
            // 
            this.stop_v.Location = new System.Drawing.Point(670, 340);
            this.stop_v.Name = "stop_v";
            this.stop_v.Size = new System.Drawing.Size(92, 34);
            this.stop_v.TabIndex = 2;
            this.stop_v.Text = "强制中断(&T)";
            this.stop_v.UseVisualStyleBackColor = true;
            this.stop_v.Click += new System.EventHandler(this.stop_v_Click);
            // 
            // start_v
            // 
            this.start_v.Location = new System.Drawing.Point(572, 340);
            this.start_v.Name = "start_v";
            this.start_v.Size = new System.Drawing.Size(92, 34);
            this.start_v.TabIndex = 2;
            this.start_v.Text = "开始(&S)";
            this.start_v.UseVisualStyleBackColor = true;
            this.start_v.Click += new System.EventHandler(this.start_v_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modsList_v);
            this.groupBox1.Controls.Add(this.su_oper);
            this.groupBox1.Controls.Add(this.sel_script);
            this.groupBox1.Controls.Add(this.save_video);
            this.groupBox1.Controls.Add(this.open_video);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.output_v);
            this.groupBox1.Controls.Add(this.input_v);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // modsList_v
            // 
            this.modsList_v.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modsList_v.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modsList_v.FormattingEnabled = true;
            this.modsList_v.Location = new System.Drawing.Point(69, 81);
            this.modsList_v.Name = "modsList_v";
            this.modsList_v.Size = new System.Drawing.Size(242, 25);
            this.modsList_v.TabIndex = 4;
            // 
            // su_oper
            // 
            this.su_oper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.su_oper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.su_oper.FormattingEnabled = true;
            this.su_oper.Items.AddRange(new object[] {
            "啥也不做",
            "关机",
            "重启"});
            this.su_oper.Location = new System.Drawing.Point(68, 115);
            this.su_oper.Name = "su_oper";
            this.su_oper.Size = new System.Drawing.Size(243, 25);
            this.su_oper.TabIndex = 3;
            this.su_oper.SelectedIndexChanged += new System.EventHandler(this.su_oper_SelectedIndexChanged);
            // 
            // sel_script
            // 
            this.sel_script.Location = new System.Drawing.Point(317, 116);
            this.sel_script.Name = "sel_script";
            this.sel_script.Size = new System.Drawing.Size(40, 23);
            this.sel_script.TabIndex = 2;
            this.sel_script.Text = "...";
            this.sel_script.UseVisualStyleBackColor = true;
            this.sel_script.Click += new System.EventHandler(this.sel_script_Click);
            // 
            // save_video
            // 
            this.save_video.Location = new System.Drawing.Point(317, 51);
            this.save_video.Name = "save_video";
            this.save_video.Size = new System.Drawing.Size(40, 23);
            this.save_video.TabIndex = 2;
            this.save_video.Text = "...";
            this.save_video.UseVisualStyleBackColor = true;
            this.save_video.Click += new System.EventHandler(this.save_video_Click);
            // 
            // open_video
            // 
            this.open_video.Location = new System.Drawing.Point(317, 22);
            this.open_video.Name = "open_video";
            this.open_video.Size = new System.Drawing.Size(40, 23);
            this.open_video.TabIndex = 2;
            this.open_video.Text = "...";
            this.open_video.UseVisualStyleBackColor = true;
            this.open_video.Click += new System.EventHandler(this.open_video_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "渲染模型";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "完成后";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "输出文件";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "输入文件";
            // 
            // output_v
            // 
            this.output_v.Location = new System.Drawing.Point(68, 51);
            this.output_v.Name = "output_v";
            this.output_v.ReadOnly = true;
            this.output_v.Size = new System.Drawing.Size(243, 23);
            this.output_v.TabIndex = 0;
            this.output_v.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input_v
            // 
            this.input_v.Location = new System.Drawing.Point(68, 22);
            this.input_v.Name = "input_v";
            this.input_v.ReadOnly = true;
            this.input_v.Size = new System.Drawing.Size(243, 23);
            this.input_v.TabIndex = 0;
            this.input_v.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.webView21);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 380);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "帮助";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(6, 6);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(756, 368);
            this.webView21.Source = new System.Uri("http://help.linxi.info/imagePlus/index.html", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.Click += new System.EventHandler(this.webView21_Click);
            this.webView21.Enter += new System.EventHandler(this.webView21_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作OToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作OToolStripMenuItem
            // 
            this.操作OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查更新CToolStripMenuItem,
            this.toolStripMenuItem1,
            this.检查程序完整性AToolStripMenuItem,
            this.退出程序EToolStripMenuItem});
            this.操作OToolStripMenuItem.Name = "操作OToolStripMenuItem";
            this.操作OToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.操作OToolStripMenuItem.Text = "操作(&O)";
            // 
            // 检查更新CToolStripMenuItem
            // 
            this.检查更新CToolStripMenuItem.Name = "检查更新CToolStripMenuItem";
            this.检查更新CToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.检查更新CToolStripMenuItem.Text = "检查更新(&C)";
            this.检查更新CToolStripMenuItem.Click += new System.EventHandler(this.检查更新CToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem1.Text = "强制中断(&T)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 检查程序完整性AToolStripMenuItem
            // 
            this.检查程序完整性AToolStripMenuItem.Enabled = false;
            this.检查程序完整性AToolStripMenuItem.Name = "检查程序完整性AToolStripMenuItem";
            this.检查程序完整性AToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.检查程序完整性AToolStripMenuItem.Text = "检查程序完整性(&A)";
            // 
            // 退出程序EToolStripMenuItem
            // 
            this.退出程序EToolStripMenuItem.Name = "退出程序EToolStripMenuItem";
            this.退出程序EToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.退出程序EToolStripMenuItem.Text = "退出程序(&E)";
            this.退出程序EToolStripMenuItem.Click += new System.EventHandler(this.退出程序EToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明SToolStripMenuItem,
            this.联系作者LToolStripMenuItem,
            this.无法显示帮助DToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 说明SToolStripMenuItem
            // 
            this.说明SToolStripMenuItem.Name = "说明SToolStripMenuItem";
            this.说明SToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.说明SToolStripMenuItem.Text = "说明(&S)";
            this.说明SToolStripMenuItem.Click += new System.EventHandler(this.说明SToolStripMenuItem_Click);
            // 
            // 联系作者LToolStripMenuItem
            // 
            this.联系作者LToolStripMenuItem.Name = "联系作者LToolStripMenuItem";
            this.联系作者LToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.联系作者LToolStripMenuItem.Text = "联系作者(&L)";
            this.联系作者LToolStripMenuItem.Click += new System.EventHandler(this.联系作者LToolStripMenuItem_Click);
            // 
            // 无法显示帮助DToolStripMenuItem
            // 
            this.无法显示帮助DToolStripMenuItem.Name = "无法显示帮助DToolStripMenuItem";
            this.无法显示帮助DToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.无法显示帮助DToolStripMenuItem.Text = "无法显示帮助?(&D)";
            this.无法显示帮助DToolStripMenuItem.Click += new System.EventHandler(this.无法显示帮助DToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button openFile;
        private Label label1;
        private TextBox path_i;
        private PictureBox output;
        private PictureBox input;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 操作OToolStripMenuItem;
        private ToolStripMenuItem 检查更新CToolStripMenuItem;
        private ToolStripMenuItem 检查程序完整性AToolStripMenuItem;
        private ToolStripMenuItem 退出程序EToolStripMenuItem;
        private ToolStripMenuItem 帮助HToolStripMenuItem;
        private ToolStripMenuItem 说明SToolStripMenuItem;
        private ToolStripMenuItem 联系作者LToolStripMenuItem;
        private ComboBox out_format;
        private Button saveFile;
        private Label label3;
        private Label label2;
        private TextBox out_path;
        private ComboBox modList;
        private Label label4;
        public Button stop;
        public Button start;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private TextBox input_v;
        private Button save_video;
        private Button open_video;
        private TextBox output_v;
        private ComboBox su_oper;
        private Button sel_script;
        private Label label7;
        private ComboBox modsList_v;
        private Label label8;
        private Button stop_v;
        private Button start_v;
        private System.Windows.Forms.Timer timer2;
        private ToolStripMenuItem toolStripMenuItem1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private ToolStripMenuItem 无法显示帮助DToolStripMenuItem;
    }
}