namespace DyncSolutions.PersonalizedReports
{
    partial class DYREP10100
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "DEMO"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DYREP10100));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cboSerie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboReporte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lsvOpciones = new System.Windows.Forms.ListView();
            this.IndiceO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OptionDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvImprimir = new System.Windows.Forms.ListView();
            this.IndiceI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OptionPrintName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvIntervalos = new System.Windows.Forms.ListView();
            this.Indice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IntervaloStr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Intervalo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParametroSQL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParametroIni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnImprimir, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Toolbar_Print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(3, -1);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(81, 24);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnClear, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Toolbar_Clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(90, -1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 24);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Borrar";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnDelete, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Toolbar_Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(176, -1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 24);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboSerie
            // 
            this.cboSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSerie.FormattingEnabled = true;
            this.cboSerie.Items.AddRange(new object[] {
            "Financiero",
            "Ventas",
            "Compras",
            "Inventario",
            "Nomina",
            "Proyecto",
            "Sistema",
            "Compañia"});
            this.cboSerie.Location = new System.Drawing.Point(93, 39);
            this.cboSerie.Name = "cboSerie";
            this.cboSerie.Size = new System.Drawing.Size(147, 21);
            this.cboSerie.TabIndex = 3;
            this.cboSerie.SelectedIndexChanged += new System.EventHandler(this.cboSerie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.dexLabelProvider.SetLinkField(this.label1, "cboSerie");
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serie";
            // 
            // cboReporte
            // 
            this.cboReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReporte.FormattingEnabled = true;
            this.cboReporte.Location = new System.Drawing.Point(12, 95);
            this.cboReporte.Name = "cboReporte";
            this.cboReporte.Size = new System.Drawing.Size(408, 21);
            this.cboReporte.TabIndex = 6;
            this.cboReporte.SelectedIndexChanged += new System.EventHandler(this.cboReporte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reporte";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opciones";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(324, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Imprimir";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsertar.Location = new System.Drawing.Point(246, 156);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar >>";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuitar.Location = new System.Drawing.Point(246, 185);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.Location = new System.Drawing.Point(40, 297);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(133, 297);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lsvOpciones
            // 
            this.lsvOpciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndiceO,
            this.OptionDesc});
            this.lsvOpciones.FullRowSelect = true;
            this.lsvOpciones.HideSelection = false;
            this.lsvOpciones.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsvOpciones.Location = new System.Drawing.Point(15, 156);
            this.lsvOpciones.Name = "lsvOpciones";
            this.lsvOpciones.Size = new System.Drawing.Size(225, 130);
            this.lsvOpciones.TabIndex = 15;
            this.lsvOpciones.UseCompatibleStateImageBehavior = false;
            this.lsvOpciones.View = System.Windows.Forms.View.Details;
            // 
            // IndiceO
            // 
            this.IndiceO.Text = "";
            this.IndiceO.Width = 0;
            // 
            // OptionDesc
            // 
            this.OptionDesc.Text = "Existentes";
            this.OptionDesc.Width = 220;
            // 
            // lsvImprimir
            // 
            this.lsvImprimir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndiceI,
            this.OptionPrintName});
            this.lsvImprimir.FullRowSelect = true;
            this.lsvImprimir.HideSelection = false;
            this.lsvImprimir.Location = new System.Drawing.Point(327, 156);
            this.lsvImprimir.Name = "lsvImprimir";
            this.lsvImprimir.Size = new System.Drawing.Size(225, 130);
            this.lsvImprimir.TabIndex = 16;
            this.lsvImprimir.UseCompatibleStateImageBehavior = false;
            this.lsvImprimir.View = System.Windows.Forms.View.Details;
            // 
            // IndiceI
            // 
            this.IndiceI.Width = 0;
            // 
            // OptionPrintName
            // 
            this.OptionPrintName.Text = "Opcion seleccionada";
            this.OptionPrintName.Width = 220;
            // 
            // lsvIntervalos
            // 
            this.lsvIntervalos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvIntervalos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvIntervalos.FullRowSelect = true;
            this.lsvIntervalos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvIntervalos.HideSelection = false;
            this.lsvIntervalos.LabelWrap = false;
            this.lsvIntervalos.Location = new System.Drawing.Point(514, 26);
            this.lsvIntervalos.Name = "lsvIntervalos";
            this.lsvIntervalos.ShowGroups = false;
            this.lsvIntervalos.Size = new System.Drawing.Size(38, 19);
            this.lsvIntervalos.TabIndex = 17;
            this.lsvIntervalos.UseCompatibleStateImageBehavior = false;
            this.lsvIntervalos.View = System.Windows.Forms.View.Details;
            this.lsvIntervalos.Visible = false;
            // 
            // Indice
            // 
            this.Indice.Text = "";
            this.Indice.Width = 0;
            // 
            // IntervaloStr
            // 
            this.IntervaloStr.Text = "Intervalo";
            this.IntervaloStr.Width = 500;
            // 
            // Intervalo
            // 
            this.Intervalo.Text = "";
            this.Intervalo.Width = 0;
            // 
            // Desde
            // 
            this.Desde.Text = "";
            this.Desde.Width = 0;
            // 
            // Hasta
            // 
            this.Hasta.Text = "";
            this.Hasta.Width = 0;
            // 
            // ParametroSQL
            // 
            this.ParametroSQL.Text = "";
            this.ParametroSQL.Width = 0;
            // 
            // ParametroIni
            // 
            this.ParametroIni.Text = "";
            this.ParametroIni.Width = 0;
            // 
            // TipoDoc
            // 
            this.TipoDoc.Text = "";
            this.TipoDoc.Width = 0;
            // 
            // DYREP10100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 352);
            this.Controls.Add(this.lsvIntervalos);
            this.Controls.Add(this.lsvImprimir);
            this.Controls.Add(this.lsvOpciones);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboReporte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSerie);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnImprimir);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "DYREP10100";
            this.Text = "Seleccion de Reportes";
            this.Load += new System.EventHandler(this.DYREP10100_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cboSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboReporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListView lsvOpciones;
        private System.Windows.Forms.ListView lsvImprimir;
        private System.Windows.Forms.ColumnHeader IndiceO;
        private System.Windows.Forms.ColumnHeader OptionDesc;
        private System.Windows.Forms.ColumnHeader IndiceI;
        private System.Windows.Forms.ColumnHeader OptionPrintName;
        private System.Windows.Forms.ListView lsvIntervalos;
        private System.Windows.Forms.ColumnHeader Indice;
        private System.Windows.Forms.ColumnHeader IntervaloStr;
        private System.Windows.Forms.ColumnHeader Intervalo;
        private System.Windows.Forms.ColumnHeader Desde;
        private System.Windows.Forms.ColumnHeader Hasta;
        private System.Windows.Forms.ColumnHeader ParametroSQL;
        private System.Windows.Forms.ColumnHeader ParametroIni;
        private System.Windows.Forms.ColumnHeader TipoDoc;
    }
}