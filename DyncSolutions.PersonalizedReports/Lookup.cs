using System;
using System.Windows.Forms;

namespace DyncSolutions.PersonalizedReports
{
    public partial class Lookup
    {
        private SqlDbConnect con;
        //-- Objecto BindingSource
        public BindingSource xBindingSource = new BindingSource();
        //-- Nombre del origen de datos
        public string SqlDataSourceNamex;
        //-- Nombre físico de la base de datos de la compañía 
        public string InterCompanyx;
        //-- Consulta SQL
        public string xQuery = "";
        //-- Variable para retorno de dato columna(x)
        public string xData1 = "";
        //-- Variable para retorno de dato columna(x)
        public string xData2 = "";
        //-- Variable para retorno de dato columna(x)
        public string xData3 = "";
        //-- Indicador de columna(1x) para tomar el dato seleccionado
        public int xColumn1 = 0;
        //-- Indicador de columna(2x) para tomar el dato seleccionado
        public int xColumn2 = 0;
        //-- Indicador de columna(3x)
        public int xColumn3 = 0;
        //-- Titulo de la ventana
        public string xTitle = "";
        //-- Ancho columna #1
        public int xWithCol1 = 0;
        //-- Ancho columna #2
        public int xWithCol2 = 0;
        //-- Ancho columna #3
        public int xWithCol3 = 0;
        //-- Texto de busqueda predeterminado
        public string xSearchText = "";
        //-- Columna para hacer filtro y reordenar la data en el grid
        private int xColumn;
        public Lookup(string xTitleForm, string xSQLQuery, int xColumnData1, int xColumnData2, int xColumnData3 = 0, int WithCol1 = 0, int WithCol2 = 0, int WithCol3 = 0, string SearchText = "")
        {
            Load += Lookup_Load;
            xQuery = xSQLQuery;
            xColumn1 = xColumnData1;
            xColumn2 = xColumnData2;
            xColumn3 = xColumnData3;
            xTitle = xTitleForm;
            xWithCol1 = WithCol1;
            xWithCol2 = WithCol2;
            xWithCol3 = WithCol3;
            xSearchText = SearchText;

            InitializeComponent();
        }

        private void BtnCancel_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSelect_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                xData1 = Convert.ToString(dgvLookup.CurrentRow.Cells[xColumn1].Value);
                if (dgvLookup.ColumnCount >= xColumn2)
                {
                    xData2 = Convert.ToString(dgvLookup.CurrentRow.Cells[xColumn2].Value);
                }
                if (dgvLookup.ColumnCount >= xColumn3)
                {
                    xData3 = Convert.ToString(dgvLookup.CurrentRow.Cells[xColumn3].Value);
                }

                //-- Asigna el dato seleccionado a variable --
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lookup_Load(System.Object sender, System.EventArgs e)
        {
            try
            {
                //this.dgvLookup.DefaultCellStyle.Font = new Font("Tahoma", 8);
                this.Text = xTitle;

                con = new SqlDbConnect();
                con.SqlQuery(xQuery);

                //-- Llenando objecto BindingSource --
                xBindingSource = new BindingSource { DataSource = con.QueryEx() };
                dgvLookup.DataSource = xBindingSource;
                //-- Llenando Grilla

                //-- Asignando tamaño y formato de columnas --
                for (int Conteo = 1; Conteo <= dgvLookup.Columns.Count; Conteo++)
                {
                    switch (Conteo)
                    {
                        case 1:
                            //-- Definiendo ancho para columna 1 --
                            if (xWithCol1 == 0)
                            {
                                dgvLookup.Columns[0].Width = 150;
                            }
                            else
                            {
                                dgvLookup.Columns[0].Width = xWithCol1;
                            }
                            Lbl_Lookup.Text = Lbl_Lookup.Tag + dgvLookup.Columns[0].HeaderText.ToString().Trim();

                            break;
                        case 2:
                            //-- Definiendo ancho para columna 2 --
                            if (xWithCol2 == 0)
                            {
                                dgvLookup.Columns[1].Width = dgvLookup.Width - (dgvLookup.Columns[0].Width + 5);
                            }
                            else if (xWithCol2 > 0)
                            {
                                dgvLookup.Columns[1].Width = xWithCol2;
                            }
                            break;
                        case 3: // ERROR: Case labels with binary operators are unsupported : Equality

                            //-- Definiendo ancho para columna 3 --
                            if (xWithCol3 == 0)
                            {
                                dgvLookup.Columns[Conteo - 1].Width = dgvLookup.Columns[0].Width;
                            }
                            else if (xWithCol3 > 0)
                            {
                                dgvLookup.Columns[Conteo - 1].Width = xWithCol3;
                            }
                            break;
                        default: // ERROR: Case labels with binary operators are unsupported : GreaterThan

                            //-- Definiendo ancho para columna 3 --
                            dgvLookup.Columns[Conteo - 1].Width = dgvLookup.Columns[0].Width;
                            break;
                    }
                }
                Txt_Lookup.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int xRowCount = dgvLookup.RowCount;
            try
            {
                //-- Asignando ancho fijo a celdas y deshabilitando campo --
                for (int yRowCount = 0; yRowCount <= xRowCount - 1; yRowCount++)
                {
                    dgvLookup.Rows[yRowCount].Height = 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //-- Verificando si existe texto para buscar --
            if (xSearchText.Trim().Length > 0)
            {
                Txt_Lookup.Text = xSearchText;
                Txt_Lookup_TextChanged(sender, e);
            }

        }

        private void dgvLookup_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            try
            {
                BtnSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_Lookup_TextChanged(System.Object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Txt_Lookup.Text.Trim()))
                {
                    xBindingSource.Filter = string.Format("[{0}] LIKE '%{1}%'", Convert.ToString(dgvLookup.Columns[xColumn].Name.ToString()), Txt_Lookup.Text);
                }
                else
                {
                    xBindingSource.RemoveFilter();
                }

                //-- Asignando ancho fijo a celdas y deshabilitando campo --
                int xRowCount = dgvLookup.RowCount;
                for (int yRowCount = 0; yRowCount <= xRowCount - 1; yRowCount++)
                {
                    dgvLookup.Rows[yRowCount].Height = 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLookup_ColumnHeaderMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            xColumn = e.ColumnIndex;
            Lbl_Lookup.Text = Lbl_Lookup.Tag + dgvLookup.Columns[xColumn].HeaderText.ToString().Trim();

            int xRowCount = dgvLookup.RowCount;
            try
            {
                //-- Asignando ancho fijo a celdas y deshabilitando campo --
                for (int yRowCount = 0; yRowCount <= xRowCount - 1; yRowCount++)
                {
                    dgvLookup.Rows[yRowCount].Height = 30;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                Txt_Lookup.Text = "";
                xBindingSource.RemoveFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Microsoft Dynamics GP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}