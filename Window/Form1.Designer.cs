
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
            this.lbKategori = new System.Windows.Forms.ListBox();
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
            this.lvPodcast.Location = new System.Drawing.Point(18, 45);
            this.lvPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(756, 370);
            this.lvPodcast.TabIndex = 0;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Avsnitt";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Namn";
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
            this.tbNamn.Location = new System.Drawing.Point(18, 468);
            this.tbNamn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNamn.Name = "tbNamn";
            this.tbNamn.Size = new System.Drawing.Size(240, 26);
            this.tbNamn.TabIndex = 1;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(18, 545);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(240, 26);
            this.tbUrl.TabIndex = 2;
            // 
            // tbNyKategori
            // 
            this.tbNyKategori.Location = new System.Drawing.Point(975, 468);
            this.tbNyKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNyKategori.Name = "tbNyKategori";
            this.tbNyKategori.Size = new System.Drawing.Size(240, 26);
            this.tbNyKategori.TabIndex = 3;
            // 
            // lbKategori
            // 
            this.lbKategori.FormattingEnabled = true;
            this.lbKategori.ItemHeight = 20;
            this.lbKategori.Location = new System.Drawing.Point(864, 45);
            this.lbKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(451, 364);
            this.lbKategori.TabIndex = 4;
            // 
            // lbAvsnittsLista
            // 
            this.lbAvsnittsLista.FormattingEnabled = true;
            this.lbAvsnittsLista.ItemHeight = 20;
            this.lbAvsnittsLista.Location = new System.Drawing.Point(18, 658);
            this.lbAvsnittsLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbAvsnittsLista.Name = "lbAvsnittsLista";
            this.lbAvsnittsLista.Size = new System.Drawing.Size(756, 304);
            this.lbAvsnittsLista.TabIndex = 5;
            // 
            // tbBeskrivning
            // 
            this.tbBeskrivning.Location = new System.Drawing.Point(864, 658);
            this.tbBeskrivning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBeskrivning.Multiline = true;
            this.tbBeskrivning.Name = "tbBeskrivning";
            this.tbBeskrivning.Size = new System.Drawing.Size(451, 304);
            this.tbBeskrivning.TabIndex = 6;
            // 
            // cbFrekvens
            // 
            this.cbFrekvens.FormattingEnabled = true;
            this.cbFrekvens.Location = new System.Drawing.Point(318, 466);
            this.cbFrekvens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFrekvens.Name = "cbFrekvens";
            this.cbFrekvens.Size = new System.Drawing.Size(212, 28);
            this.cbFrekvens.TabIndex = 7;
            
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(570, 466);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(204, 28);
            this.cbKategori.TabIndex = 8;
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(318, 545);
            this.btnNyPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(142, 35);
            this.btnNyPodcast.TabIndex = 9;
            this.btnNyPodcast.Text = "Ny";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            this.btnNyPodcast.Click += new System.EventHandler(this.btnNyPodcast_Click);
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(482, 545);
            this.btnSparaPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(142, 35);
            this.btnSparaPodcast.TabIndex = 10;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            this.btnSparaPodcast.Click += new System.EventHandler(this.btnSparaPodcast_Click);
            // 
            // btnTaBortPodcast
            // 
            this.btnTaBortPodcast.Location = new System.Drawing.Point(633, 545);
            this.btnTaBortPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaBortPodcast.Name = "btnTaBortPodcast";
            this.btnTaBortPodcast.Size = new System.Drawing.Size(142, 35);
            this.btnTaBortPodcast.TabIndex = 11;
            this.btnTaBortPodcast.Text = "Ta bort";
            this.btnTaBortPodcast.UseVisualStyleBackColor = true;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(864, 545);
            this.btnNyKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(142, 35);
            this.btnNyKategori.TabIndex = 12;
            this.btnNyKategori.Text = "Ny";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(1016, 545);
            this.btnSparaKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(142, 35);
            this.btnSparaKategori.TabIndex = 13;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnTaBortKategori
            // 
            this.btnTaBortKategori.Location = new System.Drawing.Point(1174, 545);
            this.btnTaBortKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaBortKategori.Name = "btnTaBortKategori";
            this.btnTaBortKategori.Size = new System.Drawing.Size(142, 35);
            this.btnTaBortKategori.TabIndex = 14;
            this.btnTaBortKategori.Text = "Ta bort";
            this.btnTaBortKategori.UseVisualStyleBackColor = true;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(18, 443);
            this.lblNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(43, 13);
            this.lblNamn.TabIndex = 16;
            this.lblNamn.Text = "Namn:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(18, 520);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(36, 13);
            this.lblUrl.TabIndex = 17;
            this.lblUrl.Text = "URL:";
            // 
            // lblFrekvens
            // 
            this.lblFrekvens.AutoSize = true;
            this.lblFrekvens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrekvens.Location = new System.Drawing.Point(314, 442);
            this.lblFrekvens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrekvens.Name = "lblFrekvens";
            this.lblFrekvens.Size = new System.Drawing.Size(135, 13);
            this.lblFrekvens.TabIndex = 18;
            this.lblFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(566, 442);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(58, 13);
            this.lblKategori.TabIndex = 19;
            this.lblKategori.Text = "Kategori:";
            
            // 
            // lblNyKategori
            // 
            this.lblNyKategori.AutoSize = true;
            this.lblNyKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyKategori.Location = new System.Drawing.Point(970, 442);
            this.lblNyKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNyKategori.Name = "lblNyKategori";
            this.lblNyKategori.Size = new System.Drawing.Size(76, 13);
            this.lblNyKategori.TabIndex = 20;
            this.lblNyKategori.Text = "Ny kategori:";
            // 
            // lblKategorier
            // 
            this.lblKategorier.AutoSize = true;
            this.lblKategorier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategorier.Location = new System.Drawing.Point(860, 20);
            this.lblKategorier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategorier.Name = "lblKategorier";
            this.lblKategorier.Size = new System.Drawing.Size(54, 13);
            this.lblKategorier.TabIndex = 21;
            this.lblKategorier.Text = "Kategori";
            // 
            // lblPodcasts
            // 
            this.lblPodcasts.AutoSize = true;
            this.lblPodcasts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPodcasts.Location = new System.Drawing.Point(18, 14);
            this.lblPodcasts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPodcasts.Name = "lblPodcasts";
            this.lblPodcasts.Size = new System.Drawing.Size(53, 13);
            this.lblPodcasts.TabIndex = 22;
            this.lblPodcasts.Text = "Podcast";
            
            // 
            // lblBeskrivning
            // 
            this.lblBeskrivning.AutoSize = true;
            this.lblBeskrivning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeskrivning.Location = new System.Drawing.Point(860, 634);
            this.lblBeskrivning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBeskrivning.Name = "lblBeskrivning";
            this.lblBeskrivning.Size = new System.Drawing.Size(121, 13);
            this.lblBeskrivning.TabIndex = 23;
            this.lblBeskrivning.Text = "Avsnittsbeskrivning:";
            // 
            // lblAvsnittsLista
            // 
            this.lblAvsnittsLista.AutoSize = true;
            this.lblAvsnittsLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvsnittsLista.Location = new System.Drawing.Point(14, 634);
            this.lblAvsnittsLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvsnittsLista.Name = "lblAvsnittsLista";
            this.lblAvsnittsLista.Size = new System.Drawing.Size(109, 13);
            this.lblAvsnittsLista.TabIndex = 24;
            this.lblAvsnittsLista.Text = "Lista över avsnitt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 998);
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
            this.Controls.Add(this.lbKategori);
            this.Controls.Add(this.tbNyKategori);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbNamn);
            this.Controls.Add(this.lvPodcast);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ListBox lbKategori;
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
    }
}

