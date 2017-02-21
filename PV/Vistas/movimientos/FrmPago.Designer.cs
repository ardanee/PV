namespace PV
{
    partial class FrmPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.grdVenta = new System.Windows.Forms.DataGridView();
            this.idUsuarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editarCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.rolCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.nombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambiarContrasenaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPago = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTituloVenta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(341, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(2, 57);
            this.txtBusqueda.MaxLength = 50;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(336, 22);
            this.txtBusqueda.TabIndex = 3;
            // 
            // grdVenta
            // 
            this.grdVenta.AllowUserToAddRows = false;
            this.grdVenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVenta.BackgroundColor = System.Drawing.Color.White;
            this.grdVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdVenta.ColumnHeadersHeight = 30;
            this.grdVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioCol,
            this.editarCol,
            this.rolCol,
            this.nombreCol,
            this.usuarioCol,
            this.observacionesCol,
            this.activoCol,
            this.fechaNacimientoCol,
            this.cambiarContrasenaCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdVenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdVenta.EnableHeadersVisualStyles = false;
            this.grdVenta.GridColor = System.Drawing.Color.LightGray;
            this.grdVenta.Location = new System.Drawing.Point(1, 84);
            this.grdVenta.MultiSelect = false;
            this.grdVenta.Name = "grdVenta";
            this.grdVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdVenta.RowHeadersWidth = 20;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdVenta.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdVenta.RowTemplate.Height = 30;
            this.grdVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVenta.Size = new System.Drawing.Size(998, 188);
            this.grdVenta.TabIndex = 4;
            // 
            // idUsuarioCol
            // 
            this.idUsuarioCol.DataPropertyName = "idUsuario";
            this.idUsuarioCol.HeaderText = "ID";
            this.idUsuarioCol.Name = "idUsuarioCol";
            this.idUsuarioCol.Visible = false;
            // 
            // editarCol
            // 
            this.editarCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.editarCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.editarCol.FillWeight = 121.8274F;
            this.editarCol.HeaderText = "";
            this.editarCol.Image = global::PV.Properties.Resources.pencil;
            this.editarCol.MinimumWidth = 30;
            this.editarCol.Name = "editarCol";
            this.editarCol.Width = 30;
            // 
            // rolCol
            // 
            this.rolCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.rolCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.rolCol.FillWeight = 96.8818F;
            this.rolCol.HeaderText = "";
            this.rolCol.Image = global::PV.Properties.Resources.account_settings_variant;
            this.rolCol.MinimumWidth = 30;
            this.rolCol.Name = "rolCol";
            this.rolCol.Width = 30;
            // 
            // nombreCol
            // 
            this.nombreCol.DataPropertyName = "nombre";
            this.nombreCol.FillWeight = 96.8818F;
            this.nombreCol.HeaderText = "Nombre";
            this.nombreCol.Name = "nombreCol";
            // 
            // usuarioCol
            // 
            this.usuarioCol.DataPropertyName = "usuario";
            this.usuarioCol.FillWeight = 96.8818F;
            this.usuarioCol.HeaderText = "Usuario";
            this.usuarioCol.Name = "usuarioCol";
            // 
            // observacionesCol
            // 
            this.observacionesCol.DataPropertyName = "descripcion";
            this.observacionesCol.FillWeight = 96.8818F;
            this.observacionesCol.HeaderText = "Observaciones";
            this.observacionesCol.Name = "observacionesCol";
            // 
            // activoCol
            // 
            this.activoCol.DataPropertyName = "activo";
            this.activoCol.FillWeight = 96.8818F;
            this.activoCol.HeaderText = "Activo";
            this.activoCol.Name = "activoCol";
            // 
            // fechaNacimientoCol
            // 
            this.fechaNacimientoCol.DataPropertyName = "fechaNacimiento";
            this.fechaNacimientoCol.FillWeight = 96.8818F;
            this.fechaNacimientoCol.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoCol.Name = "fechaNacimientoCol";
            // 
            // cambiarContrasenaCol
            // 
            this.cambiarContrasenaCol.DataPropertyName = "cambiarContrasena";
            this.cambiarContrasenaCol.FillWeight = 96.8818F;
            this.cambiarContrasenaCol.HeaderText = "Cambiar Contraseña";
            this.cambiarContrasenaCol.Name = "cambiarContrasenaCol";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1007, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pagos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Busque un crédito activo";
            // 
            // grdPago
            // 
            this.grdPago.AllowUserToAddRows = false;
            this.grdPago.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPago.BackgroundColor = System.Drawing.Color.White;
            this.grdPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdPago.ColumnHeadersHeight = 30;
            this.grdPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewImageColumn1,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPago.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdPago.EnableHeadersVisualStyles = false;
            this.grdPago.GridColor = System.Drawing.Color.LightGray;
            this.grdPago.Location = new System.Drawing.Point(1, 310);
            this.grdPago.MultiSelect = false;
            this.grdPago.Name = "grdPago";
            this.grdPago.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPago.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdPago.RowHeadersWidth = 20;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            this.grdPago.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.grdPago.RowTemplate.Height = 30;
            this.grdPago.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPago.Size = new System.Drawing.Size(998, 190);
            this.grdPago.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImageColumn1.FillWeight = 121.8274F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PV.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.MinimumWidth = 30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewImageColumn2.FillWeight = 96.8818F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PV.Properties.Resources.account_settings_variant;
            this.dataGridViewImageColumn2.MinimumWidth = 30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.FillWeight = 96.8818F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn3.FillWeight = 96.8818F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn4.FillWeight = 96.8818F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "activo";
            this.dataGridViewTextBoxColumn5.FillWeight = 96.8818F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Activo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fechaNacimiento";
            this.dataGridViewTextBoxColumn6.FillWeight = 96.8818F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha Nacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cambiarContrasena";
            this.dataGridViewTextBoxColumn7.FillWeight = 96.8818F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Cambiar Contraseña";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // lblTituloVenta
            // 
            this.lblTituloVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloVenta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTituloVenta.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloVenta.ForeColor = System.Drawing.Color.White;
            this.lblTituloVenta.Location = new System.Drawing.Point(-2, 275);
            this.lblTituloVenta.Name = "lblTituloVenta";
            this.lblTituloVenta.Size = new System.Drawing.Size(1007, 34);
            this.lblTituloVenta.TabIndex = 14;
            this.lblTituloVenta.Text = "Lista de pagos recibidos";
            this.lblTituloVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 501);
            this.Controls.Add(this.lblTituloVenta);
            this.Controls.Add(this.grdPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.grdVenta);
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView grdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioCol;
        private System.Windows.Forms.DataGridViewImageColumn editarCol;
        private System.Windows.Forms.DataGridViewImageColumn rolCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cambiarContrasenaCol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblTituloVenta;
    }
}