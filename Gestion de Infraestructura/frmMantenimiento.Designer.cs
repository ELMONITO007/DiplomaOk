namespace DiplomaFinal.Gestion_de_Infraestructura
{
    partial class frmMantenimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btBajaProveedor = new MetroFramework.Controls.MetroButton();
            this.txtTipo = new MetroFramework.Controls.MetroComboBox();
            this.btnAltaProveedor = new MetroFramework.Controls.MetroButton();
            this.btnModificarProveedor = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.mgProveedores = new MetroFramework.Controls.MetroGrid();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.txtTipoProveedor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mgTipoProveedor = new MetroFramework.Controls.MetroGrid();
            this.txtTipoProvv = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProveedor = new MetroFramework.Controls.MetroComboBox();
            this.txtFecha = new MetroFramework.Controls.MetroDateTime();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNICreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Realizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRealiazado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgProveedores)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgTipoProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 34);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1133, 515);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtFecha);
            this.metroTabPage1.Controls.Add(this.txtProveedor);
            this.metroTabPage1.Controls.Add(this.btBajaProveedor);
            this.metroTabPage1.Controls.Add(this.txtTipo);
            this.metroTabPage1.Controls.Add(this.btnAltaProveedor);
            this.metroTabPage1.Controls.Add(this.btnModificarProveedor);
            this.metroTabPage1.Controls.Add(this.metroLabel17);
            this.metroTabPage1.Controls.Add(this.metroLabel19);
            this.metroTabPage1.Controls.Add(this.metroLabel20);
            this.metroTabPage1.Controls.Add(this.mgProveedores);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1125, 473);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Tag = "Mantenimiento";
            this.metroTabPage1.Text = "Mantenimiento";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btBajaProveedor
            // 
            this.btBajaProveedor.Location = new System.Drawing.Point(1018, 383);
            this.btBajaProveedor.Name = "btBajaProveedor";
            this.btBajaProveedor.Size = new System.Drawing.Size(107, 23);
            this.btBajaProveedor.TabIndex = 51;
            this.btBajaProveedor.Tag = "Baja";
            this.btBajaProveedor.Text = "Baja";
            this.btBajaProveedor.UseSelectable = true;
            this.btBajaProveedor.Click += new System.EventHandler(this.btBajaProveedor_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.ItemHeight = 23;
            this.txtTipo.Location = new System.Drawing.Point(893, 75);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(232, 29);
            this.txtTipo.TabIndex = 49;
            this.txtTipo.UseSelectable = true;
            this.txtTipo.SelectedIndexChanged += new System.EventHandler(this.txtTipo_SelectedIndexChanged);
            // 
            // btnAltaProveedor
            // 
            this.btnAltaProveedor.Location = new System.Drawing.Point(877, 383);
            this.btnAltaProveedor.Name = "btnAltaProveedor";
            this.btnAltaProveedor.Size = new System.Drawing.Size(107, 23);
            this.btnAltaProveedor.TabIndex = 48;
            this.btnAltaProveedor.Tag = "Alta";
            this.btnAltaProveedor.Text = "Alta";
            this.btnAltaProveedor.UseSelectable = true;
            this.btnAltaProveedor.Click += new System.EventHandler(this.btnAltaProveedor_Click);
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.Location = new System.Drawing.Point(734, 383);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(107, 23);
            this.btnModificarProveedor.TabIndex = 47;
            this.btnModificarProveedor.Tag = "Realizado";
            this.btnModificarProveedor.Text = "Realizado";
            this.btnModificarProveedor.UseSelectable = true;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(761, 75);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(35, 19);
            this.metroLabel17.TabIndex = 39;
            this.metroLabel17.Tag = "Tipo";
            this.metroLabel17.Text = "Tipo";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(759, 12);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(43, 19);
            this.metroLabel19.TabIndex = 37;
            this.metroLabel19.Tag = "Fecha";
            this.metroLabel19.Text = "Fecha";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(761, 147);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(71, 19);
            this.metroLabel20.TabIndex = 40;
            this.metroLabel20.Tag = "Proveedor";
            this.metroLabel20.Text = "Proveedor";
            // 
            // mgProveedores
            // 
            this.mgProveedores.AllowUserToAddRows = false;
            this.mgProveedores.AllowUserToDeleteRows = false;
            this.mgProveedores.AllowUserToResizeRows = false;
            this.mgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mgProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Fecha,
            this.DNICreo,
            this.TipoMantenimiento,
            this.Realizado,
            this.Proveedor,
            this.FechaRealiazado});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgProveedores.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgProveedores.EnableHeadersVisualStyles = false;
            this.mgProveedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgProveedores.Location = new System.Drawing.Point(-4, 29);
            this.mgProveedores.Name = "mgProveedores";
            this.mgProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgProveedores.Size = new System.Drawing.Size(732, 350);
            this.mgProveedores.TabIndex = 36;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.txtTipoProvv);
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.metroButton4);
            this.metroTabPage2.Controls.Add(this.metroButton6);
            this.metroTabPage2.Controls.Add(this.txtTipoProveedor);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.mgTipoProveedor);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1125, 473);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Tag = "Tipo Mantenimiento";
            this.metroTabPage2.Text = "Tipo Mantenimiento";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(887, 191);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(107, 23);
            this.metroButton3.TabIndex = 56;
            this.metroButton3.Tag = "Baja";
            this.metroButton3.Text = "Baja";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(743, 191);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(107, 23);
            this.metroButton4.TabIndex = 55;
            this.metroButton4.Tag = "Alta";
            this.metroButton4.Text = "Alta";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(609, 191);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(107, 23);
            this.metroButton6.TabIndex = 54;
            this.metroButton6.Tag = "Modificar";
            this.metroButton6.Text = "Modificar";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // txtTipoProveedor
            // 
            // 
            // 
            // 
            this.txtTipoProveedor.CustomButton.Image = null;
            this.txtTipoProveedor.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtTipoProveedor.CustomButton.Name = "";
            this.txtTipoProveedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTipoProveedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTipoProveedor.CustomButton.TabIndex = 1;
            this.txtTipoProveedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTipoProveedor.CustomButton.UseSelectable = true;
            this.txtTipoProveedor.CustomButton.Visible = false;
            this.txtTipoProveedor.Lines = new string[0];
            this.txtTipoProveedor.Location = new System.Drawing.Point(743, 103);
            this.txtTipoProveedor.MaxLength = 32767;
            this.txtTipoProveedor.Name = "txtTipoProveedor";
            this.txtTipoProveedor.PasswordChar = '\0';
            this.txtTipoProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTipoProveedor.SelectedText = "";
            this.txtTipoProveedor.SelectionLength = 0;
            this.txtTipoProveedor.SelectionStart = 0;
            this.txtTipoProveedor.ShortcutsEnabled = true;
            this.txtTipoProveedor.Size = new System.Drawing.Size(232, 23);
            this.txtTipoProveedor.TabIndex = 53;
            this.txtTipoProveedor.UseSelectable = true;
            this.txtTipoProveedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTipoProveedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(609, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(35, 19);
            this.metroLabel4.TabIndex = 52;
            this.metroLabel4.Tag = "Tipo";
            this.metroLabel4.Text = "Tipo";
            // 
            // mgTipoProveedor
            // 
            this.mgTipoProveedor.AllowUserToAddRows = false;
            this.mgTipoProveedor.AllowUserToDeleteRows = false;
            this.mgTipoProveedor.AllowUserToResizeRows = false;
            this.mgTipoProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mgTipoProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgTipoProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgTipoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgTipoProveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgTipoProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgTipoProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mgTipoProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgTipoProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TipoP,
            this.TipoProveedor});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgTipoProveedor.DefaultCellStyle = dataGridViewCellStyle11;
            this.mgTipoProveedor.EnableHeadersVisualStyles = false;
            this.mgTipoProveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgTipoProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgTipoProveedor.Location = new System.Drawing.Point(21, 38);
            this.mgTipoProveedor.Name = "mgTipoProveedor";
            this.mgTipoProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgTipoProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.mgTipoProveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgTipoProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgTipoProveedor.Size = new System.Drawing.Size(491, 350);
            this.mgTipoProveedor.TabIndex = 47;
            this.mgTipoProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgTipoProveedor_CellContentClick);
            // 
            // txtTipoProvv
            // 
            this.txtTipoProvv.FormattingEnabled = true;
            this.txtTipoProvv.ItemHeight = 23;
            this.txtTipoProvv.Location = new System.Drawing.Point(743, 38);
            this.txtTipoProvv.Name = "txtTipoProvv";
            this.txtTipoProvv.Size = new System.Drawing.Size(232, 29);
            this.txtTipoProvv.TabIndex = 57;
            this.txtTipoProvv.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(609, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 19);
            this.metroLabel3.TabIndex = 58;
            this.metroLabel3.Tag = "Tipo Proveedor";
            this.metroLabel3.Text = "Tipo Proveedor";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Legajo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 64;
            // 
            // TipoP
            // 
            this.TipoP.HeaderText = "Tipo";
            this.TipoP.Name = "TipoP";
            this.TipoP.Width = 53;
            // 
            // TipoProveedor
            // 
            this.TipoProveedor.HeaderText = "Tipo Proveedor";
            this.TipoProveedor.Name = "TipoProveedor";
            this.TipoProveedor.ReadOnly = true;
            this.TipoProveedor.Width = 99;
            // 
            // txtProveedor
            // 
            this.txtProveedor.FormattingEnabled = true;
            this.txtProveedor.ItemHeight = 23;
            this.txtProveedor.Location = new System.Drawing.Point(889, 137);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(232, 29);
            this.txtProveedor.TabIndex = 57;
            this.txtProveedor.UseSelectable = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(889, 12);
            this.txtFecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 29);
            this.txtFecha.TabIndex = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Legajo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 64;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 60;
            // 
            // DNICreo
            // 
            this.DNICreo.HeaderText = "DNI Creo";
            this.DNICreo.Name = "DNICreo";
            this.DNICreo.ReadOnly = true;
            this.DNICreo.Width = 76;
            // 
            // TipoMantenimiento
            // 
            this.TipoMantenimiento.HeaderText = "Tipo Mantenimiento";
            this.TipoMantenimiento.Name = "TipoMantenimiento";
            this.TipoMantenimiento.ReadOnly = true;
            this.TipoMantenimiento.Width = 123;
            // 
            // Realizado
            // 
            this.Realizado.HeaderText = "Realizado";
            this.Realizado.Name = "Realizado";
            this.Realizado.ReadOnly = true;
            this.Realizado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Realizado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Realizado.Width = 80;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Width = 82;
            // 
            // FechaRealiazado
            // 
            this.FechaRealiazado.HeaderText = "Fecha Realiazado";
            this.FechaRealiazado.Name = "FechaRealiazado";
            this.FechaRealiazado.ReadOnly = true;
            this.FechaRealiazado.Width = 109;
            // 
            // frmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 594);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmMantenimiento";
            this.Load += new System.EventHandler(this.frmMantenimiento_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgProveedores)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgTipoProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btBajaProveedor;
        private MetroFramework.Controls.MetroComboBox txtTipo;
        private MetroFramework.Controls.MetroButton btnAltaProveedor;
        private MetroFramework.Controls.MetroButton btnModificarProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroGrid mgProveedores;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroTextBox txtTipoProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid mgTipoProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox txtTipoProvv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoProveedor;
        private MetroFramework.Controls.MetroDateTime txtFecha;
        private MetroFramework.Controls.MetroComboBox txtProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNICreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMantenimiento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Realizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRealiazado;
    }
}