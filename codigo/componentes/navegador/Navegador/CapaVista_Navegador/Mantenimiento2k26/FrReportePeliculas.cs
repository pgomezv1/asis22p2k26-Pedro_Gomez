using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using CapaControlador_Seguridad;

namespace CapaVista_Navegador.reportes
{
    public partial class FrReportePeliculas : Form
    {
        private ClsModeloEmpleado empleado = new ClsModeloEmpleado();
        public FrReportePeliculas()
        {
            InitializeComponent();
        }
        //
        private void FrReporteEmpleados_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", empleado.SeguridadMetObtenerTodos());
            reportViewer1.LocalReport.ReportEmbeddedResource = "CapaVista_Navegador.reportes.ReporteEmpleado.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource1);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
