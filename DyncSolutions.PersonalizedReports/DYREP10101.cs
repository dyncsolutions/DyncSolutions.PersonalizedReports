using Microsoft.Dexterity.Applications;
using Microsoft.Dexterity.Shell;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Windows.Forms;

namespace DyncSolutions.PersonalizedReports
{
    public partial class DYREP10101 : DexUIForm
    {
        SqlDbConnect con;
        private bool aIntervaloActivo;
        private int aFieldType;
        private string aSqlFind;
        private string aSqlParameters;
        private string aSqlBalIni;
        private int aOptionAlternative;
        private string aOptionName;
        private string aSerie;
        private string aReportId;
        private string aReportName;
        private string aReportSql;
        private string aReportPath;
        private ListViewItem listDatos;
        private string aParameter1;
        private string aParameter2;
        private string aParameter3;
        private string aParameter4;
        private string aParameter5;
        private string aParameter6;
        public DYREP10101(string serie, string reportId, string reportName, string reportSql, string reportPath, string optionName)
        {
            aSerie = serie;
            aReportId = reportId;
            aReportName = reportName;
            aReportSql = reportSql;
            aOptionName = optionName;
            aReportPath = reportPath;
            InitializeComponent();
            CenterToScreen();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboOpcion.Text))
            {
                con = new SqlDbConnect();
                con.SqlQuery($"DEVELOPMENT.dbo.DYREP10100SI '{Dynamics.Globals.IntercompanyId.Value}','{aSerie}','{aReportName}','{cboOpcion.Text.Trim()}'");
                con.NonQueryEx();
                con.SqlQuery($"DEVELOPMENT.dbo.DYREP10101SD '{Dynamics.Globals.IntercompanyId.Value}','{aSerie}','{aReportName}','{cboOpcion.Text.Trim()}'");
                con.NonQueryEx();

                for (int i = 0; i < lsvOpciones.Items.Count; i++)
                {
                    con.SqlQuery($"DEVELOPMENT.dbo.DYREP10101SI '{Dynamics.Globals.IntercompanyId.Value}','{aSerie}','{aReportName}','{cboOpcion.Text.Trim()}'," +
                        $"'{lsvOpciones.Items[i].SubItems[1].Text.Trim()}','{lsvOpciones.Items[i].SubItems[2].Text.Trim()}','{lsvOpciones.Items[i].SubItems[3].Text.Trim()}'," +
                        $"'{lsvOpciones.Items[i].SubItems[4].Text.Trim()}','{lsvOpciones.Items[i].SubItems[5].Text.Trim()}','{lsvOpciones.Items[i].SubItems[6].Text.Trim()}'," +
                        $"'{lsvOpciones.Items[i].SubItems[7].Text.Trim()}'");
                    con.NonQueryEx();
                }
                cboOpcion.Text = "";
                btnClear_Click(sender, e);
                CargarOpciones();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                aOptionAlternative = cboOpcion.SelectedIndex;
                cboIntervalo.Items.Clear();
                lsvOpciones.Items.Clear();
                CargarIntervalos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboOpcion.Text))
            {
                if (MessageBox.Show($"Esta seguro que desea eliminar la opcion {cboOpcion.Text.Trim()}", "Microsoft Dynamics GP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con = new SqlDbConnect();
                    con.SqlQuery($"DEVELOPMENT.dbo.DYREP10100SD '{Dynamics.Globals.IntercompanyId.Value}','{aSerie}','{aReportName}','{cboOpcion.Text.Trim()}'");
                    con.NonQueryEx();
                    cboOpcion.Text = "";
                    btnClear_Click(sender, e);
                    CargarOpciones();
                }
            }
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(aReportSql))
               MessageBox.Show("La consulta SQL para la generacion de este reporte aun no esta completamente configurada", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                string query = GenerarQuery();
                if (!string.IsNullOrEmpty(query))
                    new ReportView(aReportPath, aReportId, aReportName, query, aParameter1, aParameter2, aParameter3, aParameter4, aParameter5, aParameter6).Show();
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            if ((!string.IsNullOrEmpty(txtDesde.Text) && string.IsNullOrEmpty(txtHasta.Text) && !dtpDesde.Visible) && dtpHasta.Visible)
            {
                txtDesde.Text = txtHasta.Text;
                dtpDesde.Value = dtpHasta.Value;
            }
            if (!string.IsNullOrEmpty(txtDesde.Text) && string.IsNullOrEmpty(txtHasta.Text))
                txtHasta.Text = txtDesde.Text;
            if (string.IsNullOrEmpty(txtDesde.Text) && !string.IsNullOrEmpty(txtHasta.Text))
                txtDesde.Text = txtHasta.Text;
            if (DateTime.Compare(dtpDesde.Value, dtpHasta.Value) > 0)
                dtpHasta.Value = dtpDesde.Value;
            switch (aFieldType)
            {
                case 0:
                case 1:
                    if (string.IsNullOrEmpty(txtDesde.Text))
                    {
                        MessageBox.Show("No es posible insertar el intervalo seleccionado, ya que no se ha indicado datos para el filtro", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                    }
                    if (Operators.CompareString(txtDesde.Text.Trim(), txtHasta.Text.Trim(), false) > 0)
                    {
                        MessageBox.Show("El rango desde no puede ser mayor al rango hasta", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                    }
                    break;
                case 2:
                    if (DateTime.Compare(dtpDesde.Value, dtpHasta.Value) > 0)
                    {
                        MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta", "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isValid = false;
                    }
                    break;
            }
            if (isValid)
            {
                int type = 0;
                string filtroDesde = "";
                string filtroHasta = "";
                if (!dtpDesde.Visible && dtpHasta.Visible)
                {
                    dtpDesde.Value = new DateTime(1900, 1, 1);
                    type = 2;
                }
                if (dtpDesde.Visible && !dtpHasta.Visible)
                {
                    dtpHasta.Value = new DateTime(1900, 1, 1);
                    type = 1;
                }
                if (!txtDesde.Visible & txtHasta.Visible)
                {
                    txtDesde.Text = "";
                    type = 2;
                }
                if (txtDesde.Visible & !txtHasta.Visible)
                {
                    txtHasta.Text = "";
                    type = 1;
                }
                if (type == 0 | type == 1)
                    filtroDesde = $" Desde {(txtDesde.Text.Trim().Length > 0 ? txtDesde.Text.Trim() : dtpDesde.Value.ToString("dd/MM/yyyy"))}";
                if (type == 0 | type == 2)
                    filtroHasta = $" Hasta {(txtHasta.Text.Trim().Length > 0 ? txtHasta.Text.Trim() : dtpHasta.Value.ToString("dd/MM/yyyy"))}";

                listDatos = new ListViewItem();
                listDatos.SubItems.Add($"{cboIntervalo.Text.Trim()}{filtroDesde}{filtroHasta}");
                listDatos.SubItems.Add(cboIntervalo.Text.Trim());
                listDatos.SubItems.Add(txtDesde.Text.Trim().Length > 0 ? txtDesde.Text.Trim() : dtpDesde.Value.ToString("yyyy/MM/dd"));
                listDatos.SubItems.Add(txtHasta.Text.Trim().Length > 0 ? txtHasta.Text.Trim() : dtpHasta.Value.ToString("yyyy/MM/dd"));
                listDatos.SubItems.Add(aSqlParameters);
                listDatos.SubItems.Add(aSqlBalIni);
                listDatos.SubItems.Add(aFieldType.ToString());
                lsvOpciones.Items.Add(listDatos);
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsvOpciones.Items.Count; i++)
            {
                if (lsvOpciones.Items[i].Selected)
                {
                    lsvOpciones.Items[i].Remove();
                    break;
                }
            }
        }
        private void cboIntervalo_SelectedIndexChanged(object sender, EventArgs e)
        {
            aIntervaloActivo = false;
            con = new SqlDbConnect();
            if (!string.IsNullOrEmpty(cboIntervalo.Text.Trim()))
            {
                con.SqlQuery($"DEVELOPMENT.dbo.DYREP10001S5 '{Dynamics.Globals.IntercompanyId.Value}','{aSerie.Trim()}','{aReportName}','{cboIntervalo.Text.Trim()}'");
                var table = con.QueryEx();
                if (table.Rows.Count > 0)
                {
                    aIntervaloActivo = true;
                    aFieldType = Convert.ToInt32(table.Rows[0][0]);
                    aSqlFind = Convert.ToString(table.Rows[0][1]);
                    aSqlParameters = Convert.ToString(table.Rows[0][2]);
                    aSqlBalIni = Convert.ToString(table.Rows[0][3]);
                    txtDesde.Visible = false;
                    txtHasta.Visible = false;
                    btnLookDesde.Visible = false;
                    btnLookHasta.Visible = false;
                    cboDesde.Visible = false;
                    cboHasta.Visible = false;
                    dtpDesde.Visible = false;
                    dtpHasta.Visible = false;
                    Refresh();
                    switch (aFieldType)
                    {
                        case 0:
                            txtDesde.Visible = true;
                            txtHasta.Visible = true;
                            break;
                        case 1:
                            txtDesde.Visible = true;
                            txtHasta.Visible = true;
                            if (!string.IsNullOrEmpty(aSqlFind))
                            {
                                btnLookDesde.Visible = true;
                                btnLookHasta.Visible = true;
                            }
                            break;
                        case 2:
                            cboDesde.Visible = true;
                            cboHasta.Visible = true;
                            dtpDesde.Visible = true;
                            dtpHasta.Visible = true;
                            cboDesde.SelectedIndex = 0;
                            cboHasta.SelectedIndex = 0;
                            break;
                    }
                    switch (Convert.ToInt32(table.Rows[0][4]))
                    {
                        case 1:
                            txtHasta.Visible = false;
                            btnLookHasta.Visible = false;
                            dtpHasta.Visible = false;
                            cboHasta.Visible = false;
                            break;
                        case 2:
                            txtDesde.Visible = false;
                            btnLookDesde.Visible = false;
                            dtpDesde.Visible = false;
                            cboDesde.Visible = false;
                            break;

                    }
                }
            }

            Refresh();
            Application.DoEvents();
        }
        private void cboOpcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOpcion.SelectedIndex != aOptionAlternative)
                btnClear_Click(sender, e);
        }
        private void cboOpcion_KeyPress(object sender, KeyPressEventArgs e) { try { e.Handled = GPAddIn.ValidarCaracter(cboOpcion.Tag.ToString(), e.KeyChar, cboOpcion.Text.ToString(), 0); } catch { } }
        private void cboHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpHasta.Visible = false;
            dtpHasta.Value = DateTime.Now;
            switch (cboDesde.SelectedIndex)
            {
                case 0:
                    dtpHasta.Visible = true;
                    break;
                case 2:
                    dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    break;
                case 3:
                    dtpHasta.Value = DateAndTime.DateAdd(DateInterval.Day, (double)(0 - DateTime.Now.Day), DateAndTime.DateAdd(DateInterval.Day, 1, DateTime.Now));
                    break;
                default:
                    break;
            }

            Refresh();
        }
        private void cboDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDesde.Visible = false;
            dtpDesde.Value = DateTime.Now;
            switch (cboDesde.SelectedIndex)
            {
                case 0:
                    dtpDesde.Visible = true;
                    break;
                case 2:
                    dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    break;
                case 3:
                    dtpDesde.Value = DateAndTime.DateAdd(DateInterval.Day, (double)(0 - DateTime.Now.Day), DateAndTime.DateAdd(DateInterval.Day, 1, DateTime.Now));
                    break;
                default:
                    break;
            }

            Refresh();
        }

        private void CargarIntervalos()
        {
            cboIntervalo.Items.Clear();
            lsvOpciones.Items.Clear();
            if (!string.IsNullOrEmpty(aReportName))
            {
                con.SqlQuery($"DEVELOPMENT.dbo.DYREP10001S4 '{Dynamics.Globals.IntercompanyId.Value}','{aSerie.Trim()}','{aReportName}'");
                var table = con.QueryEx();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                        cboIntervalo.Items.Add(item[0].ToString());
                    if (cboIntervalo.Items.Count > 0)
                        cboIntervalo.SelectedIndex = 0;
                }

                if (!string.IsNullOrEmpty(cboOpcion.Text.Trim()))
                {
                    con.SqlQuery($"DEVELOPMENT.dbo.DYREP10101S1 '{Dynamics.Globals.IntercompanyId.Value}','{aSerie.Trim()}','{aReportName}','{cboOpcion.Text.Trim()}'");
                    table = con.QueryEx();
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
                        lsvOpciones.Items.Add(listDatos);
                    }
                }
            }
        }
        private void CargarOpciones()
        {
            cboOpcion.Items.Clear();
            cboIntervalo.Items.Clear();
            lsvOpciones.Items.Clear();
            con = new SqlDbConnect();
            if (!string.IsNullOrEmpty(aReportName))
            {
                con.SqlQuery($"DEVELOPMENT.dbo.DYREP10100S1 '{Dynamics.Globals.IntercompanyId.Value}','{aSerie.Trim()}','{aReportName}'");
                var table = con.QueryEx();
                if (table.Rows.Count > 0)
                {
                    foreach (DataRow item in table.Rows)
                        cboOpcion.Items.Add(item[0].ToString());
                    cboOpcion.SelectedIndex = 0;
                }
                CargarIntervalos();
            }
        }
        private string GenerarQuery()
        {
            string str3 = "";
            string str4 = "";
            aParameter1 = "";
            aParameter2 = "";
            aParameter3 = "";
            aParameter4 = "";
            aParameter5 = "";
            aParameter6 = "";

            for (int i = 0; i < lsvOpciones.Items.Count; i++)
            {
                string truePart;
                if (lsvOpciones.Items[0].SubItems[2].Text.Trim() == lsvOpciones.Items[i].SubItems[2].Text.Trim())
                    truePart = " OR ";
                else
                    truePart = " AND ";

                if (!string.IsNullOrEmpty(lsvOpciones.Items[i].SubItems[6].Text.Trim()))
                    str4 += $"{(!string.IsNullOrEmpty(str4.Trim()) ? truePart : "")}{(truePart == " AND " ? "(" : "")}{lsvOpciones.Items[i].SubItems[6].Text.Trim().Replace("[$Parametro1$]", lsvOpciones.Items[i].SubItems[3].Text.Trim()).Replace("[$Parametro2$]", lsvOpciones.Items[i].SubItems[4].Text.Trim())}";
                str3 += $"{(!string.IsNullOrEmpty(str3.Trim()) ? truePart : "")}{(truePart == " AND " ? "(" : "")}{lsvOpciones.Items[i].SubItems[5].Text.Trim().Replace("[$Parametro1$]", lsvOpciones.Items[i].SubItems[3].Text.Trim()).Replace("[$Parametro2$]", lsvOpciones.Items[i].SubItems[4].Text.Trim())}";

                switch (i)
                {
                    case 0:
                        aParameter1 = lsvOpciones.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 1:
                        aParameter2 = lsvOpciones.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 2:
                        aParameter3 = lsvOpciones.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 3:
                        aParameter4 = lsvOpciones.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 4:
                        aParameter5 = lsvOpciones.Items[i].SubItems[1].Text.Trim();
                        break;
                    case 5:
                        aParameter6 = lsvOpciones.Items[i].SubItems[1].Text.Trim();
                        break;
                    default:
                        break;
                }
            }

            return aReportSql.Trim().Replace("[$Parametros$]", $"'{aReportId.Trim()}','{str3.Trim()}','{str4.Trim()}','{Dynamics.Globals.IntercompanyId.Value}'");
        }

        private void DYREP10101_Load(object sender, EventArgs e)
        {
            txtReporte.Text = aReportName;
            CargarOpciones();
            cboOpcion.Text = aOptionName;
            if (!string.IsNullOrWhiteSpace(aOptionName))
                CargarIntervalos();
            else
                lsvOpciones.Items.Clear();
        }
        private void btnLookDesde_Click(object sender, EventArgs e)
        {
            Lookup look = new Lookup("Buscar...", aSqlFind, 0, 1);
            if (look.ShowDialog() == DialogResult.OK)
                txtDesde.Text = look.xData1.Trim();
        }
        private void btnLookHasta_Click(object sender, EventArgs e)
        {
            Lookup look = new Lookup("Buscar...", aSqlFind, 0, 1);
            if (look.ShowDialog() == DialogResult.OK)
                txtHasta.Text = look.xData1.Trim();
        }
        private void txtDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aFieldType == 0)
                e.Handled = GPAddIn.ValidarCaracter("[N] ';:[]!@#$%^&*()-_=+ABCDEFGHIJKLMNOPQRSTUVWXYZ", e.KeyChar, txtDesde.Text.ToString(), 0);
            else
                e.Handled = GPAddIn.ValidarCaracter("[A] ,'[]", e.KeyChar, txtDesde.Text.ToString(), 0);
        }
        private void txtHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (aFieldType == 0)
                e.Handled = GPAddIn.ValidarCaracter("[N] ';:[]!@#$%^&*()-_=+ABCDEFGHIJKLMNOPQRSTUVWXYZ", e.KeyChar, txtHasta.Text.ToString(), 0);
            else
                e.Handled = GPAddIn.ValidarCaracter("[A] ,'[]", e.KeyChar, txtHasta.Text.ToString(), 0);
        }
    }
}