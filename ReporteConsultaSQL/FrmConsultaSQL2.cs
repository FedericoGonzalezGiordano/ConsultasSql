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
    public partial class FrmConsultaSQL2 : Form
    {
        Helper Helper;
        public FrmConsultaSQL2()
        {
            InitializeComponent();
            Helper=new Helper();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargarGrilla();
            
        }
        
        private void cargarGrilla()
        {
            int anio;
            if (int.TryParse(TxtAnio.Text, out anio))
            {
                try
                {
                    DataTable dt = new DataTable();
                    Parametro p = new Parametro("@año", anio);
                    dt = Helper.Consultar("SP_CLIENTES_MES_AÑO", p);

                    DgvConsulta2.Rows.Clear();
                    DgvConsulta2.Columns.Clear(); 

                    
                    DgvConsulta2.Columns.Add("Cantidad", "Cantidad");
                    DgvConsulta2.Columns.Add("Mes", "Mes");
                    DgvConsulta2.Columns.Add("Año", "Año");
                    DgvConsulta2.Columns.Add("Total", "Total");
                    DgvConsulta2.Columns.Add("MayorCantidad", "Mayor Cantidad");

                    foreach (DataRow fila in dt.Rows)
                    {
                    DgvConsulta2.Rows.Add(new object[] {
                    fila["Cantidad"].ToString(),
                    fila["Mes"].ToString(),
                    fila["Año"].ToString(),
                    fila["Total"].ToString(),
                    fila["MayorCantidad"].ToString()

                });
                        DgvConsulta2.AutoResizeColumns();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la grilla: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un año válido.");
                TxtAnio.Clear();
                TxtAnio.Focus();
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void DgvConsulta2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmConsultaSQL2_Load(object sender, EventArgs e)
        {
            txtConsulta.Enabled = false;
            txtEnunciado.Enabled = false;
           
        }
    }
       







}


