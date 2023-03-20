﻿using System.Net;
using System.Text;

using LibGit2Sharp;
using System.Net.NetworkInformation;
using XSystem.Security.Cryptography;
using System.IO.Compression;

namespace Super_Metroid_Launcher
{
    partial class progressForm : Form
    {
        private volatile int progress = 0;
        private volatile int max = 999999;

        public progressForm(string title, string message)
        {
            InitializeComponent();

            this.Text = title;
            this.updateLabel.Text = message;

            switch (title)
            {
                case "Repository Download":
                    this.Shown += new System.EventHandler(this.cloneRepo);
                    break;
                case "Copying ROM File":
                    this.Shown += new System.EventHandler(this.copyROM);
                    break;
                case "Downloading TCC":
                    this.Shown += new System.EventHandler(this.downloadTCC);
                    break;
                case "Downloading SDL2":
                    this.Shown += new System.EventHandler(this.downloadSDL2);
                    break;
                /*case "Downloading Python":
                    this.Shown += new System.EventHandler(this.downloadPython);
                    break;*/
                case "Downloading pip":
                    this.Shown += new System.EventHandler(this.downloadPip);
                    break;
            }
        }

        private void copyROM(object sender, EventArgs e)
        {
            this.Refresh();

            if (File.Exists(Path.Combine(Program.repoDir, "sm.smc")))
            {
                this.Close();
                return;
            }

            if (File.Exists(Path.Combine(Program.currentDirectory, "sm.smc")))
            {
                File.Move(Path.Combine(Program.currentDirectory, "sm.smc"), Path.Combine(Program.repoDir, "sm.smc"));
                this.Close();
                return;
            }

            Boolean exit = false;
            var result = new OpenFileDialog();
            result.Filter = "Super Metroid ROM(*.smc;*.sfc)|*.smc;*.sfc";
            while (!exit)
            {
                if (result.ShowDialog() == DialogResult.OK)
                {
                    if (checkHash(result.FileName))
                    {
                        File.Copy(result.FileName, Path.Combine(Program.repoDir, "sm.smc"));
                        exit = true;
                    }
                    else
                    {
                        var answer = MessageBox.Show("ROM hash is not valid.\n\nWould you like to select another?", "Invalid ROM Hash", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (answer == DialogResult.No) exit = true;
                    }
                }
                else exit = true;
            }

            this.Close();
        }

        private void cloneRepo(object sender, EventArgs e)
        {
            this.Refresh();

            if (!IsConnectedToInternet())
            {
                MessageBox.Show("Unable to connect to the internet.\n\nPlease ensure you have a stable internet connection before updating your repository.", "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            var repoDir = Path.Combine(Program.currentDirectory, "sm");

            try
            {
                using (var repo = new Repository(repoDir))
                {
                    var trackedBranch = repo.Head.TrackedBranch;

                    Commit originHeadCommit = repo.ObjectDatabase.FindMergeBase(repo.Branches[trackedBranch.FriendlyName].Tip, repo.Head.Tip);
                    repo.Reset(ResetMode.Hard, originHeadCommit,
                        new CheckoutOptions
                        {
                            OnCheckoutProgress = (clonePath, completed, total) => CheckoutProgress(clonePath, completed, total)
                        });
                }
            }
            catch
            {
                Task.Run(() =>
                {
                    Repository.Clone("https://github.com/snesrev/sm.git", repoDir,
                        new CloneOptions
                        {
                            OnCheckoutProgress = (clonePath, completed, total) => CheckoutProgress(clonePath, completed, total)
                        });
                });
            }

            while (!Directory.Exists(repoDir))
            {
                Application.DoEvents();
            }

            do
            {
                progBar.Value = progress;
                progBar.Maximum = max;
            } while (progress < max);

            this.Close();
        }

        public void CheckoutProgress(string path, int completed, int total)
        {
            max = total;
            progress = completed;
        }

        private void downloadTCC(object sender, EventArgs e)
        {
            this.Refresh();

            downloadZip("tcc", "TCC.zip", new Uri("https://github.com/FitzRoyX/tinycc/releases/download/tcc_20221020/tcc_20221020.zip"));

            this.Close();
        }

        private void downloadSDL2(object sender, EventArgs e)
        {
            this.Refresh();

            downloadZip("SDL2-2.24.1", "SDL2.zip", new Uri("https://github.com/libsdl-org/SDL/releases/download/release-2.24.1/SDL2-devel-2.24.1-VC.zip"));

            this.Close();
        }

        private void downloadPython(object sender, EventArgs e)
        {
            this.Refresh();

            downloadZip("tables", "Python.zip", new Uri("https://www.python.org/ftp/python/3.10.7/python-3.10.7-embed-win32.zip"));

            this.Close();
        }

        private void downloadZip(string folder, string filename, Uri uri)
        {
            var directory = Path.Combine(Program.third_partyDir, folder);
            var zip = Path.Combine(Program.third_partyDir, filename);

            if (File.Exists(zip)) File.Delete(zip);
            if (Directory.Exists(directory)) Directory.Delete(directory, true);

            if (!IsConnectedToInternet())
            {
                MessageBox.Show("Unable to connect to the internet.\n\nPlease ensure you have a stable internet connection before downloading TCC files.",
                    "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            Task.Run(() =>
            {
                using (var client = new WebClient())
                {
                    if (!Directory.Exists(Program.third_partyDir))
                    {
                        Directory.CreateDirectory(Program.third_partyDir);
                    }
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgress);
                    client.DownloadFileAsync(uri, zip);
                }
            });

            while (!File.Exists(zip))
            {
                Application.DoEvents();
            }

            progBar.Maximum = 100;

            do
            {
                progBar.Value = progress;
            } while (progress < 100);

            this.updateLabel.Text = "Extracting " + filename + " to " + folder + "...";

            Task.Run(() =>
            {
                bool unzipped = false;
                do
                {
                    try
                    {
                        if (filename.Equals("Python.zip")) ZipFile.ExtractToDirectory(zip, Path.Combine(Program.repoDir, "tables"), true);
                        else ZipFile.ExtractToDirectory(zip, Program.third_partyDir, true);
                        unzipped = true;
                    }
                    catch { }
                } while (!unzipped);
            }).Wait();

            File.Delete(zip);
        }

        private void downloadPip(object sender, EventArgs e)
        {
            this.Refresh();

            var folder = "python";
            var filename = "get-pip.py";
            Uri uri = new Uri("https://bootstrap.pypa.io/get-pip.py");

            var directory = Path.Combine(Program.repoDir, "tables");
            var destination = Path.Combine(Program.repoDir, "tables", filename);

            if (File.Exists(destination)) File.Delete(destination);

            if (!IsConnectedToInternet())
            {
                MessageBox.Show("Unable to connect to the internet.\n\nPlease ensure you have a stable internet connection before downloading TCC files.",
                    "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            Task.Run(() =>
            {
                using (var client = new WebClient())
                {
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgress);
                    client.DownloadFileAsync(uri, destination);
                }
            });

            while (!File.Exists(destination))
            {
                Application.DoEvents();
            }

            progBar.Maximum = 100;

            do
            {
                progBar.Value = progress;
            } while (progress < 100);

            this.Close();
        }

        private void downloadProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            progress = e.ProgressPercentage;
        }

        public static bool IsConnectedToInternet()
        {
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send("github.com", 10000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            try
            {
                PingReply reply = p.Send("python.org", 10000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            try
            {
                PingReply reply = p.Send("google.com", 10000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }

            return false;
        }

        private Boolean checkHash(string file)
        {
            using (SHA256Managed sha256Hasher = new SHA256Managed())
            using (FileStream stream = new FileStream(file, FileMode.Open))
            using (BufferedStream buffer = new BufferedStream(stream))
            {
                byte[] hash = sha256Hasher.ComputeHash(buffer);
                StringBuilder hashString = new StringBuilder(2 * hash.Length);
                foreach (byte b in hash)
                {
                    hashString.AppendFormat("{0:x2}", b);
                }

                if (hashString.ToString().ToUpper() == "12B77C4BC9C1832CEE8881244659065EE1D84C70C3D29E6EAF92E6798CC2CA72") return true;
            }
            return false;
        }

        private ProgressBar progBar;
        private Label updateLabel;
    }
}