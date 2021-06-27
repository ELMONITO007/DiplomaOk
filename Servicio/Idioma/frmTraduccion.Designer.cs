
namespace DiplomaFinal.Servicio.Idioma
{
    partial class frmTraduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraduccion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.btnAlta = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbIdioma = new MetroFramework.Controls.MetroComboBox();
            this.txtIdioma = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnTodo = new MetroFramework.Controls.MetroButton();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.txtBuscar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnModificar = new MetroFramework.Controls.MetroButton();
            this.mgListado = new MetroFramework.Controls.MetroGrid();
            this.ID_idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Palabra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Palabra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Traduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPalabra = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(3, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(837, 832);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroTabPage1.BackgroundImage")));
            this.metroTabPage1.Controls.Add(this.txtPalabra);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.htmlLabel1);
            this.metroTabPage1.Controls.Add(this.btnAlta);
            this.metroTabPage1.Controls.Add(this.metroButton1);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.cbIdioma);
            this.metroTabPage1.Controls.Add(this.txtIdioma);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.btnTodo);
            this.metroTabPage1.Controls.Add(this.btnBuscar);
            this.metroTabPage1.Controls.Add(this.txtBuscar);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.btnModificar);
            this.metroTabPage1.Controls.Add(this.mgListado);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(829, 790);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Tag = "Palabras";
            this.metroTabPage1.Text = "Palabras";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(171, 48);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(473, 183);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(8, 8);
            this.htmlLabel1.TabIndex = 28;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(693, 194);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(104, 29);
            this.btnAlta.TabIndex = 25;
            this.btnAlta.Tag = "Alta";
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseSelectable = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(380, 82);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(84, 28);
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Tag = "Seleccionar";
            this.metroButton1.Text = "Seleccionar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(77, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Tag = "Idioma";
            this.metroLabel2.Text = "Idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.ItemHeight = 23;
            this.cbIdioma.Location = new System.Drawing.Point(220, 82);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(122, 29);
            this.cbIdioma.TabIndex = 2;
            this.cbIdioma.UseSelectable = true;
            // 
            // txtIdioma
            // 
            // 
            // 
            // 
            this.txtIdioma.CustomButton.Image = null;
            this.txtIdioma.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtIdioma.CustomButton.Name = "";
            this.txtIdioma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdioma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdioma.CustomButton.TabIndex = 1;
            this.txtIdioma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdioma.CustomButton.UseSelectable = true;
            this.txtIdioma.CustomButton.Visible = false;
            this.txtIdioma.Lines = new string[0];
            this.txtIdioma.Location = new System.Drawing.Point(501, 194);
            this.txtIdioma.MaxLength = 32767;
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.PasswordChar = '\0';
            this.txtIdioma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdioma.SelectedText = "";
            this.txtIdioma.SelectionLength = 0;
            this.txtIdioma.SelectionStart = 0;
            this.txtIdioma.ShortcutsEnabled = true;
            this.txtIdioma.Size = new System.Drawing.Size(135, 23);
            this.txtIdioma.TabIndex = 23;
            this.txtIdioma.UseSelectable = true;
            this.txtIdioma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdioma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(424, 194);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Tag = "Traduccion";
            this.metroLabel4.Text = "Traduccion";
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(401, 34);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(74, 23);
            this.btnTodo.TabIndex = 20;
            this.btnTodo.Tag = "Ver Todo";
            this.btnTodo.Text = "Ver todo";
            this.btnTodo.UseSelectable = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Tag = "Buscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            // 
            // 
            // 
            this.txtBuscar.CustomButton.Image = null;
            this.txtBuscar.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtBuscar.CustomButton.Name = "";
            this.txtBuscar.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.txtBuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscar.CustomButton.TabIndex = 1;
            this.txtBuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscar.CustomButton.UseSelectable = true;
            this.txtBuscar.CustomButton.Visible = false;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(130, 34);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = true;
            this.txtBuscar.Size = new System.Drawing.Size(103, 17);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.UseSelectable = true;
            this.txtBuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Tag = "Buscar";
            this.metroLabel1.Text = "Buscar";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(18, 740);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 29);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Tag = "Modificar";
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseSelectable = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // mgListado
            // 
            this.mgListado.AllowUserToAddRows = false;
            this.mgListado.AllowUserToDeleteRows = false;
            this.mgListado.AllowUserToResizeRows = false;
            this.mgListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_idioma,
            this.ID_Palabra,
            this.Palabra,
            this.Traduccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgListado.EnableHeadersVisualStyles = false;
            this.mgListado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgListado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgListado.Location = new System.Drawing.Point(77, 146);
            this.mgListado.Name = "mgListado";
            this.mgListado.ReadOnly = true;
            this.mgListado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgListado.Size = new System.Drawing.Size(321, 528);
            this.mgListado.TabIndex = 14;
            this.mgListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgListado_CellContentClick);
            // 
            // ID_idioma
            // 
            this.ID_idioma.HeaderText = "ID_idioma";
            this.ID_idioma.Name = "ID_idioma";
            this.ID_idioma.ReadOnly = true;
            this.ID_idioma.Visible = false;
            // 
            // ID_Palabra
            // 
            this.ID_Palabra.HeaderText = "ID_Palabra";
            this.ID_Palabra.Name = "ID_Palabra";
            this.ID_Palabra.ReadOnly = true;
            this.ID_Palabra.Visible = false;
            // 
            // Palabra
            // 
            this.Palabra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Palabra.HeaderText = "Palabra";
            this.Palabra.Name = "Palabra";
            this.Palabra.ReadOnly = true;
            this.Palabra.Width = 68;
            // 
            // Traduccion
            // 
            this.Traduccion.HeaderText = "Traduccion";
            this.Traduccion.Name = "Traduccion";
            this.Traduccion.ReadOnly = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(424, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Tag = "Palabra";
            this.metroLabel3.Text = "Palabra";
            // 
            // txtPalabra
            // 
            this.txtPalabra.AutoSize = true;
            this.txtPalabra.Location = new System.Drawing.Point(498, 161);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(0, 13);
            this.txtPalabra.TabIndex = 30;
            // 
            // frmTraduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 888);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmTraduccion";
            this.Text = "Traduccion";
            this.Load += new System.EventHandler(this.frmTraduccion_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroButton btnAlta;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbIdioma;
        private MetroFramework.Controls.MetroTextBox txtIdioma;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnTodo;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroTextBox txtBuscar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnModificar;
        private MetroFramework.Controls.MetroGrid mgListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Palabra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palabra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traduccion;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label txtPalabra;
    }
}