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

namespace zCheatDownload
{
    public partial class GhostClients : Form
    {
        public GhostClients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://github.com/weynn/Exelon/blob/main/exelon.exe?raw=true", UseShellExecute = true });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://cdn.discordapp.com/attachments/826610689182400543/829005214249910352/lith-lite_protected.exe", UseShellExecute = true });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://jelte.vip/download/dl/koid", UseShellExecute = true });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://jelte.vip/download/dl/itami", UseShellExecute = true });
        }
    }
}
