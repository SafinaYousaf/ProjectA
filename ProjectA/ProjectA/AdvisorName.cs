﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjectA
{
    public partial class AdvisorName : Form
    {
        public AdvisorName()
        {
            InitializeComponent();
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void AdvisorName_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load("C:\\Users\\M.ALI\\Documents\\GitHub\\ProjectA\\ProjectA\\ProjectA\\CrystalReport5.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();

        }

        private void AdvisorName_FormClosed(object sender, FormClosedEventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
