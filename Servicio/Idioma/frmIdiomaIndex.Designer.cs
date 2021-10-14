
namespace DiplomaFinal.Servicio.Idioma
{
    partial class frmIdiomaIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdiomaIndex));
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.Idioma = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbIdioma = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(137, 218);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(146, 177);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Tag = "Traduccion";
            this.metroTile1.Text = "Traduccion";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(289, 158);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(192, 191);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Tag = "Palabra";
            this.metroTile2.Text = "Palabras";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Idioma
            // 
            this.Idioma.ActiveControl = null;
            this.Idioma.BackColor = System.Drawing.Color.Black;
            this.Idioma.Location = new System.Drawing.Point(116, 63);
            this.Idioma.Name = "Idioma";
            this.Idioma.Size = new System.Drawing.Size(167, 149);
            this.Idioma.TabIndex = 3;
            this.Idioma.Tag = "Idioma";
            this.Idioma.Text = "Idioma";
            this.Idioma.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Idioma.TileImage = ((System.Drawing.Image)(resources.GetObject("Idioma.TileImage")));
            this.Idioma.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Idioma.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Idioma.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Idioma.UseSelectable = true;
            this.Idioma.UseTileImage = true;
            this.Idioma.Click += new System.EventHandler(this.Idioma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(582, 22);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 22);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Tag = "Modificar";
            this.metroButton1.Text = "Modificar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(219, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Tag = "Idioma";
            this.metroLabel1.Text = "Idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.ItemHeight = 23;
            this.cbIdioma.Location = new System.Drawing.Point(289, 18);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(287, 29);
            this.cbIdioma.TabIndex = 18;
            this.cbIdioma.UseSelectable = true;
            // 
            // frmIdiomaIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.Idioma);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmIdiomaIndex";
            this.Text = "Lenguaje";
            this.Load += new System.EventHandler(this.frmIdiomaIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile Idioma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbIdioma;
    }
}