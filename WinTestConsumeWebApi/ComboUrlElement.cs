using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTestConsumeWebApi
{
    public class ComboUrlElement
    {
        public string UrlSrv { get; set; }

        public string DescSrv { get; set; }

        public ComboUrlElement()
        {
            this.UrlSrv = this.DescSrv = string.Empty;
        }

        public ComboUrlElement(string pUrlSrv, string pDescSrv)
        {
            this.UrlSrv = pUrlSrv;
            this.DescSrv = pDescSrv;
        }

        public override string ToString()
        {
            return this.DescSrv;
        }
    }
}
