using System.ComponentModel;
using System.Text;
using System.Diagnostics;
using System.Net;

namespace LOLSkinDownloader
{
    public partial class SkinDownloader : Form
    {
        string fileURL;
        string fileName;
        string fileVersion;
        string savePath;
        public SkinDownloader()
        {
            InitializeComponent();
            btnClose.Parent = picBoxbg;
            labelTitle.Parent= picBoxbg;
            labelTitle.ForeColor = Color.White;
            groupBoxPath.Parent= picBoxbg;
            groupBoxPath.ForeColor = Color.White;
            groupBoxDownload.Parent= picBoxbg;
            groupBoxDownload.ForeColor = Color.White;
            btnDldDir.ForeColor = Color.White;
            btnDldBrwoser.ForeColor = Color.White;
            fileURL = GetDownloadURL();
            fileVersion = fileURL.Substring(fileURL.IndexOf("_")+1, fileURL.IndexOf(".zip") - fileURL.IndexOf("_")-1);
            fileName = "LOLSkin "+fileVersion + ".zip";
            if(fileVersion!=null)
                MessageBox.Show("Get newest version succeed!");
            labelVer.Parent= picBoxbg;
            labelVer.Text += fileVersion+"             Jayczee";
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe","http://leagueskin.net/p/download-mod-skin-2020-chn");
        }
            private string SelectPath()
        {
            string path = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                path = fbd.SelectedPath;
            }
            return path;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            txtPath.Text = SelectPath();
            savePath = txtPath.Text;
        }

        private bool CheckPath(string path)
        {
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Directory illegal!!!\nPlease choose a right directory.");
                return false;
            }
            return true;
        }

        private string GetDownloadURL()
        {
            using (WebClient client=new WebClient())
            {
                client.Credentials = CredentialCache.DefaultCredentials;
                byte[] buffer = client.DownloadData("http://leagueskin.net/p/download-mod-skin-2020-chn"); 
                string htmlfile = UnicodeEncoding.UTF8.GetString(buffer);
                htmlfile = htmlfile.Substring(htmlfile.IndexOf("<a id=\"link_download3\""));
                htmlfile = htmlfile.Substring(29, htmlfile.IndexOf("target=\"_blank\"> ")- 31);
                return htmlfile;
            }

        }

        private void btnDldDir_Click(object sender, EventArgs e)
        {
            Download(fileURL);
        }

        private DateTime StartTime;

        private void Download(string url)
        {

            btnDldDir.Text = "Downloading...";
            btnDldDir.Enabled = false;
            btnDldBrwoser.Enabled = false; 
            StartTime = DateTime.Now;
            progressBar1.Value = 0;
            WebClient ws = new WebClient();
            ws.DownloadProgressChanged += OnDownloadProgressChanged;
            ws.DownloadFileCompleted += OnDownloadFileCompleted;
            ws.DownloadFileAsync(new Uri(url), Path.Combine(savePath, fileName));
        }

        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            var s = (DateTime.Now - StartTime).TotalSeconds;
            var sd = ReadableFilesize(e.BytesReceived / s);
            txtProgress.Text = "下载速度" + sd + "/秒" + ",已下载" + ReadableFilesize(e.BytesReceived) + "/总计" + ReadableFilesize(e.TotalBytesToReceive);//一个label框，用来显示当前下载的数据
        }

        private void OnDownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Done!\nSaved to "+savePath+fileName);
            btnDldDir.Text = "Direct\nDownload";
            btnDldBrwoser.Text = "Browser\nDownload";
            btnDldDir.Enabled = true;
            btnDldBrwoser.Enabled=true;
        }

        private string ReadableFilesize(double size)
        {
            String[] units = { "B", "KB", "MB", "GB", "TB", "PB" };
            double mod = 1024.0;
            int i = 0;
            while (size >= mod)
            {
                size /= mod;
                i++;
            }
            return Math.Round(size) + units[i];
        }

        private void btnDldBrwoser_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", fileURL);
        }

    }
}
