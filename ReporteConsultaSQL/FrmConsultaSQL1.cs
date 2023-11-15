using System;
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
    public partial class FrmConsultaSQL1 : Form
    {

        Helper helper = new Helper();
        public FrmConsultaSQL1()
        {
            InitializeComponent();
            helper=new Helper();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void cargarTabla()
        {
            DataTable dt = new DataTable();
            dt = helper.Consultar("sp_reportt");
            dgvconsulta1.DataSource = dt;
            dgvconsulta1.AutoResizeColumns();

        }

        private void dgvconsulta1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvconsulta1.AutoResizeColumns();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmConsultaSQL1_Load(object sender, EventArgs e)
        {
            txtConsulta.Enabled = false;
            txtEnunciado.Enabled = false;
        }
    }
}
