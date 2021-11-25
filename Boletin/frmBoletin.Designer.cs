namespace DiplomaFinal.Gestion_Boletin
{
    partial class frmBoletin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAlta = new MetroFramework.Controls.MetroButton();
            this.btnBaja = new MetroFramework.Controls.MetroButton();
            this.btnVerBoletin = new MetroFramework.Controls.MetroButton();
            this.txtCurso = new MetroFramework.Controls.MetroComboBox();
            this.txtAlumno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.mgVer = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cutrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCuatrimestre = new MetroFramework.Controls.MetroComboBox();
            this.txtNota = new MetroFramework.Controls.MetroTextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.mgVer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(527, 120);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(130, 33);
            this.btnAlta.TabIndex = 0;
            this.btnAlta.Tag = "Alta";
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseSelectable = true;
            this.btnAlta.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(705, 120);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(130, 33);
            this.btnBaja.TabIndex = 1;
            this.btnBaja.Tag = "Baja";
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseSelectable = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnVerBoletin
            // 
            this.btnVerBoletin.Location = new System.Drawing.Point(902, 120);
            this.btnVerBoletin.Name = "btnVerBoletin";
            this.btnVerBoletin.Size = new System.Drawing.Size(130, 33);
            this.btnVerBoletin.TabIndex = 2;
            this.btnVerBoletin.Tag = "Ver Boletin";
            this.btnVerBoletin.Text = "Ver Boletin";
            this.btnVerBoletin.UseSelectable = true;
            this.btnVerBoletin.Click += new System.EventHandler(this.btnVerBoletin_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.FormattingEnabled = true;
            this.txtCurso.ItemHeight = 23;
            this.txtCurso.Location = new System.Drawing.Point(156, 118);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(289, 29);
            this.txtCurso.TabIndex = 44;
            this.txtCurso.UseSelectable = true;
            this.txtCurso.SelectedIndexChanged += new System.EventHandler(this.txtCurso_SelectedIndexChanged);
            // 
            // txtAlumno
            // 
            this.txtAlumno.FormattingEnabled = true;
            this.txtAlumno.ItemHeight = 23;
            this.txtAlumno.Location = new System.Drawing.Point(156, 161);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(289, 29);
            this.txtAlumno.TabIndex = 43;
            this.txtAlumno.UseSelectable = true;
            this.txtAlumno.SelectedIndexChanged += new System.EventHandler(this.txtAlumno_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(67, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Tag = "Alumno";
            this.metroLabel3.Text = "Alumno";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(67, 118);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(43, 19);
            this.metroLabel12.TabIndex = 41;
            this.metroLabel12.Tag = "Curso";
            this.metroLabel12.Text = "Curso";
            // 
            // mgVer
            // 
            this.mgVer.AllowUserToAddRows = false;
            this.mgVer.AllowUserToDeleteRows = false;
            this.mgVer.AllowUserToResizeRows = false;
            this.mgVer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mgVer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgVer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgVer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgVer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Apellido_,
            this.Año,
            this.Cutrimestre,
            this.Observaciones});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgVer.DefaultCellStyle = dataGridViewCellStyle3;
            this.mgVer.EnableHeadersVisualStyles = false;
            this.mgVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgVer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVer.Location = new System.Drawing.Point(48, 206);
            this.mgVer.Name = "mgVer";
            this.mgVer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgVer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgVer.Size = new System.Drawing.Size(514, 350);
            this.mgVer.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Legajo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // Apellido_
            // 
            this.Apellido_.HeaderText = "Apellido";
            this.Apellido_.Name = "Apellido_";
            this.Apellido_.ReadOnly = true;
            this.Apellido_.Width = 73;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.ReadOnly = true;
            this.Año.Width = 51;
            // 
            // Cutrimestre
            // 
            this.Cutrimestre.HeaderText = "Cutrimestre";
            this.Cutrimestre.Name = "Cutrimestre";
            this.Cutrimestre.ReadOnly = true;
            this.Cutrimestre.Width = 89;
            // 
            // Observaciones
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 105;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(568, 206);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Tag = "Cutrimestre";
            this.metroLabel2.Text = "Cutrimestre";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(568, 257);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Tag = "Notas";
            this.metroLabel4.Text = "Notas";
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.FormattingEnabled = true;
            this.txtCuatrimestre.ItemHeight = 23;
            this.txtCuatrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.txtCuatrimestre.Location = new System.Drawing.Point(667, 196);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(289, 29);
            this.txtCuatrimestre.TabIndex = 48;
            this.txtCuatrimestre.UseSelectable = true;
            this.txtCuatrimestre.SelectedIndexChanged += new System.EventHandler(this.txtCuatrimestre_SelectedIndexChanged);
            // 
            // txtNota
            // 
            // 
            // 
            // 
            this.txtNota.CustomButton.Image = null;
            this.txtNota.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtNota.CustomButton.Name = "";
            this.txtNota.CustomButton.Size = new System.Drawing.Size(163, 163);
            this.txtNota.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNota.CustomButton.TabIndex = 1;
            this.txtNota.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNota.CustomButton.UseSelectable = true;
            this.txtNota.CustomButton.Visible = false;
            this.txtNota.Lines = new string[0];
            this.txtNota.Location = new System.Drawing.Point(667, 257);
            this.txtNota.MaxLength = 32767;
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.PasswordChar = '\0';
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNota.SelectedText = "";
            this.txtNota.SelectionLength = 0;
            this.txtNota.SelectionStart = 0;
            this.txtNota.ShortcutsEnabled = true;
            this.txtNota.Size = new System.Drawing.Size(355, 165);
            this.txtNota.TabIndex = 49;
            this.txtNota.UseSelectable = true;
            this.txtNota.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNota.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Program Files (x86)\\Crear y Ser\\Leame.chm";
            // 
            // frmBoletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 650);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.mgVer);
            this.Controls.Add(this.btnVerBoletin);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnAlta);
            this.helpProvider1.SetHelpKeyword(this, "Alta boletin");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "frmBoletin";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Boletin";
            this.Load += new System.EventHandler(this.frmBoletin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAlta;
        private MetroFramework.Controls.MetroButton btnBaja;
        private MetroFramework.Controls.MetroButton btnVerBoletin;
        private MetroFramework.Controls.MetroComboBox txtCurso;
        private MetroFramework.Controls.MetroComboBox txtAlumno;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroGrid mgVer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox txtCuatrimestre;
        private MetroFramework.Controls.MetroTextBox txtNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cutrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}