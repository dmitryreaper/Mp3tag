using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TagEditor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlgmail = "https://gmail.com";

            // Открываем URL в браузере по умолчанию
            Process.Start(new ProcessStartInfo
            {
                FileName = urlgmail,
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string urlgit = "https://github.com/dmitryreaper";

            // Открываем URL в браузере по умолчанию
            Process.Start(new ProcessStartInfo
            {
                FileName = urlgit,
                UseShellExecute = true
            });
        }
    }
}
