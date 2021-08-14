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
            InitMyComponents();
        }

        private void InitMyComponents()
        {
            cmbServicios.Items.Add(new ComboUrlElement("https://localhost:44310/api/MyMusicAppServices/GetProductosSegunda",
                                                          "Obtener Productos de Segunda"));
            cmbServicios.Items.Add(new ComboUrlElement("https://localhost:44310/api/MyMusicAppServices/GetProdSegundaRelProdNuevo",
                                                          "Obtener Productos Segunda/Texto"));
            cmbServicios.SelectedIndex = 0;
        }

        private void butDo_Click(object sender, EventArgs e)
        {

            try
            {
                var cmbElem = (ComboUrlElement)cmbServicios.SelectedItem;
                string url = cmbElem.UrlSrv + (txtParameters.Text.Length > 0 ? "?" : string.Empty) +
                                             txtParameters.Text;
                txtUrlFinal.Text = url;
                var json = new WebClient().DownloadString(url);
                dynamic m = JsonConvert.DeserializeObject(json);
                txtOutput.Text = json;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
