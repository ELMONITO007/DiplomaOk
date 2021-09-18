namespace DiplomaFinal.Gestion_Boletin
{
    partial class frmMateria
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
            this.btnModificarEsp = new MetroFramework.Controls.MetroButton();
            this.btnEliminarEsp = new MetroFramework.Controls.MetroButton();
            this.mgEspecialidades = new MetroFramework.Controls.MetroGrid();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAltaEsp = new MetroFramework.Controls.MetroButton();
            this.txtMateria = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtEspecialidad = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificarEsp
            // 
            this.btnModificarEsp.Location = new System.Drawing.Point(834, 394);
            this.btnModificarEsp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarEsp.Name = "btnModificarEsp";
            this.btnModificarEsp.Size = new System.Drawing.Size(159, 35);
            this.btnModificarEsp.TabIndex = 47;
            this.btnModificarEsp.Tag = "Modificar";
            this.btnModificarEsp.Text = "Modificar";
            this.btnModificarEsp.UseSelectable = true;
            this.btnModificarEsp.Click += new System.EventHandler(this.btnModificarEsp_Click);
            // 
            // btnEliminarEsp
            // 
            this.btnEliminarEsp.Location = new System.Drawing.Point(1010, 389);
            this.btnEliminarEsp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarEsp.Name = "btnEliminarEsp";
            this.btnEliminarEsp.Size = new System.Drawing.Size(159, 40);
            this.btnEliminarEsp.TabIndex = 46;
            this.btnEliminarEsp.Tag = "Eliminar";
            this.btnEliminarEsp.Text = "Eliminar";
            this.btnEliminarEsp.UseSelectable = true;
            this.btnEliminarEsp.Click += new System.EventHandler(this.btnEliminarEsp_Click);
            // 
            // mgEspecialidades
            // 
            this.mgEspecialidades.AllowUserToAddRows = false;
            this.mgEspecialidades.AllowUserToDeleteRows = false;
            this.mgEspecialidades.AllowUserToResizeRows = false;
            this.mgEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mgEspecialidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mgEspecialidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEspecialidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgEspecialidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgEspecialidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEspecialidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Especialidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgEspecialidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgEspecialidades.EnableHeadersVisualStyles = false;
            this.mgEspecialidades.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgEspecialidades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgEspecialidades.Location = new System.Drawing.Point(57, 162);
            this.mgEspecialidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mgEspecialidades.MultiSelect = false;
            this.mgEspecialidades.Name = "mgEspecialidades";
            this.mgEspecialidades.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgEspecialidades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgEspecialidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgEspecialidades.Size = new System.Drawing.Size(468, 583);
            this.mgEspecialidades.TabIndex = 45;
            this.mgEspecialidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgEspecialidades_CellContentClick);
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.Visible = false;
            this.Legajo.Width = 64;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 71;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 94;
            // 
            // btnAltaEsp
            // 
            this.btnAltaEsp.Location = new System.Drawing.Point(648, 394);
            this.btnAltaEsp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaEsp.Name = "btnAltaEsp";
            this.btnAltaEsp.Size = new System.Drawing.Size(159, 35);
            this.btnAltaEsp.TabIndex = 44;
            this.btnAltaEsp.Tag = "Alta";
            this.btnAltaEsp.Text = "Alta";
            this.btnAltaEsp.UseSelectable = true;
            this.btnAltaEsp.Click += new System.EventHandler(this.btnAltaEsp_Click);
            // 
            // txtMateria
            // 
            // 
            // 
            // 
            this.txtMateria.CustomButton.Image = null;
            this.txtMateria.CustomButton.Location = new System.Drawing.Point(471, 2);
            this.txtMateria.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMateria.CustomButton.Name = "";
            this.txtMateria.CustomButton.Size = new System.Drawing.Size(50, 51);
            this.txtMateria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMateria.CustomButton.TabIndex = 1;
            this.txtMateria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMateria.CustomButton.UseSelectable = true;
            this.txtMateria.CustomButton.Visible = false;
            this.txtMateria.Lines = new string[0];
            this.txtMateria.Location = new System.Drawing.Point(834, 194);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMateria.MaxLength = 32767;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.PasswordChar = '\0';
            this.txtMateria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMateria.SelectedText = "";
            this.txtMateria.SelectionLength = 0;
            this.txtMateria.SelectionStart = 0;
            this.txtMateria.ShortcutsEnabled = true;
            this.txtMateria.Size = new System.Drawing.Size(348, 35);
            this.txtMateria.TabIndex = 43;
            this.txtMateria.UseSelectable = true;
            this.txtMateria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMateria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(662, 194);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(59, 19);
            this.metroLabel11.TabIndex = 42;
            this.metroLabel11.Tag = "Nombre";
            this.metroLabel11.Text = "Nombre";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(662, 297);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 48;
            this.metroLabel1.Tag = "Especialidad";
            this.metroLabel1.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.FormattingEnabled = true;
            this.txtEspecialidad.ItemHeight = 23;
            this.txtEspecialidad.Location = new System.Drawing.Point(834, 282);
            this.txtEspecialidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(346, 29);
            this.txtEspecialidad.TabIndex = 49;
            this.txtEspecialidad.UseSelectable = true;
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 895);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnModificarEsp);
            this.Controls.Add(this.btnEliminarEsp);
            this.Controls.Add(this.mgEspecialidades);
            this.Controls.Add(this.btnAltaEsp);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.metroLabel11);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMateria";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Load += new System.EventHandler(this.frmMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnModificarEsp;
        private MetroFramework.Controls.MetroButton btnEliminarEsp;
        private MetroFramework.Controls.MetroGrid mgEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private MetroFramework.Controls.MetroButton btnAltaEsp;
        private MetroFramework.Controls.MetroTextBox txtMateria;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox txtEspecialidad;
    }
}