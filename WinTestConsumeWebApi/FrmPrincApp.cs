using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestConsumeWebApi
{
    public partial class FrmPrincApp : Form
    {
        public FrmPrincApp()
        {
            InitializeComponent();
        }

        private void butDo_Click(object sender, EventArgs e)
        {
            string url = "";
            var json = new WebClient().DownloadString(url);
            dynamic m = JsonConvert.DeserializeObject(json);
                
        }
    }
}
