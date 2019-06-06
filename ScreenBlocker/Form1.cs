using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenBlocker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern void SetWindowDisplayAffinity(IntPtr handle, int flag);

        public Form1()
        {
            InitializeComponent();
            SetWindowDisplayAffinity(Handle, 1);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
