using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class ReportdataSource
    {
        private string p;
        private System.Data.DataTable dt;

        public ReportdataSource(string p, System.Data.DataTable dt)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.dt = dt;
        }
    }
}
