
namespace DiplomaFinal.Servicio
{
    partial class frmUsuario
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
            this.Alta = new MetroFramework.Controls.MetroTabControl();
            this.mtListar = new MetroFramework.Controls.MetroTabPage();
            this.btnContraseña = new MetroFramework.Controls.MetroButton();
            this.lblErrContraseña = new MetroFramework.Controls.MetroLabel();
            this.lblErrUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblErrApellido = new MetroFramework.Controls.MetroLabel();
            this.lblErrNombre = new MetroFramework.Controls.MetroLabel();
            this.btnAlta = new MetroFramework.Controls.MetroButton();
            this.txtContraseña = new MetroFramework.Controls.MetroTextBox();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblErrorBuscar = new MetroFramework.Controls.MetroLabel();
            this.btnDesbloquear = new MetroFramework.Controls.MetroButton();
            this.btnEliminar = new MetroFramework.Controls.MetroButton();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.mlBuscar = new MetroFramework.Controls.MetroLabel();
            this.mgUsuario = new MetroFramework.Controls.MetroGrid();
            this.ID_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntentosFallidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Alta.SuspendLayout();
            this.mtListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Alta
            // 
            this.Alta.Controls.Add(this.mtListar);
            this.Alta.Location = new System.Drawing.Point(23, 72);
            this.Alta.Name = "Alta";
            this.Alta.SelectedIndex = 0;
            this.Alta.Size = new System.Drawing.Size(1387, 529);
            this.Alta.TabIndex = 5;
            this.Alta.UseSelectable = true;
            // 
            // mtListar
            // 
            this.mtListar.BackgroundImage = global::DiplomaFinal.Properties.Resources.Fondo_pantalla_gral_2;
            this.mtListar.Controls.Add(this.btnContraseña);
            this.mtListar.Controls.Add(this.lblErrContraseña);
            this.mtListar.Controls.Add(this.lblErrUsuario);
            this.mtListar.Controls.Add(this.lblErrApellido);
            this.mtListar.Controls.Add(this.lblErrNombre);
            this.mtListar.Controls.Add(this.btnAlta);
            this.mtListar.Controls.Add(this.txtContraseña);
            this.mtListar.Controls.Add(this.txtUsuario);
            this.mtListar.Controls.Add(this.txtApellido);
            this.mtListar.Controls.Add(this.txtNombre);
            this.mtListar.Controls.Add(this.metroLabel4);
            this.mtListar.Controls.Add(this.metroLabel3);
            this.mtListar.Controls.Add(this.metroLabel2);
            this.mtListar.Controls.Add(this.metroLabel1);
            this.mtListar.Controls.Add(this.lblErrorBuscar);
            this.mtListar.Controls.Add(this.btnDesbloquear);
            this.mtListar.Controls.Add(this.btnEliminar);
            this.mtListar.Controls.Add(this.btnModificar);
            this.mtListar.Controls.Add(this.btnBuscar);
            this.mtListar.Controls.Add(this.txtBuscar);
            this.mtListar.Controls.Add(this.mlBuscar);
            this.mtListar.Controls.Add(this.mgUsuario);
            this.mtListar.HorizontalScrollbarBarColor = true;
            this.mtListar.HorizontalScrollbarHighlightOnWheel = false;
            this.mtListar.HorizontalScrollbarSize = 10;
            this.mtListar.Location = new System.Drawing.Point(4, 38);
            this.mtListar.Name = "mtListar";
            this.mtListar.Size = new System.Drawing.Size(1379, 487);
            this.mtListar.TabIndex = 0;
            this.mtListar.Tag = "Usuario";
            this.mtListar.Text = "Usuario";
            this.mtListar.VerticalScrollbarBarColor = true;
            this.mtListar.VerticalScrollbarHighlightOnWheel = false;
            this.mtListar.VerticalScrollbarSize = 10;
            // 
            // btnContraseña
            // 
            this.btnContraseña.Location = new System.Drawing.Point(241, 431);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(118, 23);
            this.btnContraseña.TabIndex = 28;
            this.btnContraseña.Tag = "Cambiar contraseña";
            this.btnContraseña.Text = "Cambiar Contraseña";
            this.btnContraseña.UseSelectable = true;
            // 
            // lblErrContraseña
            // 
            this.lblErrContraseña.AutoSize = true;
            this.lblErrContraseña.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblErrContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrContraseña.Location = new System.Drawing.Point(1320, 255);
            this.lblErrContraseña.Name = "lblErrContraseña";
            this.lblErrContraseña.Size = new System.Drawing.Size(0, 0);
            this.lblErrContraseña.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrContraseña.TabIndex = 27;
            this.lblErrContraseña.UseCustomForeColor = true;
            // 
            // lblErrUsuario
            // 
            this.lblErrUsuario.AutoSize = true;
            this.lblErrUsuario.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblErrUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrUsuario.Location = new System.Drawing.Point(1320, 205);
            this.lblErrUsuario.Name = "lblErrUsuario";
            this.lblErrUsuario.Size = new System.Drawing.Size(0, 0);
            this.lblErrUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrUsuario.TabIndex = 26;
            this.lblErrUsuario.UseCustomForeColor = true;
            // 
            // lblErrApellido
            // 
            this.lblErrApellido.AutoSize = true;
            this.lblErrApellido.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblErrApellido.ForeColor = System.Drawing.Color.Red;
            this.lblErrApellido.Location = new System.Drawing.Point(1320, 150);
            this.lblErrApellido.Name = "lblErrApellido";
            this.lblErrApellido.Size = new System.Drawing.Size(0, 0);
            this.lblErrApellido.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrApellido.TabIndex = 25;
            this.lblErrApellido.UseCustomForeColor = true;
            // 
            // lblErrNombre
            // 
            this.lblErrNombre.AutoSize = true;
            this.lblErrNombre.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblErrNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrNombre.Location = new System.Drawing.Point(1320, 97);
            this.lblErrNombre.Name = "lblErrNombre";
            this.lblErrNombre.Size = new System.Drawing.Size(0, 0);
            this.lblErrNombre.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrNombre.TabIndex = 24;
            this.lblErrNombre.UseCustomForeColor = true;
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(775, 373);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 23);
            this.btnAlta.TabIndex = 23;
            this.btnAlta.Tag = "Alta";
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseSelectable = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // txtContraseña
            // 
            // 
            // 
            // 
            this.txtContraseña.CustomButton.Image = null;
            this.txtContraseña.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtContraseña.CustomButton.Name = "";
            this.txtContraseña.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContraseña.CustomButton.TabIndex = 1;
            this.txtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContraseña.CustomButton.UseSelectable = true;
            this.txtContraseña.CustomButton.Visible = false;
            this.txtContraseña.Lines = new string[0];
            this.txtContraseña.Location = new System.Drawing.Point(933, 255);
            this.txtContraseña.MaxLength = 32767;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.ShortcutsEnabled = true;
            this.txtContraseña.Size = new System.Drawing.Size(369, 23);
            this.txtContraseña.TabIndex = 22;
            this.txtContraseña.UseSelectable = true;
            this.txtContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContraseña.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(933, 202);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(369, 23);
            this.txtUsuario.TabIndex = 21;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtApellido
            // 
            // 
            // 
            // 
            this.txtApellido.CustomButton.Image = null;
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(933, 147);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(369, 23);
            this.txtApellido.TabIndex = 20;
            this.txtApellido.UseSelectable = true;
            this.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(933, 98);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(369, 23);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(775, 255);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 19);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Tag = "Contraseña";
            this.metroLabel4.Text = "Contraseña";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(775, 202);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Tag = "Usuario";
            this.metroLabel3.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(775, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Tag = "Apellido";
            this.metroLabel2.Text = "Apellido";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(775, 98);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Tag = "Nombre";
            this.metroLabel1.Text = "Nombre";
            // 
            // lblErrorBuscar
            // 
            this.lblErrorBuscar.AutoSize = true;
            this.lblErrorBuscar.Location = new System.Drawing.Point(108, 66);
            this.lblErrorBuscar.Name = "lblErrorBuscar";
            this.lblErrorBuscar.Size = new System.Drawing.Size(0, 0);
            this.lblErrorBuscar.TabIndex = 11;
            this.lblErrorBuscar.Tag = "Error Buscar";
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDesbloquear.Location = new System.Drawing.Point(398, 431);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(75, 23);
            this.btnDesbloquear.TabIndex = 10;
            this.btnDesbloquear.Tag = "Desbloquear";
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDesbloquear.UseSelectable = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(901, 373);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Tag = "Eliminar";
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEliminar.UseSelectable = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(1028, 373);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Tag = "Modificar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(398, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Tag = "Buscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBuscar.UseSelectable = true;
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(108, 40);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(208, 23);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlBuscar
            // 
            this.mlBuscar.AutoSize = true;
            this.mlBuscar.Location = new System.Drawing.Point(35, 40);
            this.mlBuscar.Name = "mlBuscar";
            this.mlBuscar.Size = new System.Drawing.Size(47, 19);
            this.mlBuscar.TabIndex = 5;
            this.mlBuscar.Tag = "Buscar";
            this.mlBuscar.Text = "Buscar";
            // 
            // mgUsuario
            // 
            this.mgUsuario.AllowUserToAddRows = false;
            this.mgUsuario.AllowUserToDeleteRows = false;
            this.mgUsuario.AllowUserToResizeRows = false;
            this.mgUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mgUsuario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Usuario,
            this.NombreUsuario,
            this.Nombre,
            this.Apellido,
            this.IntentosFallidos,
            this.Bloqueado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgUsuario.EnableHeadersVisualStyles = false;
            this.mgUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgUsuario.Location = new System.Drawing.Point(35, 93);
            this.mgUsuario.Name = "mgUsuario";
            this.mgUsuario.ReadOnly = true;
            this.mgUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgUsuario.RowHeadersWidth = 62;
            this.mgUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgUsuario.Size = new System.Drawing.Size(734, 287);
            this.mgUsuario.TabIndex = 4;
            this.mgUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgUsuario_CellContentClick);
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.HeaderText = "ID";
            this.ID_Usuario.MinimumWidth = 8;
            this.ID_Usuario.Name = "ID_Usuario";
            this.ID_Usuario.ReadOnly = true;
            this.ID_Usuario.Visible = false;
            this.ID_Usuario.Width = 41;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "Nombre Usuario";
            this.NombreUsuario.MinimumWidth = 8;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 115;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 82;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 84;
            // 
            // IntentosFallidos
            // 
            this.IntentosFallidos.HeaderText = "Intentos Logueo";
            this.IntentosFallidos.MinimumWidth = 8;
            this.IntentosFallidos.Name = "IntentosFallidos";
            this.IntentosFallidos.ReadOnly = true;
            this.IntentosFallidos.Width = 116;
            // 
            // Bloqueado
            // 
            this.Bloqueado.HeaderText = "Bloqueado";
            this.Bloqueado.MinimumWidth = 8;
            this.Bloqueado.Name = "Bloqueado";
            this.Bloqueado.ReadOnly = true;
            this.Bloqueado.Width = 67;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 649);
            this.Controls.Add(this.Alta);
            this.Name = "frmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.Alta.ResumeLayout(false);
            this.mtListar.ResumeLayout(false);
            this.mtListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Alta;
        private MetroFramework.Controls.MetroTabPage mtListar;
        private MetroFramework.Controls.MetroButton btnContraseña;
        private MetroFramework.Controls.MetroLabel lblErrContraseña;
        private MetroFramework.Controls.MetroLabel lblErrUsuario;
        private MetroFramework.Controls.MetroLabel lblErrApellido;
        private MetroFramework.Controls.MetroLabel lblErrNombre;
        private MetroFramework.Controls.MetroButton btnAlta;
        private MetroFramework.Controls.MetroTextBox txtContraseña;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblErrorBuscar;
        private MetroFramework.Controls.MetroButton btnDesbloquear;
        private MetroFramework.Controls.MetroButton btnEliminar;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroLabel mlBuscar;
        private MetroFramework.Controls.MetroGrid mgUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntentosFallidos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Bloqueado;
    }
}