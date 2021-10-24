namespace DiplomaFinal.Gestion_de_Personas
{
    partial class frmEspecialidad
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
            this.btnEliminarEsp = new MetroFramework.Controls.MetroButton();
            this.mgEspecialidades = new MetroFramework.Controls.MetroGrid();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAltaEsp = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtEspecialidadAlta = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mgEspecialidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarEsp
            // 
            this.btnEliminarEsp.Location = new System.Drawing.Point(762, 257);
            this.btnEliminarEsp.Name = "btnEliminarEsp";
            this.btnEliminarEsp.Size = new System.Drawing.Size(106, 26);
            this.btnEliminarEsp.TabIndex = 48;
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
            this.Nombre});
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
            this.mgEspecialidades.Location = new System.Drawing.Point(151, 133);
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
            this.mgEspecialidades.Size = new System.Drawing.Size(312, 379);
            this.mgEspecialidades.TabIndex = 43;
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
            // btnAltaEsp
            // 
            this.btnAltaEsp.Location = new System.Drawing.Point(582, 257);
            this.btnAltaEsp.Name = "btnAltaEsp";
            this.btnAltaEsp.Size = new System.Drawing.Size(106, 23);
            this.btnAltaEsp.TabIndex = 42;
            this.btnAltaEsp.Tag = "Alta";
            this.btnAltaEsp.Text = "Alta";
            this.btnAltaEsp.UseSelectable = true;
            this.btnAltaEsp.Click += new System.EventHandler(this.btnAltaEsp_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(582, 155);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(81, 19);
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Tag = "Especialidad";
            this.metroLabel11.Text = "Especialidad";
            // 
            // txtEspecialidadAlta
            // 
            this.txtEspecialidadAlta.FormattingEnabled = true;
            this.txtEspecialidadAlta.ItemHeight = 23;
            this.txtEspecialidadAlta.Location = new System.Drawing.Point(689, 155);
            this.txtEspecialidadAlta.Name = "txtEspecialidadAlta";
            this.txtEspecialidadAlta.Size = new System.Drawing.Size(359, 29);
            this.txtEspecialidadAlta.TabIndex = 49;
            this.txtEspecialidadAlta.UseSelectable = true;
            this.txtEspecialidadAlta.SelectedIndexChanged += new System.EventHandler(this.txtEspecialidadAlta_SelectedIndexChanged);
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 584);
            this.Controls.Add(this.txtEspecialidadAlta);
            this.Controls.Add(this.btnEliminarEsp);
            this.Controls.Add(this.mgEspecialidades);
            this.Controls.Add(this.btnAltaEsp);
            this.Controls.Add(this.metroLabel11);
            this.Name = "frmEspecialidad";
            this.Text = "Especialidad";
            this.Load += new System.EventHandler(this.frmEspecialidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgEspecialidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnEliminarEsp;
        private MetroFramework.Controls.MetroGrid mgEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private MetroFramework.Controls.MetroButton btnAltaEsp;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox txtEspecialidadAlta;
    }
}