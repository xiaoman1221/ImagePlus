using modules;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Timers;

namespace ImagePlus
{
    public partial class MainPage : Form
    {

        module module = new module();
        log log = new log();
        string i_path;
        string o_path = Application.StartupPath.ToString() + @"output\";
        OpenFileDialog ofd = new OpenFileDialog();
        public string saveP;
        public string video_source;
        public string video_save = Application.StartupPath + "output\\" + DateTime.Now.Ticks.ToString() + ".mp4";
       
        public Boolean selected = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Title = "ImagePlus Console";
            if (module.init())
            {
                log.Success("程序初始化成功！");

            }
            else
            {
                MessageBox.Show("程序似乎存在问题，请截图控制台信息发送给作者或自行根据控制台输出信息解决","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                System.Environment.Exit(0);
                Application.Exit();
            }
            string[] mods = Directory.GetFiles(Application.StartupPath.ToString() + @"\program\models\", "*.param");
            foreach (string mod in mods)
            {
                modList.Items.Add(Path.GetFileNameWithoutExtension(mod));
                modsList_v.Items.Add(Path.GetFileNameWithoutExtension(mod));
            }
            modList.SelectedIndex = 3;
            out_format.SelectedIndex = 0;
            su_oper.SelectedIndex = 0;
            sel_script.Enabled = false;
            modsList_v.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ofd.Filter = "PNG图像文件|*.png|JPG图像文件|*.jpg|webp文件|*.webp";
            ofd.CheckFileExists = true;
            ofd.Title = "选择文件";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path_i.Text = ofd.FileName;
                input.ImageLocation = ofd.FileName;
                out_path.Text = Application.StartupPath +  "output\\" + Path.GetFileName(ofd.FileName) + "_output." + out_format.SelectedItem.ToString();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (module.ffIsRun)
                { 
                    module.ff.Kill();

                }
                if (module.mainIsRun)
                { 
                    module.main.Kill();

                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                
            }
            start.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.FileName == "" || out_format.SelectedItem.ToString() == "" || modList.SelectedItem.ToString() == "")
            {
                MessageBox.Show("参数不完整", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string savePath;
            if (saveP != "")
            {
                savePath = saveP;
            }
            else
            {
                savePath = "output\\" + Path.GetFileName(ofd.FileName) + "_output." + out_format.SelectedItem.ToString();

            }
            //saveP = savePath;
            module.makeImage(ofd.FileName,savePath, modList.SelectedItem.ToString());
            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void out_sel(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Title = "另存为";
            sfd.Filter = "PNG图像文件|*.png|JPG图像文件|*.jpg|webp文件|*.webp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                out_path.Text = sfd.FileName;
                saveP = sfd.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (module.ffIsRun || module.mainIsRun)
            {
                start.Enabled = false;
                out_format.Enabled = false;
                modList.Enabled = false;
                saveFile.Enabled = false;
                openFile.Enabled = false;
            }
            else
            {
                output.ImageLocation = Application.StartupPath + saveP;
                start.Enabled = true;
                openFile.Enabled = true;
                out_format.Enabled = true;
                modList.Enabled = true;
                saveFile.Enabled = true;
                timer1.Enabled = false;
                timer1.Stop();
            }
        }

        private void output_Click(object sender, EventArgs e)
        {
            if (output.ImageLocation != "")
            {
                Process open = new Process();
                open.StartInfo.FileName = "explorer.exe";
                open.StartInfo.Arguments = saveP;
                open.Start();

            }

        }

        private void input_Click(object sender, EventArgs e)
        {
            Process open = new Process();
            open.StartInfo.FileName = "explorer.exe";
            open.StartInfo.Arguments = ofd.FileName;
            open.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void su_oper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (su_oper.SelectedIndex == 3)
            {
                sel_script.Enabled = true;
            }
            else
            {
                sel_script.Enabled = false;
            }
            switch (su_oper.SelectedIndex)
            {
                case 1:
                    module.task.StartInfo.FileName = "shutdown.exe";
                    module.task.StartInfo.Arguments = " -t 30";
                    break;
                case 2:
                    module.task.StartInfo.FileName = "shutdown.exe";
                    module.task.StartInfo.Arguments = "-r -t 30";
                    break;
                default:
                    break;
            }
        }

        private void 退出程序EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("你确定要退出本程序吗？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;

            }
        }

        private void open_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog video_o = new OpenFileDialog();
            video_o.Filter = "视频文件|*.mp4";
            if (video_o.ShowDialog() == DialogResult.OK)
            {
                video_source = video_o.FileName;
                input_v.Text = video_source;
                selected = true;
            }
            else
            {
                selected = false;
                log.Infomation("canced");    
            }
        }

        private void save_video_Click(object sender, EventArgs e)
        {
            SaveFileDialog video_s = new SaveFileDialog();
            video_s.Filter = "视频文件|*.mp4";
            if (video_s.ShowDialog() == DialogResult.OK)
            {
                video_save = video_s.FileName;

                output_v.Text = video_save;
            }
        }

        private void start_v_Click(object sender, EventArgs e)
        {
            if (modsList_v.SelectedItem == null || video_source == "" || video_save == ""|| !selected)
            {
                MessageBox.Show("参数不完整", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            module.makeVideo(video_source, video_save, modsList_v.SelectedItem.ToString());
            timer2.Enabled = true;
            timer2.Interval = 100;
            timer2.Start();
        }

        private void stop_v_Click(object sender, EventArgs e)
        {
            try
            {
                if (module.ffIsRun)
                {
                    module.ff.Kill();

                }
                if (module.mainIsRun)
                {
                    module.main.Kill();

                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);

            }
            start_v.Enabled = true;
        }

        public void StopProcess()
        {
            module.cancel = true;
            try
            {
                if (module.ffIsRun)
                {
                    module.ff.Kill();

                }
                if (module.mainIsRun)
                {
                    module.main.Kill();

                }
                log.Success("已终止");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);

            }
            
            start_v.Enabled = true;
            start.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (module.ffIsRun || module.mainIsRun)
            {
                start_v.Enabled = false;
                open_video.Enabled = false;
                save_video.Enabled = false;
                modsList_v.Enabled = false;
                tabControl1.Enabled = false;
                
            }
            else
            {
                start_v.Enabled = true;
                open_video.Enabled = true;
                save_video.Enabled = true;
                modsList_v.Enabled = true;
                tabControl1.Enabled = true;

                timer2.Enabled = false;
                timer2.Stop();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            StopProcess();
            module.removeTmp();
        }

        private void sel_script_Click(object sender, EventArgs e)
        {
            task0 task0 = new task0();
            task0.ShowDialog();
        }

        private void 联系作者LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process explorer = new Process();
            explorer.StartInfo.FileName = "explorer.exe";
            explorer.StartInfo.Arguments = "\"https://wpa.qq.com/msgrd?v=3&uin=3414769627&site=qq&menu=yes&jumpflag=1\"";
            explorer.Start();
        }

        private void 说明SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[2];
        }

        private void 检查更新CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update update = new update();
            update.checkUpdate("imagePlus", 1000, true);

        }

        private void 无法显示帮助DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("帮助页依赖于Microsoft Edge WebView2 Runtime,是否立即安装?\r\n注意:这需要互联网连接", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Process webViewSetup = new Process();
                webViewSetup.StartInfo.FileName = "MicrosoftEdgeWebview2Setup.exe";
                webViewSetup.Start();
            }

            
        }

        private void webView21_Click(object sender, EventArgs e)
        {
        }

        private void webView21_Enter(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = false;

        }
    }
}