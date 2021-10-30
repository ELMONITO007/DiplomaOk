namespace DiplomaFinal.VistaAlumno
{
    partial class frmComunicadoAlumno
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
            this.mgListaComunicado = new MetroFramework.Controls.MetroGrid();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtColeccione = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mgListaComunicado)).BeginInit();
            this.SuspendLayout();
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
            this.mgListaComunicado.Location = new System.Drawing.Point(34, 183);
            this.mgListaComunicado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.mgListaComunicado.Size = new System.Drawing.Size(1108, 706);
            this.mgListaComunicado.TabIndex = 22;
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
            // txtColeccione
            // 
            // 
            // 
            // 
            this.txtColeccione.CustomButton.Image = null;
            this.txtColeccione.CustomButton.Location = new System.Drawing.Point(63, 2);
            this.txtColeccione.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtColeccione.CustomButton.Name = "";
            this.txtColeccione.CustomButton.Size = new System.Drawing.Size(910, 934);
            this.txtColeccione.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColeccione.CustomButton.TabIndex = 1;
            this.txtColeccione.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColeccione.CustomButton.UseSelectable = true;
            this.txtColeccione.CustomButton.Visible = false;
            this.txtColeccione.Lines = new string[0];
            this.txtColeccione.Location = new System.Drawing.Point(1256, 146);
            this.txtColeccione.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtColeccione.MaxLength = 32767;
            this.txtColeccione.Multiline = true;
            this.txtColeccione.Name = "txtColeccione";
            this.txtColeccione.PasswordChar = '\0';
            this.txtColeccione.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColeccione.SelectedText = "";
            this.txtColeccione.SelectionLength = 0;
            this.txtColeccione.SelectionStart = 0;
            this.txtColeccione.ShortcutsEnabled = true;
            this.txtColeccione.Size = new System.Drawing.Size(650, 609);
            this.txtColeccione.TabIndex = 27;
            this.txtColeccione.UseSelectable = true;
            this.txtColeccione.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColeccione.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1268, 788);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(285, 54);
            this.metroButton1.TabIndex = 51;
            this.metroButton1.Tag = "Leido";
            this.metroButton1.Text = "Leido";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmComunicadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1980, 1100);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtColeccione);
            this.Controls.Add(this.mgListaComunicado);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmComunicadoAlumno";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Tag = "Comunicados";
            this.Text = "Comunicados";
            this.Load += new System.EventHandler(this.frmComunicadoAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgListaComunicado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgListaComunicado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maestro;
        private MetroFramework.Controls.MetroTextBox txtColeccione;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}