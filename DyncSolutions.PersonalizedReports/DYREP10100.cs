using Microsoft.Dexterity.Applications;
using Microsoft.Dexterity.Shell;
using System;
using System.Data;
using System.Windows.Forms;

namespace DyncSolutions.PersonalizedReports
{
    public partial class DYREP10100 : DexUIForm
    {
        SqlDbConnect con;
        string aReportId;
        string aReportName;
        string aReportSql;
        private readonly string aReportDescription;
        string aReportPath;
        private ListViewItem listDatos;
        private string aParameter1;
        private string aParameter2;
        private string aParameter3;
        private string aParameter4;
        private string aParameter5;
        private string aParameter6;
        public DYREP10100()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(aReportSql))
                MessageBox.Show("La consulta de SQL no esta configurada correctamente", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string query = GenerarQuery();
                if (!string.IsNullOrEmpty(query))
                    new ReportView(aReportPath, aReportId, aReportName, query, aParameter1, aParameter2, aParameter3, aParameter4, aParameter5, aParameter6).Show();
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            lsvImprimir.Items.Clear();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboReporte.Text))
            {
                new DYREP10101(cboSerie.Text.Trim(), aReportId, cboReporte.Text.Trim(), aReportSql, aReportPath, "").Show();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lsvOpciones.SelectedItems != null && lsvOpciones.SelectedItems.Count > 0)
                new DYREP10101(cboSerie.Text.Trim(), aReportId, cboReporte.Text.Trim(), aReportSql, aReportPath, lsvOpciones.SelectedItems[0].SubItems[1].Text.Trim()).Show();
            else
                MessageBox.Show("Debe de seleccionar la opcion que desea modificar", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (lsvOpciones.SelectedItems != null && lsvOpciones.SelectedItems.Count > 0)
            {
                lsvImprimir.Items.Clear();
                var listDatos = new ListViewItem();
                listDatos.SubItems.Add(lsvOpciones.SelectedItems[0].SubItems[1].Text.Trim().ToUpper());
                lsvImprimir.Items.Add(listDatos);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                cboSerie.SelectedIndex = 0;
                cboReporte.Items.Clear();
                lsvOpciones.Items.Clear();
                lsvImprimir.Items.Clear();
                CargarReportes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvOpciones.Items.Count > 0)
            {
                for (int i = 0; i < lsvOpciones.Items.Count; i++)
                {
                    if (lsvOpciones.Items[i].Selected)
                    {
                        if (MessageBox.Show($"Esta seguro que desea eliminar la opcion {lsvOpciones.Items[i].SubItems[1].Text.Trim()}",
                            "Microsoft Dynamics GP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con = new SqlDbConnect();
                            con.SqlQuery($"DEVELOPMENT.dbo.DYREP10100SD '{Dynamics.Globals.IntercompanyId.Value}','{cboSerie.Text.Trim()}','{cboReporte.Text.Trim()}','{lsvOpciones.Items[i].SubItems[1].Text.Trim()}'");
                            con.NonQueryEx();
                        }
                        lsvOpciones.Items[i].Remove();
                        CargarOpciones();
                        return;
                    }
                }
            }
            else
                MessageBox.Show("Debe de seleccionar la opcion que desea eliminar", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void cboReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReporte.Text != aReportDescription)
                CargarOpciones();
        }
        private void cboSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboReporte.Items.Clear();
                lsvOpciones.Items.Clear();
                lsvImprimir.Items.Clear();
                CargarReportes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DYREP10100_Load(object sender, EventArgs e)
        {
            con = new SqlDbConnect();
            con.SqlQuery($"DEVELOPMENT.dbo.DYREPPATHS1");
            aReportPath = con.QueryEx().Rows[0][0].ToString();
            CargarSeries();
        }

        private void CargarSeries()
        {
            con = new SqlDbConnect();
            cboSerie.SelectedIndex = 0;
            con.SqlQuery($"DEVELOPMENT.dbo.DYREP00800S1 '{Dynamics.Globals.IntercompanyId.Value}','{Dynamics.Globals.UserId.Value}'");
            var table = con.QueryEx();
            if (table.Rows.Count > 0)
            {
                cboSerie.Items.Clear();
                foreach (DataRow item in table.Rows)
                    cboSerie.Items.Add(item[0].ToString());

                if (cboSerie.Items.Count > 0)
                {
                    cboSerie.SelectedIndex = 0;
                    CargarReportes();
                }
            }
        }
        private void CargarOpciones()
        {
            con = new SqlDbConnect();
            lsvImprimir.Items.Clear();
            lsvOpciones.Items.Clear();
            aReportId = "";
            aReportName = "";
            aReportSql = "";
            if (!string.IsNullOrEmpty(cboReporte.Text))
            {
                con.SqlQuery($"DEVELOPMENT.dbo.DYREP10100S1 '{Dynamics.Globals.IntercompanyId.Value}','{cboSerie.Text.Trim()}','{cboReporte.Text.Trim()}'");
                var table = con.QueryEx();
                foreach (DataRow item in table.Rows)
                {
                    var listDatos = new ListViewItem();
                    listDatos.SubItems.Add(item[0].ToString().ToUpper().Trim());
                    lsvOpciones.Items.Add(listDatos);
                }

                con.SqlQuery($"DEVELOPMENT.dbo.DYREP10000S3 '{Dynamics.Globals.IntercompanyId.Value}','{cboSerie.Text.Trim()}','{cboReporte.Text.Trim()}'");
                table = con.QueryEx();
                if (table.Rows.Count > 0)
                {
                    aReportId = table.Rows[0][0].ToString().Trim();
                    aReportName = table.Rows[0][1].ToString().Trim();
                    aReportSql = table.Rows[0][2].ToString().Trim();
                }
            }
        }
        private void CargarReportes()
        {
            cboReporte.Items.Clear();
            con.SqlQuery($"DEVELOPMENT.dbo.DYREP10000S4 '{Dynamics.Globals.IntercompanyId.Value}', '{Dynamics.Globals.UserId.Value}', '{cboSerie.Text.Trim()}'");
            var table = con.QueryEx();
            foreach (DataRow item in table.Rows)
                cboReporte.Items.Add(item[0].ToString().Trim().ToUpper());
            if (cboReporte.Items.Count > 0)
            {
                cboReporte.SelectedIndex = 0;
                if (!string.IsNullOrEmpty(cboReporte.Text))
                    CargarOpciones();
            }
        }
        private string GenerarQuery()
        {
            string aReport = "";
            lsvIntervalos = new ListView();

            for (int i = 0; i < lsvImprimir.Items.Count; i++)
            {
                if (lsvImprimir.Items[i].Selected)
                {
                    aReport = lsvImprimir.Items[0].SubItems[1].Text.Trim();
                    break;
                }
            }

            if (string.IsNullOrEmpty(aReport))
            {
                MessageBox.Show("Debe de seleccionar una opcion para imprimir", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }

            con.SqlQuery($"DEVELOPMENT.dbo.DYREP10101S1 '{Dynamics.Globals.IntercompanyId.Value}','{cboSerie.Text.Trim()}','{cboReporte.Text.Trim()}','{aReport.Trim()}'");
            var table = con.QueryEx();
            foreach (DataRow item in table.Rows)
            {
                listDatos = new ListViewItem();
                listDatos.SubItems.Add(item[0].ToString().Trim());
                listDatos.SubItems.Add(item[1].ToString().Trim());
                listDatos.SubItems.Add(item[2].ToString().Trim());
                listDatos.SubItems.Add(item[3].ToString().Trim());
                listDatos.SubItems.Add(item[4].ToString().Trim());
                listDatos.SubItems.Add(item[5].ToString().Trim());
                listDatos.SubItems.Add(item[6].ToString().Trim());
                lsvIntervalos.Items.Add(listDatos);
            }
            string str3 = "";
            string str4 = "";

            aParameter1 = "";
            aParameter2 = "";
            aParameter3 = "";
            aParameter4 = "";
            aParameter5 = "";
            aParameter6 = "";

            for (int i = 0; i < lsvIntervalos.Items.Count; i++)
            {
                string truePart;
                if (lsvIntervalos.Items[0].SubItems[2].Text.Trim() == lsvIntervalos.Items[i].SubItems[2].Text.Trim())
                    truePart = " OR ";
                else
                    truePart = " AND ";

                if (!string.IsNullOrEmpty(lsvIntervalos.Items[i].SubItems[6].Text.Trim()))
                    str4 += $"{(!string.IsNullOrEmpty(str4.Trim()) ? truePart : "")}{(truePart == " AND " ? "(" : "")}{lsvIntervalos.Items[i].SubItems[6].Text.Trim().Replace("[$Parametro1$]", lsvIntervalos.Items[i].SubItems[3].Text.Trim()).Replace("[$Parametro2$]", lsvIntervalos.Items[i].SubItems[4].Text.Trim())}";
                str3 += $"{(!string.IsNullOrEmpty(str3.Trim()) ? truePart : "")}{(truePart == " AND " ? "(" : "")}{lsvIntervalos.Items[i].SubItems[5].Text.Trim().Replace("[$Parametro1$]", lsvIntervalos.Items[i].SubItems[3].Text.Trim()).Replace("[$Parametro2$]", lsvIntervalos.Items[i].SubItems[4].Text.Trim())}";

                switch (i)
                {
                    case 0:
                        aParameter1 = lsvIntervalos.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 1:
                        aParameter2 = lsvIntervalos.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 2:
                        aParameter3 = lsvIntervalos.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 3:
                        aParameter4 = lsvIntervalos.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 4:
                        aParameter5 = lsvIntervalos.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 5:
                        aParameter6 = lsvIntervalos.Items[i].SubItems[1].Text.Trim();
                        break;
                    default:
                        break;
                }
            }

            return aReportSql.Trim().Replace("[$Parametros$]", $"'{aReportId.Trim()}','{str3.Trim()}','{str4.Trim()}','{Dynamics.Globals.IntercompanyId.Value}'");
        }
    }
}
