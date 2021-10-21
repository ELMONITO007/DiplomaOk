
namespace DiplomaFinal.Index
{
    partial class frmVerMiUsuario
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
            this.Alta = new MetroFramework.Controls.MetroTabControl();
            this.mtListar = new MetroFramework.Controls.MetroTabPage();
            this.txtRepita = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNueva = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtVieja = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnContraseña = new MetroFramework.Controls.MetroButton();
            this.lblErrContraseña = new MetroFramework.Controls.MetroLabel();
            this.lblErrUsuario = new MetroFramework.Controls.MetroLabel();
            this.lblErrApellido = new MetroFramework.Controls.MetroLabel();
            this.lblErrNombre = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtApellido = new MetroFramework.Controls.MetroTextBox();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnAlta = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Alta.SuspendLayout();
            this.mtListar.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alta
            // 
            this.Alta.Controls.Add(this.mtListar);
            this.Alta.Controls.Add(this.metroTabPage1);
            this.Alta.Location = new System.Drawing.Point(-2, 38);
            this.Alta.Margin = new System.Windows.Forms.Padding(2);
            this.Alta.Name = "Alta";
            this.Alta.SelectedIndex = 1;
            this.Alta.Size = new System.Drawing.Size(925, 344);
            this.Alta.TabIndex = 6;
            this.Alta.UseSelectable = true;
            // 
            // mtListar
            // 
            this.mtListar.BackgroundImage = global::DiplomaFinal.Properties.Resources.Fondo_pantalla_gral_2;
            this.mtListar.Controls.Add(this.txtRepita);
            this.mtListar.Controls.Add(this.metroLabel6);
            this.mtListar.Controls.Add(this.txtNueva);
            this.mtListar.Controls.Add(this.metroLabel5);
            this.mtListar.Controls.Add(this.txtVieja);
            this.mtListar.Controls.Add(this.metroLabel4);
            this.mtListar.Controls.Add(this.btnContraseña);
            this.mtListar.Controls.Add(this.lblErrContraseña);
            this.mtListar.Controls.Add(this.lblErrUsuario);
            this.mtListar.Controls.Add(this.lblErrApellido);
            this.mtListar.Controls.Add(this.lblErrNombre);
            this.mtListar.HorizontalScrollbarBarColor = true;
            this.mtListar.HorizontalScrollbarHighlightOnWheel = false;
            this.mtListar.HorizontalScrollbarSize = 6;
            this.mtListar.Location = new System.Drawing.Point(4, 38);
            this.mtListar.Margin = new System.Windows.Forms.Padding(2);
            this.mtListar.Name = "mtListar";
            this.mtListar.Size = new System.Drawing.Size(917, 302);
            this.mtListar.TabIndex = 0;
            this.mtListar.Tag = "Cambiar Contraseña";
            this.mtListar.Text = "Cambiar Contraseña";
            this.mtListar.VerticalScrollbarBarColor = true;
            this.mtListar.VerticalScrollbarHighlightOnWheel = false;
            this.mtListar.VerticalScrollbarSize = 7;
            // 
            // txtRepita
            // 
            // 
            // 
            // 
            this.txtRepita.CustomButton.Image = null;
            this.txtRepita.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtRepita.CustomButton.Name = "";
            this.txtRepita.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRepita.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRepita.CustomButton.TabIndex = 1;
            this.txtRepita.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRepita.CustomButton.UseSelectable = true;
            this.txtRepita.CustomButton.Visible = false;
            this.txtRepita.Lines = new string[0];
            this.txtRepita.Location = new System.Drawing.Point(149, 106);
            this.txtRepita.MaxLength = 32767;
            this.txtRepita.Name = "txtRepita";
            this.txtRepita.PasswordChar = '*';
            this.txtRepita.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRepita.SelectedText = "";
            this.txtRepita.SelectionLength = 0;
            this.txtRepita.SelectionStart = 0;
            this.txtRepita.ShortcutsEnabled = true;
            this.txtRepita.Size = new System.Drawing.Size(327, 23);
            this.txtRepita.TabIndex = 42;
            this.txtRepita.UseSelectable = true;
            this.txtRepita.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRepita.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(8, 110);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(116, 19);
            this.metroLabel6.TabIndex = 41;
            this.metroLabel6.Tag = "Repita Contraseña";
            this.metroLabel6.Text = "Repita Contraseña";
            // 
            // txtNueva
            // 
            // 
            // 
            // 
            this.txtNueva.CustomButton.Image = null;
            this.txtNueva.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtNueva.CustomButton.Name = "";
            this.txtNueva.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNueva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNueva.CustomButton.TabIndex = 1;
            this.txtNueva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNueva.CustomButton.UseSelectable = true;
            this.txtNueva.CustomButton.Visible = false;
            this.txtNueva.Lines = new string[0];
            this.txtNueva.Location = new System.Drawing.Point(149, 63);
            this.txtNueva.MaxLength = 32767;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNueva.SelectedText = "";
            this.txtNueva.SelectionLength = 0;
            this.txtNueva.SelectionStart = 0;
            this.txtNueva.ShortcutsEnabled = true;
            this.txtNueva.Size = new System.Drawing.Size(327, 23);
            this.txtNueva.TabIndex = 40;
            this.txtNueva.UseSelectable = true;
            this.txtNueva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNueva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(8, 67);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(116, 19);
            this.metroLabel5.TabIndex = 39;
            this.metroLabel5.Tag = "Contraseña Nueva";
            this.metroLabel5.Text = "Contraseña Nueva";
            // 
            // txtVieja
            // 
            // 
            // 
            // 
            this.txtVieja.CustomButton.Image = null;
            this.txtVieja.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtVieja.CustomButton.Name = "";
            this.txtVieja.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVieja.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVieja.CustomButton.TabIndex = 1;
            this.txtVieja.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVieja.CustomButton.UseSelectable = true;
            this.txtVieja.CustomButton.Visible = false;
            this.txtVieja.Lines = new string[0];
            this.txtVieja.Location = new System.Drawing.Point(149, 21);
            this.txtVieja.MaxLength = 32767;
            this.txtVieja.Name = "txtVieja";
            this.txtVieja.PasswordChar = '*';
            this.txtVieja.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVieja.SelectedText = "";
            this.txtVieja.SelectionLength = 0;
            this.txtVieja.SelectionStart = 0;
            this.txtVieja.ShortcutsEnabled = true;
            this.txtVieja.Size = new System.Drawing.Size(327, 23);
            this.txtVieja.TabIndex = 38;
            this.txtVieja.UseSelectable = true;
            this.txtVieja.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVieja.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(8, 21);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Tag = "Contraseña Vieja";
            this.metroLabel4.Text = "Contraseña Vieja";
            // 
            // btnContraseña
            // 
            this.btnContraseña.Location = new System.Drawing.Point(-4, 166);
            this.btnContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.btnContraseña.Name = "btnContraseña";
            this.btnContraseña.Size = new System.Drawing.Size(125, 15);
            this.btnContraseña.TabIndex = 28;
            this.btnContraseña.Tag = "CambiarContraseña";
            this.btnContraseña.Text = "Cambiar Contraseña";
            this.btnContraseña.UseSelectable = true;
            // 
            // lblErrContraseña
            // 
            this.lblErrContraseña.AutoSize = true;
            this.lblErrContraseña.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblErrContraseña.ForeColor = System.Drawing.Color.Red;
            this.lblErrContraseña.Location = new System.Drawing.Point(880, 166);
            this.lblErrContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblErrUsuario.Location = new System.Drawing.Point(880, 133);
            this.lblErrUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblErrApellido.Location = new System.Drawing.Point(880, 97);
            this.lblErrApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblErrNombre.Location = new System.Drawing.Point(880, 63);
            this.lblErrNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrNombre.Name = "lblErrNombre";
            this.lblErrNombre.Size = new System.Drawing.Size(0, 0);
            this.lblErrNombre.Style = MetroFramework.MetroColorStyle.Red;
            this.lblErrNombre.TabIndex = 24;
            this.lblErrNombre.UseCustomForeColor = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackgroundImage = global::DiplomaFinal.Properties.Resources.Fondo_pantalla_gral_2;
            this.metroTabPage1.Controls.Add(this.txtUsuario);
            this.metroTabPage1.Controls.Add(this.txtApellido);
            this.metroTabPage1.Controls.Add(this.txtNombre);
            this.metroTabPage1.Controls.Add(this.btnAlta);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(917, 302);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Tag = "Mi usuario";
            this.metroTabPage1.Text = "Mi usuario";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // txtUsuario
            // 
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(131, 96);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(327, 23);
            this.txtUsuario.TabIndex = 35;
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
            this.txtApellido.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtApellido.CustomButton.Name = "";
            this.txtApellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellido.CustomButton.TabIndex = 1;
            this.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellido.CustomButton.UseSelectable = true;
            this.txtApellido.CustomButton.Visible = false;
            this.txtApellido.Lines = new string[0];
            this.txtApellido.Location = new System.Drawing.Point(131, 59);
            this.txtApellido.MaxLength = 32767;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.ShortcutsEnabled = true;
            this.txtApellido.Size = new System.Drawing.Size(327, 23);
            this.txtApellido.TabIndex = 34;
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
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(131, 26);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(327, 23);
            this.txtNombre.TabIndex = 33;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(26, 200);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(59, 24);
            this.btnAlta.TabIndex = 32;
            this.btnAlta.Tag = "Modificar";
            this.btnAlta.Text = "Modificar";
            this.btnAlta.UseSelectable = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 100);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Tag = "Usuario";
            this.metroLabel3.Text = "Usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 63);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Tag = "Apellido";
            this.metroLabel2.Text = "Apellido";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 22);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Tag = "Nombre";
            this.metroLabel1.Text = "Nombre";
            // 
            // frmVerMiUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 383);
            this.Controls.Add(this.Alta);
            this.Name = "frmVerMiUsuario";
            this.Load += new System.EventHandler(this.frmVerMiUsuario_Load);
            this.Alta.ResumeLayout(false);
            this.mtListar.ResumeLayout(false);
            this.mtListar.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl Alta;
        private MetroFramework.Controls.MetroTabPage mtListar;
        private MetroFramework.Controls.MetroTextBox txtRepita;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtNueva;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtVieja;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnContraseña;
        private MetroFramework.Controls.MetroLabel lblErrContraseña;
        private MetroFramework.Controls.MetroLabel lblErrUsuario;
        private MetroFramework.Controls.MetroLabel lblErrApellido;
        private MetroFramework.Controls.MetroLabel lblErrNombre;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroTextBox txtApellido;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroButton btnAlta;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}