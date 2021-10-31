namespace DiplomaFinal.VistaMaestroGrado
{
    partial class frmBoletinMaestro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNota = new MetroFramework.Controls.MetroTextBox();
            this.txtCuatrimestre = new MetroFramework.Controls.MetroComboBox();
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
            this.btnVerBoletin = new MetroFramework.Controls.MetroButton();
            this.btnAlta = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mgVer)).BeginInit();
            this.SuspendLayout();
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
            this.txtNota.Location = new System.Drawing.Point(660, 223);
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
            this.txtNota.TabIndex = 59;
            this.txtNota.UseSelectable = true;
            this.txtNota.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNota.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtCuatrimestre.Location = new System.Drawing.Point(660, 162);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(289, 29);
            this.txtCuatrimestre.TabIndex = 58;
            this.txtCuatrimestre.UseSelectable = true;
            // 
            // txtCurso
            // 
            this.txtCurso.FormattingEnabled = true;
            this.txtCurso.ItemHeight = 23;
            this.txtCurso.Location = new System.Drawing.Point(149, 84);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(289, 29);
            this.txtCurso.TabIndex = 57;
            this.txtCurso.UseSelectable = true;
            this.txtCurso.SelectedIndexChanged += new System.EventHandler(this.txtCurso_SelectedIndexChanged);
            // 
            // txtAlumno
            // 
            this.txtAlumno.FormattingEnabled = true;
            this.txtAlumno.ItemHeight = 23;
            this.txtAlumno.Location = new System.Drawing.Point(149, 127);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(289, 29);
            this.txtAlumno.TabIndex = 56;
            this.txtAlumno.UseSelectable = true;
            this.txtAlumno.SelectedIndexChanged += new System.EventHandler(this.txtAlumno_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(60, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 55;
            this.metroLabel3.Tag = "Alumno";
            this.metroLabel3.Text = "Alumno";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(60, 84);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(43, 19);
            this.metroLabel12.TabIndex = 54;
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
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.mgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgVer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.Apellido_,
            this.Año,
            this.Cutrimestre,
            this.Observaciones});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgVer.DefaultCellStyle = dataGridViewCellStyle27;
            this.mgVer.EnableHeadersVisualStyles = false;
            this.mgVer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgVer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgVer.Location = new System.Drawing.Point(41, 172);
            this.mgVer.Name = "mgVer";
            this.mgVer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgVer.RowHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.mgVer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgVer.Size = new System.Drawing.Size(514, 350);
            this.mgVer.TabIndex = 53;
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
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle26;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Width = 105;
            // 
            // btnVerBoletin
            // 
            this.btnVerBoletin.Location = new System.Drawing.Point(692, 86);
            this.btnVerBoletin.Name = "btnVerBoletin";
            this.btnVerBoletin.Size = new System.Drawing.Size(130, 33);
            this.btnVerBoletin.TabIndex = 52;
            this.btnVerBoletin.Tag = "Ver Boletin";
            this.btnVerBoletin.Text = "Ver Boletin";
            this.btnVerBoletin.UseSelectable = true;
            this.btnVerBoletin.Click += new System.EventHandler(this.btnVerBoletin_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(520, 86);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(130, 33);
            this.btnAlta.TabIndex = 50;
            this.btnAlta.Tag = "Alta";
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseSelectable = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(561, 223);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 61;
            this.metroLabel4.Tag = "Notas";
            this.metroLabel4.Text = "Notas";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(561, 172);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Tag = "Cutrimestre";
            this.metroLabel2.Text = "Cutrimestre";
            // 
            // frmBoletinMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 719);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.mgVer);
            this.Controls.Add(this.btnVerBoletin);
            this.Controls.Add(this.btnAlta);
            this.Name = "frmBoletinMaestro";
            this.Load += new System.EventHandler(this.frmBoletinMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgVer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtNota;
        private MetroFramework.Controls.MetroComboBox txtCuatrimestre;
        private MetroFramework.Controls.MetroComboBox txtCurso;
        private MetroFramework.Controls.MetroComboBox txtAlumno;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroGrid mgVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cutrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private MetroFramework.Controls.MetroButton btnVerBoletin;
        private MetroFramework.Controls.MetroButton btnAlta;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}