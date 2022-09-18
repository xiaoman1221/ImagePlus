using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;
using modules;
using System.Security.Cryptography;
//using ImagePlus;

namespace ImagePlus
{
    internal class module
    {

        public string[] mainFiles = { 
            "program\\Main.exe",
            "program\\vcomp140d.dll",
            "Modules.dll",
            "program\\vcomp140.dll",
            "program\\MicrosoftEdgeWebview2Setup.exe",
            "Microsoft.Web.WebView2.Core.dll",
            "Microsoft.Web.WebView2.WinForms.dll",
            "Microsoft.Web.WebView2.Wpf.dll"
        };
        //要检查的文件
        public string[] dirs = { 
            "video_tmp",
            "output",
            "program\\models",
            "image_tmp"
        };
        //要检查的文件夹

        log log = new log();
        //Console实时日志类

        public Boolean cancel = false;
        
        public Process ff = new Process();
        //ffmpeg进程
        public Process main = new Process();
        //主进程
        public Boolean ffIsRun = false;
        //判断ffmpeg是否运行
        public Boolean mainIsRun = false;
        //判断主进程是否运行

        public Process task = new Process();

        public int mode = -1;
        public string input_file;
        //输入文件
        public string output_file;
        //输出文件
        public Boolean error = false;
        
        public Boolean init(Boolean debug = false)
        {

            foreach (string dir in dirs)
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            //循环判断文件夹是否存在
            foreach (string file in mainFiles)
            {
                if (!File.Exists(file))
                {

                    log.Error("文件:" + file + "丢失，程序无法继续执行，请重新下载此程序以解决该问题.");
                    
                    return false;
                }
                else
                {
                    log.Success(file);
                }

            }
            //循环判断文件是否存在
            return true;
        }
        public void makeVideo(string input,string output, string moduleNmae,int oper = 0)
        {

            input_file = input;
            output_file = output;
            log.Infomation("开始分割视频");
            mode = 0;
            ff.StartInfo.FileName = "program\\ffmpeg.exe";
            ff.StartInfo.Arguments = " -i " + input + " -qscale:v 1 -qmin 1 -qmax 1 -vsync 0 video_tmp/frame%08d.jpg";
            ff.Start();
            ffIsRun = true;
            ff.WaitForExit();
            ffIsRun = false;
            log.Success("视频分割完成,等待渲染...");
            main.StartInfo.FileName = "program\\Main.exe";
            main.StartInfo.Arguments = " -i video_tmp -o image_tmp -n " + moduleNmae + " -s 2 -f jpg";
            main.EnableRaisingEvents = true;
            main.Exited += Main_Exited1;
            if (cancel)
            {
                removeTmp();
                
                return;
            }
            main.Start();
            mainIsRun = true;



        }

        private void Main_Exited1(object? sender, EventArgs e)
        {
            mainIsRun = false;
            log.Success("渲染完成,等待进行视频合成...");
            ff.StartInfo.Arguments = " -i image_tmp\\frame%08d.jpg -i " + input_file + " -map 0:v:0 -map 1:a:0 -c:a copy -c:v libx264 -r " + getFPS(input_file).ToString() + " -pix_fmt yuv420p " + output_file;
            ff.EnableRaisingEvents = true;
            ff.Exited += Ff_Exited;
            if (cancel)
            {
                removeTmp();
                return;
            }
            ff.Start();
            ffIsRun = true;
        }

        public void removeTmp()
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/c del /q video_tmp\\*";
                cmd.Start();
                cmd.WaitForExit();
                cmd.StartInfo.Arguments = "/c del /q image_tmp\\*";
                cmd.Start();
                cmd.WaitForExit();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

        }

        private void Ff_Exited(object? sender, EventArgs e)
        {
            log.Success("任务完成");
            ffIsRun = false;
            try
            {
                removeTmp();

            }
            catch (Exception)
            {

                
            }
            for (int i = 10; i > 0; i--)
            {
                log.Infomation(i + "秒后将会执行完成后的任务");
                Thread.Sleep(1000);
            }
            try
            {
                task.Start();
                log.Success("执行成功");

            }
            catch (Exception ex)
            {
                log.Error("失败：" + ex.Message);
            }
        }

        public void makeImage(string input, string output,string moduleNmae)
        {
            mode = 1;
            main.StartInfo.FileName = "program\\Main.exe";
            main.StartInfo.Arguments = "-i " + input + " -o " + output + " -n " + moduleNmae;
            log.Infomation(main.StartInfo.Arguments);

            main.StartInfo.UseShellExecute = false;
            main.EnableRaisingEvents = true;
            main.Exited += new EventHandler(Main_Exited);

            main.Start();
            mainIsRun = true;

        }

        private void Main_Exited(object? sender, EventArgs e)
        {
            if (main.ExitCode == 0)
            {
                log.Success("处理完成.");
                mainIsRun = false;
            }
            else
            {
                log.Warning("处理失败.");
                mainIsRun = false;
            }
        }

        public double getFPS(string videoFile)
        {
            Process ffmpeg = new Process();
            ffmpeg.StartInfo.FileName = "powershell.exe";
            ffmpeg.StartInfo.Arguments = "-command \"program\\ffmpeg.exe -i " + videoFile + " >result 2>&1\"";
            ffmpeg.Start();
            ffmpeg.WaitForExit();

            Process cmd = new Process();
            cmd.StartInfo.FileName = "powershell.exe";
            cmd.StartInfo.Arguments = "-command \"cat ./result|findstr \"fps\" >result.tmp 2>&1\"";
            cmd.Start();
            cmd.WaitForExit();

            log.Infomation(ffmpeg.StartInfo.Arguments);
            string result = File.ReadAllText("result.tmp");

            string[] fps = result.Split(" ");
            log.Success("成功获取到帧率：" + fps[18]);
            try
            {
                File.Delete("result");
                File.Delete("result.tmp");
                return Convert.ToDouble(fps[18]);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return 0.00;
            }

        }
    }
}
