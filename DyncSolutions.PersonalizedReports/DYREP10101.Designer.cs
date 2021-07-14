namespace DyncSolutions.PersonalizedReports
{
    partial class DYREP10101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DYREP10101));
            this.lsvOpciones = new System.Windows.Forms.ListView();
            this.Indice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IntervaloStr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Intervalo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Desde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hasta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParametroSQL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParametroIni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cboOpcion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboIntervalo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cboDesde = new System.Windows.Forms.ComboBox();
            this.cboHasta = new System.Windows.Forms.ComboBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.btnLookDesde = new System.Windows.Forms.Button();
            this.btnLookHasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvOpciones
            // 
            this.lsvOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvOpciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvOpciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indice,
            this.IntervaloStr,
            this.Intervalo,
            this.Desde,
            this.Hasta,
            this.ParametroSQL,
            this.ParametroIni,
            this.TipoDoc});
            this.lsvOpciones.FullRowSelect = true;
            this.lsvOpciones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvOpciones.HideSelection = false;
            this.lsvOpciones.LabelWrap = false;
            this.lsvOpciones.Location = new System.Drawing.Point(112, 137);
            this.lsvOpciones.Name = "lsvOpciones";
            this.lsvOpciones.ShowGroups = false;
            this.lsvOpciones.Size = new System.Drawing.Size(500, 130);
            this.lsvOpciones.TabIndex = 16;
            this.lsvOpciones.UseCompatibleStateImageBehavior = false;
            this.lsvOpciones.View = System.Windows.Forms.View.Details;
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
            // label1
            // 
            this.dexLabelProvider.SetLinkField(this.label1, "cboOpcion");
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Opcion";
            // 
            // cboOpcion
            // 
            this.cboOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOpcion.FormattingEnabled = true;
            this.cboOpcion.Location = new System.Drawing.Point(63, 33);
            this.cboOpcion.Name = "cboOpcion";
            this.cboOpcion.Size = new System.Drawing.Size(147, 21);
            this.cboOpcion.TabIndex = 17;
            this.cboOpcion.Tag = "[A] \',.";
            this.cboOpcion.SelectedIndexChanged += new System.EventHandler(this.cboOpcion_SelectedIndexChanged);
            this.cboOpcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboOpcion_KeyPress);
            // 
            // label2
            // 
            this.dexLabelProvider.SetLinkField(this.label2, "txtReporte");
            this.label2.Location = new System.Drawing.Point(218, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Reporte";
            // 
            // txtReporte
            // 
            this.txtReporte.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReporte.Location = new System.Drawing.Point(284, 36);
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.Size = new System.Drawing.Size(328, 15);
            this.txtReporte.TabIndex = 20;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuitar.Location = new System.Drawing.Point(15, 203);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 22;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsertar.Location = new System.Drawing.Point(15, 174);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 21;
            this.btnInsertar.Text = "Insertar >>";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Intervalo";
            // 
            // cboIntervalo
            // 
            this.cboIntervalo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboIntervalo.FormattingEnabled = true;
            this.cboIntervalo.Location = new System.Drawing.Point(15, 102);
            this.cboIntervalo.Name = "cboIntervalo";
            this.cboIntervalo.Size = new System.Drawing.Size(195, 21);
            this.cboIntervalo.TabIndex = 24;
            this.cboIntervalo.SelectedIndexChanged += new System.EventHandler(this.cboIntervalo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(233, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(233, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Hasta";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnDelete, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Toolbar_Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(191, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 24);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnClear, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Toolbar_Clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(96, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 24);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Borrar";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnImprimir, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Toolbar_Print;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(282, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 24);
            this.btnImprimir.TabIndex = 27;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnSave, Microsoft.Dexterity.Shell.DexButtonType.ToolbarWithSeparator);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Toolbar_Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(3, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 24);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(449, 77);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(117, 22);
            this.dtpDesde.TabIndex = 31;
            this.dtpDesde.Visible = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.Location = new System.Drawing.Point(449, 104);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(117, 22);
            this.dtpHasta.TabIndex = 32;
            this.dtpHasta.Visible = false;
            // 
            // cboDesde
            // 
            this.cboDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDesde.FormattingEnabled = true;
            this.cboDesde.Items.AddRange(new object[] {
            "Escribir fecha",
            "Fecha actual",
            "Inicio de mes",
            "Fin de mes"});
            this.cboDesde.Location = new System.Drawing.Point(284, 78);
            this.cboDesde.Name = "cboDesde";
            this.cboDesde.Size = new System.Drawing.Size(138, 21);
            this.cboDesde.TabIndex = 33;
            this.cboDesde.Visible = false;
            this.cboDesde.SelectedIndexChanged += new System.EventHandler(this.cboDesde_SelectedIndexChanged);
            // 
            // cboHasta
            // 
            this.cboHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHasta.FormattingEnabled = true;
            this.cboHasta.Items.AddRange(new object[] {
            "Escribir fecha",
            "Fecha actual",
            "Inicio de mes",
            "Fin de mes"});
            this.cboHasta.Location = new System.Drawing.Point(283, 103);
            this.cboHasta.Name = "cboHasta";
            this.cboHasta.Size = new System.Drawing.Size(138, 21);
            this.cboHasta.TabIndex = 34;
            this.cboHasta.Visible = false;
            this.cboHasta.SelectedIndexChanged += new System.EventHandler(this.cboHasta_SelectedIndexChanged);
            // 
            // txtDesde
            // 
            this.txtDesde.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesde.Location = new System.Drawing.Point(285, 80);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(138, 15);
            this.txtDesde.TabIndex = 35;
            this.txtDesde.Visible = false;
            this.txtDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesde_KeyPress);
            // 
            // txtHasta
            // 
            this.txtHasta.BackColor = System.Drawing.SystemColors.Window;
            this.txtHasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHasta.Location = new System.Drawing.Point(284, 105);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(138, 15);
            this.txtHasta.TabIndex = 36;
            this.txtHasta.Visible = false;
            this.txtHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHasta_KeyPress);
            // 
            // btnLookDesde
            // 
            this.btnLookDesde.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnLookDesde, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.btnLookDesde.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.btnLookDesde.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLookDesde.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLookDesde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookDesde.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Field_Lookup;
            this.btnLookDesde.Location = new System.Drawing.Point(424, 74);
            this.btnLookDesde.Name = "btnLookDesde";
            this.btnLookDesde.Size = new System.Drawing.Size(22, 22);
            this.btnLookDesde.TabIndex = 37;
            this.btnLookDesde.TabStop = false;
            this.btnLookDesde.UseVisualStyleBackColor = false;
            this.btnLookDesde.Visible = false;
            this.btnLookDesde.Click += new System.EventHandler(this.btnLookDesde_Click);
            // 
            // btnLookHasta
            // 
            this.btnLookHasta.BackColor = System.Drawing.Color.Transparent;
            this.dexButtonProvider.SetButtonType(this.btnLookHasta, Microsoft.Dexterity.Shell.DexButtonType.Field);
            this.btnLookHasta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(173)))), ((int)(((byte)(179)))));
            this.btnLookHasta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLookHasta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLookHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookHasta.Image = global::DyncSolutions.PersonalizedReports.Properties.Resources.Field_Lookup;
            this.btnLookHasta.Location = new System.Drawing.Point(424, 101);
            this.btnLookHasta.Name = "btnLookHasta";
            this.btnLookHasta.Size = new System.Drawing.Size(22, 22);
            this.btnLookHasta.TabIndex = 38;
            this.btnLookHasta.TabStop = false;
            this.btnLookHasta.UseVisualStyleBackColor = false;
            this.btnLookHasta.Visible = false;
            this.btnLookHasta.Click += new System.EventHandler(this.btnLookHasta_Click);
            // 
            // DYREP10101
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 309);
            this.Controls.Add(this.btnLookHasta);
            this.Controls.Add(this.btnLookDesde);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.cboHasta);
            this.Controls.Add(this.cboDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboIntervalo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboOpcion);
            this.Controls.Add(this.lsvOpciones);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "DYREP10101";
            this.Text = "Opciones de reportes";
            this.Load += new System.EventHandler(this.DYREP10101_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvOpciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOpcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboIntervalo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cboDesde;
        private System.Windows.Forms.ComboBox cboHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Button btnLookDesde;
        private System.Windows.Forms.Button btnLookHasta;
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