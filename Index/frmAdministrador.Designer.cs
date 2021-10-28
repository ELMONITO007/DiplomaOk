
namespace DiplomaFinal.Index
{
    partial class frmAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrador));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbIdioma = new MetroFramework.Controls.MetroComboBox();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnUsuario = new MetroFramework.Controls.MetroButton();
            this.lblHola = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(868, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Tag = "Idioma";
            this.metroLabel1.Text = "Idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.ItemHeight = 23;
            this.cbIdioma.Location = new System.Drawing.Point(938, 63);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(287, 29);
            this.cbIdioma.TabIndex = 15;
            this.cbIdioma.UseSelectable = true;
            this.cbIdioma.SelectedIndexChanged += new System.EventHandler(this.cbIdioma_SelectedIndexChanged);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Location = new System.Drawing.Point(909, 334);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(194, 233);
            this.metroTile6.TabIndex = 14;
            this.metroTile6.Tag = "Proyecto";
            this.metroTile6.Text = "Proyecto";
            this.metroTile6.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(666, 334);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(237, 173);
            this.metroTile5.TabIndex = 13;
            this.metroTile5.Tag = "Boletin";
            this.metroTile5.Text = "Boletin";
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(423, 393);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(237, 134);
            this.metroTile4.TabIndex = 12;
            this.metroTile4.Tag = "Gestion de Infra";
            this.metroTile4.Text = "Gestion Infraestructura";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(850, 178);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(315, 150);
            this.metroTile3.TabIndex = 11;
            this.metroTile3.Tag = "Gestion salas";
            this.metroTile3.Text = "Gestion salas";
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(666, 155);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(178, 173);
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Tag = "Gestion de Alumnos";
            this.metroTile2.Text = "Gestion Alumnos";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(423, 155);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(237, 232);
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Tag = "Configuraciones";
            this.metroTile1.Text = "Configuraciones";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(1231, 67);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 22);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Tag = "Modificar";
            this.metroButton1.Text = "Modificar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(272, 7);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(181, 30);
            this.btnUsuario.TabIndex = 18;
            this.btnUsuario.Tag = "Usuario";
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseSelectable = true;
            this.btnUsuario.Visible = false;
            this.btnUsuario.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.Location = new System.Drawing.Point(2, 17);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(36, 19);
            this.lblHola.TabIndex = 19;
            this.lblHola.Tag = "Hol";
            this.lblHola.Text = "Hola";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNombre.Location = new System.Drawing.Point(44, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.ReadOnly = true;
            this.lblNombre.Size = new System.Drawing.Size(213, 13);
            this.lblNombre.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1341, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(2, 42);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(137, 23);
            this.metroButton2.TabIndex = 21;
            this.metroButton2.Tag = "Desloguearse";
            this.metroButton2.Text = "Desloguearse";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // frmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 606);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblHola);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAdministrador";
            this.Load += new System.EventHandler(this.frmAlumnoIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbIdioma;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnUsuario;
        private MetroFramework.Controls.MetroLabel lblHola;
        private System.Windows.Forms.TextBox lblNombre;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}