namespace ServiceDesk
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labeldate = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnTicketToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIncidentMajeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerIncidentMajeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherIncidentMajeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnArticleINVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnArticleINVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerMultiplesArticlesINVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMultiplesINVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerMultiplesINVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sécuritéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportOSNonSupportéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportVulnérabilitéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportInventaireCompletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesTicketsOuvertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesTicketsRésoluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesIncidentsOuvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesIncidentsRésoluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnCompteSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherCompteSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerGroupeSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherGroupeSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherUnUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldate.Location = new System.Drawing.Point(918, 510);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(63, 25);
            this.labeldate.TabIndex = 1;
            this.labeldate.Text = "label1";
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltime.Location = new System.Drawing.Point(1047, 510);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(63, 25);
            this.labeltime.TabIndex = 2;
            this.labeltime.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.créerUnTicketToolStripMenuItem,
            this.gestionIncidentMajeurToolStripMenuItem,
            this.gestionUtilisateursToolStripMenuItem,
            this.inventaireToolStripMenuItem,
            this.sécuritéToolStripMenuItem,
            this.moiToolStripMenuItem,
            this.gestionApplicationsToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.accueilToolStripMenuItem.Text = "Accueil";
            // 
            // créerUnTicketToolStripMenuItem
            // 
            this.créerUnTicketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnTicketToolStripMenuItem1,
            this.rechercherUnTicketToolStripMenuItem});
            this.créerUnTicketToolStripMenuItem.Name = "créerUnTicketToolStripMenuItem";
            this.créerUnTicketToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.créerUnTicketToolStripMenuItem.Text = "Gestion ticket";
            this.créerUnTicketToolStripMenuItem.Click += new System.EventHandler(this.créerUnTicketToolStripMenuItem_Click);
            // 
            // créerUnTicketToolStripMenuItem1
            // 
            this.créerUnTicketToolStripMenuItem1.Name = "créerUnTicketToolStripMenuItem1";
            this.créerUnTicketToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.créerUnTicketToolStripMenuItem1.Text = "Créer un ticket";
            // 
            // rechercherUnTicketToolStripMenuItem
            // 
            this.rechercherUnTicketToolStripMenuItem.Name = "rechercherUnTicketToolStripMenuItem";
            this.rechercherUnTicketToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.rechercherUnTicketToolStripMenuItem.Text = "Rechercher un ticket";
            // 
            // gestionIncidentMajeurToolStripMenuItem
            // 
            this.gestionIncidentMajeurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerIncidentMajeurToolStripMenuItem,
            this.rechercherIncidentMajeurToolStripMenuItem});
            this.gestionIncidentMajeurToolStripMenuItem.Name = "gestionIncidentMajeurToolStripMenuItem";
            this.gestionIncidentMajeurToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.gestionIncidentMajeurToolStripMenuItem.Text = "Gestion incident majeur";
            // 
            // créerIncidentMajeurToolStripMenuItem
            // 
            this.créerIncidentMajeurToolStripMenuItem.Name = "créerIncidentMajeurToolStripMenuItem";
            this.créerIncidentMajeurToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.créerIncidentMajeurToolStripMenuItem.Text = "Créer incident majeur";
            // 
            // rechercherIncidentMajeurToolStripMenuItem
            // 
            this.rechercherIncidentMajeurToolStripMenuItem.Name = "rechercherIncidentMajeurToolStripMenuItem";
            this.rechercherIncidentMajeurToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.rechercherIncidentMajeurToolStripMenuItem.Text = "Rechercher incident majeur";
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnArticleINVToolStripMenuItem,
            this.rechercherUnArticleINVToolStripMenuItem,
            this.créerMultiplesArticlesINVToolStripMenuItem,
            this.modifierMultiplesINVToolStripMenuItem,
            this.supprimerMultiplesINVToolStripMenuItem});
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            // 
            // créerUnArticleINVToolStripMenuItem
            // 
            this.créerUnArticleINVToolStripMenuItem.Name = "créerUnArticleINVToolStripMenuItem";
            this.créerUnArticleINVToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.créerUnArticleINVToolStripMenuItem.Text = "Créer un article INV";
            // 
            // rechercherUnArticleINVToolStripMenuItem
            // 
            this.rechercherUnArticleINVToolStripMenuItem.Name = "rechercherUnArticleINVToolStripMenuItem";
            this.rechercherUnArticleINVToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.rechercherUnArticleINVToolStripMenuItem.Text = "Rechercher un article INV";
            // 
            // créerMultiplesArticlesINVToolStripMenuItem
            // 
            this.créerMultiplesArticlesINVToolStripMenuItem.Name = "créerMultiplesArticlesINVToolStripMenuItem";
            this.créerMultiplesArticlesINVToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.créerMultiplesArticlesINVToolStripMenuItem.Text = "Créer multiples INV";
            this.créerMultiplesArticlesINVToolStripMenuItem.Click += new System.EventHandler(this.créerMultiplesArticlesINVToolStripMenuItem_Click);
            // 
            // modifierMultiplesINVToolStripMenuItem
            // 
            this.modifierMultiplesINVToolStripMenuItem.Name = "modifierMultiplesINVToolStripMenuItem";
            this.modifierMultiplesINVToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.modifierMultiplesINVToolStripMenuItem.Text = "Modifier multiples INV";
            // 
            // supprimerMultiplesINVToolStripMenuItem
            // 
            this.supprimerMultiplesINVToolStripMenuItem.Name = "supprimerMultiplesINVToolStripMenuItem";
            this.supprimerMultiplesINVToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.supprimerMultiplesINVToolStripMenuItem.Text = "Supprimer multiples INV";
            // 
            // sécuritéToolStripMenuItem
            // 
            this.sécuritéToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportOSNonSupportéToolStripMenuItem,
            this.rapportVulnérabilitéToolStripMenuItem,
            this.rapportInventaireCompletToolStripMenuItem});
            this.sécuritéToolStripMenuItem.Name = "sécuritéToolStripMenuItem";
            this.sécuritéToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sécuritéToolStripMenuItem.Text = "Sécurité";
            // 
            // rapportOSNonSupportéToolStripMenuItem
            // 
            this.rapportOSNonSupportéToolStripMenuItem.Name = "rapportOSNonSupportéToolStripMenuItem";
            this.rapportOSNonSupportéToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.rapportOSNonSupportéToolStripMenuItem.Text = "Rapport OS non supporté";
            // 
            // rapportVulnérabilitéToolStripMenuItem
            // 
            this.rapportVulnérabilitéToolStripMenuItem.Name = "rapportVulnérabilitéToolStripMenuItem";
            this.rapportVulnérabilitéToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.rapportVulnérabilitéToolStripMenuItem.Text = "Rapport vulnérabilité";
            // 
            // rapportInventaireCompletToolStripMenuItem
            // 
            this.rapportInventaireCompletToolStripMenuItem.Name = "rapportInventaireCompletToolStripMenuItem";
            this.rapportInventaireCompletToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.rapportInventaireCompletToolStripMenuItem.Text = "Rapport inventaire complet";
            // 
            // moiToolStripMenuItem
            // 
            this.moiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesTicketsOuvertsToolStripMenuItem,
            this.mesTicketsRésoluToolStripMenuItem,
            this.mesIncidentsOuvertToolStripMenuItem,
            this.mesIncidentsRésoluToolStripMenuItem});
            this.moiToolStripMenuItem.Name = "moiToolStripMenuItem";
            this.moiToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.moiToolStripMenuItem.Text = "Moi";
            // 
            // mesTicketsOuvertsToolStripMenuItem
            // 
            this.mesTicketsOuvertsToolStripMenuItem.Name = "mesTicketsOuvertsToolStripMenuItem";
            this.mesTicketsOuvertsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mesTicketsOuvertsToolStripMenuItem.Text = "Mes tickets ouverts";
            // 
            // mesTicketsRésoluToolStripMenuItem
            // 
            this.mesTicketsRésoluToolStripMenuItem.Name = "mesTicketsRésoluToolStripMenuItem";
            this.mesTicketsRésoluToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mesTicketsRésoluToolStripMenuItem.Text = "Mes tickets résolu";
            // 
            // mesIncidentsOuvertToolStripMenuItem
            // 
            this.mesIncidentsOuvertToolStripMenuItem.Name = "mesIncidentsOuvertToolStripMenuItem";
            this.mesIncidentsOuvertToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mesIncidentsOuvertToolStripMenuItem.Text = "Mes incidents ouvert";
            // 
            // mesIncidentsRésoluToolStripMenuItem
            // 
            this.mesIncidentsRésoluToolStripMenuItem.Name = "mesIncidentsRésoluToolStripMenuItem";
            this.mesIncidentsRésoluToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mesIncidentsRésoluToolStripMenuItem.Text = "Mes incidents résolu";
            // 
            // gestionApplicationsToolStripMenuItem
            // 
            this.gestionApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnCompteSDToolStripMenuItem,
            this.rechercherCompteSDToolStripMenuItem,
            this.créerGroupeSDToolStripMenuItem,
            this.rechercherGroupeSDToolStripMenuItem});
            this.gestionApplicationsToolStripMenuItem.Name = "gestionApplicationsToolStripMenuItem";
            this.gestionApplicationsToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.gestionApplicationsToolStripMenuItem.Text = "Gestion applications";
            // 
            // créerUnCompteSDToolStripMenuItem
            // 
            this.créerUnCompteSDToolStripMenuItem.Name = "créerUnCompteSDToolStripMenuItem";
            this.créerUnCompteSDToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.créerUnCompteSDToolStripMenuItem.Text = "Créer un compte SD";
            // 
            // rechercherCompteSDToolStripMenuItem
            // 
            this.rechercherCompteSDToolStripMenuItem.Name = "rechercherCompteSDToolStripMenuItem";
            this.rechercherCompteSDToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.rechercherCompteSDToolStripMenuItem.Text = "Rechercher compte SD";
            // 
            // créerGroupeSDToolStripMenuItem
            // 
            this.créerGroupeSDToolStripMenuItem.Name = "créerGroupeSDToolStripMenuItem";
            this.créerGroupeSDToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.créerGroupeSDToolStripMenuItem.Text = "Créer groupe SD";
            // 
            // rechercherGroupeSDToolStripMenuItem
            // 
            this.rechercherGroupeSDToolStripMenuItem.Name = "rechercherGroupeSDToolStripMenuItem";
            this.rechercherGroupeSDToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.rechercherGroupeSDToolStripMenuItem.Text = "Rechercher groupe SD";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            this.gestionUtilisateursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnUtilisateurToolStripMenuItem,
            this.rechercherUnUtilisateurToolStripMenuItem});
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion utilisateurs";
            // 
            // créerUnUtilisateurToolStripMenuItem
            // 
            this.créerUnUtilisateurToolStripMenuItem.Name = "créerUnUtilisateurToolStripMenuItem";
            this.créerUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.créerUnUtilisateurToolStripMenuItem.Text = "Créer un utilisateur";
            // 
            // rechercherUnUtilisateurToolStripMenuItem
            // 
            this.rechercherUnUtilisateurToolStripMenuItem.Name = "rechercherUnUtilisateurToolStripMenuItem";
            this.rechercherUnUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.rechercherUnUtilisateurToolStripMenuItem.Text = "Rechercher un utilisateur";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1164, 556);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label labeldate;
        private Label labeltime;
        private System.Windows.Forms.Timer timer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem accueilToolStripMenuItem;
        private ToolStripMenuItem créerUnTicketToolStripMenuItem;
        private ToolStripMenuItem créerUnTicketToolStripMenuItem1;
        private ToolStripMenuItem rechercherUnTicketToolStripMenuItem;
        private ToolStripMenuItem gestionIncidentMajeurToolStripMenuItem;
        private ToolStripMenuItem créerIncidentMajeurToolStripMenuItem;
        private ToolStripMenuItem rechercherIncidentMajeurToolStripMenuItem;
        private ToolStripMenuItem inventaireToolStripMenuItem;
        private ToolStripMenuItem créerUnArticleINVToolStripMenuItem;
        private ToolStripMenuItem rechercherUnArticleINVToolStripMenuItem;
        private ToolStripMenuItem créerMultiplesArticlesINVToolStripMenuItem;
        private ToolStripMenuItem modifierMultiplesINVToolStripMenuItem;
        private ToolStripMenuItem supprimerMultiplesINVToolStripMenuItem;
        private ToolStripMenuItem sécuritéToolStripMenuItem;
        private ToolStripMenuItem moiToolStripMenuItem;
        private ToolStripMenuItem mesTicketsOuvertsToolStripMenuItem;
        private ToolStripMenuItem mesTicketsRésoluToolStripMenuItem;
        private ToolStripMenuItem mesIncidentsOuvertToolStripMenuItem;
        private ToolStripMenuItem mesIncidentsRésoluToolStripMenuItem;
        private ToolStripMenuItem rapportOSNonSupportéToolStripMenuItem;
        private ToolStripMenuItem rapportVulnérabilitéToolStripMenuItem;
        private ToolStripMenuItem rapportInventaireCompletToolStripMenuItem;
        private ToolStripMenuItem gestionApplicationsToolStripMenuItem;
        private ToolStripMenuItem créerUnCompteSDToolStripMenuItem;
        private ToolStripMenuItem rechercherCompteSDToolStripMenuItem;
        private ToolStripMenuItem créerGroupeSDToolStripMenuItem;
        private ToolStripMenuItem rechercherGroupeSDToolStripMenuItem;
        private ToolStripMenuItem paramètresToolStripMenuItem;
        private ToolStripMenuItem gestionUtilisateursToolStripMenuItem;
        private ToolStripMenuItem créerUnUtilisateurToolStripMenuItem;
        private ToolStripMenuItem rechercherUnUtilisateurToolStripMenuItem;
    }
}