﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteConsultaSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cONSULTA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaSQL1 frm = new FrmConsultaSQL1();
            frm.ShowDialog();
        }

        private void cONSULTA2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaSQL2 frm = new FrmConsultaSQL2();
            frm.ShowDialog();
        }
    }
}
