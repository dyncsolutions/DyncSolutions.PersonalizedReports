using CrystalDecisions.CrystalReports.Engine;
using Microsoft.Dexterity.Applications;
using System;
using System.Windows.Forms;

namespace DyncSolutions.PersonalizedReports
{
    public partial class ReportView : Form
    {
        private string ReportHeader;
        private string CompanyNamex;
        private string UserIdx;
        private string ReportIdx;
        private string ReportNamex;
        private string ReportSQLx;
        private string ReportPathx;
        private string Parameter1x;
        private string Parameter2x;
        private string Parameter3x;
        private string Parameter4x;
        private string Parameter5x;
        private string Parameter6x;

        public ReportView(string ReportPath, string ReportId, string ReportName, string ReportSQL, string Parameter1, string Parameter2, string Parameter3, string Parameter4, string Parameter5, string Parameter6)
        {
            CompanyNamex = Dynamics.Globals.CompanyName;
            UserIdx = Dynamics.Globals.UserId;
            ReportIdx = ReportId;
            ReportNamex = ReportName;
            ReportSQLx = ReportSQL;
            Parameter1x = Parameter1;
            Parameter2x = Parameter2;
            Parameter3x = Parameter3;
            Parameter4x = Parameter4;
            Parameter5x = Parameter5;
            Parameter6x = Parameter6;
            ReportPathx = ReportPath;
            InitializeComponent();
        }

        private void ReportView_Load(object sender, EventArgs e)
        {
            this.Text = "Reporte: - " + ReportNamex.Trim();
            StartReport();
        }

        private void StartReport()
        {
            if (string.IsNullOrEmpty(ReportPathx))
            {
                MessageBox.Show("La ubicacion de los reportes no ha sido configurada", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                if (ReportPathx.Trim().Substring(ReportPathx.Trim().Length - 1, 1) != @"\")
                    ReportPathx += @"\";
            }

            ReportDocument document = new ReportDocument();

            try
            {
                var con = new SqlDbConnect();

                ReportHeader = "SELECT '" + CompanyNamex.Trim() + "' CompName, '" + ReportNamex.Trim() + "' Titulo, '" + Parameter1x.Trim() + "' Parametro1, '" + Parameter2x.Trim() + "' Parametro2, '" + Parameter3x.Trim() + "' Parametro3, '" + Parameter4x.Trim() + "' Parametro4, '" + Parameter5x.Trim() + "' Parametro5, '" + Parameter6x.Trim() + "' Parametro6, '" + UserIdx.Trim() + "' Usuario, 1 Marca";
                con.SqlQuery(ReportHeader);
                var cabecera = con.QueryEx();
                con.SqlQuery(ReportSQLx);
                var detalle = con.QueryEx();

                if (detalle.Rows.Count == 0)
                {
                    MessageBox.Show("No existen registros con los parametros suministrados para generar este reporte", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    document.Load($"{ReportPathx}{ReportIdx}.rpt");
                    document.Database.Tables[0].SetDataSource(cabecera);
                    document.Database.Tables[1].SetDataSource(detalle);
                    Viewer.ReportSource = document;
                    Viewer.Show();
                    Viewer.Cursor = Cursors.Arrow;
                    WindowState = FormWindowState.Maximized;
                    Viewer.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
