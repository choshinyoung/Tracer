using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ImNotGoodAtDrawingButTracing
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetKeyState(int keyCode);

        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        private IntPtr hook = IntPtr.Zero;

        private bool CapsLockPressed;

        public Form1()
        {
            CapsLockPressed = (GetKeyState((int)Keys.CapsLock) & 0xffff) != 0;

            InitializeComponent();

            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr hInstance = LoadLibrary("User32");

            hook = SetWindowsHookEx(WH_KEYBOARD_LL, HookProc, hInstance, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnhookWindowsHookEx(hook);
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

        private IntPtr HookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
            
                if (vkCode.ToString() == "20")
                {
                    CapsLockPressed = (GetKeyState((int)Keys.CapsLock) & 0xffff) == 0;
                    UpdateStyles();
                }
            }

            return CallNextHookEx(hook, code, (int)wParam, lParam);
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