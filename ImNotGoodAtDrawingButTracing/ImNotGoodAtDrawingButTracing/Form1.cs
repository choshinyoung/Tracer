using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace ImNotGoodAtDrawingButTracing
{
    public partial class Form1 : Form
    {
        Thread KeyInputThread;
        private bool CapsLockPressed;

        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CapsLockPressed = IsKeyLocked(Keys.CapsLock);

            KeyInputThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(200);

                    bool tmp = IsKeyLocked(Keys.CapsLock);

                    Invoke((MethodInvoker)delegate ()
                    {
                        UpdateStyles();
                    });

                    CapsLockPressed = tmp;
                }
            });
            KeyInputThread.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyInputThread.Abort();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;

                if (CapsLockPressed)
                {
                    cp.ExStyle |= 0x80000 | 0x20;
                    Opacity = .3;
                    TopMost = true;
                }
                else
                {
                    Opacity = 1;
                    TopMost = false;
                }

                return cp;
            }
        }

        private void FindImageButton_Click(object sender, EventArgs e)
        {
            DialogResult res = FileDialog.ShowDialog();

            if (res == DialogResult.OK)
            {
                ImageFileTextBox.Text = FileDialog.FileName;
            }
        }

        private void LoadFileImage_Click(object sender, EventArgs e)
        {
            string path = ImageFileTextBox.Text;

            if (File.Exists(path) && (path.EndsWith(".png") || path.EndsWith(".jpg") || path.EndsWith(".bmp")))
            {
                ImageBox.Image = Image.FromFile(path);
            }
        }

        private void LoadUrlImageButton_Click(object sender, EventArgs e)
        {
            string url = ImageUrlTextBox.Text;

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    var req = (HttpWebRequest)WebRequest.Create(url);
                    req.Method = "HEAD";
                    using (var resp = req.GetResponse())
                    {
                        using (Stream stream = webClient.OpenRead(url))
                        {
                            ImageBox.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch { }
            }
        }
    }
}