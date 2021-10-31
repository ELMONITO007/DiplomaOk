namespace DiplomaFinal.VistaMaestroGrado
{
    partial class frmMaestro
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
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbIdioma = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(34, 132);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(188, 172);
            this.metroTile4.TabIndex = 6;
            this.metroTile4.Tag = "Curso";
            this.metroTile4.Text = "Cursos";
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(237, 95);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(237, 209);
            this.metroTile5.TabIndex = 7;
            this.metroTile5.Tag = "Boletin";
            this.metroTile5.Text = "Boletin";
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.metroTile5_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(34, 322);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(237, 153);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Tag = "Examen";
            this.metroTile1.Text = "Examen";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(286, 322);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(188, 153);
            this.metroTile2.TabIndex = 9;
            this.metroTile2.Tag = "Comunicaciones";
            this.metroTile2.Text = "Comunicaciones";
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(252, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Tag = "Idioma";
            this.metroLabel1.Text = "Idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.ItemHeight = 23;
            this.cbIdioma.Location = new System.Drawing.Point(333, 35);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(193, 29);
            this.cbIdioma.TabIndex = 12;
            this.cbIdioma.UseSelectable = true;
            this.cbIdioma.SelectedIndexChanged += new System.EventHandler(this.cbIdioma_SelectedIndexChanged);
            // 
            // frmMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 547);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Name = "frmMaestro";
            this.Text = "frmMaestro";
            this.Load += new System.EventHandler(this.frmMaestro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbIdioma;
    }
}