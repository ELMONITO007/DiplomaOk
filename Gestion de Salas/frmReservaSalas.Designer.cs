namespace DiplomaFinal.Gesion_de_Salas
{
    partial class frmReservaSalas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabIncripcion = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.txtturno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSalasAño = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnModificarSala = new MetroFramework.Controls.MetroButton();
            this.txtVerTodoSala = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.txtBuscarSala = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.mgSala = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtGrado = new MetroFramework.Controls.MetroComboBox();
            this.btnAlta = new MetroFramework.Controls.MetroButton();
            this.txtNombreCurso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.mgReserva = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabIncripcion.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSala)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // tabIncripcion
            // 
            this.tabIncripcion.Controls.Add(this.metroTabPage3);
            this.tabIncripcion.Controls.Add(this.metroTabPage1);
            this.tabIncripcion.Controls.Add(this.metroTabPage2);
            this.tabIncripcion.Location = new System.Drawing.Point(23, 78);
            this.tabIncripcion.Name = "tabIncripcion";
            this.tabIncripcion.SelectedIndex = 0;
            this.tabIncripcion.Size = new System.Drawing.Size(1428, 628);
            this.tabIncripcion.TabIndex = 3;
            this.tabIncripcion.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.txtturno);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.txtSalasAño);
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.btnModificarSala);
            this.metroTabPage3.Controls.Add(this.txtVerTodoSala);
            this.metroTabPage3.Controls.Add(this.metroButton5);
            this.metroTabPage3.Controls.Add(this.txtBuscarSala);
            this.metroTabPage3.Controls.Add(this.metroLabel12);
            this.metroTabPage3.Controls.Add(this.mgSala);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1420, 586);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Tag = "Salas de grado";
            this.metroTabPage3.Text = "Salas de grado";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // txtturno
            // 
            this.txtturno.FormattingEnabled = true;
            this.txtturno.ItemHeight = 23;
            this.txtturno.Location = new System.Drawing.Point(205, 79);
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(279, 29);
            this.txtturno.TabIndex = 43;
            this.txtturno.UseSelectable = true;
            this.txtturno.SelectedIndexChanged += new System.EventHandler(this.txtturno_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 89);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(134, 19);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Tag = "2. Seleccione el Turno";
            this.metroLabel4.Text = "2. Seleccione el Turno";
            // 
            // txtSalasAño
            // 
            this.txtSalasAño.FormattingEnabled = true;
            this.txtSalasAño.ItemHeight = 23;
            this.txtSalasAño.Location = new System.Drawing.Point(205, 23);
            this.txtSalasAño.Name = "txtSalasAño";
            this.txtSalasAño.Size = new System.Drawing.Size(279, 29);
            this.txtSalasAño.TabIndex = 41;
            this.txtSalasAño.UseSelectable = true;
            this.txtSalasAño.SelectedIndexChanged += new System.EventHandler(this.txtSalasAño_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(19, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Tag = "1. Seleccione el año";
            this.metroLabel1.Text = "1. Seleccione el año";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 478);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "4. Reserve";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 133);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 19);
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Tag = "3. Seleccione la sala";
            this.metroLabel2.Text = "3. Seleccione la sala";
            // 
            // btnModificarSala
            // 
            this.btnModificarSala.Location = new System.Drawing.Point(19, 530);
            this.btnModificarSala.Name = "btnModificarSala";
            this.btnModificarSala.Size = new System.Drawing.Size(107, 23);
            this.btnModificarSala.TabIndex = 32;
            this.btnModificarSala.Tag = "Siguiente";
            this.btnModificarSala.Text = "Siguiente";
            this.btnModificarSala.UseSelectable = true;
            this.btnModificarSala.Visible = false;
            this.btnModificarSala.Click += new System.EventHandler(this.btnModificarSala_Click);
            // 
            // txtVerTodoSala
            // 
            this.txtVerTodoSala.Location = new System.Drawing.Point(366, 167);
            this.txtVerTodoSala.Name = "txtVerTodoSala";
            this.txtVerTodoSala.Size = new System.Drawing.Size(74, 23);
            this.txtVerTodoSala.TabIndex = 31;
            this.txtVerTodoSala.Tag = "Ver Todo";
            this.txtVerTodoSala.Text = "Ver todo";
            this.txtVerTodoSala.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(247, 167);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(75, 23);
            this.metroButton5.TabIndex = 30;
            this.metroButton5.Tag = "Buscar";
            this.metroButton5.Text = "Buscar";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // txtBuscarSala
            // 
            // 
            // 
            // 
            this.txtBuscarSala.CustomButton.Image = null;
            this.txtBuscarSala.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtBuscarSala.CustomButton.Name = "";
            this.txtBuscarSala.CustomButton.Size = new System.Drawing.Size(10, 10);
            this.txtBuscarSala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarSala.CustomButton.TabIndex = 1;
            this.txtBuscarSala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarSala.CustomButton.UseSelectable = true;
            this.txtBuscarSala.CustomButton.Visible = false;
            this.txtBuscarSala.Lines = new string[0];
            this.txtBuscarSala.Location = new System.Drawing.Point(96, 167);
            this.txtBuscarSala.MaxLength = 32767;
            this.txtBuscarSala.Name = "txtBuscarSala";
            this.txtBuscarSala.PasswordChar = '\0';
            this.txtBuscarSala.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarSala.SelectedText = "";
            this.txtBuscarSala.SelectionLength = 0;
            this.txtBuscarSala.SelectionStart = 0;
            this.txtBuscarSala.ShortcutsEnabled = true;
            this.txtBuscarSala.Size = new System.Drawing.Size(103, 17);
            this.txtBuscarSala.TabIndex = 29;
            this.txtBuscarSala.UseSelectable = true;
            this.txtBuscarSala.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscarSala.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(20, 167);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(47, 19);
            this.metroLabel12.TabIndex = 28;
            this.metroLabel12.Tag = "Buscar";
            this.metroLabel12.Text = "Buscar";
            // 
            // mgSala
            // 
            this.mgSala.AllowUserToAddRows = false;
            this.mgSala.AllowUserToDeleteRows = false;
            this.mgSala.AllowUserToResizeRows = false;
            this.mgSala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mgSala.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgSala.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgSala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgSala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgSala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgSala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgSala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.TipoSala,
            this.Capacidad,
            this.DNI});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgSala.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgSala.EnableHeadersVisualStyles = false;
            this.mgSala.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgSala.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgSala.Location = new System.Drawing.Point(-4, 215);
            this.mgSala.Name = "mgSala";
            this.mgSala.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgSala.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgSala.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgSala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgSala.Size = new System.Drawing.Size(691, 260);
            this.mgSala.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Legajo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // TipoSala
            // 
            this.TipoSala.HeaderText = "Tipo";
            this.TipoSala.Name = "TipoSala";
            this.TipoSala.ReadOnly = true;
            this.TipoSala.Width = 53;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            this.Capacidad.Width = 84;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "Sala Temporal";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DNI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DNI.Width = 93;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtGrado);
            this.metroTabPage1.Controls.Add(this.btnAlta);
            this.metroTabPage1.Controls.Add(this.txtNombreCurso);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1420, 586);
            this.metroTabPage1.TabIndex = 5;
            this.metroTabPage1.Tag = "Alta Curso";
            this.metroTabPage1.Text = "Alta Curso";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtGrado
            // 
            this.txtGrado.FormattingEnabled = true;
            this.txtGrado.ItemHeight = 23;
            this.txtGrado.Location = new System.Drawing.Point(142, 89);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(242, 29);
            this.txtGrado.TabIndex = 7;
            this.txtGrado.UseSelectable = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Enabled = false;
            this.btnAlta.Location = new System.Drawing.Point(26, 185);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(118, 38);
            this.btnAlta.TabIndex = 6;
            this.btnAlta.Tag = "Alta";
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseSelectable = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtNombreCurso
            // 
            // 
            // 
            // 
            this.txtNombreCurso.CustomButton.Image = null;
            this.txtNombreCurso.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtNombreCurso.CustomButton.Name = "";
            this.txtNombreCurso.CustomButton.Size = new System.Drawing.Size(14, 14);
            this.txtNombreCurso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreCurso.CustomButton.TabIndex = 1;
            this.txtNombreCurso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreCurso.CustomButton.UseSelectable = true;
            this.txtNombreCurso.CustomButton.Visible = false;
            this.txtNombreCurso.Enabled = false;
            this.txtNombreCurso.Lines = new string[0];
            this.txtNombreCurso.Location = new System.Drawing.Point(142, 35);
            this.txtNombreCurso.MaxLength = 32767;
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.PasswordChar = '\0';
            this.txtNombreCurso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreCurso.SelectedText = "";
            this.txtNombreCurso.SelectionLength = 0;
            this.txtNombreCurso.SelectionStart = 0;
            this.txtNombreCurso.ShortcutsEnabled = true;
            this.txtNombreCurso.Size = new System.Drawing.Size(242, 23);
            this.txtNombreCurso.TabIndex = 4;
            this.txtNombreCurso.UseSelectable = true;
            this.txtNombreCurso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreCurso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 99);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(46, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Tag = "Grado";
            this.metroLabel6.Text = "Grado";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(16, 35);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Tag = "Nombre";
            this.metroLabel5.Text = "Nombre";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.mgReserva);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1420, 586);
            this.metroTabPage2.TabIndex = 6;
            this.metroTabPage2.Tag = "Reservas";
            this.metroTabPage2.Text = "Reservas";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // mgReserva
            // 
            this.mgReserva.AllowUserToAddRows = false;
            this.mgReserva.AllowUserToDeleteRows = false;
            this.mgReserva.AllowUserToResizeRows = false;
            this.mgReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mgReserva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgReserva.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgReserva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgReserva.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgReserva.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Turno,
            this.Hora,
            this.Año,
            this.NombreSala,
            this.Grado});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgReserva.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgReserva.EnableHeadersVisualStyles = false;
            this.mgReserva.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgReserva.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgReserva.Location = new System.Drawing.Point(26, 39);
            this.mgReserva.Name = "mgReserva";
            this.mgReserva.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgReserva.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgReserva.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgReserva.Size = new System.Drawing.Size(1251, 422);
            this.mgReserva.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Legajo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 64;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 53;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Capacidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 84;
            // 
            // Turno
            // 
            this.Turno.HeaderText = "Turno";
            this.Turno.Name = "Turno";
            this.Turno.Width = 61;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 55;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 51;
            // 
            // NombreSala
            // 
            this.NombreSala.HeaderText = "Nombre Sala";
            this.NombreSala.Name = "NombreSala";
            this.NombreSala.ReadOnly = true;
            this.NombreSala.Width = 95;
            // 
            // Grado
            // 
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            this.Grado.Width = 62;
            // 
            // frmReservaSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 715);
            this.Controls.Add(this.tabIncripcion);
            this.Name = "frmReservaSalas";
            this.Tag = "Reserva Salas de Grado";
            this.Text = "Reserva Salas de Grado";
            this.Load += new System.EventHandler(this.frmReservaSalas_Load);
            this.tabIncripcion.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSala)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabIncripcion;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnModificarSala;
        private MetroFramework.Controls.MetroButton txtVerTodoSala;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox txtBuscarSala;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroGrid mgSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DNI;
        private MetroFramework.Controls.MetroComboBox txtSalasAño;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroComboBox txtturno;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnAlta;
        private MetroFramework.Controls.MetroTextBox txtNombreCurso;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox txtGrado;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid mgReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
    }
}