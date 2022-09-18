using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modules;

namespace ImagePlus
{
    public partial class task0 : Form
    {


        public task0()
        {
            InitializeComponent();
        }
        module module = new module();
        log log = new log();
        public string exeFile;
        public string args;
        private void button1_Click(object sender, EventArgs e)
        {
            module.task.StartInfo.FileName = exeFile;
            module.task.StartInfo.Arguments = execArgs.Text;
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "可执行文件|*.exe|可执行文件|*.bat|可执行文件|*.vbs|可执行文件|*.com";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                exeFile = openFileDialog.FileName;
                exePath.Text = exeFile;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void task0_Load(object sender, EventArgs e)
        {
            exePath.Text = module.task.StartInfo.FileName;
            execArgs.Text = module.task.StartInfo.Arguments;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            module.task.StartInfo.FileName = exeFile;
            module.task.StartInfo.Arguments = execArgs.Text;
            log.Infomation(exeFile + "\n" + execArgs);
            log.Infomation(module.task.StartInfo.FileName + "\n" + module.task.StartInfo.Arguments);

        }
    }
}
