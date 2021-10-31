namespace DiplomaFinal.VistaMaestroGrado
{
    partial class frmComunicacionesMaestra
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtCurso = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtColeccione = new MetroFramework.Controls.MetroTextBox();
            this.mgListaComunicado = new MetroFramework.Controls.MetroGrid();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txtCursoListado = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtNuevaComunicacion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mgAlumno = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgListaComunicado)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(6, 26);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1328, 653);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtCurso);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.txtColeccione);
            this.metroTabPage1.Controls.Add(this.mgListaComunicado);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1320, 611);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Tag = "Listado";
            this.metroTabPage1.Text = "Listado";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtCurso
            // 
            this.txtCurso.FormattingEnabled = true;
            this.txtCurso.ItemHeight = 23;
            this.txtCurso.Location = new System.Drawing.Point(81, 27);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(332, 29);
            this.txtCurso.TabIndex = 66;
            this.txtCurso.UseSelectable = true;
            this.txtCurso.SelectedIndexChanged += new System.EventHandler(this.txtCurso_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 65;
            this.metroLabel2.Tag = "Curso";
            this.metroLabel2.Text = "Curso";
            // 
            // txtColeccione
            // 
            // 
            // 
            // 
            this.txtColeccione.CustomButton.Image = null;
            this.txtColeccione.CustomButton.Location = new System.Drawing.Point(-83, 2);
            this.txtColeccione.CustomButton.Name = "";
            this.txtColeccione.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.txtColeccione.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColeccione.CustomButton.TabIndex = 1;
            this.txtColeccione.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColeccione.CustomButton.UseSelectable = true;
            this.txtColeccione.CustomButton.Visible = false;
            this.txtColeccione.Lines = new string[0];
            this.txtColeccione.Location = new System.Drawing.Point(995, 109);
            this.txtColeccione.MaxLength = 32767;
            this.txtColeccione.Multiline = true;
            this.txtColeccione.Name = "txtColeccione";
            this.txtColeccione.PasswordChar = '\0';
            this.txtColeccione.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColeccione.SelectedText = "";
            this.txtColeccione.SelectionLength = 0;
            this.txtColeccione.SelectionStart = 0;
            this.txtColeccione.ShortcutsEnabled = true;
            this.txtColeccione.Size = new System.Drawing.Size(311, 396);
            this.txtColeccione.TabIndex = 26;
            this.txtColeccione.UseSelectable = true;
            this.txtColeccione.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColeccione.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mgListaComunicado
            // 
            this.mgListaComunicado.AllowUserToAddRows = false;
            this.mgListaComunicado.AllowUserToDeleteRows = false;
            this.mgListaComunicado.AllowUserToOrderColumns = true;
            this.mgListaComunicado.AllowUserToResizeRows = false;
            this.mgListaComunicado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgListaComunicado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgListaComunicado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgListaComunicado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgListaComunicado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgListaComunicado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgListaComunicado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Visto,
            this.Fecha,
            this.Maestro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgListaComunicado.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgListaComunicado.EnableHeadersVisualStyles = false;
            this.mgListaComunicado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgListaComunicado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgListaComunicado.Location = new System.Drawing.Point(13, 124);
            this.mgListaComunicado.Name = "mgListaComunicado";
            this.mgListaComunicado.ReadOnly = true;
            this.mgListaComunicado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgListaComunicado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgListaComunicado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgListaComunicado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgListaComunicado.Size = new System.Drawing.Size(923, 350);
            this.mgListaComunicado.TabIndex = 21;
            this.mgListaComunicado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgListaComunicado_CellContentClick);
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Visto
            // 
            this.Visto.HeaderText = "Visto";
            this.Visto.Name = "Visto";
            this.Visto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Maestro
            // 
            this.Maestro.HeaderText = "Maestro";
            this.Maestro.Name = "Maestro";
            this.Maestro.ReadOnly = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.txtCursoListado);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Controls.Add(this.txtNuevaComunicacion);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.mgAlumno);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1320, 611);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Tag = "Nueva Comunicacion";
            this.metroTabPage2.Text = "Nueva Comunicacion";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // txtCursoListado
            // 
            this.txtCursoListado.FormattingEnabled = true;
            this.txtCursoListado.ItemHeight = 23;
            this.txtCursoListado.Location = new System.Drawing.Point(77, 26);
            this.txtCursoListado.Name = "txtCursoListado";
            this.txtCursoListado.Size = new System.Drawing.Size(332, 29);
            this.txtCursoListado.TabIndex = 70;
            this.txtCursoListado.UseSelectable = true;
            this.txtCursoListado.SelectedIndexChanged += new System.EventHandler(this.txtCursoListado_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 26);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 69;
            this.metroLabel6.Tag = "Curso";
            this.metroLabel6.Text = "Curso";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(852, 506);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(198, 54);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Tag = "Alta";
            this.metroButton1.Text = "Alta";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtNuevaComunicacion
            // 
            // 
            // 
            // 
            this.txtNuevaComunicacion.CustomButton.Image = null;
            this.txtNuevaComunicacion.CustomButton.Location = new System.Drawing.Point(-83, 2);
            this.txtNuevaComunicacion.CustomButton.Name = "";
            this.txtNuevaComunicacion.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.txtNuevaComunicacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevaComunicacion.CustomButton.TabIndex = 1;
            this.txtNuevaComunicacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevaComunicacion.CustomButton.UseSelectable = true;
            this.txtNuevaComunicacion.CustomButton.Visible = false;
            this.txtNuevaComunicacion.Lines = new string[0];
            this.txtNuevaComunicacion.Location = new System.Drawing.Point(926, 26);
            this.txtNuevaComunicacion.MaxLength = 32767;
            this.txtNuevaComunicacion.Multiline = true;
            this.txtNuevaComunicacion.Name = "txtNuevaComunicacion";
            this.txtNuevaComunicacion.PasswordChar = '\0';
            this.txtNuevaComunicacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevaComunicacion.SelectedText = "";
            this.txtNuevaComunicacion.SelectionLength = 0;
            this.txtNuevaComunicacion.SelectionStart = 0;
            this.txtNuevaComunicacion.ShortcutsEnabled = true;
            this.txtNuevaComunicacion.Size = new System.Drawing.Size(311, 396);
            this.txtNuevaComunicacion.TabIndex = 27;
            this.txtNuevaComunicacion.UseSelectable = true;
            this.txtNuevaComunicacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevaComunicacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(833, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Tag = "Comunicado";
            this.metroLabel1.Text = "Comunicado";
            // 
            // mgAlumno
            // 
            this.mgAlumno.AllowUserToAddRows = false;
            this.mgAlumno.AllowUserToDeleteRows = false;
            this.mgAlumno.AllowUserToOrderColumns = true;
            this.mgAlumno.AllowUserToResizeRows = false;
            this.mgAlumno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgAlumno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Direccion,
            this.dataGridViewTextBoxColumn4,
            this.FechaNacimiento});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgAlumno.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgAlumno.EnableHeadersVisualStyles = false;
            this.mgAlumno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgAlumno.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlumno.Location = new System.Drawing.Point(3, 134);
            this.mgAlumno.Name = "mgAlumno";
            this.mgAlumno.ReadOnly = true;
            this.mgAlumno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlumno.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgAlumno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgAlumno.Size = new System.Drawing.Size(732, 350);
            this.mgAlumno.TabIndex = 2;
            this.mgAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgAlumno_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Legajo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // frmComunicacionesMaestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 813);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmComunicacionesMaestra";
            this.Load += new System.EventHandler(this.frmComunicacionesMaestra_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgListaComunicado)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtColeccione;
        private MetroFramework.Controls.MetroGrid mgListaComunicado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maestro;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtNuevaComunicacion;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid mgAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private MetroFramework.Controls.MetroComboBox txtCurso;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox txtCursoListado;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}