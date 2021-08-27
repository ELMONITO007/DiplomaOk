namespace DiplomaFinal.Gesion_de_Salas
{
    partial class frmABMsalas
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
            this.tabIncripcion = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.chTiempo = new MetroFramework.Controls.MetroCheckBox();
            this.txtTipo = new MetroFramework.Controls.MetroComboBox();
            this.btnAltaSala = new MetroFramework.Controls.MetroButton();
            this.btnModificarSala = new MetroFramework.Controls.MetroButton();
            this.txtVerTodoSala = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.txtBuscarSala = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.txtCapacidad = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.mgSala = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabIncripcion.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSala)).BeginInit();
            this.SuspendLayout();
            // 
            // tabIncripcion
            // 
            this.tabIncripcion.Controls.Add(this.metroTabPage3);
            this.tabIncripcion.Location = new System.Drawing.Point(54, 66);
            this.tabIncripcion.Name = "tabIncripcion";
            this.tabIncripcion.SelectedIndex = 0;
            this.tabIncripcion.Size = new System.Drawing.Size(1224, 607);
            this.tabIncripcion.TabIndex = 2;
            this.tabIncripcion.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.chTiempo);
            this.metroTabPage3.Controls.Add(this.txtTipo);
            this.metroTabPage3.Controls.Add(this.btnAltaSala);
            this.metroTabPage3.Controls.Add(this.btnModificarSala);
            this.metroTabPage3.Controls.Add(this.txtVerTodoSala);
            this.metroTabPage3.Controls.Add(this.metroButton5);
            this.metroTabPage3.Controls.Add(this.txtBuscarSala);
            this.metroTabPage3.Controls.Add(this.metroLabel12);
            this.metroTabPage3.Controls.Add(this.txtCapacidad);
            this.metroTabPage3.Controls.Add(this.txtNombre);
            this.metroTabPage3.Controls.Add(this.metroLabel17);
            this.metroTabPage3.Controls.Add(this.metroLabel18);
            this.metroTabPage3.Controls.Add(this.metroLabel19);
            this.metroTabPage3.Controls.Add(this.metroLabel20);
            this.metroTabPage3.Controls.Add(this.mgSala);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1216, 565);
            this.metroTabPage3.TabIndex = 3;
            this.metroTabPage3.Tag = "Salas";
            this.metroTabPage3.Text = "Salas";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // chTiempo
            // 
            this.chTiempo.AutoSize = true;
            this.chTiempo.Location = new System.Drawing.Point(903, 188);
            this.chTiempo.Name = "chTiempo";
            this.chTiempo.Size = new System.Drawing.Size(120, 15);
            this.chTiempo.TabIndex = 35;
            this.chTiempo.Text = "Sala para una hora";
            this.chTiempo.UseSelectable = true;
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.ItemHeight = 23;
            this.txtTipo.Location = new System.Drawing.Point(891, 141);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(232, 29);
            this.txtTipo.TabIndex = 34;
            this.txtTipo.UseSelectable = true;
            // 
            // btnAltaSala
            // 
            this.btnAltaSala.Location = new System.Drawing.Point(919, 404);
            this.btnAltaSala.Name = "btnAltaSala";
            this.btnAltaSala.Size = new System.Drawing.Size(107, 23);
            this.btnAltaSala.TabIndex = 33;
            this.btnAltaSala.Tag = "Alta";
            this.btnAltaSala.Text = "Alta";
            this.btnAltaSala.UseSelectable = true;
            this.btnAltaSala.Click += new System.EventHandler(this.btnAltaSala_Click);
            // 
            // btnModificarSala
            // 
            this.btnModificarSala.Location = new System.Drawing.Point(736, 404);
            this.btnModificarSala.Name = "btnModificarSala";
            this.btnModificarSala.Size = new System.Drawing.Size(107, 23);
            this.btnModificarSala.TabIndex = 32;
            this.btnModificarSala.Tag = "Modificar";
            this.btnModificarSala.Text = "Modificar";
            this.btnModificarSala.UseSelectable = true;
            this.btnModificarSala.Click += new System.EventHandler(this.btnModificarSala_Click);
            // 
            // txtVerTodoSala
            // 
            this.txtVerTodoSala.Location = new System.Drawing.Point(361, 52);
            this.txtVerTodoSala.Name = "txtVerTodoSala";
            this.txtVerTodoSala.Size = new System.Drawing.Size(74, 23);
            this.txtVerTodoSala.TabIndex = 31;
            this.txtVerTodoSala.Tag = "Ver Todo";
            this.txtVerTodoSala.Text = "Ver todo";
            this.txtVerTodoSala.UseSelectable = true;
            this.txtVerTodoSala.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(244, 52);
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
            this.txtBuscarSala.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtBuscarSala.CustomButton.Name = "";
            this.txtBuscarSala.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBuscarSala.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscarSala.CustomButton.TabIndex = 1;
            this.txtBuscarSala.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscarSala.CustomButton.UseSelectable = true;
            this.txtBuscarSala.CustomButton.Visible = false;
            this.txtBuscarSala.Lines = new string[0];
            this.txtBuscarSala.Location = new System.Drawing.Point(93, 52);
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
            this.metroLabel12.Location = new System.Drawing.Point(17, 52);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(47, 19);
            this.metroLabel12.TabIndex = 28;
            this.metroLabel12.Tag = "Buscar";
            this.metroLabel12.Text = "Buscar";
            // 
            // txtCapacidad
            // 
            // 
            // 
            // 
            this.txtCapacidad.CustomButton.Image = null;
            this.txtCapacidad.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtCapacidad.CustomButton.Name = "";
            this.txtCapacidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCapacidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCapacidad.CustomButton.TabIndex = 1;
            this.txtCapacidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCapacidad.CustomButton.UseSelectable = true;
            this.txtCapacidad.CustomButton.Visible = false;
            this.txtCapacidad.Lines = new string[0];
            this.txtCapacidad.Location = new System.Drawing.Point(891, 85);
            this.txtCapacidad.MaxLength = 32767;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.PasswordChar = '\0';
            this.txtCapacidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCapacidad.SelectedText = "";
            this.txtCapacidad.SelectionLength = 0;
            this.txtCapacidad.SelectionStart = 0;
            this.txtCapacidad.ShortcutsEnabled = true;
            this.txtCapacidad.Size = new System.Drawing.Size(232, 23);
            this.txtCapacidad.TabIndex = 24;
            this.txtCapacidad.UseSelectable = true;
            this.txtCapacidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCapacidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(891, 33);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(232, 23);
            this.txtNombre.TabIndex = 23;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(761, 136);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(35, 19);
            this.metroLabel17.TabIndex = 20;
            this.metroLabel17.Tag = "Tipo";
            this.metroLabel17.Text = "Tipo";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(761, 85);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(72, 19);
            this.metroLabel18.TabIndex = 19;
            this.metroLabel18.Tag = "Capacidad";
            this.metroLabel18.Text = "Capacidad";
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Location = new System.Drawing.Point(761, 33);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(59, 19);
            this.metroLabel19.TabIndex = 18;
            this.metroLabel19.Tag = "Nombre";
            this.metroLabel19.Text = "Nombre";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(761, 184);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(120, 19);
            this.metroLabel20.TabIndex = 21;
            this.metroLabel20.Tag = "Sala para una hora";
            this.metroLabel20.Text = "Sala para una hora";
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
            this.mgSala.Location = new System.Drawing.Point(-2, 141);
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
            this.mgSala.Size = new System.Drawing.Size(732, 350);
            this.mgSala.TabIndex = 17;
            this.mgSala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgSala_CellContentClick);
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
            // frmABMsalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.tabIncripcion);
            this.Name = "frmABMsalas";
            this.Text = "ABM Salas";
            this.Load += new System.EventHandler(this.frmABMsalas_Load);
            this.tabIncripcion.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgSala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabIncripcion;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton btnAltaSala;
        private MetroFramework.Controls.MetroButton btnModificarSala;
        private MetroFramework.Controls.MetroButton txtVerTodoSala;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroTextBox txtBuscarSala;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtCapacidad;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroGrid mgSala;
        private MetroFramework.Controls.MetroCheckBox chTiempo;
        private MetroFramework.Controls.MetroComboBox txtTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DNI;
    }
}