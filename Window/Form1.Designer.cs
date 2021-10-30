
namespace Window
{
    partial class Form1
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
            this.lvPodcast = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbNamn = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbNyKategori = new System.Windows.Forms.TextBox();
            this.lbAvsnittsLista = new System.Windows.Forms.ListBox();
            this.tbBeskrivning = new System.Windows.Forms.TextBox();
            this.cbFrekvens = new System.Windows.Forms.ComboBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.btnNyPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.btnTaBortPodcast = new System.Windows.Forms.Button();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnTaBortKategori = new System.Windows.Forms.Button();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblFrekvens = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblNyKategori = new System.Windows.Forms.Label();
            this.lblKategorier = new System.Windows.Forms.Label();
            this.lblPodcasts = new System.Windows.Forms.Label();
            this.lblBeskrivning = new System.Windows.Forms.Label();
            this.lblAvsnittsLista = new System.Windows.Forms.Label();
            this.lbKategori = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvPodcast
            // 
            this.lvPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPodcast.HideSelection = false;
            this.lvPodcast.Location = new System.Drawing.Point(9, 29);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(505, 242);
            this.lvPodcast.TabIndex = 0;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
            this.lvPodcast.SelectedIndexChanged += new System.EventHandler(this.lvPodcast_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Namn";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Avsnitt";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Frekvens";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.Width = 125;
            // 
            // tbNamn
            // 
            this.tbNamn.Location = new System.Drawing.Point(12, 304);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(161, 20);
            this.tbNamn.TabIndex = 1;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(12, 354);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(161, 20);
            this.tbUrl.TabIndex = 2;
            // 
            // tbNyKategori
            // 
            this.tbNyKategori.Location = new System.Drawing.Point(650, 304);
            this.tbNyKategori.Name = "tbNyKategori";
            this.tbNyKategori.Size = new System.Drawing.Size(161, 20);
            this.tbNyKategori.TabIndex = 3;
            // 
            // lbAvsnittsLista
            // 
            this.lbAvsnittsLista.FormattingEnabled = true;
            this.lbAvsnittsLista.Location = new System.Drawing.Point(13, 428);
            this.lbAvsnittsLista.Name = "lbAvsnittsLista";
            this.lbAvsnittsLista.Size = new System.Drawing.Size(505, 199);
            this.lbAvsnittsLista.TabIndex = 5;
            this.lbAvsnittsLista.SelectedIndexChanged += new System.EventHandler(this.lbAvsnittsLista_SelectedIndexChanged);
            // 
            // tbBeskrivning
            // 
            this.tbBeskrivning.Location = new System.Drawing.Point(577, 428);
            this.tbBeskrivning.Multiline = true;
            this.tbBeskrivning.Name = "tbBeskrivning";
            this.tbBeskrivning.Size = new System.Drawing.Size(302, 199);
            this.tbBeskrivning.TabIndex = 6;
            // 
            // cbFrekvens
            // 
            this.cbFrekvens.FormattingEnabled = true;
            this.cbFrekvens.Location = new System.Drawing.Point(212, 303);
            this.cbFrekvens.Name = "cbFrekvens";
            this.cbFrekvens.Size = new System.Drawing.Size(143, 21);
            this.cbFrekvens.TabIndex = 7;
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(380, 303);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(137, 21);
            this.cbKategori.TabIndex = 8;
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(212, 354);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(95, 23);
            this.btnNyPodcast.TabIndex = 9;
            this.btnNyPodcast.Text = "Ny";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            this.btnNyPodcast.Click += new System.EventHandler(this.btnNyPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(321, 354);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(95, 23);
            this.btnSparaPodcast.TabIndex = 10;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            this.btnSparaPodcast.Click += new System.EventHandler(this.btnSparaPodcast_Click);
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(422, 354);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(95, 23);
            this.btnTaBortPodcast.TabIndex = 11;
            this.btnTaBortPodcast.Text = "Ta bort";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            this.btnTaBortPodcast.Click += new System.EventHandler(this.btnTaBortPodcast_Click);
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(576, 354);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(95, 23);
            this.btnNyKategori.TabIndex = 12;
            this.btnNyKategori.Text = "Ny";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(677, 354);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(95, 23);
            this.btnSparaKategori.TabIndex = 13;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            this.btnSparaKategori.Click += new System.EventHandler(this.btnSparaKategori_Click);
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(783, 354);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(95, 23);
            this.btnTaBortKategori.TabIndex = 14;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            this.btnTaBortKategori.Click += new System.EventHandler(this.btnTaBortKategori_Click);
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(12, 288);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(43, 13);
            this.lblNamn.TabIndex = 16;
            this.lblNamn.Text = "Namn:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(12, 338);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 13);
            this.lblUrl.TabIndex = 17;
            this.lblUrl.Text = "URL:";
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrekvens.Location = new System.Drawing.Point(209, 287);
            this.lblFrekvens.Name = "lblFrekvens";
            this.lblFrekvens.Size = new System.Drawing.Size(135, 13);
            this.lblFrekvens.TabIndex = 18;
            this.lblFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(377, 287);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(58, 13);
            this.lblKategori.TabIndex = 19;
            this.lblKategori.Text = "Kategori:";
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyKategori.Location = new System.Drawing.Point(647, 287);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(76, 13);
            this.lblNyKategori.TabIndex = 20;
            this.lblNyKategori.Text = "Ny kategori:";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(573, 13);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(54, 13);
            this.lblKategorier.TabIndex = 21;
            this.lblKategorier.Text = "Kategori";
            // 
            // lblPodcasts
            // 
            this.lblPodcasts.AutoSize = true;
            this.lblPodcasts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcasts.Location = new System.Drawing.Point(12, 9);
            this.lblPodcasts.Name = "lblPodcasts";
            this.lblPodcasts.Size = new System.Drawing.Size(53, 13);
            this.lblPodcasts.TabIndex = 22;
            this.lblPodcasts.Text = "Podcast";
            // 
            // lblBeskrivning
            // 
            this.lblBeskrivning.AutoSize = true;
            this.lblBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeskrivning.Location = new System.Drawing.Point(573, 412);
            this.lblBeskrivning.Name = "lblBeskrivning";
            this.lblBeskrivning.Size = new System.Drawing.Size(121, 13);
            this.lblBeskrivning.TabIndex = 23;
            this.lblBeskrivning.Text = "Avsnittsbeskrivning:";
            // 
            // lblAvsnittsLista
            // 
            this.lblAvsnittsLista.AutoSize = true;
            this.lblAvsnittsLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittsLista.Location = new System.Drawing.Point(9, 412);
            this.lblAvsnittsLista.Name = "lblAvsnittsLista";
            this.lblAvsnittsLista.Size = new System.Drawing.Size(109, 13);
            this.lblAvsnittsLista.TabIndex = 24;
            this.lblAvsnittsLista.Text = "Lista över avsnitt:";
            // 
            // lbKategori
            // 
            this.lbKategori.HideSelection = false;
            this.lbKategori.Location = new System.Drawing.Point(577, 29);
            this.lbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(302, 242);
            this.lbKategori.TabIndex = 25;
            this.lbKategori.UseCompatibleStateImageBehavior = false;
            this.lbKategori.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 649);
            this.Controls.Add(this.lbKategori);
            this.Controls.Add(this.lblAvsnittsLista);
            this.Controls.Add(this.lblBeskrivning);
            this.Controls.Add(this.lblPodcasts);
            this.Controls.Add(this.lblKategorier);
            this.Controls.Add(this.lblNyKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblFrekvens);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.btnTaBortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.btnTaBortPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.btnNyPodcast);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbFrekvens);
            this.Controls.Add(this.tbBeskrivning);
            this.Controls.Add(this.lbAvsnittsLista);
            this.Controls.Add(this.tbNyKategori);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.lvPodcast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPodcast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbNamn;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbNyKategori;
        private System.Windows.Forms.ListBox lbAvsnittsLista;
        private System.Windows.Forms.TextBox tbBeskrivning;
        private System.Windows.Forms.ComboBox cbFrekvens;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Button btnNyPodcast;
        private System.Windows.Forms.Button btnSparaPodcast;
        private System.Windows.Forms.Button btnTaBortPodcast;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnTaBortKategori;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblFrekvens;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblNyKategori;
        private System.Windows.Forms.Label lblKategorier;
        private System.Windows.Forms.Label lblPodcasts;
        private System.Windows.Forms.Label lblBeskrivning;
        private System.Windows.Forms.Label lblAvsnittsLista;
        private System.Windows.Forms.ListView lbKategori;
    }
}

